
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What deleting a project would do, in either mode, with nothing<br/>
    /// mutated. `blockers` is a bounded sample (at most 50) of the rows<br/>
    /// holding the project open, with the modes each refuses, and<br/>
    /// `blocker_count` is how many there are in total. `removes` is what a purge deletes or revokes, one<br/>
    /// entry per kind in a fixed order (zero counts included). `retains` is<br/>
    /// the operational records a purge keeps (a conversation with its frozen<br/>
    /// attribution, the rest moved to the Default project).
    /// </summary>
    public sealed partial class ProjectTeardown
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the project is archived. A purge is only available from<br/>
        /// the archived state, so this is the precondition to check before<br/>
        /// offering a teardown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// Whether `mode: purge` would be accepted right now: the project is<br/>
        /// archived and nothing blocks a purge. A courtesy read for the UI,<br/>
        /// never the authority - the delete re-decides both halves under the<br/>
        /// project's row lock, so a stale `true` still answers 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purge_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PurgeAvailable { get; set; }

        /// <summary>
        /// How many rows hold this project open in total. `blockers` lists at<br/>
        /// most 50 of them, so a project with more says so here; a delete is<br/>
        /// refused on this number, never on the length of the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocker_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BlockerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownBlocker> Blockers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownGroup> Removes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownGroup> Retains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTeardown" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="archived">
        /// Whether the project is archived. A purge is only available from<br/>
        /// the archived state, so this is the precondition to check before<br/>
        /// offering a teardown.
        /// </param>
        /// <param name="purgeAvailable">
        /// Whether `mode: purge` would be accepted right now: the project is<br/>
        /// archived and nothing blocks a purge. A courtesy read for the UI,<br/>
        /// never the authority - the delete re-decides both halves under the<br/>
        /// project's row lock, so a stale `true` still answers 409.
        /// </param>
        /// <param name="blockerCount">
        /// How many rows hold this project open in total. `blockers` lists at<br/>
        /// most 50 of them, so a project with more says so here; a delete is<br/>
        /// refused on this number, never on the length of the list.
        /// </param>
        /// <param name="blockers"></param>
        /// <param name="removes"></param>
        /// <param name="retains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTeardown(
            string id,
            string name,
            bool archived,
            bool purgeAvailable,
            int blockerCount,
            global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownBlocker> blockers,
            global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownGroup> removes,
            global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownGroup> retains)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Archived = archived;
            this.PurgeAvailable = purgeAvailable;
            this.BlockerCount = blockerCount;
            this.Blockers = blockers ?? throw new global::System.ArgumentNullException(nameof(blockers));
            this.Removes = removes ?? throw new global::System.ArgumentNullException(nameof(removes));
            this.Retains = retains ?? throw new global::System.ArgumentNullException(nameof(retains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTeardown" /> class.
        /// </summary>
        public ProjectTeardown()
        {
        }

    }
}