namespace Playwright.FSharp.Dsl

open System.Threading.Tasks
open Microsoft.Playwright
open FSharp.Control.Tasks

module Extensions =
    let inline combineAndIgnore (x: PlaywrightTest<'a>, f: PlaywrightTest<'b>) : PlaywrightTest<unit> =
        fun page ->
            task {
                let! _ = x page
                let! _ = f page
                return ()
            }

    type PlaywrightBuilder with
        [<CustomOperation("screenshot", MaintainsVariableSpaceUsingBind = true)>]
        member _.screenshot(x: PlaywrightTest<_>, path: string) : PlaywrightTest<unit> =
            combineAndIgnore (x, PW.screenshot (PageScreenshotOptions(Path = path)))
