
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The link's resolved lifecycle state, computed server-side so<br/>
    /// every client agrees on what "expired" means.
    /// </summary>
    public enum ShareLinkStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Exhausted,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShareLinkStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShareLinkStatus value)
        {
            return value switch
            {
                ShareLinkStatus.Active => "active",
                ShareLinkStatus.Exhausted => "exhausted",
                ShareLinkStatus.Expired => "expired",
                ShareLinkStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShareLinkStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ShareLinkStatus.Active,
                "exhausted" => ShareLinkStatus.Exhausted,
                "expired" => ShareLinkStatus.Expired,
                "revoked" => ShareLinkStatus.Revoked,
                _ => null,
            };
        }
    }
}