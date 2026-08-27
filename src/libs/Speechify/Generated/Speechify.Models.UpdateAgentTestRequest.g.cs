
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `PATCH /v1/agents/tests/{test_id}` (JSON merge-patch).<br/>
    /// All fields are optional; omitting a field leaves it unchanged. Set<br/>
    /// `folder_id` to a target folder id to move the test into that<br/>
    /// folder, or send `folder_id: null` to move the test back to root.
    /// </summary>
    public sealed partial class UpdateAgentTestRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.UpdateAgentTestRequestConfigJsonConverter))]
        public global::Speechify.UpdateAgentTestRequestConfig? Config { get; set; }

        /// <summary>
        /// Replaces the tool-mock config when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mock_config")]
        public global::Speechify.ToolMockConfig? ToolMockConfig { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to move the test into, or `null` to move the<br/>
        /// test back to root. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentTestRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Replaces the test config when present.
        /// </param>
        /// <param name="toolMockConfig">
        /// Replaces the tool-mock config when present.
        /// </param>
        /// <param name="folderId">
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to move the test into, or `null` to move the<br/>
        /// test back to root. Omit to leave unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentTestRequest(
            string? name,
            string? description,
            global::Speechify.UpdateAgentTestRequestConfig? config,
            global::Speechify.ToolMockConfig? toolMockConfig,
            string? folderId)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
            this.ToolMockConfig = toolMockConfig;
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentTestRequest" /> class.
        /// </summary>
        public UpdateAgentTestRequest()
        {
        }

    }
}