
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One hit from `GET /v1/agents/phone-numbers/available`. The number is<br/>
    /// not held: a concurrent buy by another customer may take it<br/>
    /// between this response and a subsequent purchase request.
    /// </summary>
    public sealed partial class AvailablePhoneNumber
    {
        /// <summary>
        /// The phone number in E.164 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e164")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string E164 { get; set; }

        /// <summary>
        /// Carrier-formatted display variant, e.g. "(415) 555-2671".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; set; }

        /// <summary>
        /// City the number is associated with, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locality")]
        public string? Locality { get; set; }

        /// <summary>
        /// Two-letter state code for US numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// ISO-3166 alpha-2 country code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iso_country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IsoCountry { get; set; }

        /// <summary>
        /// The purchasable carrier this number comes from. Pass it back<br/>
        /// verbatim as `provider` on the purchase request so the buy is<br/>
        /// placed on the matching Speechify-managed account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PurchasedPhoneNumberProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PurchasedPhoneNumberProvider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePhoneNumber" /> class.
        /// </summary>
        /// <param name="e164">
        /// The phone number in E.164 format.
        /// </param>
        /// <param name="isoCountry">
        /// ISO-3166 alpha-2 country code.
        /// </param>
        /// <param name="provider">
        /// The purchasable carrier this number comes from. Pass it back<br/>
        /// verbatim as `provider` on the purchase request so the buy is<br/>
        /// placed on the matching Speechify-managed account.
        /// </param>
        /// <param name="friendlyName">
        /// Carrier-formatted display variant, e.g. "(415) 555-2671".
        /// </param>
        /// <param name="locality">
        /// City the number is associated with, when known.
        /// </param>
        /// <param name="region">
        /// Two-letter state code for US numbers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailablePhoneNumber(
            string e164,
            string isoCountry,
            global::Speechify.PurchasedPhoneNumberProvider provider,
            string? friendlyName,
            string? locality,
            string? region)
        {
            this.E164 = e164 ?? throw new global::System.ArgumentNullException(nameof(e164));
            this.FriendlyName = friendlyName;
            this.Locality = locality;
            this.Region = region;
            this.IsoCountry = isoCountry ?? throw new global::System.ArgumentNullException(nameof(isoCountry));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePhoneNumber" /> class.
        /// </summary>
        public AvailablePhoneNumber()
        {
        }

    }
}