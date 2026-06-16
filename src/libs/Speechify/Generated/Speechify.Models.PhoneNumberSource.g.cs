
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Where the number came from. Determines the provisioning and<br/>
    /// portability path.<br/>
    /// - `livekit` - LiveKit owns the carrier relationship; US inbound only.<br/>
    /// - `twilio` - Customer's own Twilio number bridged via Elastic SIP Trunk.<br/>
    /// - `byoc` - Any SIP provider using a customer-supplied trunk.<br/>
    /// - `twilio_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` on Speechify's master Twilio account; billed to Speechify.<br/>
    /// - `verified_caller_id` - Customer-verified outbound caller ID on<br/>
    ///   their own Twilio account (Twilio's OutgoingCallerIds resource).<br/>
    ///   Server-determined at import time: when an `e164` submitted with<br/>
    ///   `source=twilio` is not a full DID on the customer's account but<br/>
    ///   IS a verified caller ID, the resulting row gets this source.<br/>
    ///   Outbound-only, never agent-bindable, rides the customer's<br/>
    ///   existing shared Twilio trunk for outbound routing. Requires a<br/>
    ///   prior `twilio` full-DID import from the same account; without<br/>
    ///   it the import returns 400.
    /// </summary>
    public enum PhoneNumberSource
    {
        /// <summary>
        /// 
        /// </summary>
        Byoc,
        /// <summary>
        /// 
        /// </summary>
        Livekit,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        TwilioPurchased,
        /// <summary>
        /// 
        /// </summary>
        VerifiedCallerId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberSource value)
        {
            return value switch
            {
                PhoneNumberSource.Byoc => "byoc",
                PhoneNumberSource.Livekit => "livekit",
                PhoneNumberSource.Twilio => "twilio",
                PhoneNumberSource.TwilioPurchased => "twilio_purchased",
                PhoneNumberSource.VerifiedCallerId => "verified_caller_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberSource? ToEnum(string value)
        {
            return value switch
            {
                "byoc" => PhoneNumberSource.Byoc,
                "livekit" => PhoneNumberSource.Livekit,
                "twilio" => PhoneNumberSource.Twilio,
                "twilio_purchased" => PhoneNumberSource.TwilioPurchased,
                "verified_caller_id" => PhoneNumberSource.VerifiedCallerId,
                _ => null,
            };
        }
    }
}