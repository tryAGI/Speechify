#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentIvrMemoryClient
    {
        /// <summary>
        /// Update IVR Menu Option Label<br/>
        /// Re-label one option in the stored menu_tree, matched on the<br/>
        /// supplied DTMF value. The label is what the console displays in<br/>
        /// the detail panel and what the worker reads back at navigate<br/>
        /// time to surface the option semantically. Unknown DTMF values<br/>
        /// are a no-op (the response echoes the unchanged menu).
        /// </summary>
        /// <param name="ivrMenuId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.IVRMenu> UpdateLabelAsync(
            string ivrMenuId,

            global::Speechify.UpdateIVRMenuLabelRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update IVR Menu Option Label<br/>
        /// Re-label one option in the stored menu_tree, matched on the<br/>
        /// supplied DTMF value. The label is what the console displays in<br/>
        /// the detail panel and what the worker reads back at navigate<br/>
        /// time to surface the option semantically. Unknown DTMF values<br/>
        /// are a no-op (the response echoes the unchanged menu).
        /// </summary>
        /// <param name="ivrMenuId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.IVRMenu>> UpdateLabelAsResponseAsync(
            string ivrMenuId,

            global::Speechify.UpdateIVRMenuLabelRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update IVR Menu Option Label<br/>
        /// Re-label one option in the stored menu_tree, matched on the<br/>
        /// supplied DTMF value. The label is what the console displays in<br/>
        /// the detail panel and what the worker reads back at navigate<br/>
        /// time to surface the option semantically. Unknown DTMF values<br/>
        /// are a no-op (the response echoes the unchanged menu).
        /// </summary>
        /// <param name="ivrMenuId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="dtmf">
        /// DTMF value of the option to relabel (e.g. "1", "*", "#").
        /// </param>
        /// <param name="label">
        /// New label. Capped at 256 chars server-side.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.IVRMenu> UpdateLabelAsync(
            string ivrMenuId,
            string dtmf,
            string label,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}