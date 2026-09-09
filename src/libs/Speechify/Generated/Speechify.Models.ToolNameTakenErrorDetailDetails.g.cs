
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Structured, endpoint-specific context beyond the flat<br/>
    /// `fields` map. Present only on the few errors that carry<br/>
    /// it (e.g. the `used_by` referrer list on a credential<br/>
    /// delete-conflict); its shape depends on the error `code`.<br/>
    /// Clients that don't recognise a `details` shape can ignore<br/>
    /// it - the `code` + `message` contract is unchanged.
    /// </summary>
    public sealed partial class ToolNameTakenErrorDetailDetails
    {
        /// <summary>
        /// The resource already answering to the contested tool name, named by the<br/>
        /// id you can address it with. A `builtin` holder is one of the agent's own<br/>
        /// built-in instances; every other kind is a workspace tool definition<br/>
        /// readable at `/v1/agents/tool-definitions/{tool_definition_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("held_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ToolNameHolder HeldBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNameTakenErrorDetailDetails" /> class.
        /// </summary>
        /// <param name="heldBy">
        /// The resource already answering to the contested tool name, named by the<br/>
        /// id you can address it with. A `builtin` holder is one of the agent's own<br/>
        /// built-in instances; every other kind is a workspace tool definition<br/>
        /// readable at `/v1/agents/tool-definitions/{tool_definition_id}`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolNameTakenErrorDetailDetails(
            global::Speechify.ToolNameHolder heldBy)
        {
            this.HeldBy = heldBy ?? throw new global::System.ArgumentNullException(nameof(heldBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNameTakenErrorDetailDetails" /> class.
        /// </summary>
        public ToolNameTakenErrorDetailDetails()
        {
        }

    }
}