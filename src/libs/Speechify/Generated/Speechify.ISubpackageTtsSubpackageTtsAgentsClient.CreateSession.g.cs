#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
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
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsCreateConversationResponse> CreateSessionAsync(
            string id,

            global::Speechify.TtsCreateSessionRequest request,
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
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsCreateConversationResponse>> CreateSessionAsResponseAsync(
            string id,

            global::Speechify.TtsCreateSessionRequest request,
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
        /// <param name="id"></param>
        /// <param name="userIdentity">
        /// Opaque identifier for the end-user (e.g. your app's user ID). Stamped onto the conversation. Optional - defaults to an anonymous per-session ID.
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
        global::System.Threading.Tasks.Task<global::Speechify.TtsCreateConversationResponse> CreateSessionAsync(
            string id,
            string? userIdentity = default,
            object? dynamicVariables = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}