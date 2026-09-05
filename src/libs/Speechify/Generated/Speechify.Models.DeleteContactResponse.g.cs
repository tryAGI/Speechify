
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The audit tally of a contact purge. A privacy operator answering an<br/>
    /// erasure request gets the evidence in the response, without re-querying<br/>
    /// a corpus they just asked us to stop returning. All zeros means the<br/>
    /// contact was already purged.
    /// </summary>
    public sealed partial class DeleteContactResponse
    {
        /// <summary>
        /// 1 when this call tombstoned the contact, 0 when it was already gone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_purged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContactPurged { get; set; }

        /// <summary>
        /// Identifiers tombstoned. They stop resolving immediately, so a<br/>
        /// future call or session on that channel mints a fresh contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers_purged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IdentifiersPurged { get; set; }

        /// <summary>
        /// Per-agent caller records tombstoned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callers_purged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallersPurged { get; set; }

        /// <summary>
        /// Memory rows erased, across every agent and channel - reached by<br/>
        /// contact, by caller record, and by the stored caller identity, so a<br/>
        /// row is not missed because of which key it happened to be written<br/>
        /// under.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories_purged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoriesPurged { get; set; }

        /// <summary>
        /// Durable runs whose content was scrubbed: the instruction, the<br/>
        /// variables, the output and every journalled step, which together<br/>
        /// carry the person verbatim. The run row itself stays, with its<br/>
        /// status, timings and usage - what the workspace was billed for is<br/>
        /// not the person's to erase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs_erased")]
        public int? RunsErased { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteContactResponse" /> class.
        /// </summary>
        /// <param name="contactPurged">
        /// 1 when this call tombstoned the contact, 0 when it was already gone.
        /// </param>
        /// <param name="identifiersPurged">
        /// Identifiers tombstoned. They stop resolving immediately, so a<br/>
        /// future call or session on that channel mints a fresh contact.
        /// </param>
        /// <param name="callersPurged">
        /// Per-agent caller records tombstoned.
        /// </param>
        /// <param name="memoriesPurged">
        /// Memory rows erased, across every agent and channel - reached by<br/>
        /// contact, by caller record, and by the stored caller identity, so a<br/>
        /// row is not missed because of which key it happened to be written<br/>
        /// under.
        /// </param>
        /// <param name="runsErased">
        /// Durable runs whose content was scrubbed: the instruction, the<br/>
        /// variables, the output and every journalled step, which together<br/>
        /// carry the person verbatim. The run row itself stays, with its<br/>
        /// status, timings and usage - what the workspace was billed for is<br/>
        /// not the person's to erase.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteContactResponse(
            int contactPurged,
            int identifiersPurged,
            int callersPurged,
            int memoriesPurged,
            int? runsErased)
        {
            this.ContactPurged = contactPurged;
            this.IdentifiersPurged = identifiersPurged;
            this.CallersPurged = callersPurged;
            this.MemoriesPurged = memoriesPurged;
            this.RunsErased = runsErased;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteContactResponse" /> class.
        /// </summary>
        public DeleteContactResponse()
        {
        }

    }
}