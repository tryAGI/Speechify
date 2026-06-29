
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-request routing and token breakdown. Reports the route taken,<br/>
    /// whether it escalated, and the input/output token counts for each<br/>
    /// upstream model that ran. Token counts only — no pricing or cost.
    /// </summary>
    public sealed partial class WaymarkUsage
    {
        /// <summary>
        /// The route that served the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public string? Route { get; set; }

        /// <summary>
        /// Whether the gateway escalated to a higher route for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("escalated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Escalated { get; set; }

        /// <summary>
        /// One entry per upstream model that ran, summed across the fan-out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.WaymarkModelUsage> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WaymarkUsage" /> class.
        /// </summary>
        /// <param name="escalated">
        /// Whether the gateway escalated to a higher route for this request.
        /// </param>
        /// <param name="models">
        /// One entry per upstream model that ran, summed across the fan-out.
        /// </param>
        /// <param name="route">
        /// The route that served the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WaymarkUsage(
            bool escalated,
            global::System.Collections.Generic.IList<global::Speechify.WaymarkModelUsage> models,
            string? route)
        {
            this.Route = route;
            this.Escalated = escalated;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaymarkUsage" /> class.
        /// </summary>
        public WaymarkUsage()
        {
        }

    }
}