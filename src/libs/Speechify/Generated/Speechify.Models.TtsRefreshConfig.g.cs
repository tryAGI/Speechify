
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-document auto-refresh state. Only populated<br/>
    /// for url-sourced documents; file and text rows omit this and<br/>
    /// the console's auto-refresh panel hides accordingly.
    /// </summary>
    public sealed partial class TtsRefreshConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IntervalDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_remove_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRemoveEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_refreshed_at")]
        public global::System.DateTime? LastRefreshedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consecutive_fetch_failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConsecutiveFetchFailures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRefreshConfig" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="intervalDays"></param>
        /// <param name="autoRemoveEnabled"></param>
        /// <param name="consecutiveFetchFailures"></param>
        /// <param name="lastRefreshedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsRefreshConfig(
            bool enabled,
            int intervalDays,
            bool autoRemoveEnabled,
            int consecutiveFetchFailures,
            global::System.DateTime? lastRefreshedAt)
        {
            this.Enabled = enabled;
            this.IntervalDays = intervalDays;
            this.AutoRemoveEnabled = autoRemoveEnabled;
            this.LastRefreshedAt = lastRefreshedAt;
            this.ConsecutiveFetchFailures = consecutiveFetchFailures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRefreshConfig" /> class.
        /// </summary>
        public TtsRefreshConfig()
        {
        }

    }
}