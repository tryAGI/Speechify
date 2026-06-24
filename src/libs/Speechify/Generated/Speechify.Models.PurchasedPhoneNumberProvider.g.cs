
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The carrier a Speechify-managed number is bought on, used by<br/>
    /// `POST /v1/agents/phone-numbers/purchase`. Restricted to the<br/>
    /// purchasable providers - the resulting `phone_numbers` row carries<br/>
    /// the matching `PhoneNumberProvider` value.
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