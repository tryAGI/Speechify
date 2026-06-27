#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Update Agent Tool<br/>
        /// Update one of the agent's tools. For a built-in, every field<br/>
        /// applies. For an attached external tool, only `enabled` is<br/>
        /// editable here — its shared config/name is edited on the<br/>
        /// definition (`PATCH /v1/agents/tool-definitions/{tool_definition_id}`), since the<br/>
        /// definition is referenced live by every agent it is attached to;<br/>
        /// attempting a shared-config edit here returns `tool_config_shared`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toolId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTool> UpdateToolAsync(
            string agentId,
            string toolId,

            global::Speechify.UpdateAgentToolRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Tool<br/>
        /// Update one of the agent's tools. For a built-in, every field<br/>
        /// applies. For an attached external tool, only `enabled` is<br/>
        /// editable here — its shared config/name is edited on the<br/>
        /// definition (`PATCH /v1/agents/tool-definitions/{tool_definition_id}`), since the<br/>
        /// definition is referenced live by every agent it is attached to;<br/>
        /// attempting a shared-config edit here returns `tool_config_shared`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toolId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTool>> UpdateToolAsResponseAsync(
            string agentId,
            string toolId,

            global::Speechify.UpdateAgentToolRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Tool<br/>
        /// Update one of the agent's tools. For a built-in, every field<br/>
        /// applies. For an attached external tool, only `enabled` is<br/>
        /// editable here — its shared config/name is edited on the<br/>
        /// definition (`PATCH /v1/agents/tool-definitions/{tool_definition_id}`), since the<br/>
        /// definition is referenced live by every agent it is attached to;<br/>
        /// attempting a shared-config edit here returns `tool_config_shared`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toolId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// For a built-in, the full `BuiltinToolConfig`. Rejected for shared kinds.
        /// </param>
        /// <param name="params"></param>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTool> UpdateToolAsync(
            string agentId,
            string toolId,
            string? speechifyVersion = default,
            string? name = default,
            string? description = default,
            global::Speechify.BuiltinToolConfig? config = default,
            global::System.Collections.Generic.IList<global::Speechify.ToolParam>? @params = default,
            bool? enabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}