#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// List Contacts<br/>
        /// List the workspace's contacts, most-recently-seen first, each with its<br/>
        /// live identifier set. Cursor-paginated: omit `cursor` for the first<br/>
        /// page; walk pages while `has_more` is true (default page size 50, max<br/>
        /// 200).<br/>
        /// Contacts are workspace-level, not per-agent: the same person reached<br/>
        /// on two agents and on two channels is one row here, while<br/>
        /// `/v1/agents/callers` stays the per-agent observation of them.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListContactsResponse> ListAsync(
            string? q = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Contacts<br/>
        /// List the workspace's contacts, most-recently-seen first, each with its<br/>
        /// live identifier set. Cursor-paginated: omit `cursor` for the first<br/>
        /// page; walk pages while `has_more` is true (default page size 50, max<br/>
        /// 200).<br/>
        /// Contacts are workspace-level, not per-agent: the same person reached<br/>
        /// on two agents and on two channels is one row here, while<br/>
        /// `/v1/agents/callers` stays the per-agent observation of them.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListContactsResponse>> ListAsResponseAsync(
            string? q = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}