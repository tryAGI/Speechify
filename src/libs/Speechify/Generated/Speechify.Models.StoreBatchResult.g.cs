
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreBatchResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.StoreBatchResultOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.StoreBatchResultOp Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// One document: its index row plus, when bodies were requested, the JSON object itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Speechify.StoreDocument? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBatchResult" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="id"></param>
        /// <param name="document">
        /// One document: its index row plus, when bodies were requested, the JSON object itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreBatchResult(
            global::Speechify.StoreBatchResultOp op,
            string id,
            global::Speechify.StoreDocument? document)
        {
            this.Op = op;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBatchResult" /> class.
        /// </summary>
        public StoreBatchResult()
        {
        }

    }
}