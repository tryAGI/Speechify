
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The link's resolved lifecycle state, computed server-side so<br/>
    /// every client agrees on what "expired" means.
    /// </summary>
    public enum CreateShareLinkResponseStatus
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
    public static class CreateShareLinkResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateShareLinkResponseStatus value)
        {
            return value switch
            {
                CreateShareLinkResponseStatus.Active => "active",
                CreateShareLinkResponseStatus.Exhausted => "exhausted",
                CreateShareLinkResponseStatus.Expired => "expired",
                CreateShareLinkResponseStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateShareLinkResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CreateShareLinkResponseStatus.Active,
                "exhausted" => CreateShareLinkResponseStatus.Exhausted,
                "expired" => CreateShareLinkResponseStatus.Expired,
                "revoked" => CreateShareLinkResponseStatus.Revoked,
                _ => null,
            };
        }
    }
}