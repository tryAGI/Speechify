
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One resource kind a purge would remove or keep: a live count and, for<br/>
    /// removed kinds, a bounded sample of names. Retained kinds carry no<br/>
    /// sample, because a caller identity or a memory is personal data.
    /// </summary>
    public sealed partial class ProjectTeardownGroup
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Sample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTeardownGroup" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="count"></param>
        /// <param name="sample"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTeardownGroup(
            string kind,
            int count,
            global::System.Collections.Generic.IList<string> sample)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Count = count;
            this.Sample = sample ?? throw new global::System.ArgumentNullException(nameof(sample));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTeardownGroup" /> class.
        /// </summary>
        public ProjectTeardownGroup()
        {
        }

    }
}