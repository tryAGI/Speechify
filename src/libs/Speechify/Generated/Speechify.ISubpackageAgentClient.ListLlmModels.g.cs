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
        /// receive the managed and standard models. The console renders its<br/>
        /// model picker from this response so it only offers models that<br/>
        /// POST/PATCH /v1/agents will accept.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.LLMModelsResponse> ListLlmModelsAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List LLM Models<br/>
        /// List the LLM models selectable for voice agents on the caller's<br/>
        /// workspace plan. Premium flagship models and the bring-your-own<br/>
        /// custom endpoint are available only on higher plans; lower plans<br/>
        /// receive the managed and standard models. The console renders its<br/>
        /// model picker from this response so it only offers models that<br/>
        /// POST/PATCH /v1/agents will accept.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.LLMModelsResponse>> ListLlmModelsAsResponseAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}