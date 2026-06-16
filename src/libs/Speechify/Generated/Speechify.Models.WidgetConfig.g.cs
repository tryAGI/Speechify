
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
    public sealed partial class WidgetConfig
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.WidgetConfigStyleJsonConverter))]
        public global::Speechify.WidgetConfigStyle? Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.WidgetConfigThemeJsonConverter))]
        public global::Speechify.WidgetConfigTheme? Theme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public global::Speechify.WidgetConfigAvatar? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Speechify.WidgetConfigText? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms")]
        public global::Speechify.WidgetConfigTerms? Terms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public global::Speechify.WidgetConfigTranscript? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfig" /> class.
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
        public WidgetConfig(
            int? version,
            global::Speechify.WidgetConfigStyle? style,
            global::Speechify.WidgetConfigTheme? theme,
            global::Speechify.WidgetConfigAvatar? avatar,
            global::Speechify.WidgetConfigText? text,
            global::Speechify.WidgetConfigTerms? terms,
            global::Speechify.WidgetConfigTranscript? transcript)
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
        /// Initializes a new instance of the <see cref="WidgetConfig" /> class.
        /// </summary>
        public WidgetConfig()
        {
        }

    }
}