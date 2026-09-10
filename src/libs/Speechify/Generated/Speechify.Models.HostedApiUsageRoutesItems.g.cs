
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedApiUsageRoutesItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RouteId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Reads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Writes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiUsageRoutesItems" /> class.
        /// </summary>
        /// <param name="routeId"></param>
        /// <param name="reads"></param>
        /// <param name="writes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedApiUsageRoutesItems(
            string routeId,
            long reads,
            long writes)
        {
            this.RouteId = routeId ?? throw new global::System.ArgumentNullException(nameof(routeId));
            this.Reads = reads;
            this.Writes = writes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiUsageRoutesItems" /> class.
        /// </summary>
        public HostedApiUsageRoutesItems()
        {
        }

    }
}