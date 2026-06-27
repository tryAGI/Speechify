#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentFlowClient
    {
        /// <summary>
        /// Update Flow Template<br/>
        /// Replace a flow template. The whole template is replaced, not patched field-by-field.
        /// </summary>
        /// <param name="flowTemplateId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.FlowTemplate> UpdateTemplateAsync(
            string flowTemplateId,

            global::Speechify.CreateFlowTemplateRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Flow Template<br/>
        /// Replace a flow template. The whole template is replaced, not patched field-by-field.
        /// </summary>
        /// <param name="flowTemplateId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.FlowTemplate>> UpdateTemplateAsResponseAsync(
            string flowTemplateId,

            global::Speechify.CreateFlowTemplateRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Flow Template<br/>
        /// Replace a flow template. The whole template is replaced, not patched field-by-field.
        /// </summary>
        /// <param name="flowTemplateId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="category">
        /// Defaults to "custom" when omitted.
        /// </param>
        /// <param name="graph">
        /// Request-side flow graph: nodes, edges, and variables only.<br/>
        /// Unlike the response-side FlowGraph it carries no `version`<br/>
        /// block - the server owns version metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.FlowTemplate> UpdateTemplateAsync(
            string flowTemplateId,
            string key,
            string name,
            global::Speechify.FlowGraphInput graph,
            string? speechifyVersion = default,
            string? description = default,
            string? category = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}