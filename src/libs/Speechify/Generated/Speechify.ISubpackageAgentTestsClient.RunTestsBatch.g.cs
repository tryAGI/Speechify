#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentTestsClient
    {
        /// <summary>
        /// Run Tests (Batch)<br/>
        /// Queue runs for every (test, agent) pair in the body. Entries<br/>
        /// without an `agent_id` fan out to every agent the test is<br/>
        /// attached to. Total expanded runs are capped at 100 per call.<br/>
        /// Each entry in the response is a queued run; poll<br/>
        /// `GET /v1/agents/tests/runs/{test_run_id}` for each.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> RunTestsBatchAsync(

            global::Speechify.RunBatchRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tests (Batch)<br/>
        /// Queue runs for every (test, agent) pair in the body. Entries<br/>
        /// without an `agent_id` fan out to every agent the test is<br/>
        /// attached to. Total expanded runs are capped at 100 per call.<br/>
        /// Each entry in the response is a queued run; poll<br/>
        /// `GET /v1/agents/tests/runs/{test_run_id}` for each.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RunAgentTestsResponse>> RunTestsBatchAsResponseAsync(

            global::Speechify.RunBatchRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tests (Batch)<br/>
        /// Queue runs for every (test, agent) pair in the body. Entries<br/>
        /// without an `agent_id` fan out to every agent the test is<br/>
        /// attached to. Total expanded runs are capped at 100 per call.<br/>
        /// Each entry in the response is a queued run; poll<br/>
        /// `GET /v1/agents/tests/runs/{test_run_id}` for each.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="entries"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> RunTestsBatchAsync(
            global::System.Collections.Generic.IList<global::Speechify.BatchRunEntry> entries,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}