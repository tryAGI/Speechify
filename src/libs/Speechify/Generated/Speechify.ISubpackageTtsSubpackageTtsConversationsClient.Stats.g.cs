#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsConversationsClient
    {
        /// <summary>
        /// Conversation stats<br/>
        /// Aggregated counts and averages over the caller's conversations, scoped by the same filters as the list endpoint.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="status"></param>
        /// <param name="transport">
        /// How the caller reached the agent. `web` is the browser /<br/>
        /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
        /// from the telephony stack.
        /// </param>
        /// <param name="callerIdentity"></param>
        /// <param name="search"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="durationMinMs"></param>
        /// <param name="durationMaxMs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsConversationStats> StatsAsync(
            string? agentId = default,
            global::Speechify.TtsConversationStatus? status = default,
            global::Speechify.TtsConversationTransport? transport = default,
            string? callerIdentity = default,
            string? search = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            int? durationMinMs = default,
            int? durationMaxMs = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Conversation stats<br/>
        /// Aggregated counts and averages over the caller's conversations, scoped by the same filters as the list endpoint.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="status"></param>
        /// <param name="transport">
        /// How the caller reached the agent. `web` is the browser /<br/>
        /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
        /// from the telephony stack.
        /// </param>
        /// <param name="callerIdentity"></param>
        /// <param name="search"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="durationMinMs"></param>
        /// <param name="durationMaxMs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsConversationStats>> StatsAsResponseAsync(
            string? agentId = default,
            global::Speechify.TtsConversationStatus? status = default,
            global::Speechify.TtsConversationTransport? transport = default,
            string? callerIdentity = default,
            string? search = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            int? durationMinMs = default,
            int? durationMaxMs = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}