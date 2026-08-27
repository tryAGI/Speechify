
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Read-only endpoint health. `unhealthy` after several consecutive<br/>
    /// delivery failures: inbound calls answer with the goodbye line and<br/>
    /// SMS events are parked instead of delivered. Resets to `healthy`<br/>
    /// on the next successful delivery, on rebinding the relay, or on<br/>
    /// rotating the secret.
    /// </summary>
    public enum PhoneNumberRelayHealth
    {
        /// <summary>
        ///
        /// </summary>
        Healthy,
        /// <summary>
        ///
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberRelayHealthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberRelayHealth value)
        {
            return value switch
            {
                PhoneNumberRelayHealth.Healthy => "healthy",
                PhoneNumberRelayHealth.Unhealthy => "unhealthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberRelayHealth? ToEnum(string value)
        {
            return value switch
            {
                "healthy" => PhoneNumberRelayHealth.Healthy,
                "unhealthy" => PhoneNumberRelayHealth.Unhealthy,
                _ => null,
            };
        }
    }
}