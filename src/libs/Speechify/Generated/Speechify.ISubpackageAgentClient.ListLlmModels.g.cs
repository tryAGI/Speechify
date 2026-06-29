#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List LLM Models<br/>
        /// List the LLM models selectable for voice agents on the caller's<br/>
        /// workspace plan. Premium flagship models and the bring-your-own<br/>
        /// custom endpoint are available only on higher plans; lower plans<br/>
        /// receive the managed and standard models. Drive a model picker from<br/>
        /// this response so it only offers models that POST/PATCH /v1/agents<br/>
        /// will accept. Returns the full set in a single<br/>
        /// response: bounded by the platform's curated model catalogue, so this<br/>
        /// list is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.LLMModelsResponse> ListLlmModelsAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List LLM Models<br/>
        /// List the LLM models selectable for voice agents on the caller's<br/>
        /// workspace plan. Premium flagship models and the bring-your-own<br/>
        /// custom endpoint are available only on higher plans; lower plans<br/>
        /// receive the managed and standard models. Drive a model picker from<br/>
        /// this response so it only offers models that POST/PATCH /v1/agents<br/>
        /// will accept. Returns the full set in a single<br/>
        /// response: bounded by the platform's curated model catalogue, so this<br/>
        /// list is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.LLMModelsResponse>> ListLlmModelsAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}