
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What a share-link page may know before anyone speaks: enough to<br/>
    /// render "who is this, and can I talk to them".<br/>
    /// Deliberately thin. No agent id (which would let a caller bypass the<br/>
    /// link's limits by calling the public session endpoint directly), no<br/>
    /// workspace id, no prompt, no model, no tool or knowledge-base names.
    /// </summary>
    public sealed partial class ShareLinkPreview
    {
        /// <summary>
        /// The agent's display name. Present because a visitor needs to<br/>
        /// know who they are about to talk to, and it is not part of the<br/>
        /// embed's visual configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// The embed's resolved visual configuration — avatar, colours,<br/>
        /// theme, button copy — so the page renders exactly like the real<br/>
        /// embed without ever naming the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.WidgetConfig WidgetConfig { get; set; }

        /// <summary>
        /// Whether the owner configured a pre-call consent gate. Surfaced<br/>
        /// here so the PAGE can render it: the embed's own gate reads the<br/>
        /// agent's configuration, which a share-link page deliberately<br/>
        /// never loads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TermsEnabled { get; set; }

        /// <summary>
        /// The consent text to display, as markdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_content")]
        public string? TermsContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCallDurationSeconds { get; set; }

        /// <summary>
        /// Call time left on the link, so the page can say "nearly used<br/>
        /// up" rather than failing at the click.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds_remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SecondsRemaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareLinkPreview" /> class.
        /// </summary>
        /// <param name="agentName">
        /// The agent's display name. Present because a visitor needs to<br/>
        /// know who they are about to talk to, and it is not part of the<br/>
        /// embed's visual configuration.
        /// </param>
        /// <param name="widgetConfig">
        /// The embed's resolved visual configuration — avatar, colours,<br/>
        /// theme, button copy — so the page renders exactly like the real<br/>
        /// embed without ever naming the agent.
        /// </param>
        /// <param name="termsEnabled">
        /// Whether the owner configured a pre-call consent gate. Surfaced<br/>
        /// here so the PAGE can render it: the embed's own gate reads the<br/>
        /// agent's configuration, which a share-link page deliberately<br/>
        /// never loads.
        /// </param>
        /// <param name="maxCallDurationSeconds"></param>
        /// <param name="secondsRemaining">
        /// Call time left on the link, so the page can say "nearly used<br/>
        /// up" rather than failing at the click.
        /// </param>
        /// <param name="termsContent">
        /// The consent text to display, as markdown.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShareLinkPreview(
            string agentName,
            global::Speechify.WidgetConfig widgetConfig,
            bool termsEnabled,
            int maxCallDurationSeconds,
            int secondsRemaining,
            string? termsContent)
        {
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.WidgetConfig = widgetConfig ?? throw new global::System.ArgumentNullException(nameof(widgetConfig));
            this.TermsEnabled = termsEnabled;
            this.TermsContent = termsContent;
            this.MaxCallDurationSeconds = maxCallDurationSeconds;
            this.SecondsRemaining = secondsRemaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareLinkPreview" /> class.
        /// </summary>
        public ShareLinkPreview()
        {
        }

    }
}