#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Create Agent Builtin<br/>
        /// Create a new builtin instance on this agent. `builtin` must<br/>
        /// resolve to one of the names returned by<br/>
        /// `GET /v1/agents/tools/system-builtins`; unknown values are rejected.<br/>
        /// `name` is the LLM-facing identifier the model uses to call the<br/>
        /// tool; it must match the tool-name regex and be unique within<br/>
        /// the agent's builtin set.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentBuiltin> CreateBuiltinAsync(
            string id,

            global::Speechify.TtsCreateAgentBuiltinRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Builtin<br/>
        /// Create a new builtin instance on this agent. `builtin` must<br/>
        /// resolve to one of the names returned by<br/>
        /// `GET /v1/agents/tools/system-builtins`; unknown values are rejected.<br/>
        /// `name` is the LLM-facing identifier the model uses to call the<br/>
        /// tool; it must match the tool-name regex and be unique within<br/>
        /// the agent's builtin set.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsAgentBuiltin>> CreateBuiltinAsResponseAsync(
            string id,

            global::Speechify.TtsCreateAgentBuiltinRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Builtin<br/>
        /// Create a new builtin instance on this agent. `builtin` must<br/>
        /// resolve to one of the names returned by<br/>
        /// `GET /v1/agents/tools/system-builtins`; unknown values are rejected.<br/>
        /// `name` is the LLM-facing identifier the model uses to call the<br/>
        /// tool; it must match the tool-name regex and be unique within<br/>
        /// the agent's builtin set.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="builtin">
        /// Identifier of a worker-resident system builtin. New entries are<br/>
        /// added together on the server (a new `tool_builtin_&lt;name&gt;.go`<br/>
        /// file) and worker (`tools/builtins/&lt;name&gt;.py`) - the 2-file rule<br/>
        /// AIS-3053 pins. Customers read the catalogue from<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentBuiltin> CreateBuiltinAsync(
            string id,
            string builtin,
            string name,
            string? description = default,
            object? config = default,
            global::System.Collections.Generic.IList<object>? @params = default,
            bool? enabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}