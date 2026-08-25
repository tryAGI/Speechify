#nullable enable

namespace Speechify
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List Voices<br/>
        /// Lists the voices available to the caller - the shared voice<br/>
        /// catalog plus the cloned voices they can reach, whichever member or<br/>
        /// service-account key created them. A clone filed under a project is<br/>
        /// listed only for a caller who can reach that project; a clone no<br/>
        /// project filed is shared with the whole workspace and is listed for<br/>
        /// everyone in it. By default<br/>
        /// the full catalogue is returned in one response. Pagination is<br/>
        /// opt-in: pass `limit` (and then `cursor` from the previous<br/>
        /// response) to page through the list while `has_more` is true. Max<br/>
        /// page size is 200. Narrow the list with the `type` and `locale`<br/>
        /// filters.<br/>
        /// A page can come back with fewer than `limit` voices, and a short<br/>
        /// page - an empty one included - is not the end of the list. Keep<br/>
        /// following `next_cursor` while `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="type"></param>
        /// <param name="locale"></param>
        /// <param name="gender"></param>
        /// <param name="model"></param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListVoicesResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            global::Speechify.V1VoicesGetParametersType? type = default,
            string? locale = default,
            global::Speechify.V1VoicesGetParametersGender? gender = default,
            string? model = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Voices<br/>
        /// Lists the voices available to the caller - the shared voice<br/>
        /// catalog plus the cloned voices they can reach, whichever member or<br/>
        /// service-account key created them. A clone filed under a project is<br/>
        /// listed only for a caller who can reach that project; a clone no<br/>
        /// project filed is shared with the whole workspace and is listed for<br/>
        /// everyone in it. By default<br/>
        /// the full catalogue is returned in one response. Pagination is<br/>
        /// opt-in: pass `limit` (and then `cursor` from the previous<br/>
        /// response) to page through the list while `has_more` is true. Max<br/>
        /// page size is 200. Narrow the list with the `type` and `locale`<br/>
        /// filters.<br/>
        /// A page can come back with fewer than `limit` voices, and a short<br/>
        /// page - an empty one included - is not the end of the list. Keep<br/>
        /// following `next_cursor` while `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="type"></param>
        /// <param name="locale"></param>
        /// <param name="gender"></param>
        /// <param name="model"></param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListVoicesResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::Speechify.V1VoicesGetParametersType? type = default,
            string? locale = default,
            global::Speechify.V1VoicesGetParametersGender? gender = default,
            string? model = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}