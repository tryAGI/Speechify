
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreAsset
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
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

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
        /// The API path the bytes stream from (prepend the API host).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BytesPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAsset" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filename"></param>
        /// <param name="contentType"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="createdAt"></param>
        /// <param name="bytesPath">
        /// The API path the bytes stream from (prepend the API host).
        /// </param>
        /// <param name="source">
        /// The durable run (and its journal step) that wrote this version. Absent for a direct API write.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreAsset(
            string id,
            string filename,
            string contentType,
            long sizeBytes,
            global::System.DateTime createdAt,
            string bytesPath,
            global::Speechify.StoreDocumentSource? source)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.SizeBytes = sizeBytes;
            this.Source = source;
            this.CreatedAt = createdAt;
            this.BytesPath = bytesPath ?? throw new global::System.ArgumentNullException(nameof(bytesPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAsset" /> class.
        /// </summary>
        public StoreAsset()
        {
        }

    }
}