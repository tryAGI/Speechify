#nullable enable

namespace Speechify
{
    public partial interface ITestsClient
    {
        /// <summary>
        /// Create Test<br/>
        /// Create a workspace-level test. The optional `agent_id` is the<br/>
        /// authoring agent: when supplied it seeds the test's tool schemas and<br/>
        /// variables and is recorded as authored-from provenance. Omit it to<br/>
        /// create a bare workspace test with no authoring agent (`agent_id`<br/>
        /// comes back `null`). `agent_id` is never a scope - every read, list,<br/>
        /// and run is scoped by workspace, and the run target is bound at run<br/>
        /// time (`POST /v1/agents/tests/runs`) independently of it.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTest> CreateTestAsync(

            global::Speechify.CreateAgentTestRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Test<br/>
        /// Create a workspace-level test. The optional `agent_id` is the<br/>
        /// authoring agent: when supplied it seeds the test's tool schemas and<br/>
        /// variables and is recorded as authored-from provenance. Omit it to<br/>
        /// create a bare workspace test with no authoring agent (`agent_id`<br/>
        /// comes back `null`). `agent_id` is never a scope - every read, list,<br/>
        /// and run is scoped by workspace, and the run target is bound at run<br/>
        /// time (`POST /v1/agents/tests/runs`) independently of it.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTest>> CreateTestAsResponseAsync(

            global::Speechify.CreateAgentTestRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Test<br/>
        /// Create a workspace-level test. The optional `agent_id` is the<br/>
        /// authoring agent: when supplied it seeds the test's tool schemas and<br/>
        /// variables and is recorded as authored-from provenance. Omit it to<br/>
        /// create a bare workspace test with no authoring agent (`agent_id`<br/>
        /// comes back `null`). `agent_id` is never a scope - every read, list,<br/>
        /// and run is scoped by workspace, and the run target is bound at run<br/>
        /// time (`POST /v1/agents/tests/runs`) independently of it.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="agentId">
        /// Optional authoring agent (`agent_&lt;26 char Crockford base32&gt;`).<br/>
        /// When supplied it must be an agent in the caller's workspace; it<br/>
        /// seeds the test's tool schemas and variables and is recorded as<br/>
        /// authored-from provenance. Omit it to create a bare workspace<br/>
        /// test with no authoring agent. It is never a scope, and the run<br/>
        /// target is bound at run time independently of it.
        /// </param>
        /// <param name="name">
        /// Short human-readable label for the test.
        /// </param>
        /// <param name="description">
        /// Optional longer description of what this test verifies.
        /// </param>
        /// <param name="type">
        /// Discriminates the shape of `AgentTest.config`.<br/>
        /// - `reply` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </param>
        /// <param name="config">
        /// Type-specific configuration. Must match the shape for the given `type`.
        /// </param>
        /// <param name="toolMockConfig">
        /// Optional tool-mocking config applied during every run of this test.
        /// </param>
        /// <param name="variables">
        /// Per-test variable values substituted into string fields of the<br/>
        /// config at run-start. Keys use the same rules as agent-level<br/>
        /// `DynamicVariable` keys.
        /// </param>
        /// <param name="folderId">
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to place the test in. Omit / null for root.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTest> CreateTestAsync(
            string name,
            global::Speechify.TestType type,
            global::Speechify.CreateAgentTestRequestConfig config,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? agentId = default,
            string? description = default,
            global::Speechify.ToolMockConfig? toolMockConfig = default,
            object? variables = default,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}