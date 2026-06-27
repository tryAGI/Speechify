#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentPhoneNumbersClient
    {
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's own attributes (today: `label`).<br/>
        /// `source` and `e164` are immutable after import. To bind or<br/>
        /// unbind an agent, use the relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> UpdateAsync(
            string phoneNumberId,

            global::Speechify.UpdatePhoneNumberRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's own attributes (today: `label`).<br/>
        /// `source` and `e164` are immutable after import. To bind or<br/>
        /// unbind an agent, use the relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.PhoneNumber>> UpdateAsResponseAsync(
            string phoneNumberId,

            global::Speechify.UpdatePhoneNumberRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's own attributes (today: `label`).<br/>
        /// `source` and `e164` are immutable after import. To bind or<br/>
        /// unbind an agent, use the relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="label">
        /// New label. Pass an empty string to clear.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> UpdateAsync(
            string phoneNumberId,
            string? speechifyVersion = default,
            string? label = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}