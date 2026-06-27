#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentToolDefinitionsClient
    {
        /// <summary>
        /// List Tool Attached Agents<br/>
        /// List the agents in the caller's workspace that currently have<br/>
        /// this tool attached. Useful before deleting a tool, to surface<br/>
        /// which agents will lose access. Soft-deleted agents are filtered<br/>
        /// out. Cursor-paginated: omit `cursor` for the first page; walk<br/>
        /// pages while `has_more` is true (default page size 50, max 200).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListToolAttachedAgentsResponse> ListAttachedAgentsAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tool Attached Agents<br/>
        /// List the agents in the caller's workspace that currently have<br/>
        /// this tool attached. Useful before deleting a tool, to surface<br/>
        /// which agents will lose access. Soft-deleted agents are filtered<br/>
        /// out. Cursor-paginated: omit `cursor` for the first page; walk<br/>
        /// pages while `has_more` is true (default page size 50, max 200).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListToolAttachedAgentsResponse>> ListAttachedAgentsAsResponseAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}