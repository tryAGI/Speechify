#nullable enable

namespace Speechify
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete File<br/>
        /// Delete a file and its bytes. A run already holding it as an attachment<br/>
        /// stops being able to read it.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string fileId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete File<br/>
        /// Delete a file and its bytes. A run already holding it as an attachment<br/>
        /// stops being able to read it.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string fileId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}