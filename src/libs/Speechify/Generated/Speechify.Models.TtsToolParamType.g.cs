
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Permitted JSON-Schema primitive types for tool params.
    /// </summary>
    public enum TtsToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsToolParamType value)
        {
            return value switch
            {
                TtsToolParamType.Boolean => "boolean",
                TtsToolParamType.Integer => "integer",
                TtsToolParamType.Number => "number",
                TtsToolParamType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => TtsToolParamType.Boolean,
                "integer" => TtsToolParamType.Integer,
                "number" => TtsToolParamType.Number,
                "string" => TtsToolParamType.String,
                _ => null,
            };
        }
    }
}