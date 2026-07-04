#nullable enable

namespace Speechify
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Delete Phone Number<br/>
        /// Delete a phone number from the workspace. For Twilio and LiveKit<br/>
        /// numbers this also deprovisions the backing SIP trunk and dispatch<br/>
        /// rule on LiveKit Cloud.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string phoneNumberId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Phone Number<br/>
        /// Delete a phone number from the workspace. For Twilio and LiveKit<br/>
        /// numbers this also deprovisions the backing SIP trunk and dispatch<br/>
        /// rule on LiveKit Cloud.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string phoneNumberId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}