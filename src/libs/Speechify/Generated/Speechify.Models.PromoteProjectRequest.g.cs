
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromoteProjectRequest
    {
        /// <summary>
        /// The project to copy into. Must differ from the source and belong to the same workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteProjectRequest" /> class.
        /// </summary>
        /// <param name="targetProjectId">
        /// The project to copy into. Must differ from the source and belong to the same workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteProjectRequest(
            string targetProjectId)
        {
            this.TargetProjectId = targetProjectId ?? throw new global::System.ArgumentNullException(nameof(targetProjectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteProjectRequest" /> class.
        /// </summary>
        public PromoteProjectRequest()
        {
        }

    }
}