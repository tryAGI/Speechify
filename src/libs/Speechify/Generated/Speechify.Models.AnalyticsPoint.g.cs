
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One time-bucket value in a series.
    /// </summary>
    public sealed partial class AnalyticsPoint
    {
        /// <summary>
        /// Bucket start instant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("t")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime T { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsPoint" /> class.
        /// </summary>
        /// <param name="t">
        /// Bucket start instant.
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsPoint(
            global::System.DateTime t,
            double value)
        {
            this.T = t;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsPoint" /> class.
        /// </summary>
        public AnalyticsPoint()
        {
        }

    }
}