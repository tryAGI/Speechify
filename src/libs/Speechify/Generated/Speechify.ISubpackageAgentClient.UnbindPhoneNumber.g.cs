#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Unbind Agent Phone Number<br/>
        /// Unbind a phone number from this agent. Returns 404 when the<br/>
        /// number is not currently bound to this agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnbindPhoneNumberAsync(
            string id,
            string phoneNumberId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unbind Agent Phone Number<br/>
        /// Unbind a phone number from this agent. Returns 404 when the<br/>
        /// number is not currently bound to this agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> UnbindPhoneNumberAsResponseAsync(
            string id,
            string phoneNumberId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}