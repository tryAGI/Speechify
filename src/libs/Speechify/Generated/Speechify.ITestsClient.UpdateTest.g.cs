#nullable enable

namespace Speechify
{
    public partial interface ITestsClient
    {
        /// <summary>
        /// Update Agent Test<br/>
        /// Update a test. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTest> UpdateTestAsync(
            string testId,

            global::Speechify.UpdateAgentTestRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Test<br/>
        /// Update a test. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTest>> UpdateTestAsResponseAsync(
            string testId,

            global::Speechify.UpdateAgentTestRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Test<br/>
        /// Update a test. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Replaces the test config when present.
        /// </param>
        /// <param name="toolMockConfig">
        /// Replaces the tool-mock config when present.
        /// </param>
        /// <param name="folderId">
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to move the test into, or `null` to move the<br/>
        /// test back to root. Omit to leave unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTest> UpdateTestAsync(
            string testId,
            string? speechifyVersion = default,
            string? name = default,
            string? description = default,
            global::Speechify.UpdateAgentTestRequestConfig? config = default,
            global::Speechify.ToolMockConfig? toolMockConfig = default,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}