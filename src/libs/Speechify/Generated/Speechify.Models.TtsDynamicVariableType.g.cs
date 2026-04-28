
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Declared type of a customer-scope variable. Enforced at save time<br/>
    /// and again at session-start when an override value is supplied.<br/>
    /// - `string`  - plain text value; interpolated verbatim with `{{name}}`<br/>
    /// - `number`  - numeric value; rendered as its decimal representation<br/>
    /// - `boolean` - `true` or `false`<br/>
    /// - `json`    - any valid JSON value; use `{{name|json}}` to inject<br/>
    ///               safely inside JSON tool bodies
    /// </summary>
    public enum TtsDynamicVariableType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Json,
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
    public static class TtsDynamicVariableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsDynamicVariableType value)
        {
            return value switch
            {
                TtsDynamicVariableType.Boolean => "boolean",
                TtsDynamicVariableType.Json => "json",
                TtsDynamicVariableType.Number => "number",
                TtsDynamicVariableType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsDynamicVariableType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => TtsDynamicVariableType.Boolean,
                "json" => TtsDynamicVariableType.Json,
                "number" => TtsDynamicVariableType.Number,
                "string" => TtsDynamicVariableType.String,
                _ => null,
            };
        }
    }
}