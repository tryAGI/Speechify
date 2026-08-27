
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Permitted JSON-Schema primitive types for tool params.
    /// </summary>
    public enum ToolParamType
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
    public static class ToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolParamType value)
        {
            return value switch
            {
                ToolParamType.Boolean => "boolean",
                ToolParamType.Integer => "integer",
                ToolParamType.Number => "number",
                ToolParamType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => ToolParamType.Boolean,
                "integer" => ToolParamType.Integer,
                "number" => ToolParamType.Number,
                "string" => ToolParamType.String,
                _ => null,
            };
        }
    }
}