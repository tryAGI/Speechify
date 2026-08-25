
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The outcome of restoring a purged project: what came back, and what<br/>
    /// deliberately did not.<br/>
    /// `restored` counts the resources the purge removed and this call<br/>
    /// brought back. `still_revoked` counts the credentials the purge revoked<br/>
    /// and this call left revoked, because re-issuing a credential someone<br/>
    /// killed would hand back access rather than restore a project. Member<br/>
    /// grants and pending-invite scopes are in that second group too, but<br/>
    /// their rows were removed by the purge, so they cannot be counted and<br/>
    /// appear only in `not_restored_note`.<br/>
    /// The project comes back ARCHIVED, the state it was purged from, so<br/>
    /// `archived_at` is always set: nothing dispatches or bills inside it<br/>
    /// until you unarchive it on purpose.
    /// </summary>
    public sealed partial class ProjectRestore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When the purge this call walked back happened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purged_at")]
        public global::System.DateTime? PurgedAt { get; set; }

        /// <summary>
        /// When the project was archived. Always set on a restore: a project<br/>
        /// comes back suspended, never live.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// What a restore brought back, by kind. Every field is a real count,<br/>
        /// including zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restored")]
        public global::Speechify.ProjectRestoredCounts? Restored { get; set; }

        /// <summary>
        /// What the restore deliberately left revoked: the credentials the purge<br/>
        /// killed. Every field is a real count, including zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("still_revoked")]
        public global::Speechify.ProjectStillRevokedCounts? StillRevoked { get; set; }

        /// <summary>
        /// A plain-language statement of what a restore does not bring back.<br/>
        /// Constant text, meant to be shown to a person; branch on<br/>
        /// `still_revoked` rather than parsing it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_restored_note")]
        public string? NotRestoredNote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRestore" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="purgedAt">
        /// When the purge this call walked back happened.
        /// </param>
        /// <param name="archivedAt">
        /// When the project was archived. Always set on a restore: a project<br/>
        /// comes back suspended, never live.
        /// </param>
        /// <param name="restored">
        /// What a restore brought back, by kind. Every field is a real count,<br/>
        /// including zero.
        /// </param>
        /// <param name="stillRevoked">
        /// What the restore deliberately left revoked: the credentials the purge<br/>
        /// killed. Every field is a real count, including zero.
        /// </param>
        /// <param name="notRestoredNote">
        /// A plain-language statement of what a restore does not bring back.<br/>
        /// Constant text, meant to be shown to a person; branch on<br/>
        /// `still_revoked` rather than parsing it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRestore(
            string? id,
            string? name,
            global::System.DateTime? purgedAt,
            global::System.DateTime? archivedAt,
            global::Speechify.ProjectRestoredCounts? restored,
            global::Speechify.ProjectStillRevokedCounts? stillRevoked,
            string? notRestoredNote)
        {
            this.Id = id;
            this.Name = name;
            this.PurgedAt = purgedAt;
            this.ArchivedAt = archivedAt;
            this.Restored = restored;
            this.StillRevoked = stillRevoked;
            this.NotRestoredNote = notRestoredNote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRestore" /> class.
        /// </summary>
        public ProjectRestore()
        {
        }

    }
}