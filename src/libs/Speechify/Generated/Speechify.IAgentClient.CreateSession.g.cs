#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Create Session<br/>
        /// Mint a realtime voice session for the given agent. Widget-friendly<br/>
        /// counterpart to `createConversation` — same response shape, dual<br/>
        /// authentication:<br/>
        /// * **Authenticated (Bearer)**: works for any agent the caller<br/>
        ///   owns. Typical server-to-server flow where the embedding<br/>
        ///   site's backend mints a token and hands it to the browser so<br/>
        ///   the API key never reaches the client.<br/>
        /// * **Unauthenticated**: works only when `agent.is_public = true`<br/>
        ///   AND the request's `Origin` header matches `agent.allowed_origins`<br/>
        ///   (or that list is empty). When `agent.hostname_allowlist` is<br/>
        ///   non-empty, the `Origin` hostname must additionally be a<br/>
        ///   member of that list. Used directly by the<br/>
        ///   `&lt;speechify-agent&gt;` web component.<br/>
        /// Responds with the same `CreateConversationResponse` as<br/>
        /// `createConversation`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.CreateConversationResponse> CreateSessionAsync(
            string agentId,

            global::Speechify.CreateSessionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Session<br/>
        /// Mint a realtime voice session for the given agent. Widget-friendly<br/>
        /// counterpart to `createConversation` — same response shape, dual<br/>
        /// authentication:<br/>
        /// * **Authenticated (Bearer)**: works for any agent the caller<br/>
        ///   owns. Typical server-to-server flow where the embedding<br/>
        ///   site's backend mints a token and hands it to the browser so<br/>
        ///   the API key never reaches the client.<br/>
        /// * **Unauthenticated**: works only when `agent.is_public = true`<br/>
        ///   AND the request's `Origin` header matches `agent.allowed_origins`<br/>
        ///   (or that list is empty). When `agent.hostname_allowlist` is<br/>
        ///   non-empty, the `Origin` hostname must additionally be a<br/>
        ///   member of that list. Used directly by the<br/>
        ///   `&lt;speechify-agent&gt;` web component.<br/>
        /// Responds with the same `CreateConversationResponse` as<br/>
        /// `createConversation`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.CreateConversationResponse>> CreateSessionAsResponseAsync(
            string agentId,

            global::Speechify.CreateSessionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Session<br/>
        /// Mint a realtime voice session for the given agent. Widget-friendly<br/>
        /// counterpart to `createConversation` — same response shape, dual<br/>
        /// authentication:<br/>
        /// * **Authenticated (Bearer)**: works for any agent the caller<br/>
        ///   owns. Typical server-to-server flow where the embedding<br/>
        ///   site's backend mints a token and hands it to the browser so<br/>
        ///   the API key never reaches the client.<br/>
        /// * **Unauthenticated**: works only when `agent.is_public = true`<br/>
        ///   AND the request's `Origin` header matches `agent.allowed_origins`<br/>
        ///   (or that list is empty). When `agent.hostname_allowlist` is<br/>
        ///   non-empty, the `Origin` hostname must additionally be a<br/>
        ///   member of that list. Used directly by the<br/>
        ///   `&lt;speechify-agent&gt;` web component.<br/>
        /// Responds with the same `CreateConversationResponse` as<br/>
        /// `createConversation`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="userIdentity">
        /// Opaque identifier for the end-user (e.g. your app's user ID),<br/>
        /// persisted as the conversation's `caller_identity` and used as the<br/>
        /// memory key. Optional - an omitted identity means an anonymous<br/>
        /// session, which is excluded from per-caller memory.<br/>
        /// How it is stored depends on whether the request was<br/>
        /// authenticated, because only then has anyone verified the claim:<br/>
        /// - **With an API key**: stored verbatim, and the same value on<br/>
        ///   `POST /v1/agents/{agent_id}/conversations` is the same caller.<br/>
        /// - **Without credentials** (a public agent embedded in a page):<br/>
        ///   stored in a separate `embed_`-prefixed namespace, so a<br/>
        ///   self-asserted identity can never resolve to a caller record<br/>
        ///   written by a verified surface such as a phone call. Mint<br/>
        ///   sessions from your backend if you need one caller record<br/>
        ///   across surfaces.
        /// </param>
        /// <param name="language">
        /// Starts the session in one of the agent's configured languages<br/>
        /// (the default `language` or an `additional_languages` entry,<br/>
        /// matched by primary subtag). The greeting and any per-language<br/>
        /// voice follow. Omit for the agent's default language; an<br/>
        /// unconfigured language is rejected with 400.
        /// </param>
        /// <param name="dynamicVariables">
        /// Per-session variable overrides that merge on top of the agent's<br/>
        /// stored variable defaults for this one session. Keys in the<br/>
        /// reserved `system__` namespace are rejected at this boundary.<br/>
        /// Values must match the declared type of the corresponding variable<br/>
        /// definition on the agent (a `string` type expects a JSON string,<br/>
        /// `number` expects a JSON number, etc.).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.CreateConversationResponse> CreateSessionAsync(
            string agentId,
            string? speechifyVersion = default,
            string? userIdentity = default,
            string? language = default,
            object? dynamicVariables = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}