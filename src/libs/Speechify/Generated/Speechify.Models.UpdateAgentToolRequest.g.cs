
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body. For a built-in, all fields apply. For an attached<br/>
    /// external tool only `enabled` is honoured - editing the shared<br/>
    /// config/name from here returns `tool_config_shared`.
    /// </summary>
    public sealed partial class UpdateAgentToolRequest
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
        /// For a built-in, the full `BuiltinToolConfig`. Rejected for shared kinds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Speechify.BuiltinToolConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.ToolParam>? Params { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateAgentToolRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// For a built-in, the full `BuiltinToolConfig`. Rejected for shared kinds.
        /// </param>
        /// <param name="params"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentToolRequest(
            string? name,
            string? description,
            global::Speechify.BuiltinToolConfig? config,
            global::System.Collections.Generic.IList<global::Speechify.ToolParam>? @params,
            bool? enabled)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
            this.Params = @params;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentToolRequest" /> class.
        /// </summary>
        public UpdateAgentToolRequest()
        {
        }

    }
}