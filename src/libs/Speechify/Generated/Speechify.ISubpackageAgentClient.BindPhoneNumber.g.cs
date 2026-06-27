#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Bind Agent Phone Number<br/>
        /// Bind a workspace phone number to this agent so inbound calls to<br/>
        /// the number reach it. Idempotent and last-write-wins: binding a<br/>
        /// number already bound to another agent reassigns it. Verified<br/>
        /// caller IDs are outbound-only and cannot be bound (400).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BindPhoneNumberAsync(
            string agentId,
            string phoneNumberId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bind Agent Phone Number<br/>
        /// Bind a workspace phone number to this agent so inbound calls to<br/>
        /// the number reach it. Idempotent and last-write-wins: binding a<br/>
        /// number already bound to another agent reassigns it. Verified<br/>
        /// caller IDs are outbound-only and cannot be bound (400).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> BindPhoneNumberAsResponseAsync(
            string agentId,
            string phoneNumberId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}