
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One change to this project's access or lifecycle state. The subject is<br/>
    /// whose access changed; the actor is who changed it.<br/>
    /// Every field below is always present. A field the event did not carry is<br/>
    /// `null`, which is a different fact from the key being absent altogether:<br/>
    /// `null` means this event had no such party, an absent key would mean the<br/>
    /// entry predates the platform recording that party at all. Audit entries<br/>
    /// are never backfilled, so the two are kept distinct.
    /// </summary>
    public sealed partial class ProjectAuditEvent
    {
        /// <summary>
        /// When the change was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Time { get; set; }

        /// <summary>
        /// What changed. `access_widened_to_workspace` is the revoke that<br/>
        /// removed the subject's LAST grant anywhere: a member with no grants<br/>
        /// reaches the whole workspace, so that revoke widened them rather<br/>
        /// than narrowing them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ProjectAuditEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ProjectAuditEventType Type { get; set; }

        /// <summary>
        /// The member whose access changed. Null on a lifecycle change, which is done to the project rather than to a person.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_user_id")]
        public string? SubjectUserId { get; set; }

        /// <summary>
        /// The member who made the change. Null when the change was system-initiated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_user_id")]
        public string? ActorUserId { get; set; }

        /// <summary>
        /// The actor's email at the time of the change. Null when the change carried no email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_email")]
        public string? ActorEmail { get; set; }

        /// <summary>
        /// The workspace role the actor held at the time. A role read back today cannot answer what they held when they acted. Null when the change carried no role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_role")]
        public string? ActorRole { get; set; }

        /// <summary>
        /// The Speechify support admin acting on the workspace's behalf. Null unless the change came through support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("impersonator_email")]
        public string? ImpersonatorEmail { get; set; }

        /// <summary>
        /// How many projects the subject held after the change. Null on a lifecycle change; zero is what makes a revoke a widening to the whole workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_grants")]
        public int? RemainingGrants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAuditEvent" /> class.
        /// </summary>
        /// <param name="time">
        /// When the change was recorded.
        /// </param>
        /// <param name="type">
        /// What changed. `access_widened_to_workspace` is the revoke that<br/>
        /// removed the subject's LAST grant anywhere: a member with no grants<br/>
        /// reaches the whole workspace, so that revoke widened them rather<br/>
        /// than narrowing them.
        /// </param>
        /// <param name="subjectUserId">
        /// The member whose access changed. Null on a lifecycle change, which is done to the project rather than to a person.
        /// </param>
        /// <param name="actorUserId">
        /// The member who made the change. Null when the change was system-initiated.
        /// </param>
        /// <param name="actorEmail">
        /// The actor's email at the time of the change. Null when the change carried no email.
        /// </param>
        /// <param name="actorRole">
        /// The workspace role the actor held at the time. A role read back today cannot answer what they held when they acted. Null when the change carried no role.
        /// </param>
        /// <param name="impersonatorEmail">
        /// The Speechify support admin acting on the workspace's behalf. Null unless the change came through support.
        /// </param>
        /// <param name="remainingGrants">
        /// How many projects the subject held after the change. Null on a lifecycle change; zero is what makes a revoke a widening to the whole workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectAuditEvent(
            global::System.DateTime time,
            global::Speechify.ProjectAuditEventType type,
            string? subjectUserId,
            string? actorUserId,
            string? actorEmail,
            string? actorRole,
            string? impersonatorEmail,
            int? remainingGrants)
        {
            this.Time = time;
            this.Type = type;
            this.SubjectUserId = subjectUserId;
            this.ActorUserId = actorUserId;
            this.ActorEmail = actorEmail;
            this.ActorRole = actorRole;
            this.ImpersonatorEmail = impersonatorEmail;
            this.RemainingGrants = remainingGrants;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAuditEvent" /> class.
        /// </summary>
        public ProjectAuditEvent()
        {
        }

    }
}