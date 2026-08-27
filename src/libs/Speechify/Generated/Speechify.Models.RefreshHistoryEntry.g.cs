
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One auto-refresh attempt. `running` only appears mid-tick;<br/>
    /// terminal values are the ones the drawer renders.
    /// </summary>
    public sealed partial class RefreshHistoryEntry
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
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.RefreshHistoryEntryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.RefreshHistoryEntryStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_hash")]
        public string? PreviousHash { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_hash")]
        public string? NewHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshHistoryEntry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="documentId"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="endedAt"></param>
        /// <param name="error"></param>
        /// <param name="previousHash"></param>
        /// <param name="newHash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefreshHistoryEntry(
            string id,
            string documentId,
            global::System.DateTime startedAt,
            global::Speechify.RefreshHistoryEntryStatus status,
            global::System.DateTime? endedAt,
            string? error,
            string? previousHash,
            string? newHash)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Status = status;
            this.Error = error;
            this.PreviousHash = previousHash;
            this.NewHash = newHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshHistoryEntry" /> class.
        /// </summary>
        public RefreshHistoryEntry()
        {
        }

    }
}