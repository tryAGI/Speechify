
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Coarse termination category. Worker-stamped reasons arrive<br/>
    /// before `terminate_call` fires; `caller_hangup` has two<br/>
    /// emit sites (worker-observed SIP disconnect, plus a<br/>
    /// server-side post-call catch-all).<br/>
    /// * `voicemail_message_left` — AMD machine-vm + we spoke the configured drop-message.<br/>
    /// * `voicemail_hangup` — AMD machine-vm + we terminated silently (action=hangup or empty-message bypass).<br/>
    /// * `ivr_hangup` — AMD machine-ivr + action=hangup.<br/>
    /// * `unavailable_hangup` — AMD machine-unavailable (mailbox full / disconnected).<br/>
    /// * `agent_ended` — LLM-driven end_call builtin.<br/>
    /// * `inactivity_timeout` — worker's inactivity handler fired terminate after the configured silence window.<br/>
    /// * `loop_detected` — worker's runtime loop guard force-ended the call after N consecutive near-identical user turns (typically an IVR replaying its menu while the LLM kept reacting instead of calling end_call).<br/>
    /// * `max_duration_reached` - worker's max-call-duration watchdog force-ended the call at the platform ceiling (a safety bound on runaway calls).<br/>
    /// * `over_capacity` — inbound call refused because the workspace was over its active-call concurrency cap; the busy message played and the call hung up. Stamped server-side and excluded from billing.<br/>
    /// * `caller_hangup` — caller's leg went away. Precise when the worker observed the SIP `participant_disconnected` event (stamped immediately); otherwise stamped server-side ~10s after `room_finished` as a catch-all (web tab close, network blip, worker crash, etc.).<br/>
    /// * `null` — pre-rollout calls only (anything that landed after the rollout completes without a stamp gets `caller_hangup` from the post-call goroutine).
    /// </summary>
    public enum ConversationEndReason
    {
        /// <summary>
        /// 
        /// </summary>
        AgentEnded,
        /// <summary>
        /// 
        /// </summary>
        CallerHangup,
        /// <summary>
        /// 
        /// </summary>
        InactivityTimeout,
        /// <summary>
        /// 
        /// </summary>
        IvrHangup,
        /// <summary>
        /// 
        /// </summary>
        LoopDetected,
        /// <summary>
        /// 
        /// </summary>
        MaxDurationReached,
        /// <summary>
        /// 
        /// </summary>
        OverCapacity,
        /// <summary>
        /// 
        /// </summary>
        UnavailableHangup,
        /// <summary>
        /// 
        /// </summary>
        VoicemailHangup,
        /// <summary>
        /// 
        /// </summary>
        VoicemailMessageLeft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationEndReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationEndReason value)
        {
            return value switch
            {
                ConversationEndReason.AgentEnded => "agent_ended",
                ConversationEndReason.CallerHangup => "caller_hangup",
                ConversationEndReason.InactivityTimeout => "inactivity_timeout",
                ConversationEndReason.IvrHangup => "ivr_hangup",
                ConversationEndReason.LoopDetected => "loop_detected",
                ConversationEndReason.MaxDurationReached => "max_duration_reached",
                ConversationEndReason.OverCapacity => "over_capacity",
                ConversationEndReason.UnavailableHangup => "unavailable_hangup",
                ConversationEndReason.VoicemailHangup => "voicemail_hangup",
                ConversationEndReason.VoicemailMessageLeft => "voicemail_message_left",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationEndReason? ToEnum(string value)
        {
            return value switch
            {
                "agent_ended" => ConversationEndReason.AgentEnded,
                "caller_hangup" => ConversationEndReason.CallerHangup,
                "inactivity_timeout" => ConversationEndReason.InactivityTimeout,
                "ivr_hangup" => ConversationEndReason.IvrHangup,
                "loop_detected" => ConversationEndReason.LoopDetected,
                "max_duration_reached" => ConversationEndReason.MaxDurationReached,
                "over_capacity" => ConversationEndReason.OverCapacity,
                "unavailable_hangup" => ConversationEndReason.UnavailableHangup,
                "voicemail_hangup" => ConversationEndReason.VoicemailHangup,
                "voicemail_message_left" => ConversationEndReason.VoicemailMessageLeft,
                _ => null,
            };
        }
    }
}