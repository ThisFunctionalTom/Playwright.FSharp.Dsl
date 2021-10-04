#if INTERACTIVE
#r "nuget: Microsoft.Playwright"
#endif

open System
open System.IO
open System.Threading.Tasks
open System.Reflection
open Microsoft.Playwright

let toCammelCase (str: string) =
    str.[0..0].ToLowerInvariant() + str.[1..]

type Type with
    member t.FormattedName =
        if t.IsGenericType then
            let gargs =
                t.GetGenericArguments()
                |> Seq.map (fun x -> x.FormattedName)
                |> String.concat ", "
            let prefixLength = t.Name.IndexOf "`"
            let prefix = t.Name.Substring(0, prefixLength)
            $"{prefix}<{gargs}>"
        elif t.IsGenericMethodParameter then
            $"'{t.Name}"
        elif t = typeof<Void> then
            "unit"
        else
            t.Name

let toValidName name =
    match name with
    | "type" -> "type_"
    | x -> x

let getGenericArgs (mi: MethodInfo) =
    if mi.IsGenericMethod then
        let gargs =
            mi.GetGenericArguments()
            |> Seq.map (fun x -> $"'{x.Name}")
            |> String.concat ", "
        $"<{gargs}>"
    else
        ""

let getMethodName (name: string) =
    if name.EndsWith "Async"
    then name.Substring(0, name.Length - "Async".Length)
    else name
    |> toCammelCase
    |> toValidName

let getParamsCombinations (mi: MethodInfo) =
    let rec loop (pis: ParameterInfo list) (rest: ParameterInfo list) =
        [| match rest with
           | [] -> yield pis
           | pi :: rest ->
                if pi.IsOptional then
                    yield pis
                yield! loop (pi::pis) rest |]

    loop [] (mi.GetParameters() |> List.ofArray)
    |> Array.map (Seq.rev >> Seq.toArray)

let getParams (pis: ParameterInfo []) =
    pis
    |> Seq.map (fun pi ->
        let typeName =
            if pi.ParameterType.IsGenericTypeParameter
            then pi.ParameterType.Name
            else pi.ParameterType.FormattedName

        $"{toValidName pi.Name}: {typeName}")
    |> String.concat ", "

let getArgs (pis: ParameterInfo []) =
    pis
    |> Seq.map (fun pi -> $"{toValidName pi.Name}")
    |> String.concat ", "

let getReturnType (mi: MethodInfo) =
    mi.ReturnType.FormattedName

let getHelper (mi: MethodInfo) =
    [|  for pis in getParamsCombinations mi do
            $"static member inline {getMethodName mi.Name}{getGenericArgs mi} ({getParams pis}): IPage -> {getReturnType mi} ="
            $"    fun (page: IPage) -> page.{mi.Name}{getGenericArgs mi}({getArgs pis})" |]

let getCustomOp (name, mis: MethodInfo[]) =
    [|  $"[<CustomOperation(\"{getMethodName name}\", MaintainsVariableSpaceUsingBind = true)>]"
        for mi in mis do
            for pis in getParamsCombinations mi do
                if pis.Length > 0
                then $"member builder.{getMethodName name}(x: PlaywrightTest<_>, {getParams pis}) ="
                else $"member builder.{getMethodName name}(x: PlaywrightTest<_>) ="
                $"    builder.Bind(x >> Task.ignore, fun () (page: IPage) -> page.{mi.Name}{getGenericArgs mi}({getArgs pis}))" |]

let generatePW () =
    let methods = typeof<IPage>.GetMethods()

    let helperLines =
        methods
        |> Array.collect getHelper
        |> Array.map (fun line -> $"    {line}")

    let customOpLines =
        methods
        |> Array.filter (fun mi -> mi.ReturnType = typeof<Task>)
        |> Array.groupBy (fun mi -> mi.Name)
        |> Array.collect getCustomOp
        |> Array.map (fun line -> $"        {line}")

    [|  "namespace Playwright.FSharp.Dsl"
        ""
        "open System"
        "open System.Collections.Generic"
        "open System.Text.Json"
        "open System.Text.RegularExpressions"
        "open System.Threading.Tasks"
        "open Microsoft.Playwright"
        ""
        "type PW ="
        yield! helperLines
        ""
        "module CustomOperations ="
        "    let inline private ignore (pt: PlaywrightTest<_>) ="
        "        playwright {"
        "            let! _ = pt"
        "            return ()"
        "        }"
        "    type PlaywrightBuilder with"
        yield! customOpLines |]

File.WriteAllLines("Playwright.FSharp.Dsl.Generated.fs", generatePW())
