
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).<br/>
        /// This is the sole customer-facing<br/>
        /// identifier. URL paths accept only this prefixed form; legacy<br/>
        /// UUID path parameters are rejected with 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Spoken verbatim at session start when present in the customer's flow graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstMessage { get; set; }

        /// <summary>
        /// ISO 639-1 code, e.g. 'en'. The agent's default language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Extra languages this agent serves in the same session beyond<br/>
        /// its default `language`. When non-empty the agent can switch<br/>
        /// language mid-call (triggered when the caller speaks one of<br/>
        /// these languages or asks for it). Always present on reads;<br/>
        /// empty array for single-language agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_languages")]
        public global::System.Collections.Generic.IList<global::Speechify.AgentAdditionalLanguage>? AdditionalLanguages { get; set; }

        /// <summary>
        /// Language-model configuration. Omit the whole block on create to<br/>
        /// run on the platform default model. On update (merge-patch) send<br/>
        /// only the sub-fields you want to change: an explicit null clears a<br/>
        /// nullable field to its default, a value sets it, and anything<br/>
        /// omitted is left unchanged. `provider`/`model` are validated as a<br/>
        /// pair, inheriting the omitted half from the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentLLMConfig Llm { get; set; }

        /// <summary>
        /// Text-to-speech voice and delivery configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentTTSConfig Tts { get; set; }

        /// <summary>
        /// Speech-to-text configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentSTTConfig Stt { get; set; }

        /// <summary>
        /// Turn-handling and silence-timeout configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_handling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentTurnHandlingConfig TurnHandling { get; set; }

        /// <summary>
        /// Per-caller long-term memory configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentMemoryConfig Memory { get; set; }

        /// <summary>
        /// Autonomous IVR-navigation configuration for outbound calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("navigator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentNavigatorConfig Navigator { get; set; }

        /// <summary>
        /// Runtime safety controls that are opt-in per agent rather than<br/>
        /// platform defaults, because each one bills work an ordinary call<br/>
        /// does not do.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentGuardrailsConfig Guardrails { get; set; }

        /// <summary>
        /// Optional ambient background-noise bed mixed into the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentBackgroundNoiseConfig BackgroundNoise { get; set; }

        /// <summary>
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_config")]
        public global::Speechify.WidgetConfig? WidgetConfig { get; set; }

        /// <summary>
        /// When true, the `&lt;speechify-agent&gt;` web component can start a<br/>
        /// session against this agent without an API key, subject to<br/>
        /// the `allowed_origins` allowlist. When false (default), only<br/>
        /// authenticated callers can start sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// Exact `Origin` header values (e.g. `https://example.com`)<br/>
        /// that are allowed to start public sessions. Empty array<br/>
        /// with `is_public = true` means any origin is accepted —<br/>
        /// intended for open demos. No subdomain wildcards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Optional per-agent hostname allowlist enforced at<br/>
        /// session-creation time. When set and non-empty, the<br/>
        /// `Origin` header's hostname must be an exact member.<br/>
        /// Bare hostnames only — no scheme, port, or path. Up to<br/>
        /// 10 entries. Omit (null) or leave empty for no<br/>
        /// enforcement (public agents accept any hostname).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        /// Per-agent override of the workspace webhook endpoints for this<br/>
        /// agent's post-call event. When non-empty, the control plane POSTs the<br/>
        /// standard signed `WebhookEvent` envelope here once the conversation<br/>
        /// completes. This is the same shape workspace endpoints receive:<br/>
        /// `data.object` is the completed Conversation (equal to a direct GET),<br/>
        /// with the full transcript under `data.messages` and evaluations +<br/>
        /// data extractors under `data.evaluations`. The workspace endpoints'<br/>
        /// `conversation.completed` is suppressed for this agent (the override<br/>
        /// wins, so the two planes no longer both fire). Empty routes<br/>
        /// `conversation.completed` to your workspace webhook endpoints instead.<br/>
        /// `conversation.started` / `conversation.failed` always ride the<br/>
        /// workspace endpoints regardless of this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// True when an HMAC-SHA256 webhook secret is configured. The<br/>
        /// secret itself is write-only — supplied on PATCH and never<br/>
        /// echoed back on reads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret_set")]
        public bool? WebhookSecretSet { get; set; }

        /// <summary>
        /// Answering Machine Detection routing config for outbound voice<br/>
        /// agents. AMD classifies the called party's first ~3-15 seconds of<br/>
        /// audio into one of LiveKit's categories (human, uncertain,<br/>
        /// machine-vm, machine-ivr, machine-unavailable) and dispatches per<br/>
        /// category to the configured action. Stored on the agent row;<br/>
        /// flowed onto outbound dispatch metadata under the `amd` key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AMDConfig Amd { get; set; }

        /// <summary>
        /// Hard cap on the wall-clock length of a single call on this<br/>
        /// agent, in seconds. When a call reaches it the agent ends the<br/>
        /// call automatically. Voice agents only. Null means no<br/>
        /// per-agent cap: the call is bounded only by your plan's call<br/>
        /// ceiling, which is also the hard upper bound for this field -<br/>
        /// a value above it is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_seconds")]
        public int? MaxCallDurationSeconds { get; set; }

        /// <summary>
        /// When true, every conversation produces a room-composite<br/>
        /// OGG egress uploaded to the recordings bucket. Defaults<br/>
        /// FALSE for new agents (privacy by default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_audio_recording")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SaveAudioRecording { get; set; }

        /// <summary>
        /// Workspace project this resource lives in (prefixed external<br/>
        /// id). Null means the implicit Default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).<br/>
        /// This is the sole customer-facing<br/>
        /// identifier. URL paths accept only this prefixed form; legacy<br/>
        /// UUID path parameters are rejected with 404.
        /// </param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage">
        /// Spoken verbatim at session start when present in the customer's flow graph.
        /// </param>
        /// <param name="language">
        /// ISO 639-1 code, e.g. 'en'. The agent's default language.
        /// </param>
        /// <param name="llm">
        /// Language-model configuration. Omit the whole block on create to<br/>
        /// run on the platform default model. On update (merge-patch) send<br/>
        /// only the sub-fields you want to change: an explicit null clears a<br/>
        /// nullable field to its default, a value sets it, and anything<br/>
        /// omitted is left unchanged. `provider`/`model` are validated as a<br/>
        /// pair, inheriting the omitted half from the stored value.
        /// </param>
        /// <param name="tts">
        /// Text-to-speech voice and delivery configuration.
        /// </param>
        /// <param name="stt">
        /// Speech-to-text configuration.
        /// </param>
        /// <param name="turnHandling">
        /// Turn-handling and silence-timeout configuration.
        /// </param>
        /// <param name="memory">
        /// Per-caller long-term memory configuration.
        /// </param>
        /// <param name="navigator">
        /// Autonomous IVR-navigation configuration for outbound calls.
        /// </param>
        /// <param name="guardrails">
        /// Runtime safety controls that are opt-in per agent rather than<br/>
        /// platform defaults, because each one bills work an ordinary call<br/>
        /// does not do.
        /// </param>
        /// <param name="backgroundNoise">
        /// Optional ambient background-noise bed mixed into the call.
        /// </param>
        /// <param name="isPublic">
        /// When true, the `&lt;speechify-agent&gt;` web component can start a<br/>
        /// session against this agent without an API key, subject to<br/>
        /// the `allowed_origins` allowlist. When false (default), only<br/>
        /// authenticated callers can start sessions.
        /// </param>
        /// <param name="allowedOrigins">
        /// Exact `Origin` header values (e.g. `https://example.com`)<br/>
        /// that are allowed to start public sessions. Empty array<br/>
        /// with `is_public = true` means any origin is accepted —<br/>
        /// intended for open demos. No subdomain wildcards.
        /// </param>
        /// <param name="amd">
        /// Answering Machine Detection routing config for outbound voice<br/>
        /// agents. AMD classifies the called party's first ~3-15 seconds of<br/>
        /// audio into one of LiveKit's categories (human, uncertain,<br/>
        /// machine-vm, machine-ivr, machine-unavailable) and dispatches per<br/>
        /// category to the configured action. Stored on the agent row;<br/>
        /// flowed onto outbound dispatch metadata under the `amd` key.
        /// </param>
        /// <param name="saveAudioRecording">
        /// When true, every conversation produces a room-composite<br/>
        /// OGG egress uploaded to the recordings bucket. Defaults<br/>
        /// FALSE for new agents (privacy by default).
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="additionalLanguages">
        /// Extra languages this agent serves in the same session beyond<br/>
        /// its default `language`. When non-empty the agent can switch<br/>
        /// language mid-call (triggered when the caller speaks one of<br/>
        /// these languages or asks for it). Always present on reads;<br/>
        /// empty array for single-language agents.
        /// </param>
        /// <param name="widgetConfig">
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </param>
        /// <param name="hostnameAllowlist">
        /// Optional per-agent hostname allowlist enforced at<br/>
        /// session-creation time. When set and non-empty, the<br/>
        /// `Origin` header's hostname must be an exact member.<br/>
        /// Bare hostnames only — no scheme, port, or path. Up to<br/>
        /// 10 entries. Omit (null) or leave empty for no<br/>
        /// enforcement (public agents accept any hostname).
        /// </param>
        /// <param name="webhookUrl">
        /// Per-agent override of the workspace webhook endpoints for this<br/>
        /// agent's post-call event. When non-empty, the control plane POSTs the<br/>
        /// standard signed `WebhookEvent` envelope here once the conversation<br/>
        /// completes. This is the same shape workspace endpoints receive:<br/>
        /// `data.object` is the completed Conversation (equal to a direct GET),<br/>
        /// with the full transcript under `data.messages` and evaluations +<br/>
        /// data extractors under `data.evaluations`. The workspace endpoints'<br/>
        /// `conversation.completed` is suppressed for this agent (the override<br/>
        /// wins, so the two planes no longer both fire). Empty routes<br/>
        /// `conversation.completed` to your workspace webhook endpoints instead.<br/>
        /// `conversation.started` / `conversation.failed` always ride the<br/>
        /// workspace endpoints regardless of this field.
        /// </param>
        /// <param name="webhookSecretSet">
        /// True when an HMAC-SHA256 webhook secret is configured. The<br/>
        /// secret itself is write-only — supplied on PATCH and never<br/>
        /// echoed back on reads.
        /// </param>
        /// <param name="maxCallDurationSeconds">
        /// Hard cap on the wall-clock length of a single call on this<br/>
        /// agent, in seconds. When a call reaches it the agent ends the<br/>
        /// call automatically. Voice agents only. Null means no<br/>
        /// per-agent cap: the call is bounded only by your plan's call<br/>
        /// ceiling, which is also the hard upper bound for this field -<br/>
        /// a value above it is rejected.
        /// </param>
        /// <param name="projectId">
        /// Workspace project this resource lives in (prefixed external<br/>
        /// id). Null means the implicit Default project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Agent(
            string id,
            string name,
            string slug,
            string prompt,
            string firstMessage,
            string language,
            global::Speechify.AgentLLMConfig llm,
            global::Speechify.AgentTTSConfig tts,
            global::Speechify.AgentSTTConfig stt,
            global::Speechify.AgentTurnHandlingConfig turnHandling,
            global::Speechify.AgentMemoryConfig memory,
            global::Speechify.AgentNavigatorConfig navigator,
            global::Speechify.AgentGuardrailsConfig guardrails,
            global::Speechify.AgentBackgroundNoiseConfig backgroundNoise,
            bool isPublic,
            global::System.Collections.Generic.IList<string> allowedOrigins,
            global::Speechify.AMDConfig amd,
            bool saveAudioRecording,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Speechify.AgentAdditionalLanguage>? additionalLanguages,
            global::Speechify.WidgetConfig? widgetConfig,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist,
            string? webhookUrl,
            bool? webhookSecretSet,
            int? maxCallDurationSeconds,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.FirstMessage = firstMessage ?? throw new global::System.ArgumentNullException(nameof(firstMessage));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.AdditionalLanguages = additionalLanguages;
            this.Llm = llm ?? throw new global::System.ArgumentNullException(nameof(llm));
            this.Tts = tts ?? throw new global::System.ArgumentNullException(nameof(tts));
            this.Stt = stt ?? throw new global::System.ArgumentNullException(nameof(stt));
            this.TurnHandling = turnHandling ?? throw new global::System.ArgumentNullException(nameof(turnHandling));
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.Navigator = navigator ?? throw new global::System.ArgumentNullException(nameof(navigator));
            this.Guardrails = guardrails ?? throw new global::System.ArgumentNullException(nameof(guardrails));
            this.BackgroundNoise = backgroundNoise ?? throw new global::System.ArgumentNullException(nameof(backgroundNoise));
            this.WidgetConfig = widgetConfig;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins ?? throw new global::System.ArgumentNullException(nameof(allowedOrigins));
            this.HostnameAllowlist = hostnameAllowlist;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecretSet = webhookSecretSet;
            this.Amd = amd ?? throw new global::System.ArgumentNullException(nameof(amd));
            this.MaxCallDurationSeconds = maxCallDurationSeconds;
            this.SaveAudioRecording = saveAudioRecording;
            this.ProjectId = projectId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }

    }
}