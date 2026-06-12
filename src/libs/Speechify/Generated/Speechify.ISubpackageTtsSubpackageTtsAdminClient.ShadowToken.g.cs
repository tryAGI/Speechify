#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAdminClient
    {
        /// <summary>
        /// Mint shadow-call token<br/>
        /// Mint a listen-only LiveKit access token so an authorized observer<br/>
        /// can join an ongoing voice-agent conversation as a hidden<br/>
        /// participant. Caller must be an `owner` or `admin` of the<br/>
        /// workspace the conversation belongs to. The token cannot publish<br/>
        /// audio or data; the observer is invisible to the caller and the<br/>
        /// agent. Speechify support engineers reach this endpoint the same<br/>
        /// way as any other observer — by being granted the owner/admin<br/>
        /// role on the customer's workspace (typically under an NDA-backed<br/>
        /// support arrangement).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsShadowConversationResponse> ShadowTokenAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mint shadow-call token<br/>
        /// Mint a listen-only LiveKit access token so an authorized observer<br/>
        /// can join an ongoing voice-agent conversation as a hidden<br/>
        /// participant. Caller must be an `owner` or `admin` of the<br/>
        /// workspace the conversation belongs to. The token cannot publish<br/>
        /// audio or data; the observer is invisible to the caller and the<br/>
        /// agent. Speechify support engineers reach this endpoint the same<br/>
        /// way as any other observer — by being granted the owner/admin<br/>
        /// role on the customer's workspace (typically under an NDA-backed<br/>
        /// support arrangement).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsShadowConversationResponse>> ShadowTokenAsResponseAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}