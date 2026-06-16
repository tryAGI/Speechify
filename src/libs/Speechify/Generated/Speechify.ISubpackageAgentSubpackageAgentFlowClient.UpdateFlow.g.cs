#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentFlowClient
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
        global::System.Threading.Tasks.Task<global::Speechify.FlowGraph> UpdateFlowAsync(
            string id,

            global::Speechify.PutFlowRequest request,
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.FlowGraph>> UpdateFlowAsResponseAsync(
            string id,

            global::Speechify.PutFlowRequest request,
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
        global::System.Threading.Tasks.Task<global::Speechify.FlowGraph> UpdateFlowAsync(
            string id,
            global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestNodesItems> nodes,
            global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestEdgesItems> edges,
            string? name = default,
            string? notes = default,
            global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestVariablesItems>? variables = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}