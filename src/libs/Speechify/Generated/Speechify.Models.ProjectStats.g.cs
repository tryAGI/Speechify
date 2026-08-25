
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What a project contains, as live resource counts.<br/>
    /// Credentials pinned to the project are deliberately not included.<br/>
    /// Listing API keys and service accounts is an account-level operation<br/>
    /// with its own authentication, so use those endpoints directly rather<br/>
    /// than reading credential names through a project read.
    /// </summary>
    public sealed partial class ProjectStats
    {
        /// <summary>
        /// Live counts of every resource kind grouped under one project. Each<br/>
        /// count is zero, never absent, when the project holds none of that<br/>
        /// kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ProjectResourceCounts ResourceCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStats" /> class.
        /// </summary>
        /// <param name="resourceCounts">
        /// Live counts of every resource kind grouped under one project. Each<br/>
        /// count is zero, never absent, when the project holds none of that<br/>
        /// kind.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectStats(
            global::Speechify.ProjectResourceCounts resourceCounts)
        {
            this.ResourceCounts = resourceCounts ?? throw new global::System.ArgumentNullException(nameof(resourceCounts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStats" /> class.
        /// </summary>
        public ProjectStats()
        {
        }

    }
}