#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// Get Conversation LiveKit Room<br/>
        /// Operator-only: return a conversation's internal LiveKit runtime<br/>
        /// handles (the room name and `RM_` room SID). These are deliberately<br/>
        /// absent from the conversation read responses so they never freeze<br/>
        /// into the public contract; only Speechify staff can act on them (they<br/>
        /// index a session in Speechify's own LiveKit Cloud project). The<br/>
        /// console renders them, and builds its Speechify-staff LiveKit-Cloud<br/>
        /// deep-link, for staff sessions only.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ConversationLiveKitRoom> GetLivekitRoomAsync(
            string conversationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Conversation LiveKit Room<br/>
        /// Operator-only: return a conversation's internal LiveKit runtime<br/>
        /// handles (the room name and `RM_` room SID). These are deliberately<br/>
        /// absent from the conversation read responses so they never freeze<br/>
        /// into the public contract; only Speechify staff can act on them (they<br/>
        /// index a session in Speechify's own LiveKit Cloud project). The<br/>
        /// console renders them, and builds its Speechify-staff LiveKit-Cloud<br/>
        /// deep-link, for staff sessions only.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ConversationLiveKitRoom>> GetLivekitRoomAsResponseAsync(
            string conversationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}