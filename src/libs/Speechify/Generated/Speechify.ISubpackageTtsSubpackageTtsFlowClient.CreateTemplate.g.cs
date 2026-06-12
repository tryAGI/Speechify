#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsFlowClient
    {
        /// <summary>
        /// Create Flow Template<br/>
        /// Create a reusable flow template from a graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsFlowTemplate> CreateTemplateAsync(

            global::Speechify.TtsCreateFlowTemplateRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Flow Template<br/>
        /// Create a reusable flow template from a graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsFlowTemplate>> CreateTemplateAsResponseAsync(

            global::Speechify.TtsCreateFlowTemplateRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Flow Template<br/>
        /// Create a reusable flow template from a graph.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Speechify.TtsFlowTemplate> CreateTemplateAsync(
            string key,
            string name,
            global::Speechify.TtsFlowGraphInput graph,
            string? description = default,
            string? category = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}