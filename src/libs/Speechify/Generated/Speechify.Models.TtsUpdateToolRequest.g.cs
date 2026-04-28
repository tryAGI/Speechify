
#nullable enable

namespace Speechify
{
    /// <summary>
    /// All fields optional. `kind` is immutable — create a new tool to change it.
    /// </summary>
    public sealed partial class TtsUpdateToolRequest
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsUpdateToolRequestConfigJsonConverter))]
        public global::Speechify.TtsUpdateToolRequestConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateToolRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateToolRequest(
            string? name,
            string? description,
            global::Speechify.TtsUpdateToolRequestConfig? config)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateToolRequest" /> class.
        /// </summary>
        public TtsUpdateToolRequest()
        {
        }
    }
}