#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Agent Voices<br/>
        /// List the curated voice catalogue available for voice agents.<br/>
        /// Matches the `ai-api-agents` VMS scope one-for-one, so the same<br/>
        /// slug set is accepted by POST/PATCH /v1/agents. Personal<br/>
        /// (cloned) voices are NOT included — they stay on<br/>
        /// `GET /v1/voices`. The JSON layout intentionally mirrors the<br/>
        /// TTS `/v1/voices` shape so the console feeds both endpoints<br/>
        /// into the same voice-picker component. Returns the full set in a<br/>
        /// single response: bounded by the curated agent voice catalogue, so<br/>
        /// this list is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentVoicesResponse> ListAgentVoicesAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Voices<br/>
        /// List the curated voice catalogue available for voice agents.<br/>
        /// Matches the `ai-api-agents` VMS scope one-for-one, so the same<br/>
        /// slug set is accepted by POST/PATCH /v1/agents. Personal<br/>
        /// (cloned) voices are NOT included — they stay on<br/>
        /// `GET /v1/voices`. The JSON layout intentionally mirrors the<br/>
        /// TTS `/v1/voices` shape so the console feeds both endpoints<br/>
        /// into the same voice-picker component. Returns the full set in a<br/>
        /// single response: bounded by the curated agent voice catalogue, so<br/>
        /// this list is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentVoicesResponse>> ListAgentVoicesAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}