
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreBatchWrite
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.StoreBatchWriteOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.StoreBatchWriteOp Op { get; set; }

        /// <summary>
        /// The document id; minted for a `set` without one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBatchWrite" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="id">
        /// The document id; minted for a `set` without one.
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreBatchWrite(
            global::Speechify.StoreBatchWriteOp op,
            string? id,
            object? data)
        {
            this.Op = op;
            this.Id = id;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBatchWrite" /> class.
        /// </summary>
        public StoreBatchWrite()
        {
        }

    }
}