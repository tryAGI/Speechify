#nullable enable

namespace Speechify
{
    public partial interface IToolDefinitionsClient
    {
        /// <summary>
        /// List Tool API Routes<br/>
        /// List the hosted API routes that call this tool, in the hosted APIs<br/>
        /// you can reach, ordered by API name. A route calls one operation of<br/>
        /// an `mcp` or `openapi` tool and answers only while that operation<br/>
        /// exists, runs without approval, and reads (unless the route has<br/>
        /// `allow_write`), and while the tool is in the API's project. So<br/>
        /// deleting the tool, moving it to another project, or changing an<br/>
        /// operation's class or approval can stop these routes answering:<br/>
        /// check this list before such a change. A route in a project you<br/>
        /// cannot reach is not listed; it already refuses its calls, because<br/>
        /// the tool is not in its API's project. A tool of another kind is<br/>
        /// used by no route and answers an empty list.<br/>
        /// Cursor-paginated: omit `cursor` for the first page; walk pages while<br/>
        /// `has_more` is true (default page size 50, max 200).<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="toolDefinitionId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListToolAPIRoutesResponse> ListApiRoutesAsync(
            string toolDefinitionId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tool API Routes<br/>
        /// List the hosted API routes that call this tool, in the hosted APIs<br/>
        /// you can reach, ordered by API name. A route calls one operation of<br/>
        /// an `mcp` or `openapi` tool and answers only while that operation<br/>
        /// exists, runs without approval, and reads (unless the route has<br/>
        /// `allow_write`), and while the tool is in the API's project. So<br/>
        /// deleting the tool, moving it to another project, or changing an<br/>
        /// operation's class or approval can stop these routes answering:<br/>
        /// check this list before such a change. A route in a project you<br/>
        /// cannot reach is not listed; it already refuses its calls, because<br/>
        /// the tool is not in its API's project. A tool of another kind is<br/>
        /// used by no route and answers an empty list.<br/>
        /// Cursor-paginated: omit `cursor` for the first page; walk pages while<br/>
        /// `has_more` is true (default page size 50, max 200).<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="toolDefinitionId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListToolAPIRoutesResponse>> ListApiRoutesAsResponseAsync(
            string toolDefinitionId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}