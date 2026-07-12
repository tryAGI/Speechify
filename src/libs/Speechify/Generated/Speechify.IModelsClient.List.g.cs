#nullable enable

namespace Speechify
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Models<br/>
        /// List the text-to-speech models available for synthesis. Drive a model<br/>
        /// picker from this response, then pass a model `id` as the `model`<br/>
        /// parameter to POST /v1/audio/speech or /v1/audio/stream. The response<br/>
        /// marks the default model (used when a request omits `model`). Returns<br/>
        /// the full set in a single response: the model catalog is static<br/>
        /// platform reference data, so it is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ModelsResponse> ListAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Models<br/>
        /// List the text-to-speech models available for synthesis. Drive a model<br/>
        /// picker from this response, then pass a model `id` as the `model`<br/>
        /// parameter to POST /v1/audio/speech or /v1/audio/stream. The response<br/>
        /// marks the default model (used when a request omits `model`). Returns<br/>
        /// the full set in a single response: the model catalog is static<br/>
        /// platform reference data, so it is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ModelsResponse>> ListAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}