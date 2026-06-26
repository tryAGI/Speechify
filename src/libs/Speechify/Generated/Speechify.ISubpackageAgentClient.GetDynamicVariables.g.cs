#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Get Dynamic Variables<br/>
        /// Retrieve the agent's customer-scope dynamic variables and the read-only<br/>
        /// catalogue of reserved `system__*` keys. The system variables list is<br/>
        /// provided so editor UIs can render the reference list without maintaining<br/>
        /// a client-side copy of the catalogue.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListDynamicVariablesResponse> GetDynamicVariablesAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dynamic Variables<br/>
        /// Retrieve the agent's customer-scope dynamic variables and the read-only<br/>
        /// catalogue of reserved `system__*` keys. The system variables list is<br/>
        /// provided so editor UIs can render the reference list without maintaining<br/>
        /// a client-side copy of the catalogue.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListDynamicVariablesResponse>> GetDynamicVariablesAsResponseAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}