
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMemoriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.Memory> Memories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMemoriesResponse" /> class.
        /// </summary>
        /// <param name="memories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMemoriesResponse(
            global::System.Collections.Generic.IList<global::Speechify.Memory> memories)
        {
            this.Memories = memories ?? throw new global::System.ArgumentNullException(nameof(memories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMemoriesResponse" /> class.
        /// </summary>
        public ListMemoriesResponse()
        {
        }

    }
}