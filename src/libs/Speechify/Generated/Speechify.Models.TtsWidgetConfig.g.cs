
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Customer-editable appearance + behaviour payload for the<br/>
    /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
    /// orb colours, terms-and-conditions markdown, transcript display.<br/>
    /// Every field is optional - empty fields fall back to the<br/>
    /// widget's compile-time defaults.
    /// </summary>
    public sealed partial class TtsWidgetConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsWidgetConfigStyleJsonConverter))]
        public global::Speechify.TtsWidgetConfigStyle? Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsWidgetConfigThemeJsonConverter))]
        public global::Speechify.TtsWidgetConfigTheme? Theme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public global::Speechify.TtsWidgetConfigAvatar? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Speechify.TtsWidgetConfigText? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms")]
        public global::Speechify.TtsWidgetConfigTerms? Terms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public global::Speechify.TtsWidgetConfigTranscript? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsWidgetConfig" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="style"></param>
        /// <param name="theme"></param>
        /// <param name="avatar"></param>
        /// <param name="text"></param>
        /// <param name="terms"></param>
        /// <param name="transcript"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsWidgetConfig(
            int? version,
            global::Speechify.TtsWidgetConfigStyle? style,
            global::Speechify.TtsWidgetConfigTheme? theme,
            global::Speechify.TtsWidgetConfigAvatar? avatar,
            global::Speechify.TtsWidgetConfigText? text,
            global::Speechify.TtsWidgetConfigTerms? terms,
            global::Speechify.TtsWidgetConfigTranscript? transcript)
        {
            this.Version = version;
            this.Style = style;
            this.Theme = theme;
            this.Avatar = avatar;
            this.Text = text;
            this.Terms = terms;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsWidgetConfig" /> class.
        /// </summary>
        public TtsWidgetConfig()
        {
        }

    }
}