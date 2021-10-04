namespace Playwright.FSharp.Dsl

open System
open System.Collections.Generic
open System.Text.Json
open System.Text.RegularExpressions
open System.Threading.Tasks
open Microsoft.Playwright

type PW =
    static member inline runAndWaitForConsoleMessage (action: Func<Task>): IPage -> Task<IConsoleMessage> =
        fun (page: IPage) -> page.RunAndWaitForConsoleMessageAsync(action)
    static member inline runAndWaitForConsoleMessage (action: Func<Task>, options: PageRunAndWaitForConsoleMessageOptions): IPage -> Task<IConsoleMessage> =
        fun (page: IPage) -> page.RunAndWaitForConsoleMessageAsync(action, options)
    static member inline waitForDownload (): IPage -> Task<IDownload> =
        fun (page: IPage) -> page.WaitForDownloadAsync()
    static member inline waitForDownload (options: PageWaitForDownloadOptions): IPage -> Task<IDownload> =
        fun (page: IPage) -> page.WaitForDownloadAsync(options)
    static member inline runAndWaitForDownload (action: Func<Task>): IPage -> Task<IDownload> =
        fun (page: IPage) -> page.RunAndWaitForDownloadAsync(action)
    static member inline runAndWaitForDownload (action: Func<Task>, options: PageRunAndWaitForDownloadOptions): IPage -> Task<IDownload> =
        fun (page: IPage) -> page.RunAndWaitForDownloadAsync(action, options)
    static member inline waitForFileChooser (): IPage -> Task<IFileChooser> =
        fun (page: IPage) -> page.WaitForFileChooserAsync()
    static member inline waitForFileChooser (options: PageWaitForFileChooserOptions): IPage -> Task<IFileChooser> =
        fun (page: IPage) -> page.WaitForFileChooserAsync(options)
    static member inline runAndWaitForFileChooser (action: Func<Task>): IPage -> Task<IFileChooser> =
        fun (page: IPage) -> page.RunAndWaitForFileChooserAsync(action)
    static member inline runAndWaitForFileChooser (action: Func<Task>, options: PageRunAndWaitForFileChooserOptions): IPage -> Task<IFileChooser> =
        fun (page: IPage) -> page.RunAndWaitForFileChooserAsync(action, options)
    static member inline waitForFunction (expression: String): IPage -> Task<IJSHandle> =
        fun (page: IPage) -> page.WaitForFunctionAsync(expression)
    static member inline waitForFunction (expression: String, arg: Object): IPage -> Task<IJSHandle> =
        fun (page: IPage) -> page.WaitForFunctionAsync(expression, arg)
    static member inline waitForFunction (expression: String, arg: Object, options: PageWaitForFunctionOptions): IPage -> Task<IJSHandle> =
        fun (page: IPage) -> page.WaitForFunctionAsync(expression, arg, options)
    static member inline waitForLoadState (): IPage -> Task =
        fun (page: IPage) -> page.WaitForLoadStateAsync()
    static member inline waitForLoadState (state: Nullable<LoadState>): IPage -> Task =
        fun (page: IPage) -> page.WaitForLoadStateAsync(state)
    static member inline waitForLoadState (state: Nullable<LoadState>, options: PageWaitForLoadStateOptions): IPage -> Task =
        fun (page: IPage) -> page.WaitForLoadStateAsync(state, options)
    static member inline waitForNavigation (): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.WaitForNavigationAsync()
    static member inline waitForNavigation (options: PageWaitForNavigationOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.WaitForNavigationAsync(options)
    static member inline runAndWaitForNavigation (action: Func<Task>): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.RunAndWaitForNavigationAsync(action)
    static member inline runAndWaitForNavigation (action: Func<Task>, options: PageRunAndWaitForNavigationOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.RunAndWaitForNavigationAsync(action, options)
    static member inline waitForPopup (): IPage -> Task<IPage> =
        fun (page: IPage) -> page.WaitForPopupAsync()
    static member inline waitForPopup (options: PageWaitForPopupOptions): IPage -> Task<IPage> =
        fun (page: IPage) -> page.WaitForPopupAsync(options)
    static member inline runAndWaitForPopup (action: Func<Task>): IPage -> Task<IPage> =
        fun (page: IPage) -> page.RunAndWaitForPopupAsync(action)
    static member inline runAndWaitForPopup (action: Func<Task>, options: PageRunAndWaitForPopupOptions): IPage -> Task<IPage> =
        fun (page: IPage) -> page.RunAndWaitForPopupAsync(action, options)
    static member inline waitForRequest (urlOrPredicate: String): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.WaitForRequestAsync(urlOrPredicate)
    static member inline waitForRequest (urlOrPredicate: String, options: PageWaitForRequestOptions): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.WaitForRequestAsync(urlOrPredicate, options)
    static member inline waitForRequest (urlOrPredicate: Regex): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.WaitForRequestAsync(urlOrPredicate)
    static member inline waitForRequest (urlOrPredicate: Regex, options: PageWaitForRequestOptions): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.WaitForRequestAsync(urlOrPredicate, options)
    static member inline waitForRequest (urlOrPredicate: Func<IRequest, Boolean>): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.WaitForRequestAsync(urlOrPredicate)
    static member inline waitForRequest (urlOrPredicate: Func<IRequest, Boolean>, options: PageWaitForRequestOptions): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.WaitForRequestAsync(urlOrPredicate, options)
    static member inline runAndWaitForRequest (action: Func<Task>, urlOrPredicate: String): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.RunAndWaitForRequestAsync(action, urlOrPredicate)
    static member inline runAndWaitForRequest (action: Func<Task>, urlOrPredicate: String, options: PageRunAndWaitForRequestOptions): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.RunAndWaitForRequestAsync(action, urlOrPredicate, options)
    static member inline runAndWaitForRequest (action: Func<Task>, urlOrPredicate: Regex): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.RunAndWaitForRequestAsync(action, urlOrPredicate)
    static member inline runAndWaitForRequest (action: Func<Task>, urlOrPredicate: Regex, options: PageRunAndWaitForRequestOptions): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.RunAndWaitForRequestAsync(action, urlOrPredicate, options)
    static member inline runAndWaitForRequest (action: Func<Task>, urlOrPredicate: Func<IRequest, Boolean>): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.RunAndWaitForRequestAsync(action, urlOrPredicate)
    static member inline runAndWaitForRequest (action: Func<Task>, urlOrPredicate: Func<IRequest, Boolean>, options: PageRunAndWaitForRequestOptions): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.RunAndWaitForRequestAsync(action, urlOrPredicate, options)
    static member inline waitForRequestFinished (): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.WaitForRequestFinishedAsync()
    static member inline waitForRequestFinished (options: PageWaitForRequestFinishedOptions): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.WaitForRequestFinishedAsync(options)
    static member inline runAndWaitForRequestFinished (action: Func<Task>): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.RunAndWaitForRequestFinishedAsync(action)
    static member inline runAndWaitForRequestFinished (action: Func<Task>, options: PageRunAndWaitForRequestFinishedOptions): IPage -> Task<IRequest> =
        fun (page: IPage) -> page.RunAndWaitForRequestFinishedAsync(action, options)
    static member inline waitForResponse (urlOrPredicate: String): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.WaitForResponseAsync(urlOrPredicate)
    static member inline waitForResponse (urlOrPredicate: String, options: PageWaitForResponseOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.WaitForResponseAsync(urlOrPredicate, options)
    static member inline waitForResponse (urlOrPredicate: Regex): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.WaitForResponseAsync(urlOrPredicate)
    static member inline waitForResponse (urlOrPredicate: Regex, options: PageWaitForResponseOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.WaitForResponseAsync(urlOrPredicate, options)
    static member inline waitForResponse (urlOrPredicate: Func<IResponse, Boolean>): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.WaitForResponseAsync(urlOrPredicate)
    static member inline waitForResponse (urlOrPredicate: Func<IResponse, Boolean>, options: PageWaitForResponseOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.WaitForResponseAsync(urlOrPredicate, options)
    static member inline runAndWaitForResponse (action: Func<Task>, urlOrPredicate: String): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.RunAndWaitForResponseAsync(action, urlOrPredicate)
    static member inline runAndWaitForResponse (action: Func<Task>, urlOrPredicate: String, options: PageRunAndWaitForResponseOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.RunAndWaitForResponseAsync(action, urlOrPredicate, options)
    static member inline runAndWaitForResponse (action: Func<Task>, urlOrPredicate: Regex): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.RunAndWaitForResponseAsync(action, urlOrPredicate)
    static member inline runAndWaitForResponse (action: Func<Task>, urlOrPredicate: Regex, options: PageRunAndWaitForResponseOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.RunAndWaitForResponseAsync(action, urlOrPredicate, options)
    static member inline runAndWaitForResponse (action: Func<Task>, urlOrPredicate: Func<IResponse, Boolean>): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.RunAndWaitForResponseAsync(action, urlOrPredicate)
    static member inline runAndWaitForResponse (action: Func<Task>, urlOrPredicate: Func<IResponse, Boolean>, options: PageRunAndWaitForResponseOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.RunAndWaitForResponseAsync(action, urlOrPredicate, options)
    static member inline waitForSelector (selector: String): IPage -> Task<IElementHandle> =
        fun (page: IPage) -> page.WaitForSelectorAsync(selector)
    static member inline waitForSelector (selector: String, options: PageWaitForSelectorOptions): IPage -> Task<IElementHandle> =
        fun (page: IPage) -> page.WaitForSelectorAsync(selector, options)
    static member inline waitForTimeout (timeout: Single): IPage -> Task =
        fun (page: IPage) -> page.WaitForTimeoutAsync(timeout)
    static member inline waitForURL (url: String): IPage -> Task =
        fun (page: IPage) -> page.WaitForURLAsync(url)
    static member inline waitForURL (url: String, options: PageWaitForURLOptions): IPage -> Task =
        fun (page: IPage) -> page.WaitForURLAsync(url, options)
    static member inline waitForURL (url: Regex): IPage -> Task =
        fun (page: IPage) -> page.WaitForURLAsync(url)
    static member inline waitForURL (url: Regex, options: PageWaitForURLOptions): IPage -> Task =
        fun (page: IPage) -> page.WaitForURLAsync(url, options)
    static member inline waitForURL (url: Func<String, Boolean>): IPage -> Task =
        fun (page: IPage) -> page.WaitForURLAsync(url)
    static member inline waitForURL (url: Func<String, Boolean>, options: PageWaitForURLOptions): IPage -> Task =
        fun (page: IPage) -> page.WaitForURLAsync(url, options)
    static member inline waitForWebSocket (): IPage -> Task<IWebSocket> =
        fun (page: IPage) -> page.WaitForWebSocketAsync()
    static member inline waitForWebSocket (options: PageWaitForWebSocketOptions): IPage -> Task<IWebSocket> =
        fun (page: IPage) -> page.WaitForWebSocketAsync(options)
    static member inline runAndWaitForWebSocket (action: Func<Task>): IPage -> Task<IWebSocket> =
        fun (page: IPage) -> page.RunAndWaitForWebSocketAsync(action)
    static member inline runAndWaitForWebSocket (action: Func<Task>, options: PageRunAndWaitForWebSocketOptions): IPage -> Task<IWebSocket> =
        fun (page: IPage) -> page.RunAndWaitForWebSocketAsync(action, options)
    static member inline waitForWorker (): IPage -> Task<IWorker> =
        fun (page: IPage) -> page.WaitForWorkerAsync()
    static member inline waitForWorker (options: PageWaitForWorkerOptions): IPage -> Task<IWorker> =
        fun (page: IPage) -> page.WaitForWorkerAsync(options)
    static member inline runAndWaitForWorker (action: Func<Task>): IPage -> Task<IWorker> =
        fun (page: IPage) -> page.RunAndWaitForWorkerAsync(action)
    static member inline runAndWaitForWorker (action: Func<Task>, options: PageRunAndWaitForWorkerOptions): IPage -> Task<IWorker> =
        fun (page: IPage) -> page.RunAndWaitForWorkerAsync(action, options)
    static member inline get_Workers (): IPage -> IReadOnlyList<IWorker> =
        fun (page: IPage) -> page.get_Workers()
    static member inline evaluate (expression: String): IPage -> Task<Nullable<JsonElement>> =
        fun (page: IPage) -> page.EvaluateAsync(expression)
    static member inline evaluate (expression: String, arg: Object): IPage -> Task<Nullable<JsonElement>> =
        fun (page: IPage) -> page.EvaluateAsync(expression, arg)
    static member inline evalOnSelector (selector: String, expression: String): IPage -> Task<Nullable<JsonElement>> =
        fun (page: IPage) -> page.EvalOnSelectorAsync(selector, expression)
    static member inline evalOnSelector (selector: String, expression: String, arg: Object): IPage -> Task<Nullable<JsonElement>> =
        fun (page: IPage) -> page.EvalOnSelectorAsync(selector, expression, arg)
    static member inline evalOnSelectorAll (selector: String, expression: String): IPage -> Task<Nullable<JsonElement>> =
        fun (page: IPage) -> page.EvalOnSelectorAllAsync(selector, expression)
    static member inline evalOnSelectorAll (selector: String, expression: String, arg: Object): IPage -> Task<Nullable<JsonElement>> =
        fun (page: IPage) -> page.EvalOnSelectorAllAsync(selector, expression, arg)
    static member inline exposeBinding (name: String, callback: Action<BindingSource>): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync(name, callback)
    static member inline exposeBinding<'T> (name: String, callback: Action<BindingSource, 'T>): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync<'T>(name, callback)
    static member inline exposeBinding<'TResult> (name: String, callback: Func<BindingSource, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync<'TResult>(name, callback)
    static member inline exposeBinding<'TResult> (name: String, callback: Func<BindingSource, IJSHandle, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync<'TResult>(name, callback)
    static member inline exposeBinding<'T, 'TResult> (name: String, callback: Func<BindingSource, 'T, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync<'T, 'TResult>(name, callback)
    static member inline exposeBinding<'T1, 'T2, 'TResult> (name: String, callback: Func<BindingSource, 'T1, 'T2, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync<'T1, 'T2, 'TResult>(name, callback)
    static member inline exposeBinding<'T1, 'T2, 'T3, 'TResult> (name: String, callback: Func<BindingSource, 'T1, 'T2, 'T3, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync<'T1, 'T2, 'T3, 'TResult>(name, callback)
    static member inline exposeBinding<'T1, 'T2, 'T3, 'T4, 'TResult> (name: String, callback: Func<BindingSource, 'T1, 'T2, 'T3, 'T4, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync<'T1, 'T2, 'T3, 'T4, 'TResult>(name, callback)
    static member inline exposeFunction<'T> (name: String, callback: Action<'T>): IPage -> Task =
        fun (page: IPage) -> page.ExposeFunctionAsync<'T>(name, callback)
    static member inline exposeFunction<'TResult> (name: String, callback: Func<'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeFunctionAsync<'TResult>(name, callback)
    static member inline exposeFunction<'T, 'TResult> (name: String, callback: Func<'T, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeFunctionAsync<'T, 'TResult>(name, callback)
    static member inline exposeFunction<'T1, 'T2, 'TResult> (name: String, callback: Func<'T1, 'T2, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeFunctionAsync<'T1, 'T2, 'TResult>(name, callback)
    static member inline exposeFunction<'T1, 'T2, 'T3, 'TResult> (name: String, callback: Func<'T1, 'T2, 'T3, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeFunctionAsync<'T1, 'T2, 'T3, 'TResult>(name, callback)
    static member inline exposeFunction<'T1, 'T2, 'T3, 'T4, 'TResult> (name: String, callback: Func<'T1, 'T2, 'T3, 'T4, 'TResult>): IPage -> Task =
        fun (page: IPage) -> page.ExposeFunctionAsync<'T1, 'T2, 'T3, 'T4, 'TResult>(name, callback)
    static member inline add_Close (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.add_Close(value)
    static member inline remove_Close (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.remove_Close(value)
    static member inline add_Console (value: EventHandler<IConsoleMessage>): IPage -> unit =
        fun (page: IPage) -> page.add_Console(value)
    static member inline remove_Console (value: EventHandler<IConsoleMessage>): IPage -> unit =
        fun (page: IPage) -> page.remove_Console(value)
    static member inline add_Crash (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.add_Crash(value)
    static member inline remove_Crash (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.remove_Crash(value)
    static member inline add_Dialog (value: EventHandler<IDialog>): IPage -> unit =
        fun (page: IPage) -> page.add_Dialog(value)
    static member inline remove_Dialog (value: EventHandler<IDialog>): IPage -> unit =
        fun (page: IPage) -> page.remove_Dialog(value)
    static member inline add_DOMContentLoaded (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.add_DOMContentLoaded(value)
    static member inline remove_DOMContentLoaded (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.remove_DOMContentLoaded(value)
    static member inline add_Download (value: EventHandler<IDownload>): IPage -> unit =
        fun (page: IPage) -> page.add_Download(value)
    static member inline remove_Download (value: EventHandler<IDownload>): IPage -> unit =
        fun (page: IPage) -> page.remove_Download(value)
    static member inline add_FileChooser (value: EventHandler<IFileChooser>): IPage -> unit =
        fun (page: IPage) -> page.add_FileChooser(value)
    static member inline remove_FileChooser (value: EventHandler<IFileChooser>): IPage -> unit =
        fun (page: IPage) -> page.remove_FileChooser(value)
    static member inline add_FrameAttached (value: EventHandler<IFrame>): IPage -> unit =
        fun (page: IPage) -> page.add_FrameAttached(value)
    static member inline remove_FrameAttached (value: EventHandler<IFrame>): IPage -> unit =
        fun (page: IPage) -> page.remove_FrameAttached(value)
    static member inline add_FrameDetached (value: EventHandler<IFrame>): IPage -> unit =
        fun (page: IPage) -> page.add_FrameDetached(value)
    static member inline remove_FrameDetached (value: EventHandler<IFrame>): IPage -> unit =
        fun (page: IPage) -> page.remove_FrameDetached(value)
    static member inline add_FrameNavigated (value: EventHandler<IFrame>): IPage -> unit =
        fun (page: IPage) -> page.add_FrameNavigated(value)
    static member inline remove_FrameNavigated (value: EventHandler<IFrame>): IPage -> unit =
        fun (page: IPage) -> page.remove_FrameNavigated(value)
    static member inline add_Load (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.add_Load(value)
    static member inline remove_Load (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.remove_Load(value)
    static member inline add_PageError (value: EventHandler<String>): IPage -> unit =
        fun (page: IPage) -> page.add_PageError(value)
    static member inline remove_PageError (value: EventHandler<String>): IPage -> unit =
        fun (page: IPage) -> page.remove_PageError(value)
    static member inline add_Popup (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.add_Popup(value)
    static member inline remove_Popup (value: EventHandler<IPage>): IPage -> unit =
        fun (page: IPage) -> page.remove_Popup(value)
    static member inline add_Request (value: EventHandler<IRequest>): IPage -> unit =
        fun (page: IPage) -> page.add_Request(value)
    static member inline remove_Request (value: EventHandler<IRequest>): IPage -> unit =
        fun (page: IPage) -> page.remove_Request(value)
    static member inline add_RequestFailed (value: EventHandler<IRequest>): IPage -> unit =
        fun (page: IPage) -> page.add_RequestFailed(value)
    static member inline remove_RequestFailed (value: EventHandler<IRequest>): IPage -> unit =
        fun (page: IPage) -> page.remove_RequestFailed(value)
    static member inline add_RequestFinished (value: EventHandler<IRequest>): IPage -> unit =
        fun (page: IPage) -> page.add_RequestFinished(value)
    static member inline remove_RequestFinished (value: EventHandler<IRequest>): IPage -> unit =
        fun (page: IPage) -> page.remove_RequestFinished(value)
    static member inline add_Response (value: EventHandler<IResponse>): IPage -> unit =
        fun (page: IPage) -> page.add_Response(value)
    static member inline remove_Response (value: EventHandler<IResponse>): IPage -> unit =
        fun (page: IPage) -> page.remove_Response(value)
    static member inline add_WebSocket (value: EventHandler<IWebSocket>): IPage -> unit =
        fun (page: IPage) -> page.add_WebSocket(value)
    static member inline remove_WebSocket (value: EventHandler<IWebSocket>): IPage -> unit =
        fun (page: IPage) -> page.remove_WebSocket(value)
    static member inline add_Worker (value: EventHandler<IWorker>): IPage -> unit =
        fun (page: IPage) -> page.add_Worker(value)
    static member inline remove_Worker (value: EventHandler<IWorker>): IPage -> unit =
        fun (page: IPage) -> page.remove_Worker(value)
    static member inline get_Accessibility (): IPage -> IAccessibility =
        fun (page: IPage) -> page.get_Accessibility()
    static member inline addInitScript (): IPage -> Task =
        fun (page: IPage) -> page.AddInitScriptAsync()
    static member inline addInitScript (script: String): IPage -> Task =
        fun (page: IPage) -> page.AddInitScriptAsync(script)
    static member inline addInitScript (script: String, scriptPath: String): IPage -> Task =
        fun (page: IPage) -> page.AddInitScriptAsync(script, scriptPath)
    static member inline addScriptTag (): IPage -> Task<IElementHandle> =
        fun (page: IPage) -> page.AddScriptTagAsync()
    static member inline addScriptTag (options: PageAddScriptTagOptions): IPage -> Task<IElementHandle> =
        fun (page: IPage) -> page.AddScriptTagAsync(options)
    static member inline addStyleTag (): IPage -> Task<IElementHandle> =
        fun (page: IPage) -> page.AddStyleTagAsync()
    static member inline addStyleTag (options: PageAddStyleTagOptions): IPage -> Task<IElementHandle> =
        fun (page: IPage) -> page.AddStyleTagAsync(options)
    static member inline bringToFront (): IPage -> Task =
        fun (page: IPage) -> page.BringToFrontAsync()
    static member inline check (selector: String): IPage -> Task =
        fun (page: IPage) -> page.CheckAsync(selector)
    static member inline check (selector: String, options: PageCheckOptions): IPage -> Task =
        fun (page: IPage) -> page.CheckAsync(selector, options)
    static member inline click (selector: String): IPage -> Task =
        fun (page: IPage) -> page.ClickAsync(selector)
    static member inline click (selector: String, options: PageClickOptions): IPage -> Task =
        fun (page: IPage) -> page.ClickAsync(selector, options)
    static member inline close (): IPage -> Task =
        fun (page: IPage) -> page.CloseAsync()
    static member inline close (options: PageCloseOptions): IPage -> Task =
        fun (page: IPage) -> page.CloseAsync(options)
    static member inline content (): IPage -> Task<String> =
        fun (page: IPage) -> page.ContentAsync()
    static member inline get_Context (): IPage -> IBrowserContext =
        fun (page: IPage) -> page.get_Context()
    static member inline dblClick (selector: String): IPage -> Task =
        fun (page: IPage) -> page.DblClickAsync(selector)
    static member inline dblClick (selector: String, options: PageDblClickOptions): IPage -> Task =
        fun (page: IPage) -> page.DblClickAsync(selector, options)
    static member inline dispatchEvent (selector: String, type_: String): IPage -> Task =
        fun (page: IPage) -> page.DispatchEventAsync(selector, type_)
    static member inline dispatchEvent (selector: String, type_: String, eventInit: Object): IPage -> Task =
        fun (page: IPage) -> page.DispatchEventAsync(selector, type_, eventInit)
    static member inline dispatchEvent (selector: String, type_: String, eventInit: Object, options: PageDispatchEventOptions): IPage -> Task =
        fun (page: IPage) -> page.DispatchEventAsync(selector, type_, eventInit, options)
    static member inline dragAndDrop (source: String, target: String): IPage -> Task =
        fun (page: IPage) -> page.DragAndDropAsync(source, target)
    static member inline dragAndDrop (source: String, target: String, options: PageDragAndDropOptions): IPage -> Task =
        fun (page: IPage) -> page.DragAndDropAsync(source, target, options)
    static member inline emulateMedia (): IPage -> Task =
        fun (page: IPage) -> page.EmulateMediaAsync()
    static member inline emulateMedia (options: PageEmulateMediaOptions): IPage -> Task =
        fun (page: IPage) -> page.EmulateMediaAsync(options)
    static member inline evalOnSelector<'T> (selector: String, expression: String): IPage -> Task<'T> =
        fun (page: IPage) -> page.EvalOnSelectorAsync<'T>(selector, expression)
    static member inline evalOnSelector<'T> (selector: String, expression: String, arg: Object): IPage -> Task<'T> =
        fun (page: IPage) -> page.EvalOnSelectorAsync<'T>(selector, expression, arg)
    static member inline evalOnSelector<'T> (selector: String, expression: String, arg: Object, options: PageEvalOnSelectorOptions): IPage -> Task<'T> =
        fun (page: IPage) -> page.EvalOnSelectorAsync<'T>(selector, expression, arg, options)
    static member inline evalOnSelectorAll<'T> (selector: String, expression: String): IPage -> Task<'T> =
        fun (page: IPage) -> page.EvalOnSelectorAllAsync<'T>(selector, expression)
    static member inline evalOnSelectorAll<'T> (selector: String, expression: String, arg: Object): IPage -> Task<'T> =
        fun (page: IPage) -> page.EvalOnSelectorAllAsync<'T>(selector, expression, arg)
    static member inline evaluate<'T> (expression: String): IPage -> Task<'T> =
        fun (page: IPage) -> page.EvaluateAsync<'T>(expression)
    static member inline evaluate<'T> (expression: String, arg: Object): IPage -> Task<'T> =
        fun (page: IPage) -> page.EvaluateAsync<'T>(expression, arg)
    static member inline evaluateHandle (expression: String): IPage -> Task<IJSHandle> =
        fun (page: IPage) -> page.EvaluateHandleAsync(expression)
    static member inline evaluateHandle (expression: String, arg: Object): IPage -> Task<IJSHandle> =
        fun (page: IPage) -> page.EvaluateHandleAsync(expression, arg)
    static member inline exposeBinding (name: String, callback: Action): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync(name, callback)
    static member inline exposeBinding (name: String, callback: Action, options: PageExposeBindingOptions): IPage -> Task =
        fun (page: IPage) -> page.ExposeBindingAsync(name, callback, options)
    static member inline exposeFunction (name: String, callback: Action): IPage -> Task =
        fun (page: IPage) -> page.ExposeFunctionAsync(name, callback)
    static member inline fill (selector: String, value: String): IPage -> Task =
        fun (page: IPage) -> page.FillAsync(selector, value)
    static member inline fill (selector: String, value: String, options: PageFillOptions): IPage -> Task =
        fun (page: IPage) -> page.FillAsync(selector, value, options)
    static member inline focus (selector: String): IPage -> Task =
        fun (page: IPage) -> page.FocusAsync(selector)
    static member inline focus (selector: String, options: PageFocusOptions): IPage -> Task =
        fun (page: IPage) -> page.FocusAsync(selector, options)
    static member inline frame (name: String): IPage -> IFrame =
        fun (page: IPage) -> page.Frame(name)
    static member inline frameByUrl (url: String): IPage -> IFrame =
        fun (page: IPage) -> page.FrameByUrl(url)
    static member inline frameByUrl (url: Regex): IPage -> IFrame =
        fun (page: IPage) -> page.FrameByUrl(url)
    static member inline frameByUrl (url: Func<String, Boolean>): IPage -> IFrame =
        fun (page: IPage) -> page.FrameByUrl(url)
    static member inline get_Frames (): IPage -> IReadOnlyList<IFrame> =
        fun (page: IPage) -> page.get_Frames()
    static member inline getAttribute (selector: String, name: String): IPage -> Task<String> =
        fun (page: IPage) -> page.GetAttributeAsync(selector, name)
    static member inline getAttribute (selector: String, name: String, options: PageGetAttributeOptions): IPage -> Task<String> =
        fun (page: IPage) -> page.GetAttributeAsync(selector, name, options)
    static member inline goBack (): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.GoBackAsync()
    static member inline goBack (options: PageGoBackOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.GoBackAsync(options)
    static member inline goForward (): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.GoForwardAsync()
    static member inline goForward (options: PageGoForwardOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.GoForwardAsync(options)
    static member inline goto (url: String): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.GotoAsync(url)
    static member inline goto (url: String, options: PageGotoOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.GotoAsync(url, options)
    static member inline hover (selector: String): IPage -> Task =
        fun (page: IPage) -> page.HoverAsync(selector)
    static member inline hover (selector: String, options: PageHoverOptions): IPage -> Task =
        fun (page: IPage) -> page.HoverAsync(selector, options)
    static member inline innerHTML (selector: String): IPage -> Task<String> =
        fun (page: IPage) -> page.InnerHTMLAsync(selector)
    static member inline innerHTML (selector: String, options: PageInnerHTMLOptions): IPage -> Task<String> =
        fun (page: IPage) -> page.InnerHTMLAsync(selector, options)
    static member inline innerText (selector: String): IPage -> Task<String> =
        fun (page: IPage) -> page.InnerTextAsync(selector)
    static member inline innerText (selector: String, options: PageInnerTextOptions): IPage -> Task<String> =
        fun (page: IPage) -> page.InnerTextAsync(selector, options)
    static member inline inputValue (selector: String): IPage -> Task<String> =
        fun (page: IPage) -> page.InputValueAsync(selector)
    static member inline inputValue (selector: String, options: PageInputValueOptions): IPage -> Task<String> =
        fun (page: IPage) -> page.InputValueAsync(selector, options)
    static member inline isChecked (selector: String): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsCheckedAsync(selector)
    static member inline isChecked (selector: String, options: PageIsCheckedOptions): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsCheckedAsync(selector, options)
    static member inline get_IsClosed (): IPage -> Boolean =
        fun (page: IPage) -> page.get_IsClosed()
    static member inline isDisabled (selector: String): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsDisabledAsync(selector)
    static member inline isDisabled (selector: String, options: PageIsDisabledOptions): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsDisabledAsync(selector, options)
    static member inline isEditable (selector: String): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsEditableAsync(selector)
    static member inline isEditable (selector: String, options: PageIsEditableOptions): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsEditableAsync(selector, options)
    static member inline isEnabled (selector: String): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsEnabledAsync(selector)
    static member inline isEnabled (selector: String, options: PageIsEnabledOptions): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsEnabledAsync(selector, options)
    static member inline isHidden (selector: String): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsHiddenAsync(selector)
    static member inline isHidden (selector: String, options: PageIsHiddenOptions): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsHiddenAsync(selector, options)
    static member inline isVisible (selector: String): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsVisibleAsync(selector)
    static member inline isVisible (selector: String, options: PageIsVisibleOptions): IPage -> Task<Boolean> =
        fun (page: IPage) -> page.IsVisibleAsync(selector, options)
    static member inline get_Keyboard (): IPage -> IKeyboard =
        fun (page: IPage) -> page.get_Keyboard()
    static member inline locator (selector: String): IPage -> ILocator =
        fun (page: IPage) -> page.Locator(selector)
    static member inline get_MainFrame (): IPage -> IFrame =
        fun (page: IPage) -> page.get_MainFrame()
    static member inline get_Mouse (): IPage -> IMouse =
        fun (page: IPage) -> page.get_Mouse()
    static member inline opener (): IPage -> Task<IPage> =
        fun (page: IPage) -> page.OpenerAsync()
    static member inline pause (): IPage -> Task =
        fun (page: IPage) -> page.PauseAsync()
    static member inline pdf (): IPage -> Task<Byte[]> =
        fun (page: IPage) -> page.PdfAsync()
    static member inline pdf (options: PagePdfOptions): IPage -> Task<Byte[]> =
        fun (page: IPage) -> page.PdfAsync(options)
    static member inline press (selector: String, key: String): IPage -> Task =
        fun (page: IPage) -> page.PressAsync(selector, key)
    static member inline press (selector: String, key: String, options: PagePressOptions): IPage -> Task =
        fun (page: IPage) -> page.PressAsync(selector, key, options)
    static member inline querySelector (selector: String): IPage -> Task<IElementHandle> =
        fun (page: IPage) -> page.QuerySelectorAsync(selector)
    static member inline querySelector (selector: String, options: PageQuerySelectorOptions): IPage -> Task<IElementHandle> =
        fun (page: IPage) -> page.QuerySelectorAsync(selector, options)
    static member inline querySelectorAll (selector: String): IPage -> Task<IReadOnlyList<IElementHandle>> =
        fun (page: IPage) -> page.QuerySelectorAllAsync(selector)
    static member inline reload (): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.ReloadAsync()
    static member inline reload (options: PageReloadOptions): IPage -> Task<IResponse> =
        fun (page: IPage) -> page.ReloadAsync(options)
    static member inline route (url: String, handler: Action<IRoute>): IPage -> Task =
        fun (page: IPage) -> page.RouteAsync(url, handler)
    static member inline route (url: Regex, handler: Action<IRoute>): IPage -> Task =
        fun (page: IPage) -> page.RouteAsync(url, handler)
    static member inline route (url: Func<String, Boolean>, handler: Action<IRoute>): IPage -> Task =
        fun (page: IPage) -> page.RouteAsync(url, handler)
    static member inline screenshot (): IPage -> Task<Byte[]> =
        fun (page: IPage) -> page.ScreenshotAsync()
    static member inline screenshot (options: PageScreenshotOptions): IPage -> Task<Byte[]> =
        fun (page: IPage) -> page.ScreenshotAsync(options)
    static member inline selectOption (selector: String, values: String): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values)
    static member inline selectOption (selector: String, values: String, options: PageSelectOptionOptions): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values, options)
    static member inline selectOption (selector: String, values: IElementHandle): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values)
    static member inline selectOption (selector: String, values: IElementHandle, options: PageSelectOptionOptions): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values, options)
    static member inline selectOption (selector: String, values: IEnumerable<String>): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values)
    static member inline selectOption (selector: String, values: IEnumerable<String>, options: PageSelectOptionOptions): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values, options)
    static member inline selectOption (selector: String, values: SelectOptionValue): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values)
    static member inline selectOption (selector: String, values: SelectOptionValue, options: PageSelectOptionOptions): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values, options)
    static member inline selectOption (selector: String, values: IEnumerable<IElementHandle>): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values)
    static member inline selectOption (selector: String, values: IEnumerable<IElementHandle>, options: PageSelectOptionOptions): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values, options)
    static member inline selectOption (selector: String, values: IEnumerable<SelectOptionValue>): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values)
    static member inline selectOption (selector: String, values: IEnumerable<SelectOptionValue>, options: PageSelectOptionOptions): IPage -> Task<IReadOnlyList<String>> =
        fun (page: IPage) -> page.SelectOptionAsync(selector, values, options)
    static member inline setContent (html: String): IPage -> Task =
        fun (page: IPage) -> page.SetContentAsync(html)
    static member inline setContent (html: String, options: PageSetContentOptions): IPage -> Task =
        fun (page: IPage) -> page.SetContentAsync(html, options)
    static member inline setDefaultNavigationTimeout (timeout: Single): IPage -> unit =
        fun (page: IPage) -> page.SetDefaultNavigationTimeout(timeout)
    static member inline setDefaultTimeout (timeout: Single): IPage -> unit =
        fun (page: IPage) -> page.SetDefaultTimeout(timeout)
    static member inline setExtraHTTPHeaders (headers: IEnumerable<KeyValuePair<String, String>>): IPage -> Task =
        fun (page: IPage) -> page.SetExtraHTTPHeadersAsync(headers)
    static member inline setInputFiles (selector: String, files: String): IPage -> Task =
        fun (page: IPage) -> page.SetInputFilesAsync(selector, files)
    static member inline setInputFiles (selector: String, files: String, options: PageSetInputFilesOptions): IPage -> Task =
        fun (page: IPage) -> page.SetInputFilesAsync(selector, files, options)
    static member inline setInputFiles (selector: String, files: IEnumerable<String>): IPage -> Task =
        fun (page: IPage) -> page.SetInputFilesAsync(selector, files)
    static member inline setInputFiles (selector: String, files: IEnumerable<String>, options: PageSetInputFilesOptions): IPage -> Task =
        fun (page: IPage) -> page.SetInputFilesAsync(selector, files, options)
    static member inline setInputFiles (selector: String, files: FilePayload): IPage -> Task =
        fun (page: IPage) -> page.SetInputFilesAsync(selector, files)
    static member inline setInputFiles (selector: String, files: FilePayload, options: PageSetInputFilesOptions): IPage -> Task =
        fun (page: IPage) -> page.SetInputFilesAsync(selector, files, options)
    static member inline setInputFiles (selector: String, files: IEnumerable<FilePayload>): IPage -> Task =
        fun (page: IPage) -> page.SetInputFilesAsync(selector, files)
    static member inline setInputFiles (selector: String, files: IEnumerable<FilePayload>, options: PageSetInputFilesOptions): IPage -> Task =
        fun (page: IPage) -> page.SetInputFilesAsync(selector, files, options)
    static member inline setViewportSize (width: Int32, height: Int32): IPage -> Task =
        fun (page: IPage) -> page.SetViewportSizeAsync(width, height)
    static member inline tap (selector: String): IPage -> Task =
        fun (page: IPage) -> page.TapAsync(selector)
    static member inline tap (selector: String, options: PageTapOptions): IPage -> Task =
        fun (page: IPage) -> page.TapAsync(selector, options)
    static member inline textContent (selector: String): IPage -> Task<String> =
        fun (page: IPage) -> page.TextContentAsync(selector)
    static member inline textContent (selector: String, options: PageTextContentOptions): IPage -> Task<String> =
        fun (page: IPage) -> page.TextContentAsync(selector, options)
    static member inline title (): IPage -> Task<String> =
        fun (page: IPage) -> page.TitleAsync()
    static member inline get_Touchscreen (): IPage -> ITouchscreen =
        fun (page: IPage) -> page.get_Touchscreen()
    static member inline type_ (selector: String, text: String): IPage -> Task =
        fun (page: IPage) -> page.TypeAsync(selector, text)
    static member inline type_ (selector: String, text: String, options: PageTypeOptions): IPage -> Task =
        fun (page: IPage) -> page.TypeAsync(selector, text, options)
    static member inline uncheck (selector: String): IPage -> Task =
        fun (page: IPage) -> page.UncheckAsync(selector)
    static member inline uncheck (selector: String, options: PageUncheckOptions): IPage -> Task =
        fun (page: IPage) -> page.UncheckAsync(selector, options)
    static member inline unroute (url: String): IPage -> Task =
        fun (page: IPage) -> page.UnrouteAsync(url)
    static member inline unroute (url: String, handler: Action<IRoute>): IPage -> Task =
        fun (page: IPage) -> page.UnrouteAsync(url, handler)
    static member inline unroute (url: Regex): IPage -> Task =
        fun (page: IPage) -> page.UnrouteAsync(url)
    static member inline unroute (url: Regex, handler: Action<IRoute>): IPage -> Task =
        fun (page: IPage) -> page.UnrouteAsync(url, handler)
    static member inline unroute (url: Func<String, Boolean>): IPage -> Task =
        fun (page: IPage) -> page.UnrouteAsync(url)
    static member inline unroute (url: Func<String, Boolean>, handler: Action<IRoute>): IPage -> Task =
        fun (page: IPage) -> page.UnrouteAsync(url, handler)
    static member inline get_Url (): IPage -> String =
        fun (page: IPage) -> page.get_Url()
    static member inline get_Video (): IPage -> IVideo =
        fun (page: IPage) -> page.get_Video()
    static member inline get_ViewportSize (): IPage -> PageViewportSizeResult =
        fun (page: IPage) -> page.get_ViewportSize()
    static member inline waitForConsoleMessage (): IPage -> Task<IConsoleMessage> =
        fun (page: IPage) -> page.WaitForConsoleMessageAsync()
    static member inline waitForConsoleMessage (options: PageWaitForConsoleMessageOptions): IPage -> Task<IConsoleMessage> =
        fun (page: IPage) -> page.WaitForConsoleMessageAsync(options)

module CustomOperations =
    let inline private ignore (pt: PlaywrightTest<_>) =
        playwright {
            let! _ = pt
            return ()
        }
    type PlaywrightBuilder with
        [<CustomOperation("waitForLoadState", MaintainsVariableSpaceUsingBind = true)>]
        member builder.waitForLoadState(x: PlaywrightTest<_>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForLoadStateAsync())
        member builder.waitForLoadState(x: PlaywrightTest<_>, state: Nullable<LoadState>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForLoadStateAsync(state))
        member builder.waitForLoadState(x: PlaywrightTest<_>, state: Nullable<LoadState>, options: PageWaitForLoadStateOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForLoadStateAsync(state, options))
        [<CustomOperation("waitForTimeout", MaintainsVariableSpaceUsingBind = true)>]
        member builder.waitForTimeout(x: PlaywrightTest<_>, timeout: Single) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForTimeoutAsync(timeout))
        [<CustomOperation("waitForURL", MaintainsVariableSpaceUsingBind = true)>]
        member builder.waitForURL(x: PlaywrightTest<_>, url: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForURLAsync(url))
        member builder.waitForURL(x: PlaywrightTest<_>, url: String, options: PageWaitForURLOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForURLAsync(url, options))
        member builder.waitForURL(x: PlaywrightTest<_>, url: Regex) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForURLAsync(url))
        member builder.waitForURL(x: PlaywrightTest<_>, url: Regex, options: PageWaitForURLOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForURLAsync(url, options))
        member builder.waitForURL(x: PlaywrightTest<_>, url: Func<String, Boolean>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForURLAsync(url))
        member builder.waitForURL(x: PlaywrightTest<_>, url: Func<String, Boolean>, options: PageWaitForURLOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.WaitForURLAsync(url, options))
        [<CustomOperation("exposeBinding", MaintainsVariableSpaceUsingBind = true)>]
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Action<BindingSource>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Action<BindingSource, 'T>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync<'T>(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Func<BindingSource, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync<'TResult>(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Func<BindingSource, IJSHandle, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync<'TResult>(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Func<BindingSource, 'T, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync<'T, 'TResult>(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Func<BindingSource, 'T1, 'T2, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync<'T1, 'T2, 'TResult>(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Func<BindingSource, 'T1, 'T2, 'T3, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync<'T1, 'T2, 'T3, 'TResult>(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Func<BindingSource, 'T1, 'T2, 'T3, 'T4, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync<'T1, 'T2, 'T3, 'T4, 'TResult>(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Action) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync(name, callback))
        member builder.exposeBinding(x: PlaywrightTest<_>, name: String, callback: Action, options: PageExposeBindingOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeBindingAsync(name, callback, options))
        [<CustomOperation("exposeFunction", MaintainsVariableSpaceUsingBind = true)>]
        member builder.exposeFunction(x: PlaywrightTest<_>, name: String, callback: Action<'T>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeFunctionAsync<'T>(name, callback))
        member builder.exposeFunction(x: PlaywrightTest<_>, name: String, callback: Func<'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeFunctionAsync<'TResult>(name, callback))
        member builder.exposeFunction(x: PlaywrightTest<_>, name: String, callback: Func<'T, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeFunctionAsync<'T, 'TResult>(name, callback))
        member builder.exposeFunction(x: PlaywrightTest<_>, name: String, callback: Func<'T1, 'T2, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeFunctionAsync<'T1, 'T2, 'TResult>(name, callback))
        member builder.exposeFunction(x: PlaywrightTest<_>, name: String, callback: Func<'T1, 'T2, 'T3, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeFunctionAsync<'T1, 'T2, 'T3, 'TResult>(name, callback))
        member builder.exposeFunction(x: PlaywrightTest<_>, name: String, callback: Func<'T1, 'T2, 'T3, 'T4, 'TResult>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeFunctionAsync<'T1, 'T2, 'T3, 'T4, 'TResult>(name, callback))
        member builder.exposeFunction(x: PlaywrightTest<_>, name: String, callback: Action) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ExposeFunctionAsync(name, callback))
        [<CustomOperation("addInitScript", MaintainsVariableSpaceUsingBind = true)>]
        member builder.addInitScript(x: PlaywrightTest<_>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.AddInitScriptAsync())
        member builder.addInitScript(x: PlaywrightTest<_>, script: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.AddInitScriptAsync(script))
        member builder.addInitScript(x: PlaywrightTest<_>, script: String, scriptPath: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.AddInitScriptAsync(script, scriptPath))
        [<CustomOperation("bringToFront", MaintainsVariableSpaceUsingBind = true)>]
        member builder.bringToFront(x: PlaywrightTest<_>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.BringToFrontAsync())
        [<CustomOperation("check", MaintainsVariableSpaceUsingBind = true)>]
        member builder.check(x: PlaywrightTest<_>, selector: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.CheckAsync(selector))
        member builder.check(x: PlaywrightTest<_>, selector: String, options: PageCheckOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.CheckAsync(selector, options))
        [<CustomOperation("click", MaintainsVariableSpaceUsingBind = true)>]
        member builder.click(x: PlaywrightTest<_>, selector: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ClickAsync(selector))
        member builder.click(x: PlaywrightTest<_>, selector: String, options: PageClickOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.ClickAsync(selector, options))
        [<CustomOperation("close", MaintainsVariableSpaceUsingBind = true)>]
        member builder.close(x: PlaywrightTest<_>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.CloseAsync())
        member builder.close(x: PlaywrightTest<_>, options: PageCloseOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.CloseAsync(options))
        [<CustomOperation("dblClick", MaintainsVariableSpaceUsingBind = true)>]
        member builder.dblClick(x: PlaywrightTest<_>, selector: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.DblClickAsync(selector))
        member builder.dblClick(x: PlaywrightTest<_>, selector: String, options: PageDblClickOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.DblClickAsync(selector, options))
        [<CustomOperation("dispatchEvent", MaintainsVariableSpaceUsingBind = true)>]
        member builder.dispatchEvent(x: PlaywrightTest<_>, selector: String, type_: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.DispatchEventAsync(selector, type_))
        member builder.dispatchEvent(x: PlaywrightTest<_>, selector: String, type_: String, eventInit: Object) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.DispatchEventAsync(selector, type_, eventInit))
        member builder.dispatchEvent(x: PlaywrightTest<_>, selector: String, type_: String, eventInit: Object, options: PageDispatchEventOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.DispatchEventAsync(selector, type_, eventInit, options))
        [<CustomOperation("dragAndDrop", MaintainsVariableSpaceUsingBind = true)>]
        member builder.dragAndDrop(x: PlaywrightTest<_>, source: String, target: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.DragAndDropAsync(source, target))
        member builder.dragAndDrop(x: PlaywrightTest<_>, source: String, target: String, options: PageDragAndDropOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.DragAndDropAsync(source, target, options))
        [<CustomOperation("emulateMedia", MaintainsVariableSpaceUsingBind = true)>]
        member builder.emulateMedia(x: PlaywrightTest<_>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.EmulateMediaAsync())
        member builder.emulateMedia(x: PlaywrightTest<_>, options: PageEmulateMediaOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.EmulateMediaAsync(options))
        [<CustomOperation("fill", MaintainsVariableSpaceUsingBind = true)>]
        member builder.fill(x: PlaywrightTest<_>, selector: String, value: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.FillAsync(selector, value))
        member builder.fill(x: PlaywrightTest<_>, selector: String, value: String, options: PageFillOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.FillAsync(selector, value, options))
        [<CustomOperation("focus", MaintainsVariableSpaceUsingBind = true)>]
        member builder.focus(x: PlaywrightTest<_>, selector: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.FocusAsync(selector))
        member builder.focus(x: PlaywrightTest<_>, selector: String, options: PageFocusOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.FocusAsync(selector, options))
        [<CustomOperation("hover", MaintainsVariableSpaceUsingBind = true)>]
        member builder.hover(x: PlaywrightTest<_>, selector: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.HoverAsync(selector))
        member builder.hover(x: PlaywrightTest<_>, selector: String, options: PageHoverOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.HoverAsync(selector, options))
        [<CustomOperation("pause", MaintainsVariableSpaceUsingBind = true)>]
        member builder.pause(x: PlaywrightTest<_>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.PauseAsync())
        [<CustomOperation("press", MaintainsVariableSpaceUsingBind = true)>]
        member builder.press(x: PlaywrightTest<_>, selector: String, key: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.PressAsync(selector, key))
        member builder.press(x: PlaywrightTest<_>, selector: String, key: String, options: PagePressOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.PressAsync(selector, key, options))
        [<CustomOperation("route", MaintainsVariableSpaceUsingBind = true)>]
        member builder.route(x: PlaywrightTest<_>, url: String, handler: Action<IRoute>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.RouteAsync(url, handler))
        member builder.route(x: PlaywrightTest<_>, url: Regex, handler: Action<IRoute>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.RouteAsync(url, handler))
        member builder.route(x: PlaywrightTest<_>, url: Func<String, Boolean>, handler: Action<IRoute>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.RouteAsync(url, handler))
        [<CustomOperation("setContent", MaintainsVariableSpaceUsingBind = true)>]
        member builder.setContent(x: PlaywrightTest<_>, html: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetContentAsync(html))
        member builder.setContent(x: PlaywrightTest<_>, html: String, options: PageSetContentOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetContentAsync(html, options))
        [<CustomOperation("setExtraHTTPHeaders", MaintainsVariableSpaceUsingBind = true)>]
        member builder.setExtraHTTPHeaders(x: PlaywrightTest<_>, headers: IEnumerable<KeyValuePair<String, String>>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetExtraHTTPHeadersAsync(headers))
        [<CustomOperation("setInputFiles", MaintainsVariableSpaceUsingBind = true)>]
        member builder.setInputFiles(x: PlaywrightTest<_>, selector: String, files: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetInputFilesAsync(selector, files))
        member builder.setInputFiles(x: PlaywrightTest<_>, selector: String, files: String, options: PageSetInputFilesOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetInputFilesAsync(selector, files, options))
        member builder.setInputFiles(x: PlaywrightTest<_>, selector: String, files: IEnumerable<String>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetInputFilesAsync(selector, files))
        member builder.setInputFiles(x: PlaywrightTest<_>, selector: String, files: IEnumerable<String>, options: PageSetInputFilesOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetInputFilesAsync(selector, files, options))
        member builder.setInputFiles(x: PlaywrightTest<_>, selector: String, files: FilePayload) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetInputFilesAsync(selector, files))
        member builder.setInputFiles(x: PlaywrightTest<_>, selector: String, files: FilePayload, options: PageSetInputFilesOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetInputFilesAsync(selector, files, options))
        member builder.setInputFiles(x: PlaywrightTest<_>, selector: String, files: IEnumerable<FilePayload>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetInputFilesAsync(selector, files))
        member builder.setInputFiles(x: PlaywrightTest<_>, selector: String, files: IEnumerable<FilePayload>, options: PageSetInputFilesOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetInputFilesAsync(selector, files, options))
        [<CustomOperation("setViewportSize", MaintainsVariableSpaceUsingBind = true)>]
        member builder.setViewportSize(x: PlaywrightTest<_>, width: Int32, height: Int32) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.SetViewportSizeAsync(width, height))
        [<CustomOperation("tap", MaintainsVariableSpaceUsingBind = true)>]
        member builder.tap(x: PlaywrightTest<_>, selector: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.TapAsync(selector))
        member builder.tap(x: PlaywrightTest<_>, selector: String, options: PageTapOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.TapAsync(selector, options))
        [<CustomOperation("type_", MaintainsVariableSpaceUsingBind = true)>]
        member builder.type_(x: PlaywrightTest<_>, selector: String, text: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.TypeAsync(selector, text))
        member builder.type_(x: PlaywrightTest<_>, selector: String, text: String, options: PageTypeOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.TypeAsync(selector, text, options))
        [<CustomOperation("uncheck", MaintainsVariableSpaceUsingBind = true)>]
        member builder.uncheck(x: PlaywrightTest<_>, selector: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.UncheckAsync(selector))
        member builder.uncheck(x: PlaywrightTest<_>, selector: String, options: PageUncheckOptions) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.UncheckAsync(selector, options))
        [<CustomOperation("unroute", MaintainsVariableSpaceUsingBind = true)>]
        member builder.unroute(x: PlaywrightTest<_>, url: String) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.UnrouteAsync(url))
        member builder.unroute(x: PlaywrightTest<_>, url: String, handler: Action<IRoute>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.UnrouteAsync(url, handler))
        member builder.unroute(x: PlaywrightTest<_>, url: Regex) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.UnrouteAsync(url))
        member builder.unroute(x: PlaywrightTest<_>, url: Regex, handler: Action<IRoute>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.UnrouteAsync(url, handler))
        member builder.unroute(x: PlaywrightTest<_>, url: Func<String, Boolean>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.UnrouteAsync(url))
        member builder.unroute(x: PlaywrightTest<_>, url: Func<String, Boolean>, handler: Action<IRoute>) =
            builder.Bind(ignore x, fun () (page: IPage) -> page.UnrouteAsync(url, handler))
