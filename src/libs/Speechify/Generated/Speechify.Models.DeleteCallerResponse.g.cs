
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Audit envelope returned by DELETE /v1/agents/callers/{id}. Surfaces<br/>
    /// the cascade row counts so a privacy operator has direct evidence<br/>
    /// of the purge without re-querying.
    /// </summary>
    public sealed partial class DeleteCallerResponse
    {
        /// <summary>
        /// 1 on the first delete; 0 on idempotent re-delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_purged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallerPurged { get; set; }

        /// <summary>
        /// Number of user_memories rows cascade-soft-deleted under this caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories_purged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoriesPurged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCallerResponse" /> class.
        /// </summary>
        /// <param name="callerPurged">
        /// 1 on the first delete; 0 on idempotent re-delete.
        /// </param>
        /// <param name="memoriesPurged">
        /// Number of user_memories rows cascade-soft-deleted under this caller.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteCallerResponse(
            int callerPurged,
            int memoriesPurged)
        {
            this.CallerPurged = callerPurged;
            this.MemoriesPurged = memoriesPurged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCallerResponse" /> class.
        /// </summary>
        public DeleteCallerResponse()
        {
        }

    }
}