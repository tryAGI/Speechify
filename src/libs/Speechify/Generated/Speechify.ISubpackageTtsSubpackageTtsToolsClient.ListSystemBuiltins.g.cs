#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsToolsClient
    {
        /// <summary>
        /// List System Builtins<br/>
        /// Read-only catalogue of every system builtin the worker knows<br/>
        /// about. The console fetches this at runtime rather than<br/>
        /// maintaining a parallel client-side list (AIS-3074); the server<br/>
        /// is the single source of truth for the label and description<br/>
        /// copy a customer sees in the builtin-instance picker.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsListSystemBuiltinsResponse> ListSystemBuiltinsAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List System Builtins<br/>
        /// Read-only catalogue of every system builtin the worker knows<br/>
        /// about. The console fetches this at runtime rather than<br/>
        /// maintaining a parallel client-side list (AIS-3074); the server<br/>
        /// is the single source of truth for the label and description<br/>
        /// copy a customer sees in the builtin-instance picker.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsListSystemBuiltinsResponse>> ListSystemBuiltinsAsResponseAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}