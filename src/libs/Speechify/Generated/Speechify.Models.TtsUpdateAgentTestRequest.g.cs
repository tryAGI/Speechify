
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `PATCH /v1/tests/{id}`. All fields are optional;<br/>
    /// omitting a field leaves it unchanged.
    /// </summary>
    public sealed partial class TtsUpdateAgentTestRequest
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
        /// Replaces the test config when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsUpdateAgentTestRequestConfigJsonConverter))]
        public global::Speechify.TtsUpdateAgentTestRequestConfig? Config { get; set; }

        /// <summary>
        /// Replaces the tool-mock config when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mock_config")]
        public global::Speechify.TtsToolMockConfig? ToolMockConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentTestRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Replaces the test config when present.
        /// </param>
        /// <param name="toolMockConfig">
        /// Replaces the tool-mock config when present.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateAgentTestRequest(
            string? name,
            string? description,
            global::Speechify.TtsUpdateAgentTestRequestConfig? config,
            global::Speechify.TtsToolMockConfig? toolMockConfig)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
            this.ToolMockConfig = toolMockConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentTestRequest" /> class.
        /// </summary>
        public TtsUpdateAgentTestRequest()
        {
        }
    }
}