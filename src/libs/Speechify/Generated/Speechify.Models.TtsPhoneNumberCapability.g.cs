
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the number can do. LiveKit-native numbers are `inbound` only;<br/>
    /// verified caller IDs are `outbound` only; Twilio and BYOC full-DID<br/>
    /// numbers (and Speechify-purchased numbers) support both directions.
    /// </summary>
    public enum TtsPhoneNumberCapability
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsPhoneNumberCapabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsPhoneNumberCapability value)
        {
            return value switch
            {
                TtsPhoneNumberCapability.Inbound => "inbound",
                TtsPhoneNumberCapability.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsPhoneNumberCapability? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => TtsPhoneNumberCapability.Inbound,
                "outbound" => TtsPhoneNumberCapability.Outbound,
                _ => null,
            };
        }
    }
}