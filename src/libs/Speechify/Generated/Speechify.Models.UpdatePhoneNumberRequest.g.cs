
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body for `PATCH /v1/agents/phone-numbers/{phone_number_id}`. Edits the<br/>
    /// number's own attributes - `label` - and, where the Phone product is<br/>
    /// enabled, binds the number to your own webhook brain via `relay`. The<br/>
    /// number's provider and `e164` are immutable after import. The agent<br/>
    /// binding is managed separately as a relationship, via<br/>
    /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`;<br/>
    /// a number carries an agent binding or a relay binding, never both.
    /// </summary>
    public sealed partial class UpdatePhoneNumberRequest
    {
        /// <summary>
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// New label. Pass an empty string to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Binds a number's traffic to your own HTTPS endpoint. The endpoint<br/>
        /// must be `https://` and publicly resolvable - private-network and<br/>
        /// literal-IP targets in reserved ranges are rejected. Binding a relay<br/>
        /// atomically clears any agent binding on the number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relay")]
        public global::Speechify.RelayBinding? Relay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </param>
        /// <param name="label">
        /// New label. Pass an empty string to clear.
        /// </param>
        /// <param name="relay">
        /// Binds a number's traffic to your own HTTPS endpoint. The endpoint<br/>
        /// must be `https://` and publicly resolvable - private-network and<br/>
        /// literal-IP targets in reserved ranges are rejected. Binding a relay<br/>
        /// atomically clears any agent binding on the number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePhoneNumberRequest(
            string? projectId,
            string? label,
            global::Speechify.RelayBinding? relay)
        {
            this.ProjectId = projectId;
            this.Label = label;
            this.Relay = relay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        public UpdatePhoneNumberRequest()
        {
        }

    }
}