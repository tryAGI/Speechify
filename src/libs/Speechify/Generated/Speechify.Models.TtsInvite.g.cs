
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A pending or historical workspace invite.
    /// </summary>
    public sealed partial class TtsInvite
    {
        /// <summary>
        /// Opaque invite ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Invitee email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Firebase UID of the member who created the invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvitedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Populated once the invite has been accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_at")]
        public global::System.DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// Populated once the invite has been revoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_at")]
        public global::System.DateTime? RevokedAt { get; set; }

        /// <summary>
        /// Invite token. Returned ONLY on the create-invite response;<br/>
        /// subsequent list calls redact it. Use the token to build the<br/>
        /// `/join/{token}` join URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsInvite" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque invite ID.
        /// </param>
        /// <param name="email">
        /// Invitee email.
        /// </param>
        /// <param name="invitedBy">
        /// Firebase UID of the member who created the invite.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="acceptedAt">
        /// Populated once the invite has been accepted.
        /// </param>
        /// <param name="revokedAt">
        /// Populated once the invite has been revoked.
        /// </param>
        /// <param name="token">
        /// Invite token. Returned ONLY on the create-invite response;<br/>
        /// subsequent list calls redact it. Use the token to build the<br/>
        /// `/join/{token}` join URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsInvite(
            string id,
            string email,
            string invitedBy,
            global::System.DateTime createdAt,
            global::System.DateTime expiresAt,
            global::System.DateTime? acceptedAt,
            global::System.DateTime? revokedAt,
            string? token)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.InvitedBy = invitedBy ?? throw new global::System.ArgumentNullException(nameof(invitedBy));
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.AcceptedAt = acceptedAt;
            this.RevokedAt = revokedAt;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsInvite" /> class.
        /// </summary>
        public TtsInvite()
        {
        }
    }
}