
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=builtin`. The `builtin` value names the<br/>
    /// worker-resident capability; the catalogue served by<br/>
    /// `GET /v1/agents/tool-capabilities` is the runtime source of truth<br/>
    /// for valid names plus their human-readable labels. `builtin_config`<br/>
    /// carries per-instance extras (e.g. allowed_numbers for<br/>
    /// transfer_to_number, audio_asset_id for play_audio).
    /// </summary>
    public sealed partial class BuiltinToolConfig
    {
        /// <summary>
        /// Identifier of a built-in system tool. New builtins are added by<br/>
        /// Speechify across releases. Read the catalogue from<br/>
        /// `GET /v1/agents/tool-capabilities` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Builtin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.ToolParam>? Params { get; set; }

        /// <summary>
        /// Per-builtin extras (e.g. allowed_numbers for transfer_to_number).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin_config")]
        public object? BuiltinConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltinToolConfig" /> class.
        /// </summary>
        /// <param name="builtin">
        /// Identifier of a built-in system tool. New builtins are added by<br/>
        /// Speechify across releases. Read the catalogue from<br/>
        /// `GET /v1/agents/tool-capabilities` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </param>
        /// <param name="params"></param>
        /// <param name="builtinConfig">
        /// Per-builtin extras (e.g. allowed_numbers for transfer_to_number).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltinToolConfig(
            string builtin,
            global::System.Collections.Generic.IList<global::Speechify.ToolParam>? @params,
            object? builtinConfig)
        {
            this.Builtin = builtin ?? throw new global::System.ArgumentNullException(nameof(builtin));
            this.Params = @params;
            this.BuiltinConfig = builtinConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltinToolConfig" /> class.
        /// </summary>
        public BuiltinToolConfig()
        {
        }

    }
}