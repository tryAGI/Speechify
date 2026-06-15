
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreateAgentBuiltinRequest
    {
        /// <summary>
        /// Identifier of a worker-resident system builtin. New entries are<br/>
        /// added together on the server (a new `tool_builtin_&lt;name&gt;.go`<br/>
        /// file) and worker (`tools/builtins/&lt;name&gt;.py`) - the 2-file rule<br/>
        /// the server pins. Customers read the catalogue from<br/>
        /// `GET /v1/agents/tools/system-builtins` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Builtin { get; set; }

        /// <summary>
        /// LLM-facing tool name. Must match the tool-name regex and be unique within the agent's builtin set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Defaults to true on the server when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateAgentBuiltinRequest" /> class.
        /// </summary>
        /// <param name="builtin">
        /// Identifier of a worker-resident system builtin. New entries are<br/>
        /// added together on the server (a new `tool_builtin_&lt;name&gt;.go`<br/>
        /// file) and worker (`tools/builtins/&lt;name&gt;.py`) - the 2-file rule<br/>
        /// the server pins. Customers read the catalogue from<br/>
        /// `GET /v1/agents/tools/system-builtins` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </param>
        /// <param name="name">
        /// LLM-facing tool name. Must match the tool-name regex and be unique within the agent's builtin set.
        /// </param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Per-instance configuration matching the per-builtin schema.
        /// </param>
        /// <param name="params">
        /// Per-call parameter descriptors.
        /// </param>
        /// <param name="enabled">
        /// Defaults to true on the server when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateAgentBuiltinRequest(
            string builtin,
            string name,
            string? description,
            object? config,
            global::System.Collections.Generic.IList<object>? @params,
            bool? enabled)
        {
            this.Builtin = builtin ?? throw new global::System.ArgumentNullException(nameof(builtin));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Config = config;
            this.Params = @params;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateAgentBuiltinRequest" /> class.
        /// </summary>
        public TtsCreateAgentBuiltinRequest()
        {
        }

    }
}