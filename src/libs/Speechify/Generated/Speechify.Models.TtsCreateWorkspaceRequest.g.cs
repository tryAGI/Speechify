
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for POST /v1/tenants. The `name` field is optional; omitting it falls back to "Workspace".
    /// </summary>
    public sealed partial class TtsCreateWorkspaceRequest
    {
        /// <summary>
        /// Display name for the new workspace. Trimmed; must be 120 characters or fewer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateWorkspaceRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name for the new workspace. Trimmed; must be 120 characters or fewer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateWorkspaceRequest(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateWorkspaceRequest" /> class.
        /// </summary>
        public TtsCreateWorkspaceRequest()
        {
        }
    }
}