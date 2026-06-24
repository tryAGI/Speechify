
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The per-call timeline: the conversation's turns in order, each with the<br/>
    /// latency of the pipeline stages that produced the agent's reply, plus a<br/>
    /// call-level opening summary. The `turns` array is empty for a call that<br/>
    /// never connected or produced no completed turns - in which case<br/>
    /// `first_response_ms` and `end_reason` still describe what happened (e.g.<br/>
    /// the agent's greeting started, then the caller hung up).
    /// </summary>
    public sealed partial class ConversationTrace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ConversationTraceTurn> Turns { get; set; }

        /// <summary>
        /// Milliseconds to the agent's first audio (greeting / first reply). Absent when the agent never started speaking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_response_ms")]
        public double? FirstResponseMs { get; set; }

        /// <summary>
        /// How the call ended (e.g. caller_hangup), surfaced even when there are no completed turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_reason")]
        public string? EndReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTrace" /> class.
        /// </summary>
        /// <param name="turns"></param>
        /// <param name="firstResponseMs">
        /// Milliseconds to the agent's first audio (greeting / first reply). Absent when the agent never started speaking.
        /// </param>
        /// <param name="endReason">
        /// How the call ended (e.g. caller_hangup), surfaced even when there are no completed turns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTrace(
            global::System.Collections.Generic.IList<global::Speechify.ConversationTraceTurn> turns,
            double? firstResponseMs,
            string? endReason)
        {
            this.Turns = turns ?? throw new global::System.ArgumentNullException(nameof(turns));
            this.FirstResponseMs = firstResponseMs;
            this.EndReason = endReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTrace" /> class.
        /// </summary>
        public ConversationTrace()
        {
        }

    }
}