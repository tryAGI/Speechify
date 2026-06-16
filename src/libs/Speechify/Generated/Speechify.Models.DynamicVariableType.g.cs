
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
    public enum DynamicVariableType
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
    public static class DynamicVariableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DynamicVariableType value)
        {
            return value switch
            {
                DynamicVariableType.Boolean => "boolean",
                DynamicVariableType.Json => "json",
                DynamicVariableType.Number => "number",
                DynamicVariableType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DynamicVariableType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => DynamicVariableType.Boolean,
                "json" => DynamicVariableType.Json,
                "number" => DynamicVariableType.Number,
                "string" => DynamicVariableType.String,
                _ => null,
            };
        }
    }
}