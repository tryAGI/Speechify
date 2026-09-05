
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One document: its index row plus, when bodies were requested, the JSON object itself.
    /// </summary>
    public sealed partial class StoreDocument
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Collection { get; set; }

        /// <summary>
        /// Incremented on every write to this id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// The durable run (and its journal step) that wrote this version. Absent for a direct API write.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Speechify.StoreDocumentSource? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The document body. Absent when the caller asked for index rows only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDocument" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <param name="version">
        /// Incremented on every write to this id.
        /// </param>
        /// <param name="sizeBytes"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="source">
        /// The durable run (and its journal step) that wrote this version. Absent for a direct API write.
        /// </param>
        /// <param name="data">
        /// The document body. Absent when the caller asked for index rows only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreDocument(
            string id,
            string collection,
            int version,
            long sizeBytes,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Speechify.StoreDocumentSource? source,
            object? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Collection = collection ?? throw new global::System.ArgumentNullException(nameof(collection));
            this.Version = version;
            this.SizeBytes = sizeBytes;
            this.Source = source;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDocument" /> class.
        /// </summary>
        public StoreDocument()
        {
        }

    }
}