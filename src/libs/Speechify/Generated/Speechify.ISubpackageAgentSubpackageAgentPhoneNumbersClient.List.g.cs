#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentPhoneNumbersClient
    {
        /// <summary>
        /// List Phone Numbers<br/>
        /// List all phone numbers in the caller's workspace. Returns the full<br/>
        /// set in a single response: bounded by the workspace's phone-number<br/>
        /// inventory (hard-capped at 100 and by the per-plan quota), so this<br/>
        /// list is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListPhoneNumbersResponse> ListAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Phone Numbers<br/>
        /// List all phone numbers in the caller's workspace. Returns the full<br/>
        /// set in a single response: bounded by the workspace's phone-number<br/>
        /// inventory (hard-capped at 100 and by the per-plan quota), so this<br/>
        /// list is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListPhoneNumbersResponse>> ListAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}