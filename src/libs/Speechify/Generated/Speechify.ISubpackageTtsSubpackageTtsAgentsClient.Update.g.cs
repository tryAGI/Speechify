#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Update Agent<br/>
        /// Update a voice agent. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> UpdateAsync(
            string id,

            global::Speechify.TtsUpdateAgentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent<br/>
        /// Update a voice agent. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsAgent>> UpdateAsResponseAsync(
            string id,

            global::Speechify.TtsUpdateAgentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent<br/>
        /// Update a voice agent. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="language"></param>
        /// <param name="llmProvider">
        /// LLM backend. Send an empty string together with<br/>
        /// `llm_model: ""` to clear the pair to the platform default<br/>
        /// (today: Speechify Kimi K2.6). Sending one populated and<br/>
        /// one empty is rejected as a 400. Omit both to leave the<br/>
        /// stored pair unchanged. Switching to a non-`custom` provider<br/>
        /// clears any stored `llm_base_url` / `llm_api_key` /<br/>
        /// `llm_extra_body`.
        /// </param>
        /// <param name="llmModel">
        /// Chat model slug. Empty string + empty `llm_provider`<br/>
        /// clears the pair to the platform default. For `openai` /<br/>
        /// `speechify` the (provider, model) pair must be in the<br/>
        /// allowed table; for `custom` it is free-form.
        /// </param>
        /// <param name="llmBaseUrl">
        /// Custom-endpoint base URL. Required when the resulting<br/>
        /// provider is `custom`, rejected otherwise.
        /// </param>
        /// <param name="llmApiKey">
        /// Bearer key for the custom endpoint. Write-only. Omit to<br/>
        /// keep the stored key, send "" to clear it, send a value to<br/>
        /// replace it. Rejected for non-`custom` providers.
        /// </param>
        /// <param name="llmExtraBody">
        /// JSON object forwarded to the custom endpoint as<br/>
        /// chat.completions `extra_body`. Omit to leave unchanged;<br/>
        /// a JSON object (including `{}`) replaces it. Valid only<br/>
        /// when the resulting provider is `custom`.
        /// </param>
        /// <param name="voiceId"></param>
        /// <param name="temperature"></param>
        /// <param name="widgetConfig">
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </param>
        /// <param name="isPublic"></param>
        /// <param name="allowedOrigins"></param>
        /// <param name="hostnameAllowlist">
        /// When supplied, replaces the stored list. Pass an empty<br/>
        /// array to clear enforcement (public agent is open again).<br/>
        /// Omit the field to leave the existing value unchanged.
        /// </param>
        /// <param name="memoryEnabled"></param>
        /// <param name="memoryRetentionDays"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookSecret">
        /// Rotate the HMAC secret. Write-only.
        /// </param>
        /// <param name="amd">
        /// AMD routing config (PATCH-replace, wholesale). Omit to leave the stored config unchanged.
        /// </param>
        /// <param name="saveAudioRecording"></param>
        /// <param name="navigatorMode"></param>
        /// <param name="ivrMemoryEnabled">
        /// Per-agent kill switch for the IVR-memory cache lookup. nil/omit = unchanged.
        /// </param>
        /// <param name="ttsSpeakingRate"></param>
        /// <param name="clearTtsSpeakingRate">
        /// Two-headed clear: PATCH cannot distinguish "absent" from<br/>
        /// "explicit null" reliably across stacks. Setting this to<br/>
        /// `true` resets `tts_speaking_rate` to the voice default.<br/>
        /// If both are sent, `clear_tts_speaking_rate` wins.
        /// </param>
        /// <param name="ttsPlaybackRate"></param>
        /// <param name="clearTtsPlaybackRate">
        /// Two-headed clear, mirroring `clear_tts_speaking_rate`.<br/>
        /// Setting this to `true` resets `tts_playback_rate` to null<br/>
        /// (no post-process). If both fields are sent,<br/>
        /// `clear_tts_playback_rate` wins.
        /// </param>
        /// <param name="responseDelaySeconds">
        /// Per-agent silence-wait override (seconds). See the field<br/>
        /// on Agent for semantics. Range 0.0..5.0; null is allowed<br/>
        /// but `clear_response_delay_seconds=true` is the canonical<br/>
        /// way to revert to the stack default.
        /// </param>
        /// <param name="clearResponseDelaySeconds">
        /// Two-headed clear, mirroring `clear_tts_playback_rate`.<br/>
        /// Setting this to `true` resets `response_delay_seconds` to<br/>
        /// null (revert to the stack default). If both are sent,<br/>
        /// `clear_response_delay_seconds` wins.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// Per-agent silence-tolerance override. Send `0` to clear<br/>
        /// the override and fall back to the platform default.<br/>
        /// Negative values are rejected.
        /// </param>
        /// <param name="backgroundNoisePreset">
        /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
        /// disable the bed, which also clears `background_noise_volume`.
        /// </param>
        /// <param name="backgroundNoiseVolume">
        /// Volume of the background-noise bed (0..1). Ignored when<br/>
        /// the preset is empty; clearing the preset also clears<br/>
        /// this field server-side.
        /// </param>
        /// <param name="sttOverride">
        /// Streaming-STT stack override. Send an empty string ("") to<br/>
        /// clear the override and fall back to the worker default<br/>
        /// (today: whisper-v3). Any non-empty value must be a known<br/>
        /// stack name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> UpdateAsync(
            string id,
            string? name = default,
            string? prompt = default,
            string? firstMessage = default,
            string? language = default,
            global::Speechify.TtsUpdateAgentRequestLlmProvider? llmProvider = default,
            string? llmModel = default,
            string? llmBaseUrl = default,
            string? llmApiKey = default,
            object? llmExtraBody = default,
            string? voiceId = default,
            double? temperature = default,
            global::Speechify.TtsWidgetConfig? widgetConfig = default,
            bool? isPublic = default,
            global::System.Collections.Generic.IList<string>? allowedOrigins = default,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist = default,
            bool? memoryEnabled = default,
            int? memoryRetentionDays = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::Speechify.TtsAMDConfig? amd = default,
            bool? saveAudioRecording = default,
            bool? navigatorMode = default,
            bool? ivrMemoryEnabled = default,
            double? ttsSpeakingRate = default,
            bool? clearTtsSpeakingRate = default,
            double? ttsPlaybackRate = default,
            bool? clearTtsPlaybackRate = default,
            double? responseDelaySeconds = default,
            bool? clearResponseDelaySeconds = default,
            int? inactivityTimeoutSeconds = default,
            string? backgroundNoisePreset = default,
            double? backgroundNoiseVolume = default,
            global::Speechify.TtsUpdateAgentRequestSttOverride? sttOverride = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}