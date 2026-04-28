
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A member of a workspace (joined from `tenant_users` + Firebase profile).
    /// </summary>
    public sealed partial class TtsMember
    {
        /// <summary>
        /// Firebase user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserUid { get; set; }

        /// <summary>
        /// Member's email from Firebase. Empty when the account has been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Member's display name from Firebase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Member's role within the workspace.<br/>
        /// - `owner`  - Full control, including deleting the workspace.<br/>
        /// - `admin`  - Manage members and invites; cannot change roles.<br/>
        /// - `member` - Standard access, no administrative rights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsMemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsMemberRole Role { get; set; }

        /// <summary>
        /// When the user joined the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// True when this row is the authenticated caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSelf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsMember" /> class.
        /// </summary>
        /// <param name="userUid">
        /// Firebase user ID.
        /// </param>
        /// <param name="role">
        /// Member's role within the workspace.<br/>
        /// - `owner`  - Full control, including deleting the workspace.<br/>
        /// - `admin`  - Manage members and invites; cannot change roles.<br/>
        /// - `member` - Standard access, no administrative rights.
        /// </param>
        /// <param name="createdAt">
        /// When the user joined the workspace.
        /// </param>
        /// <param name="isSelf">
        /// True when this row is the authenticated caller.
        /// </param>
        /// <param name="email">
        /// Member's email from Firebase. Empty when the account has been deleted.
        /// </param>
        /// <param name="displayName">
        /// Member's display name from Firebase.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsMember(
            string userUid,
            global::Speechify.TtsMemberRole role,
            global::System.DateTime createdAt,
            bool isSelf,
            string? email,
            string? displayName)
        {
            this.UserUid = userUid ?? throw new global::System.ArgumentNullException(nameof(userUid));
            this.Email = email;
            this.DisplayName = displayName;
            this.Role = role;
            this.CreatedAt = createdAt;
            this.IsSelf = isSelf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsMember" /> class.
        /// </summary>
        public TtsMember()
        {
        }
    }
}