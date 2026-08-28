
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The carrier a Speechify-managed number is bought on, used by<br/>
    /// `POST /v1/agents/phone-numbers/purchase`. The resulting<br/>
    /// `phone_numbers` row carries the matching `PhoneNumberProvider`<br/>
    /// value.<br/>
    /// Only `telnyx_purchased` can be bought. `twilio_purchased` is<br/>
    /// **retired for new purchases** and returns `400 validation_failed`;<br/>
    /// it remains in this enum because numbers already bought on it are<br/>
    /// still listed, released and dialled normally, and because removing a<br/>
    /// request enum value would be a breaking change. Omit `provider` and<br/>
    /// the buy lands on the current carrier automatically - the<br/>
    /// recommended call for every client.
    /// </summary>
    public enum PurchasedPhoneNumberProvider
    {
        /// <summary>
        ///
        /// </summary>
        TelnyxPurchased,
        /// <summary>
        ///
        /// </summary>
        TwilioPurchased,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PurchasedPhoneNumberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PurchasedPhoneNumberProvider value)
        {
            return value switch
            {
                PurchasedPhoneNumberProvider.TelnyxPurchased => "telnyx_purchased",
                PurchasedPhoneNumberProvider.TwilioPurchased => "twilio_purchased",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PurchasedPhoneNumberProvider? ToEnum(string value)
        {
            return value switch
            {
                "telnyx_purchased" => PurchasedPhoneNumberProvider.TelnyxPurchased,
                "twilio_purchased" => PurchasedPhoneNumberProvider.TwilioPurchased,
                _ => null,
            };
        }
    }
}