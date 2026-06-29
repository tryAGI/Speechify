#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Tool Capabilities<br/>
        /// Read-only catalogue of every built-in tool capability the agent<br/>
        /// runtime supports (the names usable as `config.builtin` when adding a<br/>
        /// `kind=builtin` tool to an agent). Fetch this at runtime rather<br/>
        /// than maintaining a parallel client-side list; the server is the<br/>
        /// single source of truth for the label and description text a<br/>
        /// customer sees in the capability picker. Returns<br/>
        /// the full set in a single response: bounded by the platform's<br/>
        /// built-in tool-capability registry, so this list is intentionally<br/>
        /// not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListSystemBuiltinsResponse> ListToolCapabilitiesAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tool Capabilities<br/>
        /// Read-only catalogue of every built-in tool capability the agent<br/>
        /// runtime supports (the names usable as `config.builtin` when adding a<br/>
        /// `kind=builtin` tool to an agent). Fetch this at runtime rather<br/>
        /// than maintaining a parallel client-side list; the server is the<br/>
        /// single source of truth for the label and description text a<br/>
        /// customer sees in the capability picker. Returns<br/>
        /// the full set in a single response: bounded by the platform's<br/>
        /// built-in tool-capability registry, so this list is intentionally<br/>
        /// not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListSystemBuiltinsResponse>> ListToolCapabilitiesAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}