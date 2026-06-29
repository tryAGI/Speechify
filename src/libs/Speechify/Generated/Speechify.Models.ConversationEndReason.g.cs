
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Coarse termination category. Most reasons are assigned by the<br/>
    /// agent runtime as the call ends; `caller_hangup` may also be<br/>
    /// applied server-side as a post-call catch-all. The `dial_*`<br/>
    /// reasons are assigned server-side on a `failed` conversation<br/>
    /// for an outbound call that never connected.<br/>
    /// * `voicemail_message_left` — AMD machine-vm + we spoke the configured drop-message.<br/>
    /// * `voicemail_hangup` — AMD machine-vm + we terminated silently (action=hangup or empty-message bypass).<br/>
    /// * `ivr_hangup` — AMD machine-ivr + action=hangup.<br/>
    /// * `unavailable_hangup` — AMD machine-unavailable (mailbox full / disconnected).<br/>
    /// * `agent_ended` — LLM-driven end_call builtin.<br/>
    /// * `inactivity_timeout` — the call ended after the configured silence window elapsed with no activity.<br/>
    /// * `loop_detected` — a loop guard force-ended the call after several consecutive near-identical user turns (typically an IVR replaying its menu while the agent kept reacting instead of ending the call).<br/>
    /// * `max_duration_reached` - the max-call-duration limit force-ended the call at the platform ceiling (a safety bound on runaway calls).<br/>
    /// * `over_capacity` — inbound call refused because the workspace was over its active-call concurrency cap; the busy message played and the call hung up. Stamped server-side and excluded from billing.<br/>
    /// * `caller_hangup` — the caller's leg went away. Stamped immediately when a SIP disconnect is observed; otherwise applied server-side shortly after the call ends as a catch-all (web tab close, network blip, etc.).<br/>
    /// * `dial_no_answer` — outbound dial: callee did not pick up (SIP 408/480/487, the ringing timeout expired).<br/>
    /// * `dial_busy` — outbound dial: the line was busy (SIP 486/600).<br/>
    /// * `dial_rejected` — outbound dial: the call was actively refused (SIP 401/403/407 carrier auth/permission, or 603/607/608 callee decline).<br/>
    /// * `dial_failed` — outbound dial: any other failure to connect (invalid number, carrier 5xx, malformed trunk address, TLS requirement, transport error). On a `failed` conversation with NULL `duration_ms`.<br/>
    /// * `null` — the termination category was not recorded. Legacy calls only; current calls always carry a reason.
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
        /// the line was busy (SIP 486/600).
        /// </summary>
        DialBusy,
        /// <summary>
        /// any other failure to connect (invalid number, carrier 5xx, malformed trunk address, TLS requirement, transport error). On a `failed` conversation with NULL `duration_ms`.
        /// </summary>
        DialFailed,
        /// <summary>
        /// callee did not pick up (SIP 408/480/487, the ringing timeout expired).
        /// </summary>
        DialNoAnswer,
        /// <summary>
        /// the call was actively refused (SIP 401/403/407 carrier auth/permission, or 603/607/608 callee decline).
        /// </summary>
        DialRejected,
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
                ConversationEndReason.DialBusy => "dial_busy",
                ConversationEndReason.DialFailed => "dial_failed",
                ConversationEndReason.DialNoAnswer => "dial_no_answer",
                ConversationEndReason.DialRejected => "dial_rejected",
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
                "dial_busy" => ConversationEndReason.DialBusy,
                "dial_failed" => ConversationEndReason.DialFailed,
                "dial_no_answer" => ConversationEndReason.DialNoAnswer,
                "dial_rejected" => ConversationEndReason.DialRejected,
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