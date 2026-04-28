
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsDeleteMemoriesByCallerResponse
    {
        /// <summary>
        /// Number of memories soft-deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsDeleteMemoriesByCallerResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Number of memories soft-deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsDeleteMemoriesByCallerResponse(
            int deleted)
        {
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsDeleteMemoriesByCallerResponse" /> class.
        /// </summary>
        public TtsDeleteMemoriesByCallerResponse()
        {
        }
    }
}