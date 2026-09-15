
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A piece of the agent's answer, sent as it is written. It is only ever<br/>
    /// the answer, never the agent's plan, so appending every piece in order<br/>
    /// gives the reply. `seq` is the journal position the answer is written at<br/>
    /// and `offset` the number of characters (Unicode code points) of it<br/>
    /// before this piece; place the piece at its offset. `run.ended` closes<br/>
    /// the answer, and its `output.reply` is the copy to keep. The SSE `id:`<br/>
    /// records the position reached, so a reconnect through `Last-Event-ID`<br/>
    /// resumes without replaying text already rendered.
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
        /// The journal position the answer is being written at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seq { get; set; }

        /// <summary>
        /// Characters of the answer that precede this piece.
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
        /// The journal position the answer is being written at.
        /// </param>
        /// <param name="offset">
        /// Characters of the answer that precede this piece.
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