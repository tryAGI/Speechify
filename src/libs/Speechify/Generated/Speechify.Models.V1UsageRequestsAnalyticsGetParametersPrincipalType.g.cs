
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1UsageRequestsAnalyticsGetParametersPrincipalType
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
    public static class V1UsageRequestsAnalyticsGetParametersPrincipalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1UsageRequestsAnalyticsGetParametersPrincipalType value)
        {
            return value switch
            {
                V1UsageRequestsAnalyticsGetParametersPrincipalType.PersonalKey => "personal_key",
                V1UsageRequestsAnalyticsGetParametersPrincipalType.ServiceAccount => "service_account",
                V1UsageRequestsAnalyticsGetParametersPrincipalType.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1UsageRequestsAnalyticsGetParametersPrincipalType? ToEnum(string value)
        {
            return value switch
            {
                "personal_key" => V1UsageRequestsAnalyticsGetParametersPrincipalType.PersonalKey,
                "service_account" => V1UsageRequestsAnalyticsGetParametersPrincipalType.ServiceAccount,
                "session" => V1UsageRequestsAnalyticsGetParametersPrincipalType.Session,
                _ => null,
            };
        }
    }
}