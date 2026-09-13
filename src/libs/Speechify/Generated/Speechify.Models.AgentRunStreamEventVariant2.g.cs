
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A piece of the text the agent is writing, sent as it is written. `seq`<br/>
    /// is the journal position the text belongs to and `offset` the number of<br/>
    /// characters (Unicode code points) of that position's text before this<br/>
    /// piece; keep one buffer per `seq` and place the piece at its offset. The<br/>
    /// buffer is closed by a `run.step.added` at the same `seq` (it was the<br/>
    /// step's `content`) or by `run.ended` (it was the reply, and<br/>
    /// `output.reply` is the copy to keep). The SSE `id:` records the position<br/>
    /// reached, so a reconnect through `Last-Event-ID` resumes without<br/>
    /// replaying text already rendered.
    /// </summary>
    public sealed partial class AgentRunStreamEventVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunStreamEventVariant2TypeJsonConverter))]
        public global::Speechify.AgentRunStreamEventVariant2Type Type { get; set; }

        /// <summary>
        /// The journal position this text is being written at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seq { get; set; }

        /// <summary>
        /// Characters of this position's text that precede this piece.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// The piece itself, never empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunStreamEventVariant2" /> class.
        /// </summary>
        /// <param name="seq">
        /// The journal position this text is being written at.
        /// </param>
        /// <param name="offset">
        /// Characters of this position's text that precede this piece.
        /// </param>
        /// <param name="text">
        /// The piece itself, never empty.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunStreamEventVariant2(
            int seq,
            int offset,
            string text,
            global::Speechify.AgentRunStreamEventVariant2Type type)
        {
            this.Type = type;
            this.Seq = seq;
            this.Offset = offset;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunStreamEventVariant2" /> class.
        /// </summary>
        public AgentRunStreamEventVariant2()
        {
        }

    }
}