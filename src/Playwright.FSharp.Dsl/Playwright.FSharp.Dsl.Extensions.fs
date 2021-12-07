namespace Playwright.FSharp.Dsl

open System.Threading.Tasks
open Microsoft.Playwright
open FSharp.Control.Tasks

module Extensions =
    type PlaywrightBuilder with
        [<CustomOperation("screenshot", MaintainsVariableSpaceUsingBind = true)>]
        member builder.screenshot(x: PlaywrightTest<_>, path: string) : PlaywrightTest<unit> =
            builder.Combine(x, PW.screenshot (PageScreenshotOptions(Path = path)) >> Task.ignore)

        [<CustomOperation("goto'", MaintainsVariableSpaceUsingBind = true)>]
        member builder.goto(x: PlaywrightTest<_>, url: string) : PlaywrightTest<unit> =
            let impl =
                playwright {
                    let! result = PW.goto url
                    if not result.Ok then
                        failwith
                }
            builder.Combine (x, )
