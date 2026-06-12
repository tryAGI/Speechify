#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsFlowClient
    {
        /// <summary>
        /// Update Agent Flow Draft<br/>
        /// Replace the agent's draft flow graph. The graph is validated<br/>
        /// before it is stored; publish it separately to make it active.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsFlowGraph> UpdateFlowAsync(
            string id,

            global::Speechify.TtsPutFlowRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Flow Draft<br/>
        /// Replace the agent's draft flow graph. The graph is validated<br/>
        /// before it is stored; publish it separately to make it active.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsFlowGraph>> UpdateFlowAsResponseAsync(
            string id,

            global::Speechify.TtsPutFlowRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Flow Draft<br/>
        /// Replace the agent's draft flow graph. The graph is validated<br/>
        /// before it is stored; publish it separately to make it active.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="notes"></param>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
        /// <param name="variables"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsFlowGraph> UpdateFlowAsync(
            string id,
            global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestNodesItems> nodes,
            global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestEdgesItems> edges,
            string? name = default,
            string? notes = default,
            global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestVariablesItems>? variables = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}