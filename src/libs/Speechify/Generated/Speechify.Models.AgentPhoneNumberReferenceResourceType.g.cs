
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Always `phone_number`.
    /// </summary>
    public enum AgentPhoneNumberReferenceResourceType
    {
        /// <summary>
        ///
        /// </summary>
        PhoneNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPhoneNumberReferenceResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPhoneNumberReferenceResourceType value)
        {
            return value switch
            {
                AgentPhoneNumberReferenceResourceType.PhoneNumber => "phone_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPhoneNumberReferenceResourceType? ToEnum(string value)
        {
            return value switch
            {
                "phone_number" => AgentPhoneNumberReferenceResourceType.PhoneNumber,
                _ => null,
            };
        }
    }
}