#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Tool Capabilities<br/>
        /// Read-only catalogue of every built-in tool capability the worker<br/>
        /// knows about (the names usable as `config.builtin` when adding a<br/>
        /// `kind=builtin` tool to an agent). The console fetches this at<br/>
        /// runtime rather than maintaining a parallel client-side list; the<br/>
        /// server is the single source of truth for the label and<br/>
        /// description copy a customer sees in the capability picker.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListSystemBuiltinsResponse> ListToolCapabilitiesAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tool Capabilities<br/>
        /// Read-only catalogue of every built-in tool capability the worker<br/>
        /// knows about (the names usable as `config.builtin` when adding a<br/>
        /// `kind=builtin` tool to an agent). The console fetches this at<br/>
        /// runtime rather than maintaining a parallel client-side list; the<br/>
        /// server is the single source of truth for the label and<br/>
        /// description copy a customer sees in the capability picker.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListSystemBuiltinsResponse>> ListToolCapabilitiesAsResponseAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}