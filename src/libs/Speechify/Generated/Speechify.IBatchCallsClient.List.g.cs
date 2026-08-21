#nullable enable

namespace Speechify
{
    public partial interface IBatchCallsClient
    {
        /// <summary>
        /// List Batch Calls<br/>
        /// Returns one page of batch calls for the workspace, newest first.<br/>
        /// Paginate by passing `cursor` from the previous response.<br/>
        /// `project_id` matches the project the batch was STARTED under, frozen<br/>
        /// at create. Moving its agent to another project therefore leaves past<br/>
        /// batches attributed where they ran.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListBatchCallsResponse> ListAsync(
            string? projectId = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Batch Calls<br/>
        /// Returns one page of batch calls for the workspace, newest first.<br/>
        /// Paginate by passing `cursor` from the previous response.<br/>
        /// `project_id` matches the project the batch was STARTED under, frozen<br/>
        /// at create. Moving its agent to another project therefore leaves past<br/>
        /// batches attributed where they ran.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListBatchCallsResponse>> ListAsResponseAsync(
            string? projectId = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}