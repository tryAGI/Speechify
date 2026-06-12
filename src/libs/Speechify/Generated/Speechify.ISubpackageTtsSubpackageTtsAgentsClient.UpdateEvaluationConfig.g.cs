#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Update Evaluation Config<br/>
        /// Replace the agent's evaluation criteria + data-collection fields.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsEvaluationConfig> UpdateEvaluationConfigAsync(
            string id,

            global::Speechify.TtsUpdateEvaluationConfigRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Evaluation Config<br/>
        /// Replace the agent's evaluation criteria + data-collection fields.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsEvaluationConfig>> UpdateEvaluationConfigAsResponseAsync(
            string id,

            global::Speechify.TtsUpdateEvaluationConfigRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Evaluation Config<br/>
        /// Replace the agent's evaluation criteria + data-collection fields.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="criteria"></param>
        /// <param name="dataCollection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsEvaluationConfig> UpdateEvaluationConfigAsync(
            string id,
            global::System.Collections.Generic.IList<global::Speechify.TtsEvaluationCriterion> criteria,
            global::System.Collections.Generic.IList<global::Speechify.TtsDataCollectionField> dataCollection,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}