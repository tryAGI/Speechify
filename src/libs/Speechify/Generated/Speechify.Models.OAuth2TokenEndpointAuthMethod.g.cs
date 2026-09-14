
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How a client-credentials credential authenticates to its `token_url`<br/>
    /// when an access token is minted. `client_secret_post` sends `client_id`<br/>
    /// and `client_secret` as form parameters in the request body, and is what<br/>
    /// a credential that omits this field uses. `client_secret_basic` sends<br/>
    /// them in an HTTP Basic `Authorization` header instead (each value<br/>
    /// form-urlencoded first, as RFC 6749 section 2.3.1 specifies) and neither<br/>
    /// in the body. Most providers accept either; choose `client_secret_basic`<br/>
    /// when the provider's documentation says so.
    /// </summary>
    public enum OAuth2TokenEndpointAuthMethod
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        ///
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuth2TokenEndpointAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2TokenEndpointAuthMethod value)
        {
            return value switch
            {
                OAuth2TokenEndpointAuthMethod.ClientSecretBasic => "client_secret_basic",
                OAuth2TokenEndpointAuthMethod.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2TokenEndpointAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => OAuth2TokenEndpointAuthMethod.ClientSecretBasic,
                "client_secret_post" => OAuth2TokenEndpointAuthMethod.ClientSecretPost,
                _ => null,
            };
        }
    }
}