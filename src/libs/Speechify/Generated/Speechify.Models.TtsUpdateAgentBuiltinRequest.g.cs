
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body. All fields optional; omitting a field leaves it<br/>
    /// unchanged. The underlying `builtin` is NOT patchable — delete<br/>
    /// and recreate to change which capability an instance maps to.
    /// </summary>
    public sealed partial class TtsUpdateAgentBuiltinRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Per-instance configuration matching the per-builtin schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Per-call parameter descriptors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<object>? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentBuiltinRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Per-instance configuration matching the per-builtin schema.
        /// </param>
        /// <param name="params">
        /// Per-call parameter descriptors.
        /// </param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateAgentBuiltinRequest(
            string? name,
            string? description,
            object? config,
            global::System.Collections.Generic.IList<object>? @params,
            bool? enabled)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
            this.Params = @params;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentBuiltinRequest" /> class.
        /// </summary>
        public TtsUpdateAgentBuiltinRequest()
        {
        }

    }
}