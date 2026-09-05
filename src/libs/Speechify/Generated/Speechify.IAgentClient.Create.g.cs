#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Agent> CreateAsync(

            global::Speechify.CreateAgentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Agent>> CreateAsResponseAsync(

            global::Speechify.CreateAgentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </param>
        /// <param name="channels">
        /// The delivery channels the agent serves. Defaults to `[voice]` when<br/>
        /// omitted. Pass an explicit `[]` for an agent with no front door,<br/>
        /// reached by its triggers only. Serving `voice` requires a<br/>
        /// `tts.voice_id`.
        /// </param>
        /// <param name="prompt"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Agent> CreateAsync(
            string name,
            string prompt,
            string? speechifyVersion = default,
            string? projectId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<global::Speechify.AgentChannel>? channels = default,
            string? knowledgeInstruction = default,
            string? firstMessage = default,
            string? language = default,
            global::System.Collections.Generic.IList<global::Speechify.AgentAdditionalLanguage>? additionalLanguages = default,
            global::Speechify.AgentLLMConfig? llm = default,
            global::Speechify.AgentTTSConfig? tts = default,
            global::Speechify.AgentTurnHandlingConfig? turnHandling = default,
            global::Speechify.AgentMemoryConfig? memory = default,
            global::Speechify.AgentNavigatorConfig? navigator = default,
            global::Speechify.AgentGuardrailsConfig? guardrails = default,
            global::Speechify.AgentBackgroundNoiseConfig? backgroundNoise = default,
            global::Speechify.WidgetConfig? widgetConfig = default,
            bool? isPublic = default,
            global::System.Collections.Generic.IList<string>? allowedOrigins = default,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::Speechify.AMDConfig? amd = default,
            int? maxCallDurationSeconds = default,
            bool? saveAudioRecording = default,
            global::Speechify.AIDisclosure? aiDisclosure = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}