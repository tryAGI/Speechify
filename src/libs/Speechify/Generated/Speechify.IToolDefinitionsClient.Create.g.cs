#nullable enable

namespace Speechify
{
    public partial interface IToolDefinitionsClient
    {
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once - store it immediately; subsequent<br/>
        /// reads return a masked placeholder.<br/>
        /// An `mcp` or `openapi` tool that authenticates references a vault<br/>
        /// credential by `auth.credential_id`: create it first with<br/>
        /// `POST /v1/credentials`. For an `mcp` tool,<br/>
        /// `POST /v1/agents/tool-definitions/test-mcp-connection` lists the<br/>
        /// server's tools before you save. For an `openapi` tool, compile the<br/>
        /// vendor's document with<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi`, choose and classify<br/>
        /// the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then send the<br/>
        /// chosen operations here. The tool is usable once it is attached to an<br/>
        /// agent (`PUT /v1/agents/{agent_id}/tools/{tool_id}`) or named in a<br/>
        /// skill's `tool_ids`.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.<br/>
        /// The contents of `config` are your own data at this level; they are<br/>
        /// validated against the tool kind's own schema, which has always<br/>
        /// refused an unknown key there.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Tool> CreateAsync(

            global::Speechify.CreateToolRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once - store it immediately; subsequent<br/>
        /// reads return a masked placeholder.<br/>
        /// An `mcp` or `openapi` tool that authenticates references a vault<br/>
        /// credential by `auth.credential_id`: create it first with<br/>
        /// `POST /v1/credentials`. For an `mcp` tool,<br/>
        /// `POST /v1/agents/tool-definitions/test-mcp-connection` lists the<br/>
        /// server's tools before you save. For an `openapi` tool, compile the<br/>
        /// vendor's document with<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi`, choose and classify<br/>
        /// the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then send the<br/>
        /// chosen operations here. The tool is usable once it is attached to an<br/>
        /// agent (`PUT /v1/agents/{agent_id}/tools/{tool_id}`) or named in a<br/>
        /// skill's `tool_ids`.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.<br/>
        /// The contents of `config` are your own data at this level; they are<br/>
        /// validated against the tool kind's own schema, which has always<br/>
        /// refused an unknown key there.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Tool>> CreateAsResponseAsync(

            global::Speechify.CreateToolRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once - store it immediately; subsequent<br/>
        /// reads return a masked placeholder.<br/>
        /// An `mcp` or `openapi` tool that authenticates references a vault<br/>
        /// credential by `auth.credential_id`: create it first with<br/>
        /// `POST /v1/credentials`. For an `mcp` tool,<br/>
        /// `POST /v1/agents/tool-definitions/test-mcp-connection` lists the<br/>
        /// server's tools before you save. For an `openapi` tool, compile the<br/>
        /// vendor's document with<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi`, choose and classify<br/>
        /// the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then send the<br/>
        /// chosen operations here. The tool is usable once it is attached to an<br/>
        /// agent (`PUT /v1/agents/{agent_id}/tools/{tool_id}`) or named in a<br/>
        /// skill's `tool_ids`.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.<br/>
        /// The contents of `config` are your own data at this level; they are<br/>
        /// validated against the tool kind's own schema, which has always<br/>
        /// refused an unknown key there.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="kind">
        /// What kind of tool this is, and where it executes.<br/>
        /// - `builtin`: a worker-resident platform capability (e.g. end_call, play_audio), configured per-agent<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls<br/>
        /// - `openapi`: a REST API described by its OpenAPI document, pinned to the operations you selected; the control plane executes every call
        /// </param>
        /// <param name="config"></param>
        /// <param name="actionClass">
        /// The impact class. Omit it and the tool's impact is read off its<br/>
        /// shape instead, and keeps tracking it: a `GET` webhook reads, a<br/>
        /// `POST` webhook reaches outside your team, an MCP, client or OpenAPI<br/>
        /// tool can do anything its author wired.<br/>
        /// On an OpenAPI tool it is the class of every operation that declares<br/>
        /// none of its own and is not a GET or HEAD; classify operations one by<br/>
        /// one with `OpenAPIOperation.action_class` instead of setting it here.<br/>
        /// On an MCP tool it is also the ceiling for what the server may claim<br/>
        /// about its own tools: a class a `tools/list` entry declares under<br/>
        /// `_meta["speechify/action_class"]` is honoured when it is at least<br/>
        /// this strong and held to this class when weaker (see<br/>
        /// `MCPToolConfig.action_classes`).
        /// </param>
        /// <param name="approval">
        /// Overrides the approval derived from the class. Omitted means derived.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Tool> CreateAsync(
            string name,
            string description,
            global::Speechify.ToolKind kind,
            global::Speechify.CreateToolRequestConfig config,
            string? speechifyVersion = default,
            string? projectId = default,
            global::Speechify.ToolActionClass? actionClass = default,
            global::Speechify.ToolApprovalClass? approval = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}