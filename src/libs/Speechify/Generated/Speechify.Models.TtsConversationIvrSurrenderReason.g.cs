
#nullable enable

namespace Speechify
{
    /// <summary>
    /// AIS-3322 canonical code the worker emits when the IVR<br/>
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
    public enum TtsConversationIvrSurrenderReason
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
    public static class TtsConversationIvrSurrenderReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsConversationIvrSurrenderReason value)
        {
            return value switch
            {
                TtsConversationIvrSurrenderReason.BelowThreshold => "below_threshold",
                TtsConversationIvrSurrenderReason.ChildCacheMiss => "child_cache_miss",
                TtsConversationIvrSurrenderReason.Disabled => "disabled",
                TtsConversationIvrSurrenderReason.DtmfSendFailure => "dtmf_send_failure",
                TtsConversationIvrSurrenderReason.FingerprintMismatch => "fingerprint_mismatch",
                TtsConversationIvrSurrenderReason.GoalAmbiguous => "goal_ambiguous",
                TtsConversationIvrSurrenderReason.MatchedOptionMissingDtmf => "matched_option_missing_dtmf",
                TtsConversationIvrSurrenderReason.NoCachedMenu => "no_cached_menu",
                TtsConversationIvrSurrenderReason.NoGoal => "no_goal",
                TtsConversationIvrSurrenderReason.RepeatedPromptMaxRetries => "repeated_prompt_max_retries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsConversationIvrSurrenderReason? ToEnum(string value)
        {
            return value switch
            {
                "below_threshold" => TtsConversationIvrSurrenderReason.BelowThreshold,
                "child_cache_miss" => TtsConversationIvrSurrenderReason.ChildCacheMiss,
                "disabled" => TtsConversationIvrSurrenderReason.Disabled,
                "dtmf_send_failure" => TtsConversationIvrSurrenderReason.DtmfSendFailure,
                "fingerprint_mismatch" => TtsConversationIvrSurrenderReason.FingerprintMismatch,
                "goal_ambiguous" => TtsConversationIvrSurrenderReason.GoalAmbiguous,
                "matched_option_missing_dtmf" => TtsConversationIvrSurrenderReason.MatchedOptionMissingDtmf,
                "no_cached_menu" => TtsConversationIvrSurrenderReason.NoCachedMenu,
                "no_goal" => TtsConversationIvrSurrenderReason.NoGoal,
                "repeated_prompt_max_retries" => TtsConversationIvrSurrenderReason.RepeatedPromptMaxRetries,
                _ => null,
            };
        }
    }
}