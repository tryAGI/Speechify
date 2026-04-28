
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Member's role within the workspace.<br/>
    /// - `owner`  - Full control, including deleting the workspace.<br/>
    /// - `admin`  - Manage members and invites; cannot change roles.<br/>
    /// - `member` - Standard access, no administrative rights.
    /// </summary>
    public enum TtsMemberRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsMemberRole value)
        {
            return value switch
            {
                TtsMemberRole.Admin => "admin",
                TtsMemberRole.Member => "member",
                TtsMemberRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => TtsMemberRole.Admin,
                "member" => TtsMemberRole.Member,
                "owner" => TtsMemberRole.Owner,
                _ => null,
            };
        }
    }
}