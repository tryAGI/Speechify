
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsOAuthErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidClient,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// 
        /// </summary>
        InvalidScope,
        /// <summary>
        /// 
        /// </summary>
        UnauthorizedClient,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedGrantType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsOAuthErrorErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsOAuthErrorError value)
        {
            return value switch
            {
                TtsOAuthErrorError.InvalidClient => "invalid_client",
                TtsOAuthErrorError.InvalidRequest => "invalid_request",
                TtsOAuthErrorError.InvalidScope => "invalid_scope",
                TtsOAuthErrorError.UnauthorizedClient => "unauthorized_client",
                TtsOAuthErrorError.UnsupportedGrantType => "unsupported_grant_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsOAuthErrorError? ToEnum(string value)
        {
            return value switch
            {
                "invalid_client" => TtsOAuthErrorError.InvalidClient,
                "invalid_request" => TtsOAuthErrorError.InvalidRequest,
                "invalid_scope" => TtsOAuthErrorError.InvalidScope,
                "unauthorized_client" => TtsOAuthErrorError.UnauthorizedClient,
                "unsupported_grant_type" => TtsOAuthErrorError.UnsupportedGrantType,
                _ => null,
            };
        }
    }
}