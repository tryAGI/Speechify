
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for PATCH /v1/agents/{agent_id}. JSON merge-patch semantics: every<br/>
    /// field is optional and omitting it leaves the stored value<br/>
    /// unchanged. Inside a nested config block (llm, tts,<br/>
    /// turn_handling, memory, navigator, background_noise, amd) send only<br/>
    /// the sub-fields you want to change - an explicit null clears a<br/>
    /// nullable sub-field to its default, a value sets it, and omitted<br/>
    /// sub-fields are left as-is. `slug` is intentionally not patchable<br/>
    /// (changing it would break embed URLs).
    /// </summary>
    public sealed partial class UpdateAgentRequest
    {
        /// <summary>
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Replaces the agent's enabled delivery channels. Adding `voice`<br/>
        /// requires the agent to have a `tts.voice_id` (already set or set in<br/>
        /// the same request). Omit to leave channels unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::Speechify.AgentChannel>? Channels { get; set; }

        /// <summary>
        /// Replaces the stored list wholesale when present; an empty<br/>
        /// array clears it back to a single-language agent. Omit to<br/>
        /// leave unchanged.
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// When supplied, replaces the stored list. Pass an empty<br/>
        /// array to clear enforcement (public agent is open again).<br/>
        /// Omit the field to leave the existing value unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Rotate the HMAC secret. Write-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// AMD routing config (PATCH-replace, wholesale). Omit to leave the stored config unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd")]
        public global::Speechify.AMDConfig? Amd { get; set; }

        /// <summary>
        /// Hard cap on the wall-clock length of a single call on this<br/>
        /// agent, in seconds. When a call reaches it the agent ends the<br/>
        /// call automatically. Voice agents only. Null means no<br/>
        /// per-agent cap: the call is bounded only by your plan's call<br/>
        /// ceiling, which is also the hard upper bound for this field -<br/>
        /// a value above it is rejected. On a PATCH, null clears a<br/>
        /// previously set cap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_seconds")]
        public int? MaxCallDurationSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_audio_recording")]
        public bool? SaveAudioRecording { get; set; }

        /// <summary>
        /// Opt-in AI-disclosure opening line (PATCH-replace, wholesale). Omit to leave the stored config unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_disclosure")]
        public global::Speechify.AIDisclosure? AiDisclosure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </param>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="knowledgeInstruction">
        /// A short steer for how the agent uses its knowledge bases: what to<br/>
        /// look up first, what never to quote, how to answer when nothing<br/>
        /// matches. It reaches the model as guidance under the prompt and<br/>
        /// shapes the per-turn retrieval query on every channel: live<br/>
        /// calls, text conversations and agent tests. Empty means none.
        /// </param>
        /// <param name="firstMessage"></param>
        /// <param name="language"></param>
        /// <param name="channels">
        /// Replaces the agent's enabled delivery channels. Adding `voice`<br/>
        /// requires the agent to have a `tts.voice_id` (already set or set in<br/>
        /// the same request). Omit to leave channels unchanged.
        /// </param>
        /// <param name="additionalLanguages">
        /// Replaces the stored list wholesale when present; an empty<br/>
        /// array clears it back to a single-language agent. Omit to<br/>
        /// leave unchanged.
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
        /// <param name="isPublic"></param>
        /// <param name="allowedOrigins"></param>
        /// <param name="hostnameAllowlist">
        /// When supplied, replaces the stored list. Pass an empty<br/>
        /// array to clear enforcement (public agent is open again).<br/>
        /// Omit the field to leave the existing value unchanged.
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookSecret">
        /// Rotate the HMAC secret. Write-only.
        /// </param>
        /// <param name="amd">
        /// AMD routing config (PATCH-replace, wholesale). Omit to leave the stored config unchanged.
        /// </param>
        /// <param name="maxCallDurationSeconds">
        /// Hard cap on the wall-clock length of a single call on this<br/>
        /// agent, in seconds. When a call reaches it the agent ends the<br/>
        /// call automatically. Voice agents only. Null means no<br/>
        /// per-agent cap: the call is bounded only by your plan's call<br/>
        /// ceiling, which is also the hard upper bound for this field -<br/>
        /// a value above it is rejected. On a PATCH, null clears a<br/>
        /// previously set cap.
        /// </param>
        /// <param name="saveAudioRecording"></param>
        /// <param name="aiDisclosure">
        /// Opt-in AI-disclosure opening line (PATCH-replace, wholesale). Omit to leave the stored config unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentRequest(
            string? projectId,
            string? name,
            string? prompt,
            string? knowledgeInstruction,
            string? firstMessage,
            string? language,
            global::System.Collections.Generic.IList<global::Speechify.AgentChannel>? channels,
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
            this.Name = name;
            this.Prompt = prompt;
            this.KnowledgeInstruction = knowledgeInstruction;
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.Channels = channels;
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
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        public UpdateAgentRequest()
        {
        }

    }
}