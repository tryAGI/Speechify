
#nullable enable

namespace Speechify
{
    /// <summary>
    /// SRTP media encryption policy.<br/>
    /// - `disable` - Unencrypted media only.<br/>
    /// - `allow` - Negotiate SRTP; fall back to unencrypted. Recommended default.<br/>
    /// - `require` - Reject calls that do not support SRTP.
    /// </summary>
    public enum SIPMediaEncryption
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
    public static class SIPMediaEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPMediaEncryption value)
        {
            return value switch
            {
                SIPMediaEncryption.Allow => "allow",
                SIPMediaEncryption.Disable => "disable",
                SIPMediaEncryption.Require => "require",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPMediaEncryption? ToEnum(string value)
        {
            return value switch
            {
                "allow" => SIPMediaEncryption.Allow,
                "disable" => SIPMediaEncryption.Disable,
                "require" => SIPMediaEncryption.Require,
                _ => null,
            };
        }
    }
}