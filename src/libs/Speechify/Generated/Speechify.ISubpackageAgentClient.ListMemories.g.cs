#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Agent Memories<br/>
        /// List per-caller memories extracted for an agent. Memories are<br/>
        /// written post-call by the built-in extractor when `memory_enabled`<br/>
        /// is true on the agent; the list is sorted newest-first.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListMemoriesResponse> ListMemoriesAsync(
            string id,
            int? limit = default,
            int? offset = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Memories<br/>
        /// List per-caller memories extracted for an agent. Memories are<br/>
        /// written post-call by the built-in extractor when `memory_enabled`<br/>
        /// is true on the agent; the list is sorted newest-first.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListMemoriesResponse>> ListMemoriesAsResponseAsync(
            string id,
            int? limit = default,
            int? offset = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}