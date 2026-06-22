
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for GET /v1/agents/analytics/dimensions.
    /// </summary>
    public sealed partial class AnalyticsDimensionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AnalyticsDimension> Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsDimensionsResponse" /> class.
        /// </summary>
        /// <param name="dimensions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsDimensionsResponse(
            global::System.Collections.Generic.IList<global::Speechify.AnalyticsDimension> dimensions)
        {
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsDimensionsResponse" /> class.
        /// </summary>
        public AnalyticsDimensionsResponse()
        {
        }

    }
}