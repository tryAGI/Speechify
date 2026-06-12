
#nullable enable

namespace Speechify
{
    /// <summary>
    /// SRTP media encryption policy.<br/>
    /// - `disable` - Unencrypted media only.<br/>
    /// - `allow` - Negotiate SRTP; fall back to unencrypted. Recommended default.<br/>
    /// - `require` - Reject calls that do not support SRTP.
    /// </summary>
    public enum TtsSIPMediaEncryption
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Disable,
        /// <summary>
        /// 
        /// </summary>
        Require,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsSIPMediaEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsSIPMediaEncryption value)
        {
            return value switch
            {
                TtsSIPMediaEncryption.Allow => "allow",
                TtsSIPMediaEncryption.Disable => "disable",
                TtsSIPMediaEncryption.Require => "require",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsSIPMediaEncryption? ToEnum(string value)
        {
            return value switch
            {
                "allow" => TtsSIPMediaEncryption.Allow,
                "disable" => TtsSIPMediaEncryption.Disable,
                "require" => TtsSIPMediaEncryption.Require,
                _ => null,
            };
        }
    }
}