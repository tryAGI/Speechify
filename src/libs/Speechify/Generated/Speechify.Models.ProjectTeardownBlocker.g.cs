
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One row whose scope holds the project open, and the delete modes it<br/>
    /// refuses. A pinned API key, a service account, a scoped vault<br/>
    /// credential, a scoped webhook endpoint, a member grant and a pending<br/>
    /// invite carrying the project refuse a detach (detaching would widen<br/>
    /// them); a phone number refuses a purge (its release is an external<br/>
    /// side effect); a member grant that is the member's only one, and a<br/>
    /// live invite whose only project is this one, refuse both (clearing<br/>
    /// either would widen that person to the whole workspace, the invite one<br/>
    /// acceptance earlier).
    /// </summary>
    public sealed partial class ProjectTeardownBlocker
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ProjectTeardownBlockerKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ProjectTeardownBlockerKind Kind { get; set; }

        /// <summary>
        /// The row's prefixed external id. The kind decides which prefix:<br/>
        /// `key_` (API key), `svc_` (service account), `cred_` (vault<br/>
        /// credential), `whe_` (webhook endpoint), `invite_` (pending<br/>
        /// invite) and `phone_` (phone number) are Crockford base32 uuidv7<br/>
        /// ids, while `user_` (member grant) wraps the workspace user's<br/>
        /// opaque identifier, exactly as the project members surface returns<br/>
        /// it. Read `kind` to know which shape to expect.
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
        /// The delete modes this row refuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownBlockerBlocksItems> Blocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTeardownBlocker" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="id">
        /// The row's prefixed external id. The kind decides which prefix:<br/>
        /// `key_` (API key), `svc_` (service account), `cred_` (vault<br/>
        /// credential), `whe_` (webhook endpoint), `invite_` (pending<br/>
        /// invite) and `phone_` (phone number) are Crockford base32 uuidv7<br/>
        /// ids, while `user_` (member grant) wraps the workspace user's<br/>
        /// opaque identifier, exactly as the project members surface returns<br/>
        /// it. Read `kind` to know which shape to expect.
        /// </param>
        /// <param name="name"></param>
        /// <param name="blocks">
        /// The delete modes this row refuses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTeardownBlocker(
            global::Speechify.ProjectTeardownBlockerKind kind,
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownBlockerBlocksItems> blocks)
        {
            this.Kind = kind;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTeardownBlocker" /> class.
        /// </summary>
        public ProjectTeardownBlocker()
        {
        }

    }
}