
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One instance of a system builtin bound to a specific agent.<br/>
    /// Storage lives in the `agent_builtins` table (migration 00061);<br/>
    /// wire format intentionally matches the legacy `kind="system"`<br/>
    /// Tool shape so the worker is untouched by the AIS-3116 split.
    /// </summary>
    public sealed partial class TtsAgentBuiltin
    {
        /// <summary>
        /// Opaque builtin instance ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The workspace owning this instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// The agent this instance is bound to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Identifier of a worker-resident system builtin. New entries are<br/>
        /// added together on the server (a new `tool_builtin_&lt;name&gt;.go`<br/>
        /// file) and worker (`tools/builtins/&lt;name&gt;.py`) - the 2-file rule<br/>
        /// AIS-3053 pins. Customers read the catalogue from<br/>
        /// `GET /v1/agents/tools/system-builtins` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Builtin { get; set; }

        /// <summary>
        /// LLM-facing tool name. Unique within the agent's builtin set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// LLM-facing one-line description of when to call the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Per-instance configuration shape. The schema depends on<br/>
        /// `builtin` — see the per-builtin contracts under<br/>
        /// `/contracts/tools/system_*.schema.json`. Null when the<br/>
        /// builtin takes no instance-level config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Per-call parameter schema fragment merged into the model's<br/>
        /// tool spec. Each entry is one parameter descriptor (the<br/>
        /// per-builtin contract pins the exact shape). Null when the<br/>
        /// builtin takes no caller arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<object>? Params { get; set; }

        /// <summary>
        /// When false, the instance is persisted but skipped at dispatch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentBuiltin" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque builtin instance ID.
        /// </param>
        /// <param name="tenantId">
        /// The workspace owning this instance.
        /// </param>
        /// <param name="agentId">
        /// The agent this instance is bound to.
        /// </param>
        /// <param name="builtin">
        /// Identifier of a worker-resident system builtin. New entries are<br/>
        /// added together on the server (a new `tool_builtin_&lt;name&gt;.go`<br/>
        /// file) and worker (`tools/builtins/&lt;name&gt;.py`) - the 2-file rule<br/>
        /// AIS-3053 pins. Customers read the catalogue from<br/>
        /// `GET /v1/agents/tools/system-builtins` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </param>
        /// <param name="name">
        /// LLM-facing tool name. Unique within the agent's builtin set.
        /// </param>
        /// <param name="description">
        /// LLM-facing one-line description of when to call the tool.
        /// </param>
        /// <param name="enabled">
        /// When false, the instance is persisted but skipped at dispatch.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="config">
        /// Per-instance configuration shape. The schema depends on<br/>
        /// `builtin` — see the per-builtin contracts under<br/>
        /// `/contracts/tools/system_*.schema.json`. Null when the<br/>
        /// builtin takes no instance-level config.
        /// </param>
        /// <param name="params">
        /// Per-call parameter schema fragment merged into the model's<br/>
        /// tool spec. Each entry is one parameter descriptor (the<br/>
        /// per-builtin contract pins the exact shape). Null when the<br/>
        /// builtin takes no caller arguments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAgentBuiltin(
            string id,
            string tenantId,
            string agentId,
            string builtin,
            string name,
            string description,
            bool enabled,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? config,
            global::System.Collections.Generic.IList<object>? @params)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Builtin = builtin ?? throw new global::System.ArgumentNullException(nameof(builtin));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Config = config;
            this.Params = @params;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentBuiltin" /> class.
        /// </summary>
        public TtsAgentBuiltin()
        {
        }

    }
}