#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// List Webhook Deliveries<br/>
        /// List post-call webhook delivery attempts for a conversation,<br/>
        /// newest first. Rows appear once the LiveKit `room_finished`<br/>
        /// webhook has fired and the post-call webhook has been<br/>
        /// dispatched to the agent's configured URL. One row per<br/>
        /// `(conversation, webhook-url)`, updated in place across retries.<br/>
        /// Each row includes the exact request payload and signed headers<br/>
        /// Speechify sent (`request_body`, `request_headers`) and the<br/>
        /// response your server returned (`last_status_code`,<br/>
        /// `last_response_body`, `last_response_headers`), so you can verify<br/>
        /// what was delivered and debug a failing endpoint.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Default page size is 50 and max is 200. Walk pages while<br/>
        /// `has_more` is true.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListWebhookDeliveriesResponse> ListWebhookDeliveriesAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Webhook Deliveries<br/>
        /// List post-call webhook delivery attempts for a conversation,<br/>
        /// newest first. Rows appear once the LiveKit `room_finished`<br/>
        /// webhook has fired and the post-call webhook has been<br/>
        /// dispatched to the agent's configured URL. One row per<br/>
        /// `(conversation, webhook-url)`, updated in place across retries.<br/>
        /// Each row includes the exact request payload and signed headers<br/>
        /// Speechify sent (`request_body`, `request_headers`) and the<br/>
        /// response your server returned (`last_status_code`,<br/>
        /// `last_response_body`, `last_response_headers`), so you can verify<br/>
        /// what was delivered and debug a failing endpoint.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Default page size is 50 and max is 200. Walk pages while<br/>
        /// `has_more` is true.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListWebhookDeliveriesResponse>> ListWebhookDeliveriesAsResponseAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}