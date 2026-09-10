#nullable enable

namespace Speechify
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Conversation stats<br/>
        /// Aggregated counts and averages over the caller's conversations, scoped<br/>
        /// by the same filters as the list endpoint, `project_id` included.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="status"></param>
        /// <param name="transport">
        /// Which runtime carried the conversation. `web` is the browser /<br/>
        /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
        /// from the telephony stack; `text` is the turn-based, roomless<br/>
        /// runtime (no call duration) that the message API and every<br/>
        /// messaging channel share.<br/>
        /// A conversation reports the transport it actually ran on:<br/>
        /// `web`, `sip_inbound`, `sip_outbound` or `text`. `phone` is<br/>
        /// selectable when filtering a list and matches calls in either<br/>
        /// direction; `whatsapp` is reserved and matches nothing today.<br/>
        /// To tell two conversations on the same transport apart, filter<br/>
        /// or read `channel` instead.
        /// </param>
        /// <param name="channel">
        /// Which front door the conversation arrived through, one level<br/>
        /// coarser than `transport`, and the value to display or group a<br/>
        /// conversation's channel by. Both telephony directions are<br/>
        /// `voice`; the browser / SDK realtime path is `web`; the message<br/>
        /// API is `text`; a conversation reached over a provider front<br/>
        /// door names that provider (`slack`) rather than the transport it<br/>
        /// shares with the message API.
        /// </param>
        /// <param name="live"></param>
        /// <param name="callerIdentity"></param>
        /// <param name="contactId"></param>
        /// <param name="q"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="durationMinMs"></param>
        /// <param name="durationMaxMs"></param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ConversationStats> StatsAsync(
            string? agentId = default,
            global::Speechify.ConversationStatus? status = default,
            global::Speechify.ConversationTransport? transport = default,
            global::Speechify.ConversationChannel? channel = default,
            bool? live = default,
            string? callerIdentity = default,
            string? contactId = default,
            string? q = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            int? durationMinMs = default,
            int? durationMaxMs = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Conversation stats<br/>
        /// Aggregated counts and averages over the caller's conversations, scoped<br/>
        /// by the same filters as the list endpoint, `project_id` included.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="status"></param>
        /// <param name="transport">
        /// Which runtime carried the conversation. `web` is the browser /<br/>
        /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
        /// from the telephony stack; `text` is the turn-based, roomless<br/>
        /// runtime (no call duration) that the message API and every<br/>
        /// messaging channel share.<br/>
        /// A conversation reports the transport it actually ran on:<br/>
        /// `web`, `sip_inbound`, `sip_outbound` or `text`. `phone` is<br/>
        /// selectable when filtering a list and matches calls in either<br/>
        /// direction; `whatsapp` is reserved and matches nothing today.<br/>
        /// To tell two conversations on the same transport apart, filter<br/>
        /// or read `channel` instead.
        /// </param>
        /// <param name="channel">
        /// Which front door the conversation arrived through, one level<br/>
        /// coarser than `transport`, and the value to display or group a<br/>
        /// conversation's channel by. Both telephony directions are<br/>
        /// `voice`; the browser / SDK realtime path is `web`; the message<br/>
        /// API is `text`; a conversation reached over a provider front<br/>
        /// door names that provider (`slack`) rather than the transport it<br/>
        /// shares with the message API.
        /// </param>
        /// <param name="live"></param>
        /// <param name="callerIdentity"></param>
        /// <param name="contactId"></param>
        /// <param name="q"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="durationMinMs"></param>
        /// <param name="durationMaxMs"></param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ConversationStats>> StatsAsResponseAsync(
            string? agentId = default,
            global::Speechify.ConversationStatus? status = default,
            global::Speechify.ConversationTransport? transport = default,
            global::Speechify.ConversationChannel? channel = default,
            bool? live = default,
            string? callerIdentity = default,
            string? contactId = default,
            string? q = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            int? durationMinMs = default,
            int? durationMaxMs = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}