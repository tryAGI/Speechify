
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Unauthenticated preview of a workspace invite. Surfaces only what<br/>
    /// the recipient needs to decide whether to accept (workspace name,<br/>
    /// invited address, inviter, expiry). Billing, plan, data region,<br/>
    /// and invite token are deliberately omitted.
    /// </summary>
    public sealed partial class TtsInvitePreview
    {
        /// <summary>
        /// Opaque workspace id. Safe to echo back on the accept call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// Workspace display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantName { get; set; }

        /// <summary>
        /// The email address the inviter typed when creating the invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvitedEmail { get; set; }

        /// <summary>
        /// Firebase email of the member who created the invite. May be<br/>
        /// absent if the Firebase profile lookup failed transiently —<br/>
        /// clients should still render the preview in that case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_by_email")]
        public string? InvitedByEmail { get; set; }

        /// <summary>
        /// Firebase display name of the member who created the invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_by_display_name")]
        public string? InvitedByDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsInvitePreview" /> class.
        /// </summary>
        /// <param name="tenantId">
        /// Opaque workspace id. Safe to echo back on the accept call.
        /// </param>
        /// <param name="tenantName">
        /// Workspace display name.
        /// </param>
        /// <param name="invitedEmail">
        /// The email address the inviter typed when creating the invite.
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="invitedByEmail">
        /// Firebase email of the member who created the invite. May be<br/>
        /// absent if the Firebase profile lookup failed transiently —<br/>
        /// clients should still render the preview in that case.
        /// </param>
        /// <param name="invitedByDisplayName">
        /// Firebase display name of the member who created the invite.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsInvitePreview(
            string tenantId,
            string tenantName,
            string invitedEmail,
            global::System.DateTime expiresAt,
            string? invitedByEmail,
            string? invitedByDisplayName)
        {
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.TenantName = tenantName ?? throw new global::System.ArgumentNullException(nameof(tenantName));
            this.InvitedEmail = invitedEmail ?? throw new global::System.ArgumentNullException(nameof(invitedEmail));
            this.InvitedByEmail = invitedByEmail;
            this.InvitedByDisplayName = invitedByDisplayName;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsInvitePreview" /> class.
        /// </summary>
        public TtsInvitePreview()
        {
        }
    }
}