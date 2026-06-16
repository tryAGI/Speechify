#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentTestsClient
    {
        /// <summary>
        /// Detach Test<br/>
        /// Detach a test from an agent. The owner agent (the agent the test<br/>
        /// was authored against) cannot be detached; delete the test<br/>
        /// instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DetachTestAsync(
            string id,
            string agentId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach Test<br/>
        /// Detach a test from an agent. The owner agent (the agent the test<br/>
        /// was authored against) cannot be detached; delete the test<br/>
        /// instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DetachTestAsResponseAsync(
            string id,
            string agentId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}