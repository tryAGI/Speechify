
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsDataCollectionFieldType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Int,
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
    public static class TtsDataCollectionFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsDataCollectionFieldType value)
        {
            return value switch
            {
                TtsDataCollectionFieldType.Boolean => "boolean",
                TtsDataCollectionFieldType.Int => "int",
                TtsDataCollectionFieldType.Number => "number",
                TtsDataCollectionFieldType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsDataCollectionFieldType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => TtsDataCollectionFieldType.Boolean,
                "int" => TtsDataCollectionFieldType.Int,
                "number" => TtsDataCollectionFieldType.Number,
                "string" => TtsDataCollectionFieldType.String,
                _ => null,
            };
        }
    }
}