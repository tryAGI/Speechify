
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `consumer_key`: every request presents a `ck_` bearer minted for this<br/>
    /// API. `public`: no credential; only read resolvers may be served, and<br/>
    /// the per-IP limiter is the only bound. `user_token`: every request<br/>
    /// presents a short-lived JWT your backend signed for the calling user<br/>
    /// (`sub`, `exp` within 24 hours, optional `aud` naming this API),<br/>
    /// verified against the API's signing secret (HS256) or its registered<br/>
    /// JWKS URL (RS256 / ES256 / EdDSA). Routes bind the verified claims as<br/>
    /// `{{user.sub}}` and the response cache is keyed per user.
    /// </summary>
    public enum HostedApiAuthMode
    {
        /// <summary>
        /// every request presents a `ck_` bearer minted for this
        /// </summary>
        ConsumerKey,
        /// <summary>
        /// no credential; only read resolvers may be served, and
        /// </summary>
        Public,
        /// <summary>
        /// every request
        /// </summary>
        UserToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedApiAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedApiAuthMode value)
        {
            return value switch
            {
                HostedApiAuthMode.ConsumerKey => "consumer_key",
                HostedApiAuthMode.Public => "public",
                HostedApiAuthMode.UserToken => "user_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedApiAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "consumer_key" => HostedApiAuthMode.ConsumerKey,
                "public" => HostedApiAuthMode.Public,
                "user_token" => HostedApiAuthMode.UserToken,
                _ => null,
            };
        }
    }
}