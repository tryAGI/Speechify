#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// List Agent TTS Models<br/>
        /// List the Simba text-to-speech models a voice agent can be pinned to<br/>
        /// with `tts.model`.<br/>
        /// The response is the whole catalog and is the same for every<br/>
        /// workspace - which model serves an agent is a routing decision, not<br/>
        /// an entitlement, so nothing here is plan-gated. Whether a *particular*<br/>
        /// agent may select an entry depends on two facts this response<br/>
        /// publishes rather than resolving for you, because both change without<br/>
        /// this list changing:<br/>
        /// - `english_only` - the model has no multilingual deployment, so an<br/>
        ///   agent that declares `additional_languages` (or whose `language` is<br/>
        ///   not English) cannot select it.<br/>
        /// - `requires_voice_curation` - a voice must be registered for the<br/>
        ///   model before it can be selected with that voice. The voice's<br/>
        ///   `models` array on GET /v1/agents/voices is the per-voice answer,<br/>
        ///   and it changes as voices are curated, with no release here.<br/>
        /// Drive a model picker from this and the voice catalog together and it<br/>
        /// can only offer combinations POST/PATCH /v1/agents will accept.<br/>
        /// Returns the full set in one response: bounded by the platform's<br/>
        /// curated model catalog, so it is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTTSModelsResponse> ListTTSModelsAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent TTS Models<br/>
        /// List the Simba text-to-speech models a voice agent can be pinned to<br/>
        /// with `tts.model`.<br/>
        /// The response is the whole catalog and is the same for every<br/>
        /// workspace - which model serves an agent is a routing decision, not<br/>
        /// an entitlement, so nothing here is plan-gated. Whether a *particular*<br/>
        /// agent may select an entry depends on two facts this response<br/>
        /// publishes rather than resolving for you, because both change without<br/>
        /// this list changing:<br/>
        /// - `english_only` - the model has no multilingual deployment, so an<br/>
        ///   agent that declares `additional_languages` (or whose `language` is<br/>
        ///   not English) cannot select it.<br/>
        /// - `requires_voice_curation` - a voice must be registered for the<br/>
        ///   model before it can be selected with that voice. The voice's<br/>
        ///   `models` array on GET /v1/agents/voices is the per-voice answer,<br/>
        ///   and it changes as voices are curated, with no release here.<br/>
        /// Drive a model picker from this and the voice catalog together and it<br/>
        /// can only offer combinations POST/PATCH /v1/agents will accept.<br/>
        /// Returns the full set in one response: bounded by the platform's<br/>
        /// curated model catalog, so it is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTTSModelsResponse>> ListTTSModelsAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}