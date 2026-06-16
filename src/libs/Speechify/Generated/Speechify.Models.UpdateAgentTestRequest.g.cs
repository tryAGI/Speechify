
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `PATCH /v1/agents/tests/{id}`. All fields are optional;<br/>
    /// omitting a field leaves it unchanged. Set `folder_id` to a target<br/>
    /// folder id to move the test into that folder; send<br/>
    /// `clear_folder_id: true` (folder_id omitted or ignored) to move<br/>
    /// the test back to root. The clear flag is the explicit signal<br/>
    /// because JSON `null` is indistinguishable from absent for<br/>
    /// pointer fields in Go's encoding/json.
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
        /// of the folder to move the test into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// When `true`, moves the test back to root (clears<br/>
        /// `folder_id`). Wins over `folder_id` when both are sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_folder_id")]
        public bool? ClearFolderId { get; set; }

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
        /// of the folder to move the test into.
        /// </param>
        /// <param name="clearFolderId">
        /// When `true`, moves the test back to root (clears<br/>
        /// `folder_id`). Wins over `folder_id` when both are sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentTestRequest(
            string? name,
            string? description,
            global::Speechify.UpdateAgentTestRequestConfig? config,
            global::Speechify.ToolMockConfig? toolMockConfig,
            string? folderId,
            bool? clearFolderId)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
            this.ToolMockConfig = toolMockConfig;
            this.FolderId = folderId;
            this.ClearFolderId = clearFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentTestRequest" /> class.
        /// </summary>
        public UpdateAgentTestRequest()
        {
        }

    }
}