
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The namespace the value lives in. Values of different kinds never<br/>
    /// denote the same person by themselves, whatever they look like.
    /// </summary>
    public enum ContactIdentifierKind
    {
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        ExternalId,
        /// <summary>
        ///
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContactIdentifierKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactIdentifierKind value)
        {
            return value switch
            {
                ContactIdentifierKind.Email => "email",
                ContactIdentifierKind.ExternalId => "external_id",
                ContactIdentifierKind.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactIdentifierKind? ToEnum(string value)
        {
            return value switch
            {
                "email" => ContactIdentifierKind.Email,
                "external_id" => ContactIdentifierKind.ExternalId,
                "phone" => ContactIdentifierKind.Phone,
                _ => null,
            };
        }
    }
}