#nullable enable

namespace Speechify
{
    public partial interface IHostedApisClient
    {
        /// <summary>
        /// Get Hosted API Usage<br/>
        /// Today's reads and runs against the API's daily caps, with each route's<br/>
        /// share of the reads. A read is a request a store, file or run_latest<br/>
        /// route answered from storage; a response served from the cache is not<br/>
        /// one. `counters_available` is false where nothing counts (no Redis), so<br/>
        /// a zero is never mistaken for a quiet day.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPIUsage> GetUsageAsync(
            string apiId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Hosted API Usage<br/>
        /// Today's reads and runs against the API's daily caps, with each route's<br/>
        /// share of the reads. A read is a request a store, file or run_latest<br/>
        /// route answered from storage; a response served from the cache is not<br/>
        /// one. `counters_available` is false where nothing counts (no Redis), so<br/>
        /// a zero is never mistaken for a quiet day.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPIUsage>> GetUsageAsResponseAsync(
            string apiId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}