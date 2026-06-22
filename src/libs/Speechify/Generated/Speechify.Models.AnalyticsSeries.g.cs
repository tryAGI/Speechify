
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One breakdown group (or the single ungrouped result). `points` is present only for bucketed (time-series) queries; `total` is the group's value (sum of points when bucketed).
    /// </summary>
    public sealed partial class AnalyticsSeries
    {
        /// <summary>
        /// The group-by dimension values for this series (absent when ungrouped).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public global::System.Collections.Generic.Dictionary<string, string>? Group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public global::System.Collections.Generic.IList<global::Speechify.AnalyticsPoint>? Points { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSeries" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="group">
        /// The group-by dimension values for this series (absent when ungrouped).
        /// </param>
        /// <param name="points"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsSeries(
            double total,
            global::System.Collections.Generic.Dictionary<string, string>? group,
            global::System.Collections.Generic.IList<global::Speechify.AnalyticsPoint>? points)
        {
            this.Group = group;
            this.Points = points;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSeries" /> class.
        /// </summary>
        public AnalyticsSeries()
        {
        }

    }
}