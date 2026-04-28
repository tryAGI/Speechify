
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for `POST /v1/agents/{id}/sessions`. Widget embeds usually pass nothing.
    /// </summary>
    public sealed partial class TtsCreateSessionRequest
    {
        /// <summary>
        /// Opaque identifier for the end-user (e.g. your app's user ID). Stamped onto the conversation. Optional - defaults to an anonymous per-session ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity")]
        public string? UserIdentity { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsCreateSessionRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateSessionRequest(
            string? userIdentity,
            object? dynamicVariables)
        {
            this.UserIdentity = userIdentity;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateSessionRequest" /> class.
        /// </summary>
        public TtsCreateSessionRequest()
        {
        }
    }
}