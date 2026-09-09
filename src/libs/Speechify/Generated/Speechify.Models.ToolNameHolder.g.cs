
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The resource already answering to the contested tool name, named by the<br/>
    /// id you can address it with. A `builtin` holder is one of the agent's own<br/>
    /// built-in instances; every other kind is a workspace tool definition<br/>
    /// readable at `/v1/agents/tool-definitions/{tool_definition_id}`.
    /// </summary>
    public sealed partial class ToolNameHolder
    {
        /// <summary>
        /// The holder's prefixed external id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name as the holder spells it (the match is case-insensitive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// What the holder is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ToolNameHolderKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ToolNameHolderKind Kind { get; set; }

        /// <summary>
        /// Present only when the refused create was agent-scoped. `false` is<br/>
        /// the state the agent's own tool list cannot explain: the definition<br/>
        /// holding the name lives in the agent's project but is not attached to<br/>
        /// it, so `GET /v1/agents/{agent_id}/tools` does not show it. Attach it<br/>
        /// with `PUT /v1/agents/{agent_id}/tools/{tool_id}`, delete it with<br/>
        /// `DELETE /v1/agents/tool-definitions/{tool_definition_id}` to free the<br/>
        /// name, or pick another name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_to_agent")]
        public bool? AttachedToAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNameHolder" /> class.
        /// </summary>
        /// <param name="id">
        /// The holder's prefixed external id.
        /// </param>
        /// <param name="name">
        /// The name as the holder spells it (the match is case-insensitive).
        /// </param>
        /// <param name="kind">
        /// What the holder is.
        /// </param>
        /// <param name="attachedToAgent">
        /// Present only when the refused create was agent-scoped. `false` is<br/>
        /// the state the agent's own tool list cannot explain: the definition<br/>
        /// holding the name lives in the agent's project but is not attached to<br/>
        /// it, so `GET /v1/agents/{agent_id}/tools` does not show it. Attach it<br/>
        /// with `PUT /v1/agents/{agent_id}/tools/{tool_id}`, delete it with<br/>
        /// `DELETE /v1/agents/tool-definitions/{tool_definition_id}` to free the<br/>
        /// name, or pick another name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolNameHolder(
            string id,
            string name,
            global::Speechify.ToolNameHolderKind kind,
            bool? attachedToAgent)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.AttachedToAgent = attachedToAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNameHolder" /> class.
        /// </summary>
        public ToolNameHolder()
        {
        }

    }
}