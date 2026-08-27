
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum DataCollectionFieldType
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
    public static class DataCollectionFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataCollectionFieldType value)
        {
            return value switch
            {
                DataCollectionFieldType.Boolean => "boolean",
                DataCollectionFieldType.Int => "int",
                DataCollectionFieldType.Number => "number",
                DataCollectionFieldType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataCollectionFieldType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => DataCollectionFieldType.Boolean,
                "int" => DataCollectionFieldType.Int,
                "number" => DataCollectionFieldType.Number,
                "string" => DataCollectionFieldType.String,
                _ => null,
            };
        }
    }
}