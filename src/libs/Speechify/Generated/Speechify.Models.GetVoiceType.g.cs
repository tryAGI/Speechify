
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum GetVoiceType
    {
        /// <summary>
        ///
        /// </summary>
        Personal,
        /// <summary>
        ///
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoiceType value)
        {
            return value switch
            {
                GetVoiceType.Personal => "personal",
                GetVoiceType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "personal" => GetVoiceType.Personal,
                "shared" => GetVoiceType.Shared,
                _ => null,
            };
        }
    }
}