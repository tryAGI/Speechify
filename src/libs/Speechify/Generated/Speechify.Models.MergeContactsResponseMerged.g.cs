
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MergeContactsResponseMerged
    {
        /// <summary>
        /// Identifiers re-pointed at the survivor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Identifiers { get; set; }

        /// <summary>
        /// Per-agent caller projections re-pointed at the survivor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Callers { get; set; }

        /// <summary>
        /// Conversations re-pointed at the survivor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Conversations { get; set; }

        /// <summary>
        /// Memory rows re-pointed at the survivor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Memories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeContactsResponseMerged" /> class.
        /// </summary>
        /// <param name="identifiers">
        /// Identifiers re-pointed at the survivor.
        /// </param>
        /// <param name="callers">
        /// Per-agent caller projections re-pointed at the survivor.
        /// </param>
        /// <param name="conversations">
        /// Conversations re-pointed at the survivor.
        /// </param>
        /// <param name="memories">
        /// Memory rows re-pointed at the survivor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergeContactsResponseMerged(
            int identifiers,
            int callers,
            int conversations,
            int memories)
        {
            this.Identifiers = identifiers;
            this.Callers = callers;
            this.Conversations = conversations;
            this.Memories = memories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeContactsResponseMerged" /> class.
        /// </summary>
        public MergeContactsResponseMerged()
        {
        }

    }
}