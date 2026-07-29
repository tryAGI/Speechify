
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Controls whether the embedded widget reports anonymous<br/>
    /// operational events (mounted, connected, first audio, failure<br/>
    /// codes) back to Speechify. Omit the object to leave telemetry<br/>
    /// on, which is the default: it is how browser-side failures a<br/>
    /// server log cannot see - a denied microphone prompt, a blocked<br/>
    /// autoplay, a visitor who gave up mid-connect - become<br/>
    /// diagnosable. No page URL, page content, transcript, or<br/>
    /// cross-site identifier is ever collected.
    /// </summary>
    public sealed partial class WidgetConfigTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigTelemetry" /> class.
        /// </summary>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetConfigTelemetry(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigTelemetry" /> class.
        /// </summary>
        public WidgetConfigTelemetry()
        {
        }

    }
}