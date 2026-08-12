
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for `POST /v1/agents/{agent_id}/sessions`. Widget embeds usually pass nothing.
    /// </summary>
    public sealed partial class CreateSessionRequest
    {
        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity")]
        public string? UserIdentity { get; set; }

        /// <summary>
        /// Starts the session in one of the agent's configured languages<br/>
        /// (the default `language` or an `additional_languages` entry,<br/>
        /// matched by primary subtag). The greeting and any per-language<br/>
        /// voice follow. Omit for the agent's default language; an<br/>
        /// unconfigured language is rejected with 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Per-session variable overrides that merge on top of the agent's<br/>
        /// stored variable defaults for this one session. Keys in the<br/>
        /// reserved `system__` namespace are rejected at this boundary.<br/>
        /// Values must match the declared type of the corresponding variable<br/>
        /// definition on the agent (a `string` type expects a JSON string,<br/>
        /// `number` expects a JSON number, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionRequest(
            string? userIdentity,
            string? language,
            object? dynamicVariables)
        {
            this.UserIdentity = userIdentity;
            this.Language = language;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
        public CreateSessionRequest()
        {
        }

    }
}