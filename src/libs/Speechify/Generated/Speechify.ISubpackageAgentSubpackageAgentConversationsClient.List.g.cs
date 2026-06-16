#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// List Conversations<br/>
        /// List conversations owned by the caller, ordered by most recent.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page; pass the<br/>
        /// previous response's `next_cursor` back to fetch the next page.<br/>
        /// Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
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
        global::System.Threading.Tasks.Task<global::Speechify.ListConversationsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? agentId = default,
            global::Speechify.ConversationStatus? status = default,
            global::Speechify.ConversationTransport? transport = default,
            string? callerIdentity = default,
            string? search = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            int? durationMinMs = default,
            int? durationMaxMs = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Conversations<br/>
        /// List conversations owned by the caller, ordered by most recent.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page; pass the<br/>
        /// previous response's `next_cursor` back to fetch the next page.<br/>
        /// Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListConversationsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? agentId = default,
            global::Speechify.ConversationStatus? status = default,
            global::Speechify.ConversationTransport? transport = default,
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