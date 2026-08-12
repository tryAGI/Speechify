
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the agent keeps a live call sane while a slow tool runs.<br/>
    /// Present means the tool is declared slow; absent keeps the tool's<br/>
    /// previous behaviour exactly.<br/>
    /// The tool still blocks the turn either way: the agent never<br/>
    /// receives a synthetic result while your endpoint is still working,<br/>
    /// so it can only ever speak about a result it actually got.
    /// </summary>
    public sealed partial class LongRunningToolConfig
    {
        /// <summary>
        /// Phrase spoken verbatim once the tool has been running for<br/>
        /// `filler_delay_ms`, e.g. "one sec, pulling that up". Write it<br/>
        /// in your agent's own language and voice — Speechify ships no<br/>
        /// default phrase, so nothing we invented can reach your caller<br/>
        /// in the wrong language. Omit to arm the duplicate policy<br/>
        /// without any spoken filler.<br/>
        /// On a multilingual agent the phrase is spoken only while the<br/>
        /// call is still in the agent's configured `language`; after a<br/>
        /// mid-call language switch the filler is suppressed rather than<br/>
        /// spoken in the language you wrote it in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filler_message")]
        public string? FillerMessage { get; set; }

        /// <summary>
        /// How long the tool must have been running, with nobody<br/>
        /// speaking, before the filler is spoken. Defaults to 2000. The<br/>
        /// wait restarts whenever the agent or the caller speaks, so the<br/>
        /// filler never lands on top of live speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filler_delay_ms")]
        public int? FillerDelayMs { get; set; }

        /// <summary>
        /// Phrases for the second and later times the agent fills, in<br/>
        /// order, so a tool that outlives one phrase does not repeat it<br/>
        /// word for word - which is what makes an agent sound broken<br/>
        /// rather than busy. The last entry repeats once the list runs<br/>
        /// out. Requires `filler_message` and `filler_interval_ms`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_filler_messages")]
        public global::System.Collections.Generic.IList<string>? AdditionalFillerMessages { get; set; }

        /// <summary>
        /// Cooldown before the filler may be spoken again while the tool<br/>
        /// is still running. Omit to speak it at most once, which covers<br/>
        /// the common few-second tool; set it for a tool whose timeout<br/>
        /// runs to tens of seconds. Capped at 10 utterances per call<br/>
        /// regardless. Requires `filler_message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filler_interval_ms")]
        public int? FillerIntervalMs { get; set; }

        /// <summary>
        /// What happens when the model calls this tool while a previous<br/>
        /// call of the SAME tool is still running. `reject` (the default<br/>
        /// whenever `long_running` is set) refuses the second call and<br/>
        /// tells the model the first is still in flight, so a slow<br/>
        /// side-effecting webhook cannot be fired twice in one turn.<br/>
        /// `allow` restores the unguarded behaviour for a read-only tool<br/>
        /// the model legitimately fans out over several arguments —<br/>
        /// duplicates are matched by tool name alone, never by<br/>
        /// arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_duplicate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.LongRunningToolConfigOnDuplicateJsonConverter))]
        public global::Speechify.LongRunningToolConfigOnDuplicate? OnDuplicate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LongRunningToolConfig" /> class.
        /// </summary>
        /// <param name="fillerMessage">
        /// Phrase spoken verbatim once the tool has been running for<br/>
        /// `filler_delay_ms`, e.g. "one sec, pulling that up". Write it<br/>
        /// in your agent's own language and voice — Speechify ships no<br/>
        /// default phrase, so nothing we invented can reach your caller<br/>
        /// in the wrong language. Omit to arm the duplicate policy<br/>
        /// without any spoken filler.<br/>
        /// On a multilingual agent the phrase is spoken only while the<br/>
        /// call is still in the agent's configured `language`; after a<br/>
        /// mid-call language switch the filler is suppressed rather than<br/>
        /// spoken in the language you wrote it in.
        /// </param>
        /// <param name="fillerDelayMs">
        /// How long the tool must have been running, with nobody<br/>
        /// speaking, before the filler is spoken. Defaults to 2000. The<br/>
        /// wait restarts whenever the agent or the caller speaks, so the<br/>
        /// filler never lands on top of live speech.
        /// </param>
        /// <param name="additionalFillerMessages">
        /// Phrases for the second and later times the agent fills, in<br/>
        /// order, so a tool that outlives one phrase does not repeat it<br/>
        /// word for word - which is what makes an agent sound broken<br/>
        /// rather than busy. The last entry repeats once the list runs<br/>
        /// out. Requires `filler_message` and `filler_interval_ms`.
        /// </param>
        /// <param name="fillerIntervalMs">
        /// Cooldown before the filler may be spoken again while the tool<br/>
        /// is still running. Omit to speak it at most once, which covers<br/>
        /// the common few-second tool; set it for a tool whose timeout<br/>
        /// runs to tens of seconds. Capped at 10 utterances per call<br/>
        /// regardless. Requires `filler_message`.
        /// </param>
        /// <param name="onDuplicate">
        /// What happens when the model calls this tool while a previous<br/>
        /// call of the SAME tool is still running. `reject` (the default<br/>
        /// whenever `long_running` is set) refuses the second call and<br/>
        /// tells the model the first is still in flight, so a slow<br/>
        /// side-effecting webhook cannot be fired twice in one turn.<br/>
        /// `allow` restores the unguarded behaviour for a read-only tool<br/>
        /// the model legitimately fans out over several arguments —<br/>
        /// duplicates are matched by tool name alone, never by<br/>
        /// arguments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LongRunningToolConfig(
            string? fillerMessage,
            int? fillerDelayMs,
            global::System.Collections.Generic.IList<string>? additionalFillerMessages,
            int? fillerIntervalMs,
            global::Speechify.LongRunningToolConfigOnDuplicate? onDuplicate)
        {
            this.FillerMessage = fillerMessage;
            this.FillerDelayMs = fillerDelayMs;
            this.AdditionalFillerMessages = additionalFillerMessages;
            this.FillerIntervalMs = fillerIntervalMs;
            this.OnDuplicate = onDuplicate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LongRunningToolConfig" /> class.
        /// </summary>
        public LongRunningToolConfig()
        {
        }

    }
}