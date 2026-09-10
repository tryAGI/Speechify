
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Who the API answers, narrowest first. `owner`: only the API's owner,<br/>
    /// with their own Speechify API key or console session. `workspace`:<br/>
    /// any member of the owning workspace, the same way. `user_token`:<br/>
    /// every request presents a short-lived JWT your backend signed for the<br/>
    /// calling user (`sub`, `exp` within 24 hours, optional `aud` naming<br/>
    /// this API), verified against the API's signing secret (HS256) or its<br/>
    /// registered JWKS URL (RS256 / ES256 / EdDSA). `consumer_key`: every<br/>
    /// request presents a `ck_` bearer minted for this API. `public`: no<br/>
    /// credential; only read resolvers may be served, the per-IP limiter is<br/>
    /// the only bound, and a workspace can refuse it as policy<br/>
    /// (`hosted_apis_public_allowed`). The three modes that name a person<br/>
    /// (`owner`, `workspace`, `user_token`) let routes bind `{{user.sub}}`,<br/>
    /// key the response cache per person, and stamp a written document as<br/>
    /// that person's.
    /// </summary>
    public enum HostedApiAuthMode
    {
        /// <summary>
        /// every
        /// </summary>
        ConsumerKey,
        /// <summary>
        /// only the API's owner,
        /// </summary>
        Owner,
        /// <summary>
        /// no
        /// </summary>
        Public,
        /// <summary>
        ///
        /// </summary>
        UserToken,
        /// <summary>
        ///
        /// </summary>
        Workspace,
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
                HostedApiAuthMode.Owner => "owner",
                HostedApiAuthMode.Public => "public",
                HostedApiAuthMode.UserToken => "user_token",
                HostedApiAuthMode.Workspace => "workspace",
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
                "owner" => HostedApiAuthMode.Owner,
                "public" => HostedApiAuthMode.Public,
                "user_token" => HostedApiAuthMode.UserToken,
                "workspace" => HostedApiAuthMode.Workspace,
                _ => null,
            };
        }
    }
}