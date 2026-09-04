
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemBuiltinInfo(
            string name,
            string label,
            string description,
            global::Speechify.ToolActionClass actionClass)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ActionClass = actionClass;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemBuiltinInfo" /> class.
        /// </summary>
        public SystemBuiltinInfo()
        {
        }

    }
}