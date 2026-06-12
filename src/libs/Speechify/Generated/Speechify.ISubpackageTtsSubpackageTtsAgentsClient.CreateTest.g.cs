#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Create Agent Test<br/>
        /// Create a new test for the agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentTest> CreateTestAsync(
            string id,

            global::Speechify.TtsCreateAgentTestRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Test<br/>
        /// Create a new test for the agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsAgentTest>> CreateTestAsResponseAsync(
            string id,

            global::Speechify.TtsCreateAgentTestRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Test<br/>
        /// Create a new test for the agent.
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="attachedAgentIds">
        /// Optional list of additional agents this test should also run<br/>
        /// against. The owner agent (path param) is always attached<br/>
        /// implicitly.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentTest> CreateTestAsync(
            string id,
            string name,
            global::Speechify.TtsTestType type,
            global::Speechify.TtsCreateAgentTestRequestConfig config,
            string? description = default,
            global::Speechify.TtsToolMockConfig? toolMockConfig = default,
            object? variables = default,
            string? folderId = default,
            global::System.Collections.Generic.IList<string>? attachedAgentIds = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}