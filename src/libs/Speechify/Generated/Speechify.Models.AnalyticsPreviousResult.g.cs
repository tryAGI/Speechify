
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The same query over the immediately preceding period.
    /// </summary>
    public sealed partial class AnalyticsPreviousResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AnalyticsSeries> Series { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsPreviousResult" /> class.
        /// </summary>
        /// <param name="series"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsPreviousResult(
            global::System.Collections.Generic.IList<global::Speechify.AnalyticsSeries> series)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsPreviousResult" /> class.
        /// </summary>
        public AnalyticsPreviousResult()
        {
        }

    }
}