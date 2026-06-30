
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The resolving principal's credential class.
    /// </summary>
    public enum RequestLogEntryPrincipalType
    {
        /// <summary>
        /// 
        /// </summary>
        PersonalKey,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        Session,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestLogEntryPrincipalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestLogEntryPrincipalType value)
        {
            return value switch
            {
                RequestLogEntryPrincipalType.PersonalKey => "personal_key",
                RequestLogEntryPrincipalType.ServiceAccount => "service_account",
                RequestLogEntryPrincipalType.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestLogEntryPrincipalType? ToEnum(string value)
        {
            return value switch
            {
                "personal_key" => RequestLogEntryPrincipalType.PersonalKey,
                "service_account" => RequestLogEntryPrincipalType.ServiceAccount,
                "session" => RequestLogEntryPrincipalType.Session,
                _ => null,
            };
        }
    }
}