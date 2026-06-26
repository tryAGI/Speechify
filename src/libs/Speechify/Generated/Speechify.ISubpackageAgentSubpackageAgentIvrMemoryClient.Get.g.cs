#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentIvrMemoryClient
    {
        /// <summary>
        /// Get IVR Menu<br/>
        /// Fetch one menu's full shape. Returns 404 for missing,<br/>
        /// soft-deleted, or foreign-tenant menus — existence information<br/>
        /// is never leaked across tenants.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.IVRMenu> GetAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get IVR Menu<br/>
        /// Fetch one menu's full shape. Returns 404 for missing,<br/>
        /// soft-deleted, or foreign-tenant menus — existence information<br/>
        /// is never leaked across tenants.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.IVRMenu>> GetAsResponseAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}