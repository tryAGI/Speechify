
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1UsageRequestsGetParametersPrincipalType
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
    public static class V1UsageRequestsGetParametersPrincipalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1UsageRequestsGetParametersPrincipalType value)
        {
            return value switch
            {
                V1UsageRequestsGetParametersPrincipalType.PersonalKey => "personal_key",
                V1UsageRequestsGetParametersPrincipalType.ServiceAccount => "service_account",
                V1UsageRequestsGetParametersPrincipalType.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1UsageRequestsGetParametersPrincipalType? ToEnum(string value)
        {
            return value switch
            {
                "personal_key" => V1UsageRequestsGetParametersPrincipalType.PersonalKey,
                "service_account" => V1UsageRequestsGetParametersPrincipalType.ServiceAccount,
                "session" => V1UsageRequestsGetParametersPrincipalType.Session,
                _ => null,
            };
        }
    }
}