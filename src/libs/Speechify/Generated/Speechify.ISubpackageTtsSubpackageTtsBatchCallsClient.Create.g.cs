#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsBatchCallsClient
    {
        /// <summary>
        /// Create Batch Call<br/>
        /// Dial a list of phone numbers through one of your voice agents in a<br/>
        /// single request. Each recipient can receive personalised dynamic<br/>
        /// variables that your agent prompt references via `{{key}}` placeholders.<br/>
        /// Batches can run immediately or be scheduled up to 30 days in advance.<br/>
        /// Accepts `application/json` or `multipart/form-data` (with a CSV file).<br/>
        /// Max 1000 recipients per batch.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsCreateBatchCallResponse> CreateAsync(

            global::Speechify.TtsCreateBatchCallRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch Call<br/>
        /// Dial a list of phone numbers through one of your voice agents in a<br/>
        /// single request. Each recipient can receive personalised dynamic<br/>
        /// variables that your agent prompt references via `{{key}}` placeholders.<br/>
        /// Batches can run immediately or be scheduled up to 30 days in advance.<br/>
        /// Accepts `application/json` or `multipart/form-data` (with a CSV file).<br/>
        /// Max 1000 recipients per batch.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsCreateBatchCallResponse>> CreateAsResponseAsync(

            global::Speechify.TtsCreateBatchCallRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch Call<br/>
        /// Dial a list of phone numbers through one of your voice agents in a<br/>
        /// single request. Each recipient can receive personalised dynamic<br/>
        /// variables that your agent prompt references via `{{key}}` placeholders.<br/>
        /// Batches can run immediately or be scheduled up to 30 days in advance.<br/>
        /// Accepts `application/json` or `multipart/form-data` (with a CSV file).<br/>
        /// Max 1000 recipients per batch.
        /// </summary>
        /// <param name="name">
        /// Human-readable batch name.
        /// </param>
        /// <param name="agentId">
        /// Agent that handles each call.
        /// </param>
        /// <param name="phoneNumberId">
        /// Caller-ID override. Falls back to the agent's bound number.
        /// </param>
        /// <param name="scheduledAt">
        /// Schedule the batch for a future time (RFC 3339). Omit to start immediately.
        /// </param>
        /// <param name="ringingTimeoutMs">
        /// Ringing timeout in milliseconds applied to every call in the<br/>
        /// batch (how long each recipient rings before the dial gives<br/>
        /// up). Range 1000-80000 (1-80s). Omit to use the 30s default.<br/>
        /// The console collects this in seconds and converts to<br/>
        /// milliseconds.
        /// </param>
        /// <param name="recipients"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsCreateBatchCallResponse> CreateAsync(
            string name,
            string agentId,
            global::System.Collections.Generic.IList<global::Speechify.TtsBatchRecipientRequest> recipients,
            string? phoneNumberId = default,
            global::System.DateTime? scheduledAt = default,
            int? ringingTimeoutMs = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}