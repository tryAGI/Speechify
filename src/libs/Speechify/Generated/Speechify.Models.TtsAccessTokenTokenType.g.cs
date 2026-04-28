
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Token type
    /// </summary>
    public enum TtsAccessTokenTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsAccessTokenTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAccessTokenTokenType value)
        {
            return value switch
            {
                TtsAccessTokenTokenType.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAccessTokenTokenType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => TtsAccessTokenTokenType.Bearer,
                _ => null,
            };
        }
    }
}