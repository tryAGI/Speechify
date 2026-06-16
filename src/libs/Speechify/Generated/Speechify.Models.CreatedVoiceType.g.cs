
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatedVoiceType
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
    public static class CreatedVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedVoiceType value)
        {
            return value switch
            {
                CreatedVoiceType.Personal => "personal",
                CreatedVoiceType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "personal" => CreatedVoiceType.Personal,
                "shared" => CreatedVoiceType.Shared,
                _ => null,
            };
        }
    }
}