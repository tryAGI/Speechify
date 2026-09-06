#nullable enable

namespace Speechify
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Workspace Entitlements<br/>
        /// The per-tier entitlements catalog plus the caller's RESOLVED entitlements<br/>
        /// for the current workspace (tier defaults composed with any per-tenant<br/>
        /// override). Readable with an API key as well as a console session: it is<br/>
        /// how an integration learns what it may use before a feature endpoint<br/>
        /// answers `402`. Branch on `current.durable_runs_access`,<br/>
        /// `current.text_agent_access`, `current.hosted_apis_access` and<br/>
        /// `current.skills_access`, and size a run from `current.max_run_turns`.<br/>
        /// The console renders quota affordances and upgrade-card limits from the<br/>
        /// same single server-authoritative source instead of a hardcoded mirror.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.EntitlementsResponse> GetEntitlementsAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Workspace Entitlements<br/>
        /// The per-tier entitlements catalog plus the caller's RESOLVED entitlements<br/>
        /// for the current workspace (tier defaults composed with any per-tenant<br/>
        /// override). Readable with an API key as well as a console session: it is<br/>
        /// how an integration learns what it may use before a feature endpoint<br/>
        /// answers `402`. Branch on `current.durable_runs_access`,<br/>
        /// `current.text_agent_access`, `current.hosted_apis_access` and<br/>
        /// `current.skills_access`, and size a run from `current.max_run_turns`.<br/>
        /// The console renders quota affordances and upgrade-card limits from the<br/>
        /// same single server-authoritative source instead of a hardcoded mirror.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.EntitlementsResponse>> GetEntitlementsAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}