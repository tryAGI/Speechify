
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum DashboardWidgetChartType
    {
        /// <summary>
        /// 
        /// </summary>
        Bar,
        /// <summary>
        /// 
        /// </summary>
        Column,
        /// <summary>
        /// 
        /// </summary>
        Donut,
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardWidgetChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardWidgetChartType value)
        {
            return value switch
            {
                DashboardWidgetChartType.Bar => "bar",
                DashboardWidgetChartType.Column => "column",
                DashboardWidgetChartType.Donut => "donut",
                DashboardWidgetChartType.Line => "line",
                DashboardWidgetChartType.Number => "number",
                DashboardWidgetChartType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardWidgetChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => DashboardWidgetChartType.Bar,
                "column" => DashboardWidgetChartType.Column,
                "donut" => DashboardWidgetChartType.Donut,
                "line" => DashboardWidgetChartType.Line,
                "number" => DashboardWidgetChartType.Number,
                "table" => DashboardWidgetChartType.Table,
                _ => null,
            };
        }
    }
}