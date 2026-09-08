#nullable enable

namespace Speechify
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get File Content<br/>
        /// Download the file's bytes. Private, uncacheable, and always served as<br/>
        /// an `application/octet-stream` attachment whatever the file's own type -<br/>
        /// read `content_type` from the file object for what it actually is.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetContentAsync(
            string fileId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get File Content<br/>
        /// Download the file's bytes. Private, uncacheable, and always served as<br/>
        /// an `application/octet-stream` attachment whatever the file's own type -<br/>
        /// read `content_type` from the file object for what it actually is.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetContentAsStreamAsync(
            string fileId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get File Content<br/>
        /// Download the file's bytes. Private, uncacheable, and always served as<br/>
        /// an `application/octet-stream` attachment whatever the file's own type -<br/>
        /// read `content_type` from the file object for what it actually is.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<byte[]>> GetContentAsResponseAsync(
            string fileId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}