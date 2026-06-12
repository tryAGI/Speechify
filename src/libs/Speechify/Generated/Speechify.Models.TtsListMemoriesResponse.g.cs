
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListMemoriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsMemory> Memories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListMemoriesResponse" /> class.
        /// </summary>
        /// <param name="memories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListMemoriesResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsMemory> memories)
        {
            this.Memories = memories ?? throw new global::System.ArgumentNullException(nameof(memories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListMemoriesResponse" /> class.
        /// </summary>
        public TtsListMemoriesResponse()
        {
        }

    }
}