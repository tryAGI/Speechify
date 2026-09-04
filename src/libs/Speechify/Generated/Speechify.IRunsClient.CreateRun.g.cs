#nullable enable

namespace Speechify
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Create Agent Run<br/>
        /// Enqueue a **durable async run**: hand the agent an instruction and get a<br/>
        /// run handle back immediately (`202`, status `queued`). The run executes on<br/>
        /// its own - poll it with `getRun` or receive a completion webhook - and it<br/>
        /// survives a deploy (it is backed by a durable job, not a request socket or<br/>
        /// a short-lived store). This is the managed-agent-platform primitive: start<br/>
        /// work, walk away, come back for the result.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first run instead of<br/>
        /// starting a duplicate (the `run_id` is the idempotency handle).<br/>
        /// Refused with `422 tool_transport_unsupported` when one of the agent's<br/>
        /// attached MCP tools uses the legacy `sse` transport, which durable runs<br/>
        /// cannot execute; the message names the tool. Switch it to<br/>
        /// `http_streamable` or detach it, then retry.<br/>
        /// Returns `429 concurrency_limit_reached` when the workspace already has<br/>
        /// 200 runs queued or running. Runs execute on a shared queue, so the<br/>
        /// ceiling is what keeps one workspace's backlog from delaying everyone<br/>
        /// else's next run; it is not a plan limit. Wait for runs to finish, or<br/>
        /// follow them with the run event stream, then retry.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentRun> CreateRunAsync(
            string agentId,

            global::Speechify.CreateAgentRunRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Run<br/>
        /// Enqueue a **durable async run**: hand the agent an instruction and get a<br/>
        /// run handle back immediately (`202`, status `queued`). The run executes on<br/>
        /// its own - poll it with `getRun` or receive a completion webhook - and it<br/>
        /// survives a deploy (it is backed by a durable job, not a request socket or<br/>
        /// a short-lived store). This is the managed-agent-platform primitive: start<br/>
        /// work, walk away, come back for the result.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first run instead of<br/>
        /// starting a duplicate (the `run_id` is the idempotency handle).<br/>
        /// Refused with `422 tool_transport_unsupported` when one of the agent's<br/>
        /// attached MCP tools uses the legacy `sse` transport, which durable runs<br/>
        /// cannot execute; the message names the tool. Switch it to<br/>
        /// `http_streamable` or detach it, then retry.<br/>
        /// Returns `429 concurrency_limit_reached` when the workspace already has<br/>
        /// 200 runs queued or running. Runs execute on a shared queue, so the<br/>
        /// ceiling is what keeps one workspace's backlog from delaying everyone<br/>
        /// else's next run; it is not a plan limit. Wait for runs to finish, or<br/>
        /// follow them with the run event stream, then retry.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentRun>> CreateRunAsResponseAsync(
            string agentId,

            global::Speechify.CreateAgentRunRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Run<br/>
        /// Enqueue a **durable async run**: hand the agent an instruction and get a<br/>
        /// run handle back immediately (`202`, status `queued`). The run executes on<br/>
        /// its own - poll it with `getRun` or receive a completion webhook - and it<br/>
        /// survives a deploy (it is backed by a durable job, not a request socket or<br/>
        /// a short-lived store). This is the managed-agent-platform primitive: start<br/>
        /// work, walk away, come back for the result.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first run instead of<br/>
        /// starting a duplicate (the `run_id` is the idempotency handle).<br/>
        /// Refused with `422 tool_transport_unsupported` when one of the agent's<br/>
        /// attached MCP tools uses the legacy `sse` transport, which durable runs<br/>
        /// cannot execute; the message names the tool. Switch it to<br/>
        /// `http_streamable` or detach it, then retry.<br/>
        /// Returns `429 concurrency_limit_reached` when the workspace already has<br/>
        /// 200 runs queued or running. Runs execute on a shared queue, so the<br/>
        /// ceiling is what keeps one workspace's backlog from delaying everyone<br/>
        /// else's next run; it is not a plan limit. Wait for runs to finish, or<br/>
        /// follow them with the run event stream, then retry.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="instruction">
        /// The task or goal to give the agent. The agent runs its brain against this over a short internal conversation and returns its result.
        /// </param>
        /// <param name="variables">
        /// Per-run values that seed the agent's flow variables (override its<br/>
        /// stored defaults). The `system__*` namespace and the legacy `memory`<br/>
        /// alias belong to the platform and are rejected with a 400 naming<br/>
        /// `variables`, the same rule a conversation applies: the run binds its<br/>
        /// own values there, including `system__caller_id` for the person it<br/>
        /// acts for.
        /// </param>
        /// <param name="maxTurns">
        /// Upper bound on the run's internal turn budget (server default when omitted; hard-capped).
        /// </param>
        /// <param name="userIdentity">
        /// The person this run acts for, in your own vocabulary - the same<br/>
        /// field a conversation and a widget session take, so one workspace<br/>
        /// never has two answers to who a person is. The agent opens the run<br/>
        /// knowing what it has already learned about them.<br/>
        /// Omit it to run the agent for nobody in particular, which is how a<br/>
        /// run behaves with no memory of anyone. Must not begin with `user_`,<br/>
        /// `embed_` or `anon_`, which name identities the platform derives.<br/>
        /// Every tool the run calls is told this value: a webhook receives<br/>
        /// it as `user_identity` inside the signed body, an MCP server as<br/>
        /// the `Speechify-User-Identity` header, and it renders in a tool's<br/>
        /// templated URL or headers as `{{system__caller_id}}`. A connector<br/>
        /// you wrote can therefore look up that person's own third-party<br/>
        /// token, which is how you integrate a system Speechify holds no<br/>
        /// credentials for.
        /// </param>
        /// <param name="outputSchema">
        /// Optional JSON Schema (2020-12, top-level `type: object`) the run's<br/>
        /// final answer must satisfy. When set, the agent answers with a JSON<br/>
        /// object, the platform validates it against this schema (re-asking the<br/>
        /// agent on a mismatch, bounded), and the conforming object is returned<br/>
        /// as `output.data`. A run that never produces a conforming object<br/>
        /// settles `succeeded` with `incomplete_reason: output_schema_violation`<br/>
        /// and no `output.data`. At most 16 KiB.
        /// </param>
        /// <param name="metadata">
        /// Up to 16 arbitrary key/value pairs echoed back on the run.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentRun> CreateRunAsync(
            string agentId,
            string instruction,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            object? variables = default,
            int? maxTurns = default,
            string? userIdentity = default,
            object? outputSchema = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}