#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Create Conversation<br/>
        /// Start a new voice conversation with the agent. Returns a realtime<br/>
        /// voice session + short-lived client token so the caller can<br/>
        /// connect the audio pipeline directly. The agent is dispatched<br/>
        /// server-side; no additional client action required.<br/>
        /// Pass `dynamic_variables` to supply per-session values that override<br/>
        /// the agent's stored variable defaults for this one conversation.<br/>
        /// Keys in the `system__` namespace are rejected at this boundary.<br/>
        /// Pass `user_identity` as the stable caller key your application uses<br/>
        /// for memory and caller correlation. It is kept separate from the<br/>
        /// opaque, per-session realtime participant identity.<br/>
        /// `overrides.voice_id` replaces the configured voice for the entire<br/>
        /// conversation, including every configured language the voice can<br/>
        /// serve. The request is rejected when the voice is unavailable or<br/>
        /// cannot cover the agent's configured language set; the rejection<br/>
        /// names `overrides.voice_id` in the error envelope's `fields` map.<br/>
        /// The override belongs to this conversation only: if the call is<br/>
        /// transferred to another agent mid-conversation, that agent speaks<br/>
        /// with its own configured voice.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.CreateConversationResponse> CreateConversationAsync(
            string agentId,

            global::Speechify.CreateConversationRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Conversation<br/>
        /// Start a new voice conversation with the agent. Returns a realtime<br/>
        /// voice session + short-lived client token so the caller can<br/>
        /// connect the audio pipeline directly. The agent is dispatched<br/>
        /// server-side; no additional client action required.<br/>
        /// Pass `dynamic_variables` to supply per-session values that override<br/>
        /// the agent's stored variable defaults for this one conversation.<br/>
        /// Keys in the `system__` namespace are rejected at this boundary.<br/>
        /// Pass `user_identity` as the stable caller key your application uses<br/>
        /// for memory and caller correlation. It is kept separate from the<br/>
        /// opaque, per-session realtime participant identity.<br/>
        /// `overrides.voice_id` replaces the configured voice for the entire<br/>
        /// conversation, including every configured language the voice can<br/>
        /// serve. The request is rejected when the voice is unavailable or<br/>
        /// cannot cover the agent's configured language set; the rejection<br/>
        /// names `overrides.voice_id` in the error envelope's `fields` map.<br/>
        /// The override belongs to this conversation only: if the call is<br/>
        /// transferred to another agent mid-conversation, that agent speaks<br/>
        /// with its own configured voice.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.CreateConversationResponse>> CreateConversationAsResponseAsync(
            string agentId,

            global::Speechify.CreateConversationRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Conversation<br/>
        /// Start a new voice conversation with the agent. Returns a realtime<br/>
        /// voice session + short-lived client token so the caller can<br/>
        /// connect the audio pipeline directly. The agent is dispatched<br/>
        /// server-side; no additional client action required.<br/>
        /// Pass `dynamic_variables` to supply per-session values that override<br/>
        /// the agent's stored variable defaults for this one conversation.<br/>
        /// Keys in the `system__` namespace are rejected at this boundary.<br/>
        /// Pass `user_identity` as the stable caller key your application uses<br/>
        /// for memory and caller correlation. It is kept separate from the<br/>
        /// opaque, per-session realtime participant identity.<br/>
        /// `overrides.voice_id` replaces the configured voice for the entire<br/>
        /// conversation, including every configured language the voice can<br/>
        /// serve. The request is rejected when the voice is unavailable or<br/>
        /// cannot cover the agent's configured language set; the rejection<br/>
        /// names `overrides.voice_id` in the error envelope's `fields` map.<br/>
        /// The override belongs to this conversation only: if the call is<br/>
        /// transferred to another agent mid-conversation, that agent speaks<br/>
        /// with its own configured voice.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="transport">
        /// Voice transport for the session: one of `web`, `sip_inbound`, or `sip_outbound`. Omit (or null) to use the default, `web`. This endpoint dispatches a LiveKit voice session, so any other value is rejected with a 400.
        /// </param>
        /// <param name="userIdentity">
        /// Stable opaque identifier for the end-user in your application.<br/>
        /// Persisted verbatim as `caller_identity` for caller correlation<br/>
        /// and memory, but never exposed as the realtime participant<br/>
        /// identity. The same value sent to an authenticated<br/>
        /// `POST /v1/agents/{agent_id}/sessions` is the same caller record.<br/>
        /// Omit to preserve `user_&lt;authenticated principal&gt;` as the caller<br/>
        /// key.<br/>
        /// May not begin with `embed_`, `anon_` or `user_`: those namespaces<br/>
        /// are reserved for identities the platform derives rather than<br/>
        /// takes on trust, and claiming one is rejected with a 400 naming<br/>
        /// `user_identity`.
        /// </param>
        /// <param name="language">
        /// Starts the conversation in one of the agent's configured<br/>
        /// languages (the default `language` or an `additional_languages`<br/>
        /// entry, matched by primary subtag). Omit for the agent's default<br/>
        /// language; an unconfigured language is rejected with 400.
        /// </param>
        /// <param name="dynamicVariables">
        /// Per-session variable overrides that merge on top of the agent's<br/>
        /// stored variable defaults for this one conversation. Keys in the<br/>
        /// reserved `system__` namespace are rejected. Values must match the<br/>
        /// declared type of the corresponding variable definition on the agent.
        /// </param>
        /// <param name="overrides">
        /// Authenticated, per-conversation configuration overrides. Overrides are<br/>
        /// validated and applied before the agent is dispatched; the effective<br/>
        /// configuration is captured in the conversation's `agent_snapshot`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.CreateConversationResponse> CreateConversationAsync(
            string agentId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? transport = default,
            string? userIdentity = default,
            string? language = default,
            object? dynamicVariables = default,
            global::Speechify.CreateConversationOverrides? overrides = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}