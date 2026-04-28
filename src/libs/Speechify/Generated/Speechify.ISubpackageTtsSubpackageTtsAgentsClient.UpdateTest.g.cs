#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Update Test<br/>
        /// Update a test. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentTest> UpdateTestAsync(
            string id,

            global::Speechify.TtsUpdateAgentTestRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Test<br/>
        /// Update a test. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Replaces the test config when present.
        /// </param>
        /// <param name="toolMockConfig">
        /// Replaces the tool-mock config when present.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentTest> UpdateTestAsync(
            string id,
            string? name = default,
            string? description = default,
            global::Speechify.TtsUpdateAgentTestRequestConfig? config = default,
            global::Speechify.TtsToolMockConfig? toolMockConfig = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}