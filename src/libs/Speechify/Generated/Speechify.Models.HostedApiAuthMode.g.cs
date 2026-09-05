
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `consumer_key`: every request presents a `ck_` bearer minted for this<br/>
    /// API. `public`: no credential; only read resolvers may be served, and<br/>
    /// the per-IP limiter is the only bound.
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
                _ => null,
            };
        }
    }
}