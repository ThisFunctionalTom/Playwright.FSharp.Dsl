namespace Playwright.FSharp.Dsl

open System
open System.Reflection
open System.Threading.Tasks
open Microsoft.Playwright
open FSharp.Control.Tasks
open Extensions

type PlaywrightTest<'T> = IPage -> Task<'T>
type PlaywrightTest = IPage -> Task

type Ex =
    /// Modify the exception, preserve the stacktrace and add the current stack, then throw (.NET 2.0+).
    /// This puts the origin point of the exception on top of the stacktrace.
    static member inline throwPreserve ex =
        let preserveStackTrace =
            typeof<Exception>.GetMethod("InternalPreserveStackTrace", BindingFlags.Instance ||| BindingFlags.NonPublic)

        (ex, null)
        |> preserveStackTrace.Invoke  // alters the exn, preserves its stacktrace
        |> ignore

        raise ex

module Task =
    let ignore (t: Task<_>) =
        task {
            let! _ = t
            return ()
        }

type Playwright =
    static member RunAsTask (test: PlaywrightTest<'a>) : Task<'a> =
        task {
            use! playwright = Playwright.CreateAsync()
            let! browser = playwright.Chromium.LaunchAsync()
            try
                let! page = browser.NewPageAsync()
                return! test page
            with
            | ex ->
                do! browser.DisposeAsync()
                return Ex.throwPreserve ex
            // // Once native support for IAsyncDisposable is released (.NET SDK 6) we can use "use!" here
            // return! Task.Using(playwright.Chromium.LaunchAsync, fun browser ->
            //     task  {
            //         let! page = browser.NewPageAsync()
            //         return! test page
            //     })
        }

    static member Run (test: PlaywrightTest<'a>) : 'a =
        Playwright.RunAsTask test
        |> Async.AwaitTask
        |> Async.RunSynchronously

[<AutoOpen>]
module Builder =
    let inline private always x = fun (_page: IPage) -> Task.FromResult x

    let inline private bind (dist: PlaywrightTest<'T>) (k: 'T -> PlaywrightTest<'b>) =
        fun (page: IPage) ->
            task {
                let! x = dist page
                return! k x page
            }
    let inline private ofTask(t: Task<'a>) : PlaywrightTest<'a> =
        fun (_page: IPage) -> t

    let inline private ofUnitTask(t: Task) : PlaywrightTest<unit> =
        fun (_page: IPage) -> task { do! t }

    let inline private ofUnitPageTest(t: PlaywrightTest) : PlaywrightTest<unit> =
        fun (page: IPage) -> task { do! t page }

    let inline pageUrl (page: IPage) = Task.FromResult page.Url

    type PlaywrightBuilder() =

        member _.Zero () = fun _page -> Task.FromResult ()
        member _.Delay(f) = bind (always ()) f
        member _.Let(v, f) = bind (always v) f
        member _.Return(x) = always x
        member _.ReturnFrom(x: PlaywrightTest<_>) = x

        member _.Bind(d: PlaywrightTest<'a>, f: 'a -> PlaywrightTest<'b>) = bind d f

        member this.Bind(x: PlaywrightTest, f : unit -> PlaywrightTest<'b>) : PlaywrightTest<'b> =
            this.Bind(ofUnitPageTest x, f)
        member this.Bind(x: PlaywrightTest, f : unit -> PlaywrightTest) : PlaywrightTest<unit> =
            this.Bind(ofUnitPageTest x, f >> ofUnitPageTest)
        member this.Bind(x: PlaywrightTest<'a>, f : 'a -> PlaywrightTest) : PlaywrightTest<unit> =
            this.Bind(x, f >> ofUnitPageTest)

        member this.Bind(x: Task<'a>, f : 'a -> PlaywrightTest<'b>) : PlaywrightTest<'b> =
            this.Bind(ofTask x, f)
        member this.Bind(x: Task<'a>, f : 'a -> Task<'b>) : PlaywrightTest<'b> =
            this.Bind(ofTask x, f >> ofTask)
        member this.Bind(x: PlaywrightTest<'a>, f : 'a -> Task<'b>) : PlaywrightTest<'b> =
            this.Bind(x, f >> ofTask)

        member this.Bind(x: Task, f : unit -> PlaywrightTest<'b>) : PlaywrightTest<'b> =
            this.Bind(ofUnitTask x, f)
        member this.Bind(x: Task, f : unit -> Task) : PlaywrightTest<unit> =
            this.Bind(ofUnitTask x, f >> ofUnitTask)
        member this.Bind(x: PlaywrightTest<'a>, f : 'a -> Task) : PlaywrightTest<unit> =
            this.Bind(x, f >> ofUnitTask)

        member builder.Combine(p1: PlaywrightTest<_>, p2: PlaywrightTest<'b>) =
            builder.Bind(p1, fun () -> p2)

    let playwright = PlaywrightBuilder()
