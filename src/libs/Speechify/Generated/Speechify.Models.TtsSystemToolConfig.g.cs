
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=system`.
    /// </summary>
    public sealed partial class TtsSystemToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsSystemToolConfigBuiltinJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsSystemToolConfigBuiltin Builtin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsToolParam>? Params { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsSystemToolConfig" /> class.
        /// </summary>
        /// <param name="builtin"></param>
        /// <param name="params"></param>
        /// <param name="builtinConfig">
        /// Per-builtin extras (e.g. allowed_numbers for transfer_to_number).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSystemToolConfig(
            global::Speechify.TtsSystemToolConfigBuiltin builtin,
            global::System.Collections.Generic.IList<global::Speechify.TtsToolParam>? @params,
            object? builtinConfig)
        {
            this.Builtin = builtin;
            this.Params = @params;
            this.BuiltinConfig = builtinConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSystemToolConfig" /> class.
        /// </summary>
        public TtsSystemToolConfig()
        {
        }
    }
}