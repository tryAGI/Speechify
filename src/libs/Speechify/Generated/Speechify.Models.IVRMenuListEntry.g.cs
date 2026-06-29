
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One row in the list-IVR-menus response. Carries the sample<br/>
    /// transcript so a client can render the IVR identity (keyed on<br/>
    /// the prefixed `fingerprint_id`) without a second round-trip.<br/>
    /// `last_observed_at` and `occurrence_count` are projected from<br/>
    /// `ivr_fingerprints` for the "when did we last see this IVR" signal.
    /// </summary>
    public sealed partial class IVRMenuListEntry
    {
        /// <summary>
        /// Prefixed wire identifier (`menu_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FingerprintId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptSample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SchemaVersion { get; set; }

        /// <summary>
        /// Validated menu_tree per contracts/agents/ivr_menu.schema.json. Opaque to consumers other than the worker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("menu_tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.IvrMenuListEntryMenuTree MenuTree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfidenceScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded_traversals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SucceededTraversals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_traversals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTraversals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_validated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastValidatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_observed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastObservedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occurrence_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OccurrenceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IVRMenuListEntry" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`menu_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="fingerprintId"></param>
        /// <param name="transcriptSample"></param>
        /// <param name="schemaVersion"></param>
        /// <param name="menuTree">
        /// Validated menu_tree per contracts/agents/ivr_menu.schema.json. Opaque to consumers other than the worker.
        /// </param>
        /// <param name="confidenceScore"></param>
        /// <param name="succeededTraversals"></param>
        /// <param name="totalTraversals"></param>
        /// <param name="lastValidatedAt"></param>
        /// <param name="lastObservedAt"></param>
        /// <param name="occurrenceCount"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IVRMenuListEntry(
            string id,
            string fingerprintId,
            string transcriptSample,
            int schemaVersion,
            global::Speechify.IvrMenuListEntryMenuTree menuTree,
            double confidenceScore,
            int succeededTraversals,
            int totalTraversals,
            global::System.DateTime lastValidatedAt,
            global::System.DateTime lastObservedAt,
            int occurrenceCount,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FingerprintId = fingerprintId ?? throw new global::System.ArgumentNullException(nameof(fingerprintId));
            this.TranscriptSample = transcriptSample ?? throw new global::System.ArgumentNullException(nameof(transcriptSample));
            this.SchemaVersion = schemaVersion;
            this.MenuTree = menuTree ?? throw new global::System.ArgumentNullException(nameof(menuTree));
            this.ConfidenceScore = confidenceScore;
            this.SucceededTraversals = succeededTraversals;
            this.TotalTraversals = totalTraversals;
            this.LastValidatedAt = lastValidatedAt;
            this.LastObservedAt = lastObservedAt;
            this.OccurrenceCount = occurrenceCount;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IVRMenuListEntry" /> class.
        /// </summary>
        public IVRMenuListEntry()
        {
        }

    }
}