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
        /// out. Bounded by the number of agents per workspace (tens), so<br/>
        /// the response is not paginated.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListToolAttachedAgentsResponse> ListAttachedAgentsAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tool Attached Agents<br/>
        /// List the agents in the caller's workspace that currently have<br/>
        /// this tool attached. Useful before deleting a tool, to surface<br/>
        /// which agents will lose access. Soft-deleted agents are filtered<br/>
        /// out. Bounded by the number of agents per workspace (tens), so<br/>
        /// the response is not paginated.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListToolAttachedAgentsResponse>> ListAttachedAgentsAsResponseAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}