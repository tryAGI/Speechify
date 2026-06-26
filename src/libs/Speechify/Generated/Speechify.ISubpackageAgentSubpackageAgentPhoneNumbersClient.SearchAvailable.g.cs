#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentPhoneNumbersClient
    {
        /// <summary>
        /// Search Available Phone Numbers<br/>
        /// Search carrier inventory for phone numbers available to purchase.<br/>
        /// Currently restricted to the US (`country=US`); pass `area_code`<br/>
        /// to narrow to a specific NPA. The returned numbers are not held;<br/>
        /// a subsequent `POST /v1/agents/phone-numbers/purchase` against the same<br/>
        /// E.164 may fail with 4xx if the number has been taken in the<br/>
        /// meantime.
        /// </summary>
        /// <param name="country">
        /// Default Value: US
        /// </param>
        /// <param name="areaCode"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.SearchAvailablePhoneNumbersResponse> SearchAvailableAsync(
            string? country = default,
            string? areaCode = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Available Phone Numbers<br/>
        /// Search carrier inventory for phone numbers available to purchase.<br/>
        /// Currently restricted to the US (`country=US`); pass `area_code`<br/>
        /// to narrow to a specific NPA. The returned numbers are not held;<br/>
        /// a subsequent `POST /v1/agents/phone-numbers/purchase` against the same<br/>
        /// E.164 may fail with 4xx if the number has been taken in the<br/>
        /// meantime.
        /// </summary>
        /// <param name="country">
        /// Default Value: US
        /// </param>
        /// <param name="areaCode"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.SearchAvailablePhoneNumbersResponse>> SearchAvailableAsResponseAsync(
            string? country = default,
            string? areaCode = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}