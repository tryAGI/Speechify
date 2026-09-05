
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The cadence of a schedule trigger. Set exactly one of `cron` or<br/>
    /// `interval_seconds`.
    /// </summary>
    public sealed partial class TriggerScheduleConfig
    {
        /// <summary>
        /// A standard 5-field cron expression (minute hour day-of-month month day-of-week).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        public string? Cron { get; set; }

        /// <summary>
        /// Fire every N seconds (minimum 60, maximum 7776000 = 90 days).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        public int? IntervalSeconds { get; set; }

        /// <summary>
        /// IANA timezone applied to `cron` (e.g. "America/New_York"). Defaults to UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerScheduleConfig" /> class.
        /// </summary>
        /// <param name="cron">
        /// A standard 5-field cron expression (minute hour day-of-month month day-of-week).
        /// </param>
        /// <param name="intervalSeconds">
        /// Fire every N seconds (minimum 60, maximum 7776000 = 90 days).
        /// </param>
        /// <param name="timezone">
        /// IANA timezone applied to `cron` (e.g. "America/New_York"). Defaults to UTC.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerScheduleConfig(
            string? cron,
            int? intervalSeconds,
            string? timezone)
        {
            this.Cron = cron;
            this.IntervalSeconds = intervalSeconds;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerScheduleConfig" /> class.
        /// </summary>
        public TriggerScheduleConfig()
        {
        }

    }
}