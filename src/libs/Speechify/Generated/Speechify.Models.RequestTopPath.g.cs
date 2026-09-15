
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A called route pattern and its request count in the window.
    /// </summary>
    public sealed partial class RequestTopPath
    {
        /// <summary>
        /// The route pattern as the request log labels it. On a hosted API's analytics, the label of the route `route_id` names, and empty for a route since deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Route { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Hosted API analytics only - the route the row counts (`route_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_id")]
        public string? RouteId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTopPath" /> class.
        /// </summary>
        /// <param name="route">
        /// The route pattern as the request log labels it. On a hosted API's analytics, the label of the route `route_id` names, and empty for a route since deleted.
        /// </param>
        /// <param name="count"></param>
        /// <param name="routeId">
        /// Hosted API analytics only - the route the row counts (`route_...`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestTopPath(
            string route,
            int count,
            string? routeId)
        {
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.Count = count;
            this.RouteId = routeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTopPath" /> class.
        /// </summary>
        public RequestTopPath()
        {
        }

    }
}