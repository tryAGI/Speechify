
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Operator-only projection of a conversation's internal LiveKit<br/>
    /// room handles, returned by<br/>
    /// `GET /v1/agents/conversations/{conversation_id}/livekit-room`.<br/>
    /// These are kept off the conversation read responses so they never<br/>
    /// freeze into the public contract, and are available only to<br/>
    /// Speechify operators.
    /// </summary>
    public sealed partial class ConversationLiveKitRoom
    {
        /// <summary>
        /// LiveKit room name. Equals the conversation `id` for `web`<br/>
        /// and `sip_outbound` transports; `sip_inbound` rooms use a<br/>
        /// `sip_&lt;e164&gt;_&lt;random&gt;` name assigned by the SIP dispatch rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("room_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoomName { get; set; }

        /// <summary>
        /// LiveKit room SID (`RM_...`), stamped once the room exists.<br/>
        /// Absent for a conversation whose room was never created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("room_sid")]
        public string? RoomSid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationLiveKitRoom" /> class.
        /// </summary>
        /// <param name="roomName">
        /// LiveKit room name. Equals the conversation `id` for `web`<br/>
        /// and `sip_outbound` transports; `sip_inbound` rooms use a<br/>
        /// `sip_&lt;e164&gt;_&lt;random&gt;` name assigned by the SIP dispatch rule.
        /// </param>
        /// <param name="roomSid">
        /// LiveKit room SID (`RM_...`), stamped once the room exists.<br/>
        /// Absent for a conversation whose room was never created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationLiveKitRoom(
            string roomName,
            string? roomSid)
        {
            this.RoomName = roomName ?? throw new global::System.ArgumentNullException(nameof(roomName));
            this.RoomSid = roomSid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationLiveKitRoom" /> class.
        /// </summary>
        public ConversationLiveKitRoom()
        {
        }

    }
}