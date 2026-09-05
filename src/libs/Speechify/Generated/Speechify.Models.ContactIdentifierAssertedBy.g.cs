
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Who vouched for this identifier. Server-assigned, never accepted<br/>
    /// from a client.<br/>
    /// - `api` - your authenticated backend, via this endpoint or a<br/>
    ///   server-to-server session. May be linked to an existing contact.<br/>
    /// - `telephony` - carrier ANI on an inbound call. Trustworthy as a<br/>
    ///   fact about the call and silent about which of your users it is,<br/>
    ///   so it creates a phone-only contact until you say otherwise.<br/>
    /// - `unverified` - a self-asserted claim from a public or embedded<br/>
    ///   browser session. Nobody stands behind it, so it never joins a<br/>
    ///   verified contact.
    /// </summary>
    public enum ContactIdentifierAssertedBy
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Telephony,
        /// <summary>
        ///
        /// </summary>
        Unverified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContactIdentifierAssertedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactIdentifierAssertedBy value)
        {
            return value switch
            {
                ContactIdentifierAssertedBy.Api => "api",
                ContactIdentifierAssertedBy.Telephony => "telephony",
                ContactIdentifierAssertedBy.Unverified => "unverified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactIdentifierAssertedBy? ToEnum(string value)
        {
            return value switch
            {
                "api" => ContactIdentifierAssertedBy.Api,
                "telephony" => ContactIdentifierAssertedBy.Telephony,
                "unverified" => ContactIdentifierAssertedBy.Unverified,
                _ => null,
            };
        }
    }
}