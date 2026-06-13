#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> CreateAsync(

            global::Speechify.TtsCreateAgentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsAgent>> CreateAsResponseAsync(

            global::Speechify.TtsCreateAgentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage">
        /// Greeting spoken verbatim at session start when included in the agent's flow graph.
        /// </param>
        /// <param name="language">
        /// ISO 639-1 code. Defaults to 'en' when omitted.
        /// </param>
        /// <param name="llmProvider">
        /// LLM backend. Leave empty (or omit both `llm_provider` and<br/>
        /// `llm_model`) to use the platform default (today: Speechify<br/>
        /// Kimi K2.6, resolved server-side at dispatch). When set,<br/>
        /// must be paired with a non-empty `llm_model`; mixing a<br/>
        /// populated provider with an empty model is rejected as a<br/>
        /// 400. `custom` additionally requires `llm_base_url`.
        /// </param>
        /// <param name="llmModel">
        /// Chat model slug. Leave empty to use the platform default.<br/>
        /// For `openai` / `speechify` the (provider, model) pair must<br/>
        /// be in the allowed table; for `custom` it is free-form.
        /// </param>
        /// <param name="llmBaseUrl">
        /// Custom OpenAI/vLLM-compatible endpoint base URL. Required<br/>
        /// when `llm_provider` is `custom`, rejected otherwise.
        /// </param>
        /// <param name="llmApiKey">
        /// Bearer key for the custom endpoint. Write-only - stored<br/>
        /// encrypted, never returned (GET exposes `llm_api_key_set`).<br/>
        /// Optional even for `custom` (keyless endpoints); rejected<br/>
        /// for any other provider.
        /// </param>
        /// <param name="llmExtraBody">
        /// Optional JSON object forwarded verbatim to the custom<br/>
        /// endpoint as the chat.completions `extra_body` (reasoning /<br/>
        /// sampling knobs). Valid only when `llm_provider` is<br/>
        /// `custom`.
        /// </param>
        /// <param name="voiceId">
        /// Voice slug from the VMS catalog (see GET /v1/voices). Required — the server rejects writes with an unknown or empty slug.
        /// </param>
        /// <param name="temperature">
        /// 0.0..1.0. Defaults to 0.7 when omitted.
        /// </param>
        /// <param name="widgetConfig">
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </param>
        /// <param name="isPublic">
        /// Defaults to false when omitted.
        /// </param>
        /// <param name="allowedOrigins"></param>
        /// <param name="hostnameAllowlist">
        /// Optional per-agent hostname allowlist (see Agent schema).
        /// </param>
        /// <param name="memoryEnabled">
        /// Defaults to false when omitted.
        /// </param>
        /// <param name="memoryRetentionDays">
        /// Defaults to 90 when omitted.
        /// </param>
        /// <param name="webhookUrl">
        /// Customer-facing post-call webhook URL.
        /// </param>
        /// <param name="webhookSecret">
        /// HMAC-SHA256 secret seed. Write-only — never echoed back on<br/>
        /// reads; clients see `webhook_secret_set: true` instead.
        /// </param>
        /// <param name="amd">
        /// AMD routing config. Optional on create; omitted means AMD off. See AMDConfig schema.
        /// </param>
        /// <param name="saveAudioRecording">
        /// When set, opts the agent into per-conversation audio recording. Defaults to false when omitted.
        /// </param>
        /// <param name="navigatorMode">
        /// When set, opts the agent into IVR-tuned turn handling. Defaults to false when omitted.
        /// </param>
        /// <param name="ivrMemoryEnabled">
        /// When omitted, defaults to true. Set to false to opt-out of the IVR-memory cache lookup for this agent.
        /// </param>
        /// <param name="ttsSpeakingRate"></param>
        /// <param name="ttsPlaybackRate">
        /// Post-process pitch-preserving time-stretch on the synthesized<br/>
        /// audio. See the field on Agent for semantics.
        /// </param>
        /// <param name="responseDelaySeconds">
        /// Per-agent override for the worker's endpointing min_delay on<br/>
        /// the VAD path (seconds). See the field on Agent for semantics.<br/>
        /// Range 0.0..5.0; null means use the stack default.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// Per-agent silence-tolerance override in seconds. Send `0`<br/>
        /// to clear the override and fall back to the platform<br/>
        /// default. Negative values are rejected.
        /// </param>
        /// <param name="backgroundNoisePreset">
        /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
        /// disable the bed, which also clears `background_noise_volume`.
        /// </param>
        /// <param name="backgroundNoiseVolume">
        /// Volume of the background-noise bed (0..1). Ignored when<br/>
        /// `background_noise_preset` is empty.
        /// </param>
        /// <param name="sttOverride">
        /// Optional non-default streaming-STT stack for this agent.<br/>
        /// Omit to use the worker's default stack (today: whisper-v3).<br/>
        /// See the Agent schema for the full option semantics.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> CreateAsync(
            string name,
            string voiceId,
            string? slug = default,
            string? prompt = default,
            string? firstMessage = default,
            string? language = default,
            global::Speechify.TtsCreateAgentRequestLlmProvider? llmProvider = default,
            string? llmModel = default,
            string? llmBaseUrl = default,
            string? llmApiKey = default,
            object? llmExtraBody = default,
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
            double? ttsPlaybackRate = default,
            double? responseDelaySeconds = default,
            int? inactivityTimeoutSeconds = default,
            global::Speechify.TtsCreateAgentRequestBackgroundNoisePreset? backgroundNoisePreset = default,
            double? backgroundNoiseVolume = default,
            global::Speechify.TtsCreateAgentRequestSttOverride? sttOverride = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}