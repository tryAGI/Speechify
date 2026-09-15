#nullable enable

namespace Speechify
{
    public partial interface IHostedApisClient
    {
        /// <summary>
        /// Create Hosted API<br/>
        /// Create a hosted API. The slug is a DNS label, globally unique on the<br/>
        /// shared domain (409 `hosted_api_slug_taken`) and immutable afterwards.<br/>
        /// `auth_mode` names the audience, narrowest first: `owner`, `workspace`<br/>
        /// (the platform's own credentials), `user_token` (a JWT your backend<br/>
        /// signs per user), `consumer_key` (a `ck_` key you mint) or `public`<br/>
        /// (anyone, reads only). A workspace can refuse `public` as policy (403<br/>
        /// `hosted_api_public_refused`). Reads, runs and writes are each bounded<br/>
        /// per UTC day (`daily_read_cap`, `daily_run_cap`, `daily_write_cap`),<br/>
        /// and an API holds only a share of a server's requests open at once, so<br/>
        /// a slow upstream behind one API cannot take the capacity others need:<br/>
        /// past it, a request answers 429 `hosted_api_busy` with `Retry-After`.<br/>
        /// `mcp_enabled: true` also serves the API's routes as an MCP server at<br/>
        /// `POST &lt;base_url&gt;/mcp`, so an MCP client (Claude Code, Cursor) attaches<br/>
        /// to one address and gets them as tools, under the same audience, keys<br/>
        /// and caps. It is refused with `auth_mode: public`. On that face the<br/>
        /// API's `name` is the server's title and its `description` is the<br/>
        /// instructions the client's model reads, so describe what the tools are<br/>
        /// for.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPI> CreateAsync(

            global::Speechify.CreateHostedAPIRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Hosted API<br/>
        /// Create a hosted API. The slug is a DNS label, globally unique on the<br/>
        /// shared domain (409 `hosted_api_slug_taken`) and immutable afterwards.<br/>
        /// `auth_mode` names the audience, narrowest first: `owner`, `workspace`<br/>
        /// (the platform's own credentials), `user_token` (a JWT your backend<br/>
        /// signs per user), `consumer_key` (a `ck_` key you mint) or `public`<br/>
        /// (anyone, reads only). A workspace can refuse `public` as policy (403<br/>
        /// `hosted_api_public_refused`). Reads, runs and writes are each bounded<br/>
        /// per UTC day (`daily_read_cap`, `daily_run_cap`, `daily_write_cap`),<br/>
        /// and an API holds only a share of a server's requests open at once, so<br/>
        /// a slow upstream behind one API cannot take the capacity others need:<br/>
        /// past it, a request answers 429 `hosted_api_busy` with `Retry-After`.<br/>
        /// `mcp_enabled: true` also serves the API's routes as an MCP server at<br/>
        /// `POST &lt;base_url&gt;/mcp`, so an MCP client (Claude Code, Cursor) attaches<br/>
        /// to one address and gets them as tools, under the same audience, keys<br/>
        /// and caps. It is refused with `auth_mode: public`. On that face the<br/>
        /// API's `name` is the server's title and its `description` is the<br/>
        /// instructions the client's model reads, so describe what the tools are<br/>
        /// for.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPI>> CreateAsResponseAsync(

            global::Speechify.CreateHostedAPIRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Hosted API<br/>
        /// Create a hosted API. The slug is a DNS label, globally unique on the<br/>
        /// shared domain (409 `hosted_api_slug_taken`) and immutable afterwards.<br/>
        /// `auth_mode` names the audience, narrowest first: `owner`, `workspace`<br/>
        /// (the platform's own credentials), `user_token` (a JWT your backend<br/>
        /// signs per user), `consumer_key` (a `ck_` key you mint) or `public`<br/>
        /// (anyone, reads only). A workspace can refuse `public` as policy (403<br/>
        /// `hosted_api_public_refused`). Reads, runs and writes are each bounded<br/>
        /// per UTC day (`daily_read_cap`, `daily_run_cap`, `daily_write_cap`),<br/>
        /// and an API holds only a share of a server's requests open at once, so<br/>
        /// a slow upstream behind one API cannot take the capacity others need:<br/>
        /// past it, a request answers 429 `hosted_api_busy` with `Retry-After`.<br/>
        /// `mcp_enabled: true` also serves the API's routes as an MCP server at<br/>
        /// `POST &lt;base_url&gt;/mcp`, so an MCP client (Claude Code, Cursor) attaches<br/>
        /// to one address and gets them as tools, under the same audience, keys<br/>
        /// and caps. It is refused with `auth_mode: public`. On that face the<br/>
        /// API's `name` is the server's title and its `description` is the<br/>
        /// instructions the client's model reads, so describe what the tools are<br/>
        /// for.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="slug">
        /// 3-40 lowercase letters, digits or hyphens; a DNS label, unique on the shared domain; immutable.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description">
        /// What the API is for; also the instructions an MCP client hands its model when `mcp_enabled` is on.
        /// </param>
        /// <param name="authMode">
        /// consumer_key when omitted. `public` is refused with 403 `hosted_api_public_refused` where the workspace's policy does not allow internet-facing APIs.
        /// </param>
        /// <param name="corsOrigins"></param>
        /// <param name="dailyRunCap">
        /// Runs the API may start per UTC day through its run routes; 1000 when omitted.
        /// </param>
        /// <param name="dailyReadCap">
        /// Reads the API's store, file, run_latest and tool routes may serve per UTC day; 100000 when omitted.
        /// </param>
        /// <param name="dailyWriteCap">
        /// Documents the API's write routes may land per UTC day; 10000 when omitted.
        /// </param>
        /// <param name="mcpEnabled">
        /// Serve the routes as an MCP server at `POST &lt;base_url&gt;/mcp` too;<br/>
        /// false when omitted. Refused with `auth_mode: public` (400<br/>
        /// `validation_failed` naming `mcp_enabled`).
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="userTokenJwksUrl">
        /// Register the key set end-user tokens are verified against (an `https` URL on a public host).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPI> CreateAsync(
            string slug,
            string name,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? description = default,
            global::Speechify.CreateHostedApiRequestAuthMode? authMode = default,
            global::System.Collections.Generic.IList<string>? corsOrigins = default,
            int? dailyRunCap = default,
            int? dailyReadCap = default,
            int? dailyWriteCap = default,
            bool? mcpEnabled = default,
            string? projectId = default,
            string? userTokenJwksUrl = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}