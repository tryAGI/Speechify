
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Canonical code the worker emits when the IVR<br/>
    /// navigator gave up. NULL when the navigator completed<br/>
    /// cleanly OR never started a plan.<br/>
    /// * `no_goal` - the goal extractor returned empty.<br/>
    /// * `no_cached_menu` - AMD-time cache miss for the root fingerprint.<br/>
    /// * `below_threshold` - cached menu loaded but confidence &lt; threshold.<br/>
    /// * `fingerprint_mismatch` - in-call prompt diverged from the cached menu fingerprint.<br/>
    /// * `goal_ambiguous` - cached options matched the goal more than once or not at all.<br/>
    /// * `child_cache_miss` - sub-menu fingerprint had no cached row.<br/>
    /// * `dtmf_send_failure` - DTMF press could not be delivered.<br/>
    /// * `matched_option_missing_dtmf` - defensive shape guard.<br/>
    /// * `disabled` - per-agent toggle off OR operator kill switch on.<br/>
    /// * `repeated_prompt_max_retries` - bounded press-retry on the same fingerprint hit its cap of 1.
    /// </summary>
    public enum ConversationIvrSurrenderReason
    {
        /// <summary>
        /// 
        /// </summary>
        BelowThreshold,
        /// <summary>
        /// 
        /// </summary>
        ChildCacheMiss,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        DtmfSendFailure,
        /// <summary>
        /// 
        /// </summary>
        FingerprintMismatch,
        /// <summary>
        /// 
        /// </summary>
        GoalAmbiguous,
        /// <summary>
        /// 
        /// </summary>
        MatchedOptionMissingDtmf,
        /// <summary>
        /// 
        /// </summary>
        NoCachedMenu,
        /// <summary>
        /// 
        /// </summary>
        NoGoal,
        /// <summary>
        /// 
        /// </summary>
        RepeatedPromptMaxRetries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationIvrSurrenderReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationIvrSurrenderReason value)
        {
            return value switch
            {
                ConversationIvrSurrenderReason.BelowThreshold => "below_threshold",
                ConversationIvrSurrenderReason.ChildCacheMiss => "child_cache_miss",
                ConversationIvrSurrenderReason.Disabled => "disabled",
                ConversationIvrSurrenderReason.DtmfSendFailure => "dtmf_send_failure",
                ConversationIvrSurrenderReason.FingerprintMismatch => "fingerprint_mismatch",
                ConversationIvrSurrenderReason.GoalAmbiguous => "goal_ambiguous",
                ConversationIvrSurrenderReason.MatchedOptionMissingDtmf => "matched_option_missing_dtmf",
                ConversationIvrSurrenderReason.NoCachedMenu => "no_cached_menu",
                ConversationIvrSurrenderReason.NoGoal => "no_goal",
                ConversationIvrSurrenderReason.RepeatedPromptMaxRetries => "repeated_prompt_max_retries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationIvrSurrenderReason? ToEnum(string value)
        {
            return value switch
            {
                "below_threshold" => ConversationIvrSurrenderReason.BelowThreshold,
                "child_cache_miss" => ConversationIvrSurrenderReason.ChildCacheMiss,
                "disabled" => ConversationIvrSurrenderReason.Disabled,
                "dtmf_send_failure" => ConversationIvrSurrenderReason.DtmfSendFailure,
                "fingerprint_mismatch" => ConversationIvrSurrenderReason.FingerprintMismatch,
                "goal_ambiguous" => ConversationIvrSurrenderReason.GoalAmbiguous,
                "matched_option_missing_dtmf" => ConversationIvrSurrenderReason.MatchedOptionMissingDtmf,
                "no_cached_menu" => ConversationIvrSurrenderReason.NoCachedMenu,
                "no_goal" => ConversationIvrSurrenderReason.NoGoal,
                "repeated_prompt_max_retries" => ConversationIvrSurrenderReason.RepeatedPromptMaxRetries,
                _ => null,
            };
        }
    }
}