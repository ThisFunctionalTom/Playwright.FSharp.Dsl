namespace Playwright.FSharp.Dsl.Tests

open Expecto
open Microsoft.Playwright
open Playwright.FSharp.Dsl
open type Playwright.FSharp.Dsl.PW

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
    let simpleTest =
        playwright {
            let! _ = goto "https://playwright.dev/dotnet"
            let! bytes = screenshot (PageScreenshotOptions(Path = "screenshot.png"))
            return ()
        }

    [<Tests>]
    let tests =
        testList "samples" [
            pwTest "Playwright sample" {
                let! _ = goto "https://playwright.dev/dotnet"
                let! _ = screenshot (PageScreenshotOptions(Path = "screenshot1.png"))
                return ()
            }
        ]
