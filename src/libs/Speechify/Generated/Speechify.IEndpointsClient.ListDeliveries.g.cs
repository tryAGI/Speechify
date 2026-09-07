#nullable enable

namespace Speechify
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// List webhook endpoint deliveries<br/>
        /// Delivery attempts for one webhook endpoint, newest first. One row per<br/>
        /// (endpoint, event, resource), updated in place across retries. Each row<br/>
        /// includes the exact request payload and signed headers Speechify sent<br/>
        /// (`request_body`, `request_headers`) and the response your server returned<br/>
        /// (`last_status_code`, `last_response_body`, `last_response_headers`), so<br/>
        /// you can verify the signature and debug failures. Cursor-paginated: omit<br/>
        /// `cursor` for the first page; walk pages while `has_more` is true (default<br/>
        /// page size 50, max 200).<br/>
        /// An endpoint that was not a target of an event has no row for it: a<br/>
        /// project-scoped endpoint records nothing for another project's events.<br/>
        /// An empty list therefore means either nothing matched or nothing<br/>
        /// happened. To tell them apart, list the project's own activity first<br/>
        /// (`GET /v1/agents/runs?project_id=…`, the conversations list): activity<br/>
        /// there with no delivery here is a defect to report; none there means<br/>
        /// there was nothing to deliver.
        /// </summary>
        /// <param name="webhookEndpointId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListWebhookEndpointDeliveriesResponse> ListDeliveriesAsync(
            string webhookEndpointId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhook endpoint deliveries<br/>
        /// Delivery attempts for one webhook endpoint, newest first. One row per<br/>
        /// (endpoint, event, resource), updated in place across retries. Each row<br/>
        /// includes the exact request payload and signed headers Speechify sent<br/>
        /// (`request_body`, `request_headers`) and the response your server returned<br/>
        /// (`last_status_code`, `last_response_body`, `last_response_headers`), so<br/>
        /// you can verify the signature and debug failures. Cursor-paginated: omit<br/>
        /// `cursor` for the first page; walk pages while `has_more` is true (default<br/>
        /// page size 50, max 200).<br/>
        /// An endpoint that was not a target of an event has no row for it: a<br/>
        /// project-scoped endpoint records nothing for another project's events.<br/>
        /// An empty list therefore means either nothing matched or nothing<br/>
        /// happened. To tell them apart, list the project's own activity first<br/>
        /// (`GET /v1/agents/runs?project_id=…`, the conversations list): activity<br/>
        /// there with no delivery here is a defect to report; none there means<br/>
        /// there was nothing to deliver.
        /// </summary>
        /// <param name="webhookEndpointId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListWebhookEndpointDeliveriesResponse>> ListDeliveriesAsResponseAsync(
            string webhookEndpointId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}