#nullable enable

namespace Speechify
{
    public partial interface IFlowClient
    {
        /// <summary>
        /// Clone Flow Template<br/>
        /// Clone a flow template onto an agent as a new draft graph.
        /// </summary>
        /// <param name="flowTemplateId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.FlowGraph> CloneTemplateAsync(
            string flowTemplateId,

            global::Speechify.CloneFlowTemplateRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Flow Template<br/>
        /// Clone a flow template onto an agent as a new draft graph.
        /// </summary>
        /// <param name="flowTemplateId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.FlowGraph>> CloneTemplateAsResponseAsync(
            string flowTemplateId,

            global::Speechify.CloneFlowTemplateRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Flow Template<br/>
        /// Clone a flow template onto an agent as a new draft graph.
        /// </summary>
        /// <param name="flowTemplateId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="agentId">
        /// The agent that receives the cloned graph as a new draft.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.FlowGraph> CloneTemplateAsync(
            string flowTemplateId,
            string agentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}