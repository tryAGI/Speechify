
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=client`. Execution happens in the caller's browser / SDK.
    /// </summary>
    public sealed partial class TtsClientToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsToolParam>? Params { get; set; }

        /// <summary>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsClientToolConfig" /> class.
        /// </summary>
        /// <param name="params"></param>
        /// <param name="timeoutMs">
        /// Default Value: 10000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsClientToolConfig(
            global::System.Collections.Generic.IList<global::Speechify.TtsToolParam>? @params,
            int? timeoutMs)
        {
            this.Params = @params;
            this.TimeoutMs = timeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsClientToolConfig" /> class.
        /// </summary>
        public TtsClientToolConfig()
        {
        }
    }
}