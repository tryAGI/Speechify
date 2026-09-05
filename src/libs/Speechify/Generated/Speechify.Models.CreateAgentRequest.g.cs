
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentRequest
    {
        /// <summary>
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// The delivery channels the agent serves. Defaults to `[voice]` when<br/>
        /// omitted. Pass an explicit `[]` for an agent with no front door,<br/>
        /// reached by its triggers only. Serving `voice` requires a<br/>
        /// `tts.voice_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::Speechify.AgentChannel>? Channels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// A short steer for how the agent uses its knowledge bases: what to<br/>
        /// look up first, what never to quote, how to answer when nothing<br/>
        /// matches. It reaches the model as guidance under the prompt and<br/>
        /// shapes the per-turn retrieval query on every channel: live<br/>
        /// calls, text conversations and agent tests. Empty means none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_instruction")]
        public string? KnowledgeInstruction { get; set; }

        /// <summary>
        /// Greeting spoken verbatim at session start when included in the agent's flow graph. Omit for an agent with no channels, which opens no live turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// ISO 639-1 code. Defaults to 'en' when omitted. The agent's default language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Extra languages this agent serves in the same session.<br/>
        /// Each entry's language must be supported, unique, and<br/>
        /// different from the default `language`.
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
        public global::Speechify.AgentLLMConfig? Llm { get; set; }

        /// <summary>
        /// Text-to-speech voice and delivery configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::Speechify.AgentTTSConfig? Tts { get; set; }

        /// <summary>
        /// Turn-handling and silence-timeout configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_handling")]
        public global::Speechify.AgentTurnHandlingConfig? TurnHandling { get; set; }

        /// <summary>
        /// Per-caller long-term memory configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Speechify.AgentMemoryConfig? Memory { get; set; }

        /// <summary>
        /// Autonomous IVR-navigation configuration for outbound calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("navigator")]
        public global::Speechify.AgentNavigatorConfig? Navigator { get; set; }

        /// <summary>
        /// Runtime safety controls that are opt-in per agent rather than<br/>
        /// platform defaults, because each one bills work an ordinary call<br/>
        /// does not do.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        public global::Speechify.AgentGuardrailsConfig? Guardrails { get; set; }

        /// <summary>
        /// Optional ambient background-noise bed mixed into the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise")]
        public global::Speechify.AgentBackgroundNoiseConfig? BackgroundNoise { get; set; }

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
        /// Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// Optional per-agent hostname allowlist (see Agent schema).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        /// Customer-facing post-call webhook URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// HMAC-SHA256 secret seed. Write-only — never echoed back on<br/>
        /// reads; clients see `webhook_secret_set: true` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// AMD routing config. Optional on create; omitted means AMD off. See AMDConfig schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd")]
        public global::Speechify.AMDConfig? Amd { get; set; }

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
        /// When set, opts the agent into per-conversation audio recording. Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_audio_recording")]
        public bool? SaveAudioRecording { get; set; }

        /// <summary>
        /// Opt-in AI-disclosure opening line. Optional on create; omitted means off. See AIDisclosure schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_disclosure")]
        public global::Speechify.AIDisclosure? AiDisclosure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="slug">
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </param>
        /// <param name="channels">
        /// The delivery channels the agent serves. Defaults to `[voice]` when<br/>
        /// omitted. Pass an explicit `[]` for an agent with no front door,<br/>
        /// reached by its triggers only. Serving `voice` requires a<br/>
        /// `tts.voice_id`.
        /// </param>
        /// <param name="knowledgeInstruction">
        /// A short steer for how the agent uses its knowledge bases: what to<br/>
        /// look up first, what never to quote, how to answer when nothing<br/>
        /// matches. It reaches the model as guidance under the prompt and<br/>
        /// shapes the per-turn retrieval query on every channel: live<br/>
        /// calls, text conversations and agent tests. Empty means none.
        /// </param>
        /// <param name="firstMessage">
        /// Greeting spoken verbatim at session start when included in the agent's flow graph. Omit for an agent with no channels, which opens no live turn.
        /// </param>
        /// <param name="language">
        /// ISO 639-1 code. Defaults to 'en' when omitted. The agent's default language.
        /// </param>
        /// <param name="additionalLanguages">
        /// Extra languages this agent serves in the same session.<br/>
        /// Each entry's language must be supported, unique, and<br/>
        /// different from the default `language`.
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
        /// <param name="maxCallDurationSeconds">
        /// Hard cap on the wall-clock length of a single call on this<br/>
        /// agent, in seconds. When a call reaches it the agent ends the<br/>
        /// call automatically. Voice agents only. Null means no<br/>
        /// per-agent cap: the call is bounded only by your plan's call<br/>
        /// ceiling, which is also the hard upper bound for this field -<br/>
        /// a value above it is rejected.
        /// </param>
        /// <param name="saveAudioRecording">
        /// When set, opts the agent into per-conversation audio recording. Defaults to false when omitted.
        /// </param>
        /// <param name="aiDisclosure">
        /// Opt-in AI-disclosure opening line. Optional on create; omitted means off. See AIDisclosure schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequest(
            string name,
            string prompt,
            string? projectId,
            string? slug,
            global::System.Collections.Generic.IList<global::Speechify.AgentChannel>? channels,
            string? knowledgeInstruction,
            string? firstMessage,
            string? language,
            global::System.Collections.Generic.IList<global::Speechify.AgentAdditionalLanguage>? additionalLanguages,
            global::Speechify.AgentLLMConfig? llm,
            global::Speechify.AgentTTSConfig? tts,
            global::Speechify.AgentTurnHandlingConfig? turnHandling,
            global::Speechify.AgentMemoryConfig? memory,
            global::Speechify.AgentNavigatorConfig? navigator,
            global::Speechify.AgentGuardrailsConfig? guardrails,
            global::Speechify.AgentBackgroundNoiseConfig? backgroundNoise,
            global::Speechify.WidgetConfig? widgetConfig,
            bool? isPublic,
            global::System.Collections.Generic.IList<string>? allowedOrigins,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist,
            string? webhookUrl,
            string? webhookSecret,
            global::Speechify.AMDConfig? amd,
            int? maxCallDurationSeconds,
            bool? saveAudioRecording,
            global::Speechify.AIDisclosure? aiDisclosure)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug;
            this.Channels = channels;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.KnowledgeInstruction = knowledgeInstruction;
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.AdditionalLanguages = additionalLanguages;
            this.Llm = llm;
            this.Tts = tts;
            this.TurnHandling = turnHandling;
            this.Memory = memory;
            this.Navigator = navigator;
            this.Guardrails = guardrails;
            this.BackgroundNoise = backgroundNoise;
            this.WidgetConfig = widgetConfig;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins;
            this.HostnameAllowlist = hostnameAllowlist;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
            this.Amd = amd;
            this.MaxCallDurationSeconds = maxCallDurationSeconds;
            this.SaveAudioRecording = saveAudioRecording;
            this.AiDisclosure = aiDisclosure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        public CreateAgentRequest()
        {
        }

    }
}