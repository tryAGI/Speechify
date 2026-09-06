
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Customer-facing per-tier limits + feature flags, including the API<br/>
    /// rate limits the plan enforces. Numeric fields are caps; booleans gate<br/>
    /// features.
    /// </summary>
    public sealed partial class BillingEntitlements
    {
        /// <summary>
        /// Speechify-managed (purchased) phone numbers allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PhoneNumberQuota { get; set; }

        /// <summary>
        /// Simultaneously-active voice calls allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrent_call_cap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConcurrentCallCap { get; set; }

        /// <summary>
        /// Members allowed in a single workspace (owner + invitees).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxMembers { get; set; }

        /// <summary>
        /// Per-call wall-clock ceiling, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCallDurationSeconds { get; set; }

        /// <summary>
        /// Active service accounts allowed. 0 means service accounts are not<br/>
        /// included in the plan (creating one returns 402<br/>
        /// service_accounts_not_in_plan); existing accounts keep working.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_service_accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxServiceAccounts { get; set; }

        /// <summary>
        /// Sustained requests per second across the audio (TTS) endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_requests_per_second")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtsRequestsPerSecond { get; set; }

        /// <summary>
        /// Simultaneous in-flight requests across the audio (TTS) endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtsConcurrency { get; set; }

        /// <summary>
        /// Sustained requests per second across the agents API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_requests_per_second")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentRequestsPerSecond { get; set; }

        /// <summary>
        /// Simultaneous in-flight requests across the agents API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentConcurrency { get; set; }

        /// <summary>
        /// Highest LLM model access class an agent on this plan may select.<br/>
        /// `managed`: Speechify-served models, included on every plan.<br/>
        /// `standard`: low-cost third-party models (e.g. GPT-4.1 Mini).<br/>
        /// `premium`: flagship third-party models (e.g. GPT-4.1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_llm_model_class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.BillingEntitlementsMaxLlmModelClassJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.BillingEntitlementsMaxLlmModelClass MaxLlmModelClass { get; set; }

        /// <summary>
        /// Whether the workspace may create ADDITIONAL workspaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_create_workspaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanCreateWorkspaces { get; set; }

        /// <summary>
        /// Whether prepaid funds may be added beyond the monthly grant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topup_allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TopupAllowed { get; set; }

        /// <summary>
        /// Whether voice cloning is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_cloning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VoiceCloning { get; set; }

        /// <summary>
        /// Whether batch outbound calls are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BatchCalls { get; set; }

        /// <summary>
        /// Whether agents may use a bring-your-own custom LLM endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CustomLlmEndpoint { get; set; }

        /// <summary>
        /// Whether Waymark API access is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waymark_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WaymarkAccess { get; set; }

        /// <summary>
        /// Whether the workspace may create and run agents that serve the text<br/>
        /// channel. When false, enabling the text channel or opening a text<br/>
        /// conversation returns 402 text_channel_not_in_plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_agent_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TextAgentAccess { get; set; }

        /// <summary>
        /// Whether the workspace may start and read durable async agent runs,<br/>
        /// including the approvals they raise and team runs. When false, those<br/>
        /// endpoints return 402 durable_runs_not_in_plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durable_runs_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DurableRunsAccess { get; set; }

        /// <summary>
        /// The per-run turn ceiling (one turn is one plan-act-observe cycle).<br/>
        /// A run or a trigger fire asking for more is clamped to it, and the<br/>
        /// run echoes the budget it got in `input.max_turns`; plan against<br/>
        /// this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_run_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxRunTurns { get; set; }

        /// <summary>
        /// Whether the workspace may connect a Slack front door. Off on every<br/>
        /// plan; granted per workspace. A Slack turn runs on the async-turn<br/>
        /// runtime and meters as a text message, so `text_agent_access` is<br/>
        /// required alongside it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_channel_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SlackChannelAccess { get; set; }

        /// <summary>
        /// Whether stores and hosted APIs are available. Off on every plan; granted per workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosted_apis_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HostedApisAccess { get; set; }

        /// <summary>
        /// Documents one store may hold; 0 means uncapped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_store_documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxStoreDocuments { get; set; }

        /// <summary>
        /// Bytes one store may hold across its documents and files; 0 means uncapped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_store_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxStoreBytes { get; set; }

        /// <summary>
        /// Whether the skill catalog and per-agent attachment surface are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SkillsAccess { get; set; }

        /// <summary>
        /// Skills one workspace may hold; 0 means uncapped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSkills { get; set; }

        /// <summary>
        /// Skills one agent may attach; 0 means uncapped. Not only an abuse<br/>
        /// ceiling: every enabled skill renders its instructions into the<br/>
        /// agent's system prompt, so this is what bounds prompt growth on a<br/>
        /// latency-sensitive turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_skills_per_agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSkillsPerAgent { get; set; }

        /// <summary>
        /// Whether enterprise SAML/OIDC SSO is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_sso")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseSso { get; set; }

        /// <summary>
        /// Whether Agent Phone (a number whose brain is your webhook) is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_relay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PhoneRelay { get; set; }

        /// <summary>
        /// Whether SMS on Agent Phone numbers is available (also requires 10DLC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_sms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PhoneSms { get; set; }

        /// <summary>
        /// Whether zero data retention is enabled for this workspace on the<br/>
        /// Text to Speech API. Read-only: Speechify sets it against a signed<br/>
        /// agreement, never self-serve, and that agreement defines the scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zero_data_retention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ZeroDataRetention { get; set; }

        /// <summary>
        /// Whether `POST /v1/voices` accepts a clone from this workspace<br/>
        /// without a consent challenge and verification recording, because the<br/>
        /// workspace captures and holds speaker consent under its own<br/>
        /// agreement with Speechify. Read-only: Speechify sets it against that<br/>
        /// agreement, never self-serve. It does not grant cloning - the<br/>
        /// `voice_cloning` entitlement still applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_cloning_consent_exempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VoiceCloningConsentExempt { get; set; }

        /// <summary>
        /// Largest single manual prepaid top-up accepted, in whole US dollars.<br/>
        /// 0 means adding prepaid credit is not included in the plan. This is<br/>
        /// the enforced amount, so a top-up of exactly this value succeeds; a<br/>
        /// client may offer it directly without applying further bounds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_manual_top_up_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxManualTopUpUsd { get; set; }

        /// <summary>
        /// Largest single automatic recharge, in whole US dollars. 0 means<br/>
        /// auto-recharge is not included in the plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_auto_recharge_charge_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxAutoRechargeChargeUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingEntitlements" /> class.
        /// </summary>
        /// <param name="phoneNumberQuota">
        /// Speechify-managed (purchased) phone numbers allowed.
        /// </param>
        /// <param name="concurrentCallCap">
        /// Simultaneously-active voice calls allowed.
        /// </param>
        /// <param name="maxMembers">
        /// Members allowed in a single workspace (owner + invitees).
        /// </param>
        /// <param name="maxCallDurationSeconds">
        /// Per-call wall-clock ceiling, in seconds.
        /// </param>
        /// <param name="maxServiceAccounts">
        /// Active service accounts allowed. 0 means service accounts are not<br/>
        /// included in the plan (creating one returns 402<br/>
        /// service_accounts_not_in_plan); existing accounts keep working.
        /// </param>
        /// <param name="ttsRequestsPerSecond">
        /// Sustained requests per second across the audio (TTS) endpoints.
        /// </param>
        /// <param name="ttsConcurrency">
        /// Simultaneous in-flight requests across the audio (TTS) endpoints.
        /// </param>
        /// <param name="agentRequestsPerSecond">
        /// Sustained requests per second across the agents API.
        /// </param>
        /// <param name="agentConcurrency">
        /// Simultaneous in-flight requests across the agents API.
        /// </param>
        /// <param name="maxLlmModelClass">
        /// Highest LLM model access class an agent on this plan may select.<br/>
        /// `managed`: Speechify-served models, included on every plan.<br/>
        /// `standard`: low-cost third-party models (e.g. GPT-4.1 Mini).<br/>
        /// `premium`: flagship third-party models (e.g. GPT-4.1).
        /// </param>
        /// <param name="canCreateWorkspaces">
        /// Whether the workspace may create ADDITIONAL workspaces.
        /// </param>
        /// <param name="topupAllowed">
        /// Whether prepaid funds may be added beyond the monthly grant.
        /// </param>
        /// <param name="voiceCloning">
        /// Whether voice cloning is available.
        /// </param>
        /// <param name="batchCalls">
        /// Whether batch outbound calls are available.
        /// </param>
        /// <param name="customLlmEndpoint">
        /// Whether agents may use a bring-your-own custom LLM endpoint.
        /// </param>
        /// <param name="waymarkAccess">
        /// Whether Waymark API access is available.
        /// </param>
        /// <param name="textAgentAccess">
        /// Whether the workspace may create and run agents that serve the text<br/>
        /// channel. When false, enabling the text channel or opening a text<br/>
        /// conversation returns 402 text_channel_not_in_plan.
        /// </param>
        /// <param name="durableRunsAccess">
        /// Whether the workspace may start and read durable async agent runs,<br/>
        /// including the approvals they raise and team runs. When false, those<br/>
        /// endpoints return 402 durable_runs_not_in_plan.
        /// </param>
        /// <param name="maxRunTurns">
        /// The per-run turn ceiling (one turn is one plan-act-observe cycle).<br/>
        /// A run or a trigger fire asking for more is clamped to it, and the<br/>
        /// run echoes the budget it got in `input.max_turns`; plan against<br/>
        /// this value.
        /// </param>
        /// <param name="slackChannelAccess">
        /// Whether the workspace may connect a Slack front door. Off on every<br/>
        /// plan; granted per workspace. A Slack turn runs on the async-turn<br/>
        /// runtime and meters as a text message, so `text_agent_access` is<br/>
        /// required alongside it.
        /// </param>
        /// <param name="hostedApisAccess">
        /// Whether stores and hosted APIs are available. Off on every plan; granted per workspace.
        /// </param>
        /// <param name="maxStoreDocuments">
        /// Documents one store may hold; 0 means uncapped.
        /// </param>
        /// <param name="maxStoreBytes">
        /// Bytes one store may hold across its documents and files; 0 means uncapped.
        /// </param>
        /// <param name="skillsAccess">
        /// Whether the skill catalog and per-agent attachment surface are available.
        /// </param>
        /// <param name="maxSkills">
        /// Skills one workspace may hold; 0 means uncapped.
        /// </param>
        /// <param name="maxSkillsPerAgent">
        /// Skills one agent may attach; 0 means uncapped. Not only an abuse<br/>
        /// ceiling: every enabled skill renders its instructions into the<br/>
        /// agent's system prompt, so this is what bounds prompt growth on a<br/>
        /// latency-sensitive turn.
        /// </param>
        /// <param name="enterpriseSso">
        /// Whether enterprise SAML/OIDC SSO is available.
        /// </param>
        /// <param name="phoneRelay">
        /// Whether Agent Phone (a number whose brain is your webhook) is available.
        /// </param>
        /// <param name="phoneSms">
        /// Whether SMS on Agent Phone numbers is available (also requires 10DLC).
        /// </param>
        /// <param name="zeroDataRetention">
        /// Whether zero data retention is enabled for this workspace on the<br/>
        /// Text to Speech API. Read-only: Speechify sets it against a signed<br/>
        /// agreement, never self-serve, and that agreement defines the scope.
        /// </param>
        /// <param name="voiceCloningConsentExempt">
        /// Whether `POST /v1/voices` accepts a clone from this workspace<br/>
        /// without a consent challenge and verification recording, because the<br/>
        /// workspace captures and holds speaker consent under its own<br/>
        /// agreement with Speechify. Read-only: Speechify sets it against that<br/>
        /// agreement, never self-serve. It does not grant cloning - the<br/>
        /// `voice_cloning` entitlement still applies.
        /// </param>
        /// <param name="maxManualTopUpUsd">
        /// Largest single manual prepaid top-up accepted, in whole US dollars.<br/>
        /// 0 means adding prepaid credit is not included in the plan. This is<br/>
        /// the enforced amount, so a top-up of exactly this value succeeds; a<br/>
        /// client may offer it directly without applying further bounds.
        /// </param>
        /// <param name="maxAutoRechargeChargeUsd">
        /// Largest single automatic recharge, in whole US dollars. 0 means<br/>
        /// auto-recharge is not included in the plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingEntitlements(
            int phoneNumberQuota,
            int concurrentCallCap,
            int maxMembers,
            int maxCallDurationSeconds,
            int maxServiceAccounts,
            int ttsRequestsPerSecond,
            int ttsConcurrency,
            int agentRequestsPerSecond,
            int agentConcurrency,
            global::Speechify.BillingEntitlementsMaxLlmModelClass maxLlmModelClass,
            bool canCreateWorkspaces,
            bool topupAllowed,
            bool voiceCloning,
            bool batchCalls,
            bool customLlmEndpoint,
            bool waymarkAccess,
            bool textAgentAccess,
            bool durableRunsAccess,
            int maxRunTurns,
            bool slackChannelAccess,
            bool hostedApisAccess,
            int maxStoreDocuments,
            long maxStoreBytes,
            bool skillsAccess,
            int maxSkills,
            int maxSkillsPerAgent,
            bool enterpriseSso,
            bool phoneRelay,
            bool phoneSms,
            bool zeroDataRetention,
            bool voiceCloningConsentExempt,
            int maxManualTopUpUsd,
            int maxAutoRechargeChargeUsd)
        {
            this.PhoneNumberQuota = phoneNumberQuota;
            this.ConcurrentCallCap = concurrentCallCap;
            this.MaxMembers = maxMembers;
            this.MaxCallDurationSeconds = maxCallDurationSeconds;
            this.MaxServiceAccounts = maxServiceAccounts;
            this.TtsRequestsPerSecond = ttsRequestsPerSecond;
            this.TtsConcurrency = ttsConcurrency;
            this.AgentRequestsPerSecond = agentRequestsPerSecond;
            this.AgentConcurrency = agentConcurrency;
            this.MaxLlmModelClass = maxLlmModelClass;
            this.CanCreateWorkspaces = canCreateWorkspaces;
            this.TopupAllowed = topupAllowed;
            this.VoiceCloning = voiceCloning;
            this.BatchCalls = batchCalls;
            this.CustomLlmEndpoint = customLlmEndpoint;
            this.WaymarkAccess = waymarkAccess;
            this.TextAgentAccess = textAgentAccess;
            this.DurableRunsAccess = durableRunsAccess;
            this.MaxRunTurns = maxRunTurns;
            this.SlackChannelAccess = slackChannelAccess;
            this.HostedApisAccess = hostedApisAccess;
            this.MaxStoreDocuments = maxStoreDocuments;
            this.MaxStoreBytes = maxStoreBytes;
            this.SkillsAccess = skillsAccess;
            this.MaxSkills = maxSkills;
            this.MaxSkillsPerAgent = maxSkillsPerAgent;
            this.EnterpriseSso = enterpriseSso;
            this.PhoneRelay = phoneRelay;
            this.PhoneSms = phoneSms;
            this.ZeroDataRetention = zeroDataRetention;
            this.VoiceCloningConsentExempt = voiceCloningConsentExempt;
            this.MaxManualTopUpUsd = maxManualTopUpUsd;
            this.MaxAutoRechargeChargeUsd = maxAutoRechargeChargeUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingEntitlements" /> class.
        /// </summary>
        public BillingEntitlements()
        {
        }

    }
}