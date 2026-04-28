
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsUpdateMemberRoleRequest
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateMemberRoleRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// Member's role within the workspace.<br/>
        /// - `owner`  - Full control, including deleting the workspace.<br/>
        /// - `admin`  - Manage members and invites; cannot change roles.<br/>
        /// - `member` - Standard access, no administrative rights.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateMemberRoleRequest(
            global::Speechify.TtsMemberRole role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateMemberRoleRequest" /> class.
        /// </summary>
        public TtsUpdateMemberRoleRequest()
        {
        }
    }
}