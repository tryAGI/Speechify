
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetConfigText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_call")]
        public string? StartCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public string? EndCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listening")]
        public string? Listening { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public string? Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking")]
        public string? Speaking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigText" /> class.
        /// </summary>
        /// <param name="startCall"></param>
        /// <param name="endCall"></param>
        /// <param name="listening"></param>
        /// <param name="thinking"></param>
        /// <param name="speaking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetConfigText(
            string? startCall,
            string? endCall,
            string? listening,
            string? thinking,
            string? speaking)
        {
            this.StartCall = startCall;
            this.EndCall = endCall;
            this.Listening = listening;
            this.Thinking = thinking;
            this.Speaking = speaking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigText" /> class.
        /// </summary>
        public WidgetConfigText()
        {
        }

    }
}