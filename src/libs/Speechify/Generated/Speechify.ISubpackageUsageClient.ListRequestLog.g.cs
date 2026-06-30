#nullable enable

namespace Speechify
{
    public partial interface ISubpackageUsageClient
    {
        /// <summary>
        /// List Request Log<br/>
        /// The workspace Request Log: one row per API request (time, method,<br/>
        /// route, path, status, latency, and the resolving principal), newest<br/>
        /// first. Tenant-scoped server-side and gated on the `usage.view`<br/>
        /// permission (owner / admin / billing_admin). Sourced from the request<br/>
        /// traces. Every filter is optional; the tenant is derived from the<br/>
        /// session, never a query parameter. Cursor-paginated by request time:<br/>
        /// omit `cursor` for the first page and walk while `has_more` is true<br/>
        /// (default page size 50, max 200). Default range is the last 7 days,<br/>
        /// capped at 30 days.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="method"></param>
        /// <param name="status"></param>
        /// <param name="path"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="principalType"></param>
        /// <param name="minLatencyMs"></param>
        /// <param name="maxLatencyMs"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RequestLogResponse> ListRequestLogAsync(
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::System.Collections.Generic.IList<global::Speechify.V1UsageRequestsGetParametersMethodSchemaItems>? method = default,
            global::System.Collections.Generic.IList<int>? status = default,
            string? path = default,
            string? userId = default,
            string? apiKeyId = default,
            global::Speechify.V1UsageRequestsGetParametersPrincipalType? principalType = default,
            int? minLatencyMs = default,
            int? maxLatencyMs = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Request Log<br/>
        /// The workspace Request Log: one row per API request (time, method,<br/>
        /// route, path, status, latency, and the resolving principal), newest<br/>
        /// first. Tenant-scoped server-side and gated on the `usage.view`<br/>
        /// permission (owner / admin / billing_admin). Sourced from the request<br/>
        /// traces. Every filter is optional; the tenant is derived from the<br/>
        /// session, never a query parameter. Cursor-paginated by request time:<br/>
        /// omit `cursor` for the first page and walk while `has_more` is true<br/>
        /// (default page size 50, max 200). Default range is the last 7 days,<br/>
        /// capped at 30 days.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="method"></param>
        /// <param name="status"></param>
        /// <param name="path"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="principalType"></param>
        /// <param name="minLatencyMs"></param>
        /// <param name="maxLatencyMs"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RequestLogResponse>> ListRequestLogAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::System.Collections.Generic.IList<global::Speechify.V1UsageRequestsGetParametersMethodSchemaItems>? method = default,
            global::System.Collections.Generic.IList<int>? status = default,
            string? path = default,
            string? userId = default,
            string? apiKeyId = default,
            global::Speechify.V1UsageRequestsGetParametersPrincipalType? principalType = default,
            int? minLatencyMs = default,
            int? maxLatencyMs = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}