
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One organisational node in the per-owner tests tree. A folder is<br/>
    /// workspace-wide: it groups tests across agents and so across<br/>
    /// projects, and no project scope ever hides a folder. Every folder<br/>
    /// response carries `test_count` and `total_test_count`; neither ever<br/>
    /// counts a test the caller could not list. A single-folder response<br/>
    /// takes no `project_id` filter, so there the two are equal.
    /// </summary>
    public sealed partial class AgentTestFolder
    {
        /// <summary>
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When set, prefixed wire identifier<br/>
        /// (`folder_&lt;26 char Crockford base32&gt;`) of the parent folder.<br/>
        /// Null means root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Number of tests in this folder the caller's current project<br/>
        /// scope admits: the credential's project pin and the member's<br/>
        /// project grants, narrowed further by the `project_id` filter<br/>
        /// when given. It is the row count<br/>
        /// `GET /v1/agents/tests?folder_id=&lt;id&gt;` returns under the same<br/>
        /// scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TestCount { get; set; }

        /// <summary>
        /// Number of tests in this folder the caller could see with no<br/>
        /// `project_id` filter: every project for an unscoped caller,<br/>
        /// only the granted projects for a scoped member. It never counts<br/>
        /// a test the caller cannot list, so under a `project_id` filter<br/>
        /// the difference to `test_count` is how many of the folder's<br/>
        /// visible tests that filter hides, never how many sit outside<br/>
        /// the caller's grants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_test_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTestCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestFolder" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="name"></param>
        /// <param name="testCount">
        /// Number of tests in this folder the caller's current project<br/>
        /// scope admits: the credential's project pin and the member's<br/>
        /// project grants, narrowed further by the `project_id` filter<br/>
        /// when given. It is the row count<br/>
        /// `GET /v1/agents/tests?folder_id=&lt;id&gt;` returns under the same<br/>
        /// scope.
        /// </param>
        /// <param name="totalTestCount">
        /// Number of tests in this folder the caller could see with no<br/>
        /// `project_id` filter: every project for an unscoped caller,<br/>
        /// only the granted projects for a scoped member. It never counts<br/>
        /// a test the caller cannot list, so under a `project_id` filter<br/>
        /// the difference to `test_count` is how many of the folder's<br/>
        /// visible tests that filter hides, never how many sit outside<br/>
        /// the caller's grants.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="parentFolderId">
        /// When set, prefixed wire identifier<br/>
        /// (`folder_&lt;26 char Crockford base32&gt;`) of the parent folder.<br/>
        /// Null means root.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestFolder(
            string id,
            string name,
            int testCount,
            int totalTestCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? parentFolderId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ParentFolderId = parentFolderId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TestCount = testCount;
            this.TotalTestCount = totalTestCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestFolder" /> class.
        /// </summary>
        public AgentTestFolder()
        {
        }

    }
}