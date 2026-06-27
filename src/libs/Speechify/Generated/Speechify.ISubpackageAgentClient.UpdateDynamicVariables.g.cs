#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
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
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListDynamicVariablesResponse> UpdateDynamicVariablesAsync(
            string agentId,

            global::Speechify.UpdateDynamicVariablesRequest request,
            string? speechifyVersion = default,
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
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListDynamicVariablesResponse>> UpdateDynamicVariablesAsResponseAsync(
            string agentId,

            global::Speechify.UpdateDynamicVariablesRequest request,
            string? speechifyVersion = default,
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
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="variables">
        /// The new variable list. Replaces the existing list entirely.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListDynamicVariablesResponse> UpdateDynamicVariablesAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::Speechify.DynamicVariable> variables,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}