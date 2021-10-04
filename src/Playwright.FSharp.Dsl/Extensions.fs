module Extensions

open System
open System.Threading.Tasks

type Async with
    static member TryFinally(body : Async<'T>, finallyF : Async<unit>) = async {
        let! ct = Async.CancellationToken
        return! Async.FromContinuations(fun (sc,ec,cc) ->
            let sc' (t : 'T) = Async.StartWithContinuations(finallyF, (fun () -> sc t), ec, cc, ct)
            let ec' (e : exn) = Async.StartWithContinuations(finallyF, (fun () -> ec e), ec, cc, ct)
            Async.StartWithContinuations(body, sc', ec', cc, ct))
    }

type Task with
    static member TryFinally (body: Task<'T>, finallyF: unit -> Task) =
        Async.TryFinally(body |> Async.AwaitTask, finallyF () |> Async.AwaitTask)

    static member Using(getResource: unit -> Task<'a>, body : 'a -> Task<'b>) =
        let dispose (ad: IAsyncDisposable) =
            async {
                do! ad.DisposeAsync().AsTask() |> Async.AwaitTask
            }

        async {
            let! resource = getResource () |> Async.AwaitTask
            return! Async.TryFinally(body resource |> Async.AwaitTask, dispose resource)
        }
