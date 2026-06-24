
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One conversational exchange: the caller spoke and the agent replied.<br/>
    /// The stage latencies are the time that went into producing that reply -<br/>
    /// speech-to-text, end-of-turn detection, the LLM's time to first token,<br/>
    /// and TTS time to first byte - with `e2e_ms` (caller stopped speaking -&gt;<br/>
    /// agent started speaking) as the headline. Stage fields are omitted when<br/>
    /// that stage produced no span for the turn.
    /// </summary>
    public sealed partial class ConversationTraceTurn
    {
        /// <summary>
        /// 1-based position of this turn within the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Milliseconds from the start of the call to the start of this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StartOffsetMs { get; set; }

        /// <summary>
        /// End-to-end response time - caller stopped speaking to agent started speaking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e2e_ms")]
        public double? E2eMs { get; set; }

        /// <summary>
        /// Speech-to-text latency for the caller's utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_ms")]
        public double? SttMs { get; set; }

        /// <summary>
        /// End-of-turn (end-of-utterance) detection latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eou_ms")]
        public double? EouMs { get; set; }

        /// <summary>
        /// The LLM's time to first token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_ttft_ms")]
        public double? LlmTtftMs { get; set; }

        /// <summary>
        /// TTS time to first audio byte.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_ttfb_ms")]
        public double? TtsTtfbMs { get; set; }

        /// <summary>
        /// The LLM model that ACTUALLY served this turn's reply (the resolved model, not a wrapper).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// The provider that actually served this turn's LLM (e.g. inference.baseten.co, openai).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        public string? LlmProvider { get; set; }

        /// <summary>
        /// True when the model that served differs from the agent's configured model - i.e. a provider fallback kicked in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_fallback")]
        public bool? LlmFallback { get; set; }

        /// <summary>
        /// Tool calls and DTMF presses that fired during this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Speechify.ConversationTraceEvent>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTraceTurn" /> class.
        /// </summary>
        /// <param name="index">
        /// 1-based position of this turn within the call.
        /// </param>
        /// <param name="startOffsetMs">
        /// Milliseconds from the start of the call to the start of this turn.
        /// </param>
        /// <param name="e2eMs">
        /// End-to-end response time - caller stopped speaking to agent started speaking.
        /// </param>
        /// <param name="sttMs">
        /// Speech-to-text latency for the caller's utterance.
        /// </param>
        /// <param name="eouMs">
        /// End-of-turn (end-of-utterance) detection latency.
        /// </param>
        /// <param name="llmTtftMs">
        /// The LLM's time to first token.
        /// </param>
        /// <param name="ttsTtfbMs">
        /// TTS time to first audio byte.
        /// </param>
        /// <param name="llmModel">
        /// The LLM model that ACTUALLY served this turn's reply (the resolved model, not a wrapper).
        /// </param>
        /// <param name="llmProvider">
        /// The provider that actually served this turn's LLM (e.g. inference.baseten.co, openai).
        /// </param>
        /// <param name="llmFallback">
        /// True when the model that served differs from the agent's configured model - i.e. a provider fallback kicked in.
        /// </param>
        /// <param name="events">
        /// Tool calls and DTMF presses that fired during this turn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTraceTurn(
            int index,
            long startOffsetMs,
            double? e2eMs,
            double? sttMs,
            double? eouMs,
            double? llmTtftMs,
            double? ttsTtfbMs,
            string? llmModel,
            string? llmProvider,
            bool? llmFallback,
            global::System.Collections.Generic.IList<global::Speechify.ConversationTraceEvent>? events)
        {
            this.Index = index;
            this.StartOffsetMs = startOffsetMs;
            this.E2eMs = e2eMs;
            this.SttMs = sttMs;
            this.EouMs = eouMs;
            this.LlmTtftMs = llmTtftMs;
            this.TtsTtfbMs = ttsTtfbMs;
            this.LlmModel = llmModel;
            this.LlmProvider = llmProvider;
            this.LlmFallback = llmFallback;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTraceTurn" /> class.
        /// </summary>
        public ConversationTraceTurn()
        {
        }

    }
}