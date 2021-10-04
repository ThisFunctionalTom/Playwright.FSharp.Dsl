namespace Playwright.FSharp.Dsl.Tests

open Expecto
open Microsoft.Playwright
open Playwright.FSharp.Dsl
open type Playwright.FSharp.Dsl.PW
open Playwright.FSharp.Dsl.Extensions

module ExpectoPlaywright =
    type PwTestBuilder (testName) =
        inherit PlaywrightBuilder()
        member _.Name = testName
        member _.Run(f) =
            testAsync testName {
                return! Playwright.RunAsTask f |> Async.AwaitTask
            }

    let pwTest name = PwTestBuilder(name)

open ExpectoPlaywright

module SampleTests =
    [<Tests>]
    let tests =
        testList "samples" [
            pwTest "Playwright sample" {
                let! _ = goto "https://playwright.dev/dotnet"
                screenshot "screenshot3.png"
                printfn "Screenshot"
                return ()
            }
        ]
