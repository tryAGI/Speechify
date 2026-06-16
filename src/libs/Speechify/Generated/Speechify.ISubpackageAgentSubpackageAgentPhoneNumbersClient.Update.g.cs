#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentPhoneNumbersClient
    {
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number. Only `label` and `agent_id` are mutable;<br/>
        /// `source` and `e164` are immutable after import. Pass `null` for<br/>
        /// `agent_id` to unbind the number from its current agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> UpdateAsync(
            string id,

            global::Speechify.UpdatePhoneNumberRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number. Only `label` and `agent_id` are mutable;<br/>
        /// `source` and `e164` are immutable after import. Pass `null` for<br/>
        /// `agent_id` to unbind the number from its current agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.PhoneNumber>> UpdateAsResponseAsync(
            string id,

            global::Speechify.UpdatePhoneNumberRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number. Only `label` and `agent_id` are mutable;<br/>
        /// `source` and `e164` are immutable after import. Pass `null` for<br/>
        /// `agent_id` to unbind the number from its current agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label">
        /// New label. Pass an empty string to clear.
        /// </param>
        /// <param name="agentId">
        /// Agent to bind the number to. Prefixed wire identifier<br/>
        /// (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="clearAgentId">
        /// When `true`, unbinds the current agent (clears `agent_id`).<br/>
        /// Wins over `agent_id` when both are sent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> UpdateAsync(
            string id,
            string? label = default,
            string? agentId = default,
            bool? clearAgentId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}