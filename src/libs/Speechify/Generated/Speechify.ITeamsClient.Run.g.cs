#nullable enable

namespace Speechify
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Run Team<br/>
        /// **Run a team**: start a durable async run of the team's manager agent,<br/>
        /// which pursues the given instruction and delegates sub-goals to the team<br/>
        /// members (each executing as its own bounded child run). Returns a run<br/>
        /// handle immediately (`202`, status `queued`); poll it with `getRun` or<br/>
        /// watch its step timeline - it is the same durable run primitive as<br/>
        /// `createRun`, so the returned handle addresses the manager run.<br/>
        /// The team must have a manager assigned; a draft team without one is a<br/>
        /// `400`. Idempotent via `Idempotency-Key`: a retry replays the first run.<br/>
        /// Every admission rule `createRun` describes applies here, on the manager<br/>
        /// agent: the publish gate (`422 agent_publish_gate_required` until the<br/>
        /// manager's current configuration is published), the MCP transport check<br/>
        /// (`422 tool_transport_unsupported`), the 200-run workspace backlog<br/>
        /// ceiling (`429 concurrency_limit_reached` - and a team run's children<br/>
        /// count towards it as they start), and the spend gate.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentRun> RunAsync(
            string teamId,

            global::Speechify.CreateTeamRunRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Team<br/>
        /// **Run a team**: start a durable async run of the team's manager agent,<br/>
        /// which pursues the given instruction and delegates sub-goals to the team<br/>
        /// members (each executing as its own bounded child run). Returns a run<br/>
        /// handle immediately (`202`, status `queued`); poll it with `getRun` or<br/>
        /// watch its step timeline - it is the same durable run primitive as<br/>
        /// `createRun`, so the returned handle addresses the manager run.<br/>
        /// The team must have a manager assigned; a draft team without one is a<br/>
        /// `400`. Idempotent via `Idempotency-Key`: a retry replays the first run.<br/>
        /// Every admission rule `createRun` describes applies here, on the manager<br/>
        /// agent: the publish gate (`422 agent_publish_gate_required` until the<br/>
        /// manager's current configuration is published), the MCP transport check<br/>
        /// (`422 tool_transport_unsupported`), the 200-run workspace backlog<br/>
        /// ceiling (`429 concurrency_limit_reached` - and a team run's children<br/>
        /// count towards it as they start), and the spend gate.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentRun>> RunAsResponseAsync(
            string teamId,

            global::Speechify.CreateTeamRunRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Team<br/>
        /// **Run a team**: start a durable async run of the team's manager agent,<br/>
        /// which pursues the given instruction and delegates sub-goals to the team<br/>
        /// members (each executing as its own bounded child run). Returns a run<br/>
        /// handle immediately (`202`, status `queued`); poll it with `getRun` or<br/>
        /// watch its step timeline - it is the same durable run primitive as<br/>
        /// `createRun`, so the returned handle addresses the manager run.<br/>
        /// The team must have a manager assigned; a draft team without one is a<br/>
        /// `400`. Idempotent via `Idempotency-Key`: a retry replays the first run.<br/>
        /// Every admission rule `createRun` describes applies here, on the manager<br/>
        /// agent: the publish gate (`422 agent_publish_gate_required` until the<br/>
        /// manager's current configuration is published), the MCP transport check<br/>
        /// (`422 tool_transport_unsupported`), the 200-run workspace backlog<br/>
        /// ceiling (`429 concurrency_limit_reached` - and a team run's children<br/>
        /// count towards it as they start), and the spend gate.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="instruction">
        /// The task or goal to give the team. The manager agent runs its brain against this, delegating sub-goals to the members, and returns its aggregated result. The server's limit is 8000 **bytes**, so a mostly non-ASCII instruction reaches it before 8000 characters.
        /// </param>
        /// <param name="variables">
        /// Per-run values that seed the manager's flow variables (override its<br/>
        /// stored defaults). As on a single-agent run, the `system__*`<br/>
        /// namespace and the legacy `memory` alias belong to the platform and<br/>
        /// are rejected with a 400 naming `variables`.
        /// </param>
        /// <param name="userIdentity">
        /// The person this team run acts for, in your own vocabulary - the same<br/>
        /// field a single-agent run, a conversation and a widget session take,<br/>
        /// so one workspace never has two answers to who a person is. The<br/>
        /// manager run carries it and every child it delegates inherits it, so<br/>
        /// each member opens knowing what the platform has learned about that<br/>
        /// person.<br/>
        /// Omit it to run the team for nobody in particular. Must not begin<br/>
        /// with `user_`, `embed_` or `anon_`, which name identities the platform<br/>
        /// derives.<br/>
        /// Every tool called anywhere in the team run - by the manager or by a<br/>
        /// delegated member - is told this value: a webhook receives it as<br/>
        /// `user_identity` inside the signed body, an MCP server as the<br/>
        /// `Speechify-User-Identity` header, and it renders in a tool's<br/>
        /// templated URL or headers as `{{system__caller_id}}`.
        /// </param>
        /// <param name="maxTurns">
        /// Upper bound on the manager run's internal turn budget - one turn is<br/>
        /// one plan-act-observe cycle. Defaults to 8 when omitted, and bounds<br/>
        /// the MANAGER only: each delegated child gets its own budget.<br/>
        /// **Clamped to the workspace's per-run ceiling** (5 on Free, 10<br/>
        /// on Starter, 20 on Pro, 30 on Scale, 50 on Enterprise; per-workspace<br/>
        /// overrides apply): the run's `input.max_turns` echoes the budget it<br/>
        /// actually got, and `GET /v1/workspaces/current/entitlements`<br/>
        /// (`max_run_turns`) reports the ceiling up front, so plan against<br/>
        /// that rather than the value you sent. An omitted `max_turns` takes<br/>
        /// the default, clamped to the ceiling.
        /// </param>
        /// <param name="outputSchema">
        /// Optional JSON Schema (2020-12) the run's final answer must satisfy.<br/>
        /// When set, the agent answers with a JSON object, the platform<br/>
        /// validates it, and the conforming object is returned as<br/>
        /// `output.data`.<br/>
        /// The top level must be `type: object` - an array-typed or scalar<br/>
        /// schema is refused at create with `400`. At most 16 KiB.<br/>
        /// On a mismatch the platform re-asks the agent, feeding back up to 8<br/>
        /// of the violations. **At most two repair attempts, and each one<br/>
        /// spends a turn from `max_turns`** - so a schema-constrained run on a<br/>
        /// 5-turn ceiling has little room left for tool calls. Each attempt is<br/>
        /// journaled as an `observation` step whose `tool` is the reserved<br/>
        /// name `output_schema`, which a timeline renderer should expect<br/>
        /// alongside real tool names.<br/>
        /// A run that never produces a conforming object settles `succeeded`<br/>
        /// with `incomplete_reason: output_schema_violation` and no<br/>
        /// `output.data` - its prose answer is still on `output.reply`. The<br/>
        /// platform never returns an object the schema refused.
        /// </param>
        /// <param name="metadata">
        /// Up to 16 arbitrary key/value pairs echoed back on the run. Your own correlation ids belong here - the platform never reads them.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentRun> RunAsync(
            string teamId,
            string instruction,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            object? variables = default,
            string? userIdentity = default,
            int? maxTurns = default,
            object? outputSchema = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}