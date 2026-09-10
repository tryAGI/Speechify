
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
        /// Calls and chats scrubbed the way a run is: the row keeps its id,<br/>
        /// status, timings and billed duration, and loses the person - the<br/>
        /// identity, the phone numbers, the frozen prompt and variables, and<br/>
        /// the pointer to any recording.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations_erased")]
        public int? ConversationsErased { get; set; }

        /// <summary>
        /// Transcript turns deleted outright. A message is content and nothing<br/>
        /// else, so unlike its conversation there is nothing on it worth<br/>
        /// keeping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages_erased")]
        public int? MessagesErased { get; set; }

        /// <summary>
        /// Turns in SHARED threads that named this person and no longer do.<br/>
        /// A room has no single caller, so its conversation cannot be erased<br/>
        /// on one member's behalf without taking everyone else's words with<br/>
        /// it; their name comes off their turns instead, leaving the words as<br/>
        /// unattributable as they were before we recorded who said them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_attributions_erased")]
        public int? SpeakerAttributionsErased { get; set; }

        /// <summary>
        /// Files this person handed a conversation - a picture pasted into a<br/>
        /// direct message, a document dropped in a thread - now tombstoned in<br/>
        /// the workspace file drop. The bytes go with the drop's next expiry<br/>
        /// sweep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_files_erased")]
        public long? AttachedFilesErased { get; set; }

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
        /// <param name="conversationsErased">
        /// Calls and chats scrubbed the way a run is: the row keeps its id,<br/>
        /// status, timings and billed duration, and loses the person - the<br/>
        /// identity, the phone numbers, the frozen prompt and variables, and<br/>
        /// the pointer to any recording.
        /// </param>
        /// <param name="messagesErased">
        /// Transcript turns deleted outright. A message is content and nothing<br/>
        /// else, so unlike its conversation there is nothing on it worth<br/>
        /// keeping.
        /// </param>
        /// <param name="speakerAttributionsErased">
        /// Turns in SHARED threads that named this person and no longer do.<br/>
        /// A room has no single caller, so its conversation cannot be erased<br/>
        /// on one member's behalf without taking everyone else's words with<br/>
        /// it; their name comes off their turns instead, leaving the words as<br/>
        /// unattributable as they were before we recorded who said them.
        /// </param>
        /// <param name="attachedFilesErased">
        /// Files this person handed a conversation - a picture pasted into a<br/>
        /// direct message, a document dropped in a thread - now tombstoned in<br/>
        /// the workspace file drop. The bytes go with the drop's next expiry<br/>
        /// sweep.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteContactResponse(
            int contactPurged,
            int identifiersPurged,
            int callersPurged,
            int memoriesPurged,
            int? runsErased,
            int? conversationsErased,
            int? messagesErased,
            int? speakerAttributionsErased,
            long? attachedFilesErased)
        {
            this.ContactPurged = contactPurged;
            this.IdentifiersPurged = identifiersPurged;
            this.CallersPurged = callersPurged;
            this.MemoriesPurged = memoriesPurged;
            this.RunsErased = runsErased;
            this.ConversationsErased = conversationsErased;
            this.MessagesErased = messagesErased;
            this.SpeakerAttributionsErased = speakerAttributionsErased;
            this.AttachedFilesErased = attachedFilesErased;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteContactResponse" /> class.
        /// </summary>
        public DeleteContactResponse()
        {
        }

    }
}