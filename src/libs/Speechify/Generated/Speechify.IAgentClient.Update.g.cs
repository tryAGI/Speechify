#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Update Agent<br/>
        /// Update a voice agent. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Agent> UpdateAsync(
            string agentId,

            global::Speechify.UpdateAgentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent<br/>
        /// Update a voice agent. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Agent>> UpdateAsResponseAsync(
            string agentId,

            global::Speechify.UpdateAgentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent<br/>
        /// Update a voice agent. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
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
        /// matches. It reaches the model as guidance under the prompt on<br/>
        /// every channel. Empty means none.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Agent> UpdateAsync(
            string agentId,
            string? speechifyVersion = default,
            string? projectId = default,
            string? name = default,
            string? prompt = default,
            string? knowledgeInstruction = default,
            string? firstMessage = default,
            string? language = default,
            global::System.Collections.Generic.IList<global::Speechify.AgentChannel>? channels = default,
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