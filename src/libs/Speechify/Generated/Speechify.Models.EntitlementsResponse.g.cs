
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `catalog` is every sellable tier's FLOOR entitlements, keyed by tier<br/>
    /// (`free`/`starter`/`pro`/`scale`/`enterprise`) for the upgrade cards.<br/>
    /// `current` is the caller's workspace RESOLVED entitlements (tier floor<br/>
    /// composed with its per-tenant override), so a custom/Enterprise customer<br/>
    /// sees their actual caps - not just the tier floor.
    /// </summary>
    public sealed partial class EntitlementsResponse
    {
        /// <summary>
        /// Per-tier floor entitlements, keyed by tier string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Speechify.BillingEntitlements> Catalog { get; set; }

        /// <summary>
        /// Customer-facing per-tier limits + feature flags, including the API<br/>
        /// rate limits the plan enforces. Numeric fields are caps; booleans gate<br/>
        /// features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.BillingEntitlements Current { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitlementsResponse" /> class.
        /// </summary>
        /// <param name="catalog">
        /// Per-tier floor entitlements, keyed by tier string.
        /// </param>
        /// <param name="current">
        /// Customer-facing per-tier limits + feature flags, including the API<br/>
        /// rate limits the plan enforces. Numeric fields are caps; booleans gate<br/>
        /// features.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntitlementsResponse(
            global::System.Collections.Generic.Dictionary<string, global::Speechify.BillingEntitlements> catalog,
            global::Speechify.BillingEntitlements current)
        {
            this.Catalog = catalog ?? throw new global::System.ArgumentNullException(nameof(catalog));
            this.Current = current ?? throw new global::System.ArgumentNullException(nameof(current));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitlementsResponse" /> class.
        /// </summary>
        public EntitlementsResponse()
        {
        }

    }
}