
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Time scope + bucketing. Defaults to the last 30 days, the `started_at` field, no bucketing, and UTC.
    /// </summary>
    public sealed partial class AnalyticsTime
    {
        /// <summary>
        /// Which timestamp to scope + bucket on. `started_at` excludes never-connected calls; `created_at` counts all attempts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnalyticsTimeFieldJsonConverter))]
        public global::Speechify.AnalyticsTimeField? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnalyticsTimeBucketJsonConverter))]
        public global::Speechify.AnalyticsTimeBucket? Bucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public global::System.DateTime? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public global::System.DateTime? To { get; set; }

        /// <summary>
        /// IANA timezone for bucket boundaries (default UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsTime" /> class.
        /// </summary>
        /// <param name="field">
        /// Which timestamp to scope + bucket on. `started_at` excludes never-connected calls; `created_at` counts all attempts.
        /// </param>
        /// <param name="bucket"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="timezone">
        /// IANA timezone for bucket boundaries (default UTC).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsTime(
            global::Speechify.AnalyticsTimeField? field,
            global::Speechify.AnalyticsTimeBucket? bucket,
            global::System.DateTime? from,
            global::System.DateTime? to,
            string? timezone)
        {
            this.Field = field;
            this.Bucket = bucket;
            this.From = from;
            this.To = to;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsTime" /> class.
        /// </summary>
        public AnalyticsTime()
        {
        }

    }
}