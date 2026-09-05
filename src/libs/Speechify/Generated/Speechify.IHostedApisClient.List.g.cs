#nullable enable

namespace Speechify
{
    public partial interface IHostedApisClient
    {
        /// <summary>
        /// List Hosted APIs<br/>
        /// List the hosted APIs in the caller's workspace, most recently updated<br/>
        /// first. A hosted API is the API you assemble: a slug that becomes<br/>
        /// `https://&lt;slug&gt;.&lt;hosted-api domain&gt;`, the routes it answers, and the<br/>
        /// consumer keys your own callers present.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListHostedAPIsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Hosted APIs<br/>
        /// List the hosted APIs in the caller's workspace, most recently updated<br/>
        /// first. A hosted API is the API you assemble: a slug that becomes<br/>
        /// `https://&lt;slug&gt;.&lt;hosted-api domain&gt;`, the routes it answers, and the<br/>
        /// consumer keys your own callers present.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListHostedAPIsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}