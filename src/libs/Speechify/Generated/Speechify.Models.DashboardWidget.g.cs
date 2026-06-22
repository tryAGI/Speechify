
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One chart on a dashboard — a chart type rendering an analytics query at a grid position.
    /// </summary>
    public sealed partial class DashboardWidget
    {
        /// <summary>
        /// Stable widget id, unique within the dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.DashboardWidgetChartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.DashboardWidgetChartType ChartType { get; set; }

        /// <summary>
        /// One tenant-scoped aggregation that powers a dashboard widget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsQueryRequest Query { get; set; }

        /// <summary>
        /// Which of the query's group_by dimensions a categorical chart (bar / column / donut / table) renders. Omitted for number / line.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_dim")]
        public string? GroupDim { get; set; }

        /// <summary>
        /// A widget's place + size in the responsive grid (12-column units).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.DashboardPosition Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardWidget" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable widget id, unique within the dashboard.
        /// </param>
        /// <param name="title"></param>
        /// <param name="chartType"></param>
        /// <param name="query">
        /// One tenant-scoped aggregation that powers a dashboard widget.
        /// </param>
        /// <param name="position">
        /// A widget's place + size in the responsive grid (12-column units).
        /// </param>
        /// <param name="groupDim">
        /// Which of the query's group_by dimensions a categorical chart (bar / column / donut / table) renders. Omitted for number / line.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardWidget(
            string id,
            string title,
            global::Speechify.DashboardWidgetChartType chartType,
            global::Speechify.AnalyticsQueryRequest query,
            global::Speechify.DashboardPosition position,
            string? groupDim)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ChartType = chartType;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.GroupDim = groupDim;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardWidget" /> class.
        /// </summary>
        public DashboardWidget()
        {
        }

    }
}