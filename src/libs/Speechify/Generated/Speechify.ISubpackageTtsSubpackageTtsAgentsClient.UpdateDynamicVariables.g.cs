#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Update Dynamic Variables<br/>
        /// Replace the agent's customer-scope dynamic variable definitions.<br/>
        /// The supplied list overwrites the stored list wholesale (same<br/>
        /// semantics as `updateEvaluationConfig`). Pass an empty array to<br/>
        /// clear all variables. Up to 20 variables per agent. Keys must<br/>
        /// match `[a-zA-Z0-9_]+` and must not start with the reserved<br/>
        /// `system__` prefix.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsListDynamicVariablesResponse> UpdateDynamicVariablesAsync(
            string id,

            global::Speechify.TtsUpdateDynamicVariablesRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dynamic Variables<br/>
        /// Replace the agent's customer-scope dynamic variable definitions.<br/>
        /// The supplied list overwrites the stored list wholesale (same<br/>
        /// semantics as `updateEvaluationConfig`). Pass an empty array to<br/>
        /// clear all variables. Up to 20 variables per agent. Keys must<br/>
        /// match `[a-zA-Z0-9_]+` and must not start with the reserved<br/>
        /// `system__` prefix.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsListDynamicVariablesResponse>> UpdateDynamicVariablesAsResponseAsync(
            string id,

            global::Speechify.TtsUpdateDynamicVariablesRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dynamic Variables<br/>
        /// Replace the agent's customer-scope dynamic variable definitions.<br/>
        /// The supplied list overwrites the stored list wholesale (same<br/>
        /// semantics as `updateEvaluationConfig`). Pass an empty array to<br/>
        /// clear all variables. Up to 20 variables per agent. Keys must<br/>
        /// match `[a-zA-Z0-9_]+` and must not start with the reserved<br/>
        /// `system__` prefix.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="variables">
        /// The new variable list. Replaces the existing list entirely.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsListDynamicVariablesResponse> UpdateDynamicVariablesAsync(
            string id,
            global::System.Collections.Generic.IList<global::Speechify.TtsDynamicVariable> variables,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}