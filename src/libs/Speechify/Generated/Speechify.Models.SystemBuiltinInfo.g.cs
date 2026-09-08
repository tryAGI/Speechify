
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One entry in the system-builtin catalogue.
    /// </summary>
    public sealed partial class SystemBuiltinInfo
    {
        /// <summary>
        /// Identifier of a built-in system tool. New builtins are added by<br/>
        /// Speechify across releases. Read the catalogue from<br/>
        /// `GET /v1/agents/tool-capabilities` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable display label for the builtin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// One-line summary of what the builtin does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The impact class the platform fixes for this builtin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ToolActionClassJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ToolActionClass ActionClass { get; set; }

        /// <summary>
        /// Who runs a call to this built-in. `worker` runs it inside the live<br/>
        /// session, so it is only meaningful on a call. `control_plane` runs it<br/>
        /// in the platform itself, against a vendor whose key you never hold,<br/>
        /// and is what an autonomous run or a text turn can use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SystemBuiltinInfoExecutionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.SystemBuiltinInfoExecution Execution { get; set; }

        /// <summary>
        /// Whether an autonomous run already has this built-in without attaching<br/>
        /// it. A `control_plane` built-in that spends at a vendor on every call<br/>
        /// is never on by default: attach it to the agent to turn it on.<br/>
        /// Attaching one that is already on changes nothing but lets you switch<br/>
        /// it off with `enabled: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DefaultOn { get; set; }

        /// <summary>
        /// Whether this built-in is meaningful only on a voice call. Attaching a<br/>
        /// voice-only built-in to an agent that does not serve the voice channel<br/>
        /// is refused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VoiceOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemBuiltinInfo" /> class.
        /// </summary>
        /// <param name="name">
        /// Identifier of a built-in system tool. New builtins are added by<br/>
        /// Speechify across releases. Read the catalogue from<br/>
        /// `GET /v1/agents/tool-capabilities` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </param>
        /// <param name="label">
        /// Human-readable display label for the builtin.
        /// </param>
        /// <param name="description">
        /// One-line summary of what the builtin does.
        /// </param>
        /// <param name="actionClass">
        /// The impact class the platform fixes for this builtin.
        /// </param>
        /// <param name="execution">
        /// Who runs a call to this built-in. `worker` runs it inside the live<br/>
        /// session, so it is only meaningful on a call. `control_plane` runs it<br/>
        /// in the platform itself, against a vendor whose key you never hold,<br/>
        /// and is what an autonomous run or a text turn can use.
        /// </param>
        /// <param name="defaultOn">
        /// Whether an autonomous run already has this built-in without attaching<br/>
        /// it. A `control_plane` built-in that spends at a vendor on every call<br/>
        /// is never on by default: attach it to the agent to turn it on.<br/>
        /// Attaching one that is already on changes nothing but lets you switch<br/>
        /// it off with `enabled: false`.
        /// </param>
        /// <param name="voiceOnly">
        /// Whether this built-in is meaningful only on a voice call. Attaching a<br/>
        /// voice-only built-in to an agent that does not serve the voice channel<br/>
        /// is refused.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemBuiltinInfo(
            string name,
            string label,
            string description,
            global::Speechify.ToolActionClass actionClass,
            global::Speechify.SystemBuiltinInfoExecution execution,
            bool defaultOn,
            bool voiceOnly)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ActionClass = actionClass;
            this.Execution = execution;
            this.DefaultOn = defaultOn;
            this.VoiceOnly = voiceOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemBuiltinInfo" /> class.
        /// </summary>
        public SystemBuiltinInfo()
        {
        }

    }
}