
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-document auto-refresh state. Only populated<br/>
    /// for url-sourced documents; file and text rows omit this and<br/>
    /// clients hide auto-refresh affordances accordingly.
    /// </summary>
    public sealed partial class RefreshConfig
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
        /// Delete the document once the source itself has answered "page gone"<br/>
        /// (HTTP 404 or 410) on 5 consecutive refreshes. A transient failure<br/>
        /// (outage, timeout, block) never removes a document: the last<br/>
        /// successfully fetched version keeps serving and the failure streak<br/>
        /// is reported in `consecutive_fetch_failures`.
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
        /// Refreshes in a row that failed to fetch the source. Reset to zero<br/>
        /// by the next successful fetch. While non-zero, the document still<br/>
        /// serves its last successfully fetched version.
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
        /// Initializes a new instance of the <see cref="RefreshConfig" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="intervalDays"></param>
        /// <param name="autoRemoveEnabled">
        /// Delete the document once the source itself has answered "page gone"<br/>
        /// (HTTP 404 or 410) on 5 consecutive refreshes. A transient failure<br/>
        /// (outage, timeout, block) never removes a document: the last<br/>
        /// successfully fetched version keeps serving and the failure streak<br/>
        /// is reported in `consecutive_fetch_failures`.
        /// </param>
        /// <param name="consecutiveFetchFailures">
        /// Refreshes in a row that failed to fetch the source. Reset to zero<br/>
        /// by the next successful fetch. While non-zero, the document still<br/>
        /// serves its last successfully fetched version.
        /// </param>
        /// <param name="lastRefreshedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefreshConfig(
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
        /// Initializes a new instance of the <see cref="RefreshConfig" /> class.
        /// </summary>
        public RefreshConfig()
        {
        }

    }
}