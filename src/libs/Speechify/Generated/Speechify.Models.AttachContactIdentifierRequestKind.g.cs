
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The namespace this value lives in.
    /// </summary>
    public enum AttachContactIdentifierRequestKind
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
    public static class AttachContactIdentifierRequestKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttachContactIdentifierRequestKind value)
        {
            return value switch
            {
                AttachContactIdentifierRequestKind.Email => "email",
                AttachContactIdentifierRequestKind.ExternalId => "external_id",
                AttachContactIdentifierRequestKind.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttachContactIdentifierRequestKind? ToEnum(string value)
        {
            return value switch
            {
                "email" => AttachContactIdentifierRequestKind.Email,
                "external_id" => AttachContactIdentifierRequestKind.ExternalId,
                "phone" => AttachContactIdentifierRequestKind.Phone,
                _ => null,
            };
        }
    }
}