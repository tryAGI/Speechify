#nullable enable

namespace Speechify
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Prompt Conversation<br/>
        /// Start an agent-initiated turn in an existing conversation. The agent<br/>
        /// runs the instruction with its normal tools on the conversation's own<br/>
        /// context - it can see what it said earlier in the thread - and whatever<br/>
        /// it writes in reply is delivered into that thread, unasked. The typical<br/>
        /// use is a follow-up on something the agent already said: a figure that<br/>
        /// was re-certified after the answer went out, a correction, a heads-up.<br/>
        /// The turn is queued, not run inline: it answers `202` with the prompt<br/>
        /// as a job (`pending`), lands in the thread within the turn's own<br/>
        /// budget, and survives a deploy and waits for the thread's in-flight<br/>
        /// turn the way a person's message does. Poll it with<br/>
        /// `GET /v1/agents/conversations/{conversation_id}/prompts/{prompt_id}`:<br/>
        /// `completed` means the reply was delivered (or the agent chose to say<br/>
        /// nothing), `failed` carries `error` saying why it never posted - the<br/>
        /// conversation ended before the turn ran, a grant withdrawn, the<br/>
        /// runtime giving up. A `pending` prompt can be cancelled. Its two<br/>
        /// transcript rows - the instruction as the `user` row and the reply as<br/>
        /// the `assistant` row - carry `initiated_by: api`, so<br/>
        /// `GET /v1/agents/conversations/{conversation_id}/messages` and any<br/>
        /// evaluation can tell it from an answer to a person.<br/>
        /// Only a conversation answered over a messaging channel (Slack) can take<br/>
        /// one, because an unasked reply needs somewhere to go: a conversation<br/>
        /// driven over the message API returns its replies in the response, so it<br/>
        /// answers `409 conversation_not_reachable`, as does a voice call or a<br/>
        /// thread whose channel has since been removed. A conversation that has<br/>
        /// ended answers `409 conversation_closed`: nothing reopens it, and the<br/>
        /// next message a person sends in that thread opens a fresh conversation<br/>
        /// to address instead.<br/>
        /// Bounded per workspace at 60 turns an hour (`429 rate_limited` with<br/>
        /// `Retry-After`) on top of the text channel's own gates: the same plan<br/>
        /// grants, monthly message cap, spend budget and in-flight cap a person's<br/>
        /// message takes, refused here with the same `402`s before anything is<br/>
        /// queued.<br/>
        /// Send an `Idempotency-Key` header to make a network retry safe: a repeat<br/>
        /// with the same key replays the first `202` instead of queueing a second<br/>
        /// turn.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ConversationPrompt> PromptAsync(
            string conversationId,

            global::Speechify.ConversationPromptRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prompt Conversation<br/>
        /// Start an agent-initiated turn in an existing conversation. The agent<br/>
        /// runs the instruction with its normal tools on the conversation's own<br/>
        /// context - it can see what it said earlier in the thread - and whatever<br/>
        /// it writes in reply is delivered into that thread, unasked. The typical<br/>
        /// use is a follow-up on something the agent already said: a figure that<br/>
        /// was re-certified after the answer went out, a correction, a heads-up.<br/>
        /// The turn is queued, not run inline: it answers `202` with the prompt<br/>
        /// as a job (`pending`), lands in the thread within the turn's own<br/>
        /// budget, and survives a deploy and waits for the thread's in-flight<br/>
        /// turn the way a person's message does. Poll it with<br/>
        /// `GET /v1/agents/conversations/{conversation_id}/prompts/{prompt_id}`:<br/>
        /// `completed` means the reply was delivered (or the agent chose to say<br/>
        /// nothing), `failed` carries `error` saying why it never posted - the<br/>
        /// conversation ended before the turn ran, a grant withdrawn, the<br/>
        /// runtime giving up. A `pending` prompt can be cancelled. Its two<br/>
        /// transcript rows - the instruction as the `user` row and the reply as<br/>
        /// the `assistant` row - carry `initiated_by: api`, so<br/>
        /// `GET /v1/agents/conversations/{conversation_id}/messages` and any<br/>
        /// evaluation can tell it from an answer to a person.<br/>
        /// Only a conversation answered over a messaging channel (Slack) can take<br/>
        /// one, because an unasked reply needs somewhere to go: a conversation<br/>
        /// driven over the message API returns its replies in the response, so it<br/>
        /// answers `409 conversation_not_reachable`, as does a voice call or a<br/>
        /// thread whose channel has since been removed. A conversation that has<br/>
        /// ended answers `409 conversation_closed`: nothing reopens it, and the<br/>
        /// next message a person sends in that thread opens a fresh conversation<br/>
        /// to address instead.<br/>
        /// Bounded per workspace at 60 turns an hour (`429 rate_limited` with<br/>
        /// `Retry-After`) on top of the text channel's own gates: the same plan<br/>
        /// grants, monthly message cap, spend budget and in-flight cap a person's<br/>
        /// message takes, refused here with the same `402`s before anything is<br/>
        /// queued.<br/>
        /// Send an `Idempotency-Key` header to make a network retry safe: a repeat<br/>
        /// with the same key replays the first `202` instead of queueing a second<br/>
        /// turn.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ConversationPrompt>> PromptAsResponseAsync(
            string conversationId,

            global::Speechify.ConversationPromptRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prompt Conversation<br/>
        /// Start an agent-initiated turn in an existing conversation. The agent<br/>
        /// runs the instruction with its normal tools on the conversation's own<br/>
        /// context - it can see what it said earlier in the thread - and whatever<br/>
        /// it writes in reply is delivered into that thread, unasked. The typical<br/>
        /// use is a follow-up on something the agent already said: a figure that<br/>
        /// was re-certified after the answer went out, a correction, a heads-up.<br/>
        /// The turn is queued, not run inline: it answers `202` with the prompt<br/>
        /// as a job (`pending`), lands in the thread within the turn's own<br/>
        /// budget, and survives a deploy and waits for the thread's in-flight<br/>
        /// turn the way a person's message does. Poll it with<br/>
        /// `GET /v1/agents/conversations/{conversation_id}/prompts/{prompt_id}`:<br/>
        /// `completed` means the reply was delivered (or the agent chose to say<br/>
        /// nothing), `failed` carries `error` saying why it never posted - the<br/>
        /// conversation ended before the turn ran, a grant withdrawn, the<br/>
        /// runtime giving up. A `pending` prompt can be cancelled. Its two<br/>
        /// transcript rows - the instruction as the `user` row and the reply as<br/>
        /// the `assistant` row - carry `initiated_by: api`, so<br/>
        /// `GET /v1/agents/conversations/{conversation_id}/messages` and any<br/>
        /// evaluation can tell it from an answer to a person.<br/>
        /// Only a conversation answered over a messaging channel (Slack) can take<br/>
        /// one, because an unasked reply needs somewhere to go: a conversation<br/>
        /// driven over the message API returns its replies in the response, so it<br/>
        /// answers `409 conversation_not_reachable`, as does a voice call or a<br/>
        /// thread whose channel has since been removed. A conversation that has<br/>
        /// ended answers `409 conversation_closed`: nothing reopens it, and the<br/>
        /// next message a person sends in that thread opens a fresh conversation<br/>
        /// to address instead.<br/>
        /// Bounded per workspace at 60 turns an hour (`429 rate_limited` with<br/>
        /// `Retry-After`) on top of the text channel's own gates: the same plan<br/>
        /// grants, monthly message cap, spend budget and in-flight cap a person's<br/>
        /// message takes, refused here with the same `402`s before anything is<br/>
        /// queued.<br/>
        /// Send an `Idempotency-Key` header to make a network retry safe: a repeat<br/>
        /// with the same key replays the first `202` instead of queueing a second<br/>
        /// turn.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="instruction">
        /// What the agent is asked to do in the conversation. It is the turn's input, run with the agent's normal tools on the thread's own context; what the agent writes in reply is what the thread sees.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ConversationPrompt> PromptAsync(
            string conversationId,
            string instruction,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}