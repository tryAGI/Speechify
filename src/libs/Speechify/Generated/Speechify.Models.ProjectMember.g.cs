
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One project grant - a workspace member who may reach this project.
    /// </summary>
    public sealed partial class ProjectMember
    {
        /// <summary>
        /// The member's prefixed user id, joinable to the workspace members list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The prefixed user id of whoever made the grant. Attribution only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMember" /> class.
        /// </summary>
        /// <param name="userId">
        /// The member's prefixed user id, joinable to the workspace members list.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="grantedBy">
        /// The prefixed user id of whoever made the grant. Attribution only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectMember(
            string userId,
            global::System.DateTime createdAt,
            string grantedBy)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreatedAt = createdAt;
            this.GrantedBy = grantedBy ?? throw new global::System.ArgumentNullException(nameof(grantedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMember" /> class.
        /// </summary>
        public ProjectMember()
        {
        }

    }
}