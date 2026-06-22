
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for GET /v1/agents/dashboards.
    /// </summary>
    public sealed partial class ListDashboardsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboards")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.Dashboard> Dashboards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDashboardsResponse" /> class.
        /// </summary>
        /// <param name="dashboards"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDashboardsResponse(
            global::System.Collections.Generic.IList<global::Speechify.Dashboard> dashboards)
        {
            this.Dashboards = dashboards ?? throw new global::System.ArgumentNullException(nameof(dashboards));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDashboardsResponse" /> class.
        /// </summary>
        public ListDashboardsResponse()
        {
        }

    }
}