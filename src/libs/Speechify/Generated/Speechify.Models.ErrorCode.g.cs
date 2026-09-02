
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Stable machine-readable error code. Additive only: codes are<br/>
    /// never renamed, only deprecated. SDKs may map each code to a<br/>
    /// typed exception class. Status-code semantics:<br/>
    /// 4xx codes describe caller-fixable issues; 5xx codes describe<br/>
    /// server-side failures and are safe to retry with backoff for<br/>
    /// idempotent requests.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        AccountDeletionBlocked,
        /// <summary>
        ///
        /// </summary>
        AgentInUse,
        /// <summary>
        ///
        /// </summary>
        AgentNotFound,
        /// <summary>
        ///
        /// </summary>
        AgentPublishGateFailed,
        /// <summary>
        ///
        /// </summary>
        AgentPublishGateRequired,
        /// <summary>
        ///
        /// </summary>
        AgentRunActionStale,
        /// <summary>
        ///
        /// </summary>
        AgentRunNotFound,
        /// <summary>
        ///
        /// </summary>
        AgentRunNotPending,
        /// <summary>
        ///
        /// </summary>
        AgentTestNotFound,
        /// <summary>
        ///
        /// </summary>
        AudioAssetNotFound,
        /// <summary>
        ///
        /// </summary>
        BadRequest,
        /// <summary>
        ///
        /// </summary>
        BatchCallsNotIncluded,
        /// <summary>
        ///
        /// </summary>
        BatchNotFound,
        /// <summary>
        ///
        /// </summary>
        BrainInUse,
        /// <summary>
        ///
        /// </summary>
        BrainNotFound,
        /// <summary>
        ///
        /// </summary>
        BuiltinNotFound,
        /// <summary>
        ///
        /// </summary>
        CallNotActive,
        /// <summary>
        ///
        /// </summary>
        CallNotFound,
        /// <summary>
        ///
        /// </summary>
        CallerNotFound,
        /// <summary>
        ///
        /// </summary>
        ChannelInstanceNotFound,
        /// <summary>
        ///
        /// </summary>
        ConcurrencyLimitReached,
        /// <summary>
        ///
        /// </summary>
        Conflict,
        /// <summary>
        ///
        /// </summary>
        ConsentChallengeAlreadyUsed,
        /// <summary>
        ///
        /// </summary>
        ConsentChallengeExpired,
        /// <summary>
        ///
        /// </summary>
        ConsentChallengeNotFound,
        /// <summary>
        ///
        /// </summary>
        ConsentPhraseMismatch,
        /// <summary>
        ///
        /// </summary>
        ConsentRecordingUnusable,
        /// <summary>
        ///
        /// </summary>
        ConsentSpeakerMismatch,
        /// <summary>
        ///
        /// </summary>
        ConsentVerificationUnavailable,
        /// <summary>
        ///
        /// </summary>
        ContactIdentifierConflict,
        /// <summary>
        ///
        /// </summary>
        ContactIdentifierNotFound,
        /// <summary>
        ///
        /// </summary>
        ContactNotFound,
        /// <summary>
        ///
        /// </summary>
        ContactResolverNotFound,
        /// <summary>
        ///
        /// </summary>
        ContentPolicyViolation,
        /// <summary>
        ///
        /// </summary>
        ConversationNotFound,
        /// <summary>
        ///
        /// </summary>
        CredentialInUse,
        /// <summary>
        ///
        /// </summary>
        CredentialNotFound,
        /// <summary>
        ///
        /// </summary>
        CreditPurchaseUnpaid,
        /// <summary>
        ///
        /// </summary>
        CrossProjectReference,
        /// <summary>
        ///
        /// </summary>
        DestinationNotAllowed,
        /// <summary>
        ///
        /// </summary>
        DurableRunsNotInPlan,
        /// <summary>
        ///
        /// </summary>
        Forbidden,
        /// <summary>
        ///
        /// </summary>
        FundedBalanceRequired,
        /// <summary>
        ///
        /// </summary>
        IdempotencyConflict,
        /// <summary>
        ///
        /// </summary>
        InsufficientScope,
        /// <summary>
        ///
        /// </summary>
        IntendedUseRequired,
        /// <summary>
        ///
        /// </summary>
        InternalError,
        /// <summary>
        ///
        /// </summary>
        InternationalDialingNotEnabled,
        /// <summary>
        ///
        /// </summary>
        InvalidApiVersion,
        /// <summary>
        ///
        /// </summary>
        InviteAlreadyPending,
        /// <summary>
        ///
        /// </summary>
        InviteEmailMismatch,
        /// <summary>
        ///
        /// </summary>
        InviteNotFound,
        /// <summary>
        ///
        /// </summary>
        KbDocumentNotFound,
        /// <summary>
        ///
        /// </summary>
        KbFolderNotFound,
        /// <summary>
        ///
        /// </summary>
        KbNotFound,
        /// <summary>
        ///
        /// </summary>
        MessageNotFound,
        /// <summary>
        ///
        /// </summary>
        MethodNotAllowed,
        /// <summary>
        ///
        /// </summary>
        ModelRetired,
        /// <summary>
        ///
        /// </summary>
        NotFound,
        /// <summary>
        ///
        /// </summary>
        NumberNotSmsCapable,
        /// <summary>
        ///
        /// </summary>
        PayloadTooLarge,
        /// <summary>
        ///
        /// </summary>
        PaymentRequired,
        /// <summary>
        ///
        /// </summary>
        PhoneNumberNotFound,
        /// <summary>
        ///
        /// </summary>
        PhoneNumberQuotaReached,
        /// <summary>
        ///
        /// </summary>
        ProjectArchived,
        /// <summary>
        ///
        /// </summary>
        ProjectHasScopedCredentials,
        /// <summary>
        ///
        /// </summary>
        ProjectLimitReached,
        /// <summary>
        ///
        /// </summary>
        ProjectNameTaken,
        /// <summary>
        ///
        /// </summary>
        ProjectNotArchived,
        /// <summary>
        ///
        /// </summary>
        ProjectNotFound,
        /// <summary>
        ///
        /// </summary>
        ProjectNotPurged,
        /// <summary>
        ///
        /// </summary>
        ProjectRestoreWindowExpired,
        /// <summary>
        ///
        /// </summary>
        ProjectSpendLimitExceeded,
        /// <summary>
        ///
        /// </summary>
        ProjectTooLargeToPromote,
        /// <summary>
        ///
        /// </summary>
        PurchasedNumbersNotIncluded,
        /// <summary>
        ///
        /// </summary>
        RateLimited,
        /// <summary>
        ///
        /// </summary>
        RelayDisplacesAgent,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountLimitReached,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountsNotInPlan,
        /// <summary>
        ///
        /// </summary>
        ServiceUnavailable,
        /// <summary>
        ///
        /// </summary>
        ShareLinkExhausted,
        /// <summary>
        ///
        /// </summary>
        ShareLinkLimitReached,
        /// <summary>
        ///
        /// </summary>
        ShareLinkNotFound,
        /// <summary>
        ///
        /// </summary>
        SipTrunkNotFound,
        /// <summary>
        ///
        /// </summary>
        SpeechMarksUnsupported,
        /// <summary>
        ///
        /// </summary>
        SpendBudgetExceeded,
        /// <summary>
        ///
        /// </summary>
        SpendCapExceeded,
        /// <summary>
        ///
        /// </summary>
        TeamNotFound,
        /// <summary>
        ///
        /// </summary>
        TextChannelNotInPlan,
        /// <summary>
        ///
        /// </summary>
        TextMessageQuotaExceeded,
        /// <summary>
        ///
        /// </summary>
        TextTurnFailed,
        /// <summary>
        ///
        /// </summary>
        ThreadNotFound,
        /// <summary>
        ///
        /// </summary>
        TooManyVoices,
        /// <summary>
        ///
        /// </summary>
        ToolConfigShared,
        /// <summary>
        ///
        /// </summary>
        ToolNotFound,
        /// <summary>
        ///
        /// </summary>
        TopupNotInPlan,
        /// <summary>
        ///
        /// </summary>
        TriggerNotFound,
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
        /// <summary>
        ///
        /// </summary>
        UnsupportedMediaType,
        /// <summary>
        ///
        /// </summary>
        UpstreamFailure,
        /// <summary>
        ///
        /// </summary>
        ValidationFailed,
        /// <summary>
        ///
        /// </summary>
        VerificationRequired,
        /// <summary>
        ///
        /// </summary>
        VoiceCloningNotIncluded,
        /// <summary>
        ///
        /// </summary>
        VoiceNotFound,
        /// <summary>
        ///
        /// </summary>
        WatermarkAudioUnusable,
        /// <summary>
        ///
        /// </summary>
        WatermarkDetectionUnavailable,
        /// <summary>
        ///
        /// </summary>
        WorkspaceFreeLimit,
        /// <summary>
        ///
        /// </summary>
        WorkspaceLastOwner,
        /// <summary>
        ///
        /// </summary>
        WorkspaceLastWorkspace,
        /// <summary>
        ///
        /// </summary>
        WorkspaceNotFound,
        /// <summary>
        ///
        /// </summary>
        WorkspaceSingleOwner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorCode value)
        {
            return value switch
            {
                ErrorCode.AccountDeletionBlocked => "account_deletion_blocked",
                ErrorCode.AgentInUse => "agent_in_use",
                ErrorCode.AgentNotFound => "agent_not_found",
                ErrorCode.AgentPublishGateFailed => "agent_publish_gate_failed",
                ErrorCode.AgentPublishGateRequired => "agent_publish_gate_required",
                ErrorCode.AgentRunActionStale => "agent_run_action_stale",
                ErrorCode.AgentRunNotFound => "agent_run_not_found",
                ErrorCode.AgentRunNotPending => "agent_run_not_pending",
                ErrorCode.AgentTestNotFound => "agent_test_not_found",
                ErrorCode.AudioAssetNotFound => "audio_asset_not_found",
                ErrorCode.BadRequest => "bad_request",
                ErrorCode.BatchCallsNotIncluded => "batch_calls_not_included",
                ErrorCode.BatchNotFound => "batch_not_found",
                ErrorCode.BrainInUse => "brain_in_use",
                ErrorCode.BrainNotFound => "brain_not_found",
                ErrorCode.BuiltinNotFound => "builtin_not_found",
                ErrorCode.CallNotActive => "call_not_active",
                ErrorCode.CallNotFound => "call_not_found",
                ErrorCode.CallerNotFound => "caller_not_found",
                ErrorCode.ChannelInstanceNotFound => "channel_instance_not_found",
                ErrorCode.ConcurrencyLimitReached => "concurrency_limit_reached",
                ErrorCode.Conflict => "conflict",
                ErrorCode.ConsentChallengeAlreadyUsed => "consent_challenge_already_used",
                ErrorCode.ConsentChallengeExpired => "consent_challenge_expired",
                ErrorCode.ConsentChallengeNotFound => "consent_challenge_not_found",
                ErrorCode.ConsentPhraseMismatch => "consent_phrase_mismatch",
                ErrorCode.ConsentRecordingUnusable => "consent_recording_unusable",
                ErrorCode.ConsentSpeakerMismatch => "consent_speaker_mismatch",
                ErrorCode.ConsentVerificationUnavailable => "consent_verification_unavailable",
                ErrorCode.ContactIdentifierConflict => "contact_identifier_conflict",
                ErrorCode.ContactIdentifierNotFound => "contact_identifier_not_found",
                ErrorCode.ContactNotFound => "contact_not_found",
                ErrorCode.ContactResolverNotFound => "contact_resolver_not_found",
                ErrorCode.ContentPolicyViolation => "content_policy_violation",
                ErrorCode.ConversationNotFound => "conversation_not_found",
                ErrorCode.CredentialInUse => "credential_in_use",
                ErrorCode.CredentialNotFound => "credential_not_found",
                ErrorCode.CreditPurchaseUnpaid => "credit_purchase_unpaid",
                ErrorCode.CrossProjectReference => "cross_project_reference",
                ErrorCode.DestinationNotAllowed => "destination_not_allowed",
                ErrorCode.DurableRunsNotInPlan => "durable_runs_not_in_plan",
                ErrorCode.Forbidden => "forbidden",
                ErrorCode.FundedBalanceRequired => "funded_balance_required",
                ErrorCode.IdempotencyConflict => "idempotency_conflict",
                ErrorCode.InsufficientScope => "insufficient_scope",
                ErrorCode.IntendedUseRequired => "intended_use_required",
                ErrorCode.InternalError => "internal_error",
                ErrorCode.InternationalDialingNotEnabled => "international_dialing_not_enabled",
                ErrorCode.InvalidApiVersion => "invalid_api_version",
                ErrorCode.InviteAlreadyPending => "invite_already_pending",
                ErrorCode.InviteEmailMismatch => "invite_email_mismatch",
                ErrorCode.InviteNotFound => "invite_not_found",
                ErrorCode.KbDocumentNotFound => "kb_document_not_found",
                ErrorCode.KbFolderNotFound => "kb_folder_not_found",
                ErrorCode.KbNotFound => "kb_not_found",
                ErrorCode.MessageNotFound => "message_not_found",
                ErrorCode.MethodNotAllowed => "method_not_allowed",
                ErrorCode.ModelRetired => "model_retired",
                ErrorCode.NotFound => "not_found",
                ErrorCode.NumberNotSmsCapable => "number_not_sms_capable",
                ErrorCode.PayloadTooLarge => "payload_too_large",
                ErrorCode.PaymentRequired => "payment_required",
                ErrorCode.PhoneNumberNotFound => "phone_number_not_found",
                ErrorCode.PhoneNumberQuotaReached => "phone_number_quota_reached",
                ErrorCode.ProjectArchived => "project_archived",
                ErrorCode.ProjectHasScopedCredentials => "project_has_scoped_credentials",
                ErrorCode.ProjectLimitReached => "project_limit_reached",
                ErrorCode.ProjectNameTaken => "project_name_taken",
                ErrorCode.ProjectNotArchived => "project_not_archived",
                ErrorCode.ProjectNotFound => "project_not_found",
                ErrorCode.ProjectNotPurged => "project_not_purged",
                ErrorCode.ProjectRestoreWindowExpired => "project_restore_window_expired",
                ErrorCode.ProjectSpendLimitExceeded => "project_spend_limit_exceeded",
                ErrorCode.ProjectTooLargeToPromote => "project_too_large_to_promote",
                ErrorCode.PurchasedNumbersNotIncluded => "purchased_numbers_not_included",
                ErrorCode.RateLimited => "rate_limited",
                ErrorCode.RelayDisplacesAgent => "relay_displaces_agent",
                ErrorCode.ServiceAccountLimitReached => "service_account_limit_reached",
                ErrorCode.ServiceAccountsNotInPlan => "service_accounts_not_in_plan",
                ErrorCode.ServiceUnavailable => "service_unavailable",
                ErrorCode.ShareLinkExhausted => "share_link_exhausted",
                ErrorCode.ShareLinkLimitReached => "share_link_limit_reached",
                ErrorCode.ShareLinkNotFound => "share_link_not_found",
                ErrorCode.SipTrunkNotFound => "sip_trunk_not_found",
                ErrorCode.SpeechMarksUnsupported => "speech_marks_unsupported",
                ErrorCode.SpendBudgetExceeded => "spend_budget_exceeded",
                ErrorCode.SpendCapExceeded => "spend_cap_exceeded",
                ErrorCode.TeamNotFound => "team_not_found",
                ErrorCode.TextChannelNotInPlan => "text_channel_not_in_plan",
                ErrorCode.TextMessageQuotaExceeded => "text_message_quota_exceeded",
                ErrorCode.TextTurnFailed => "text_turn_failed",
                ErrorCode.ThreadNotFound => "thread_not_found",
                ErrorCode.TooManyVoices => "too_many_voices",
                ErrorCode.ToolConfigShared => "tool_config_shared",
                ErrorCode.ToolNotFound => "tool_not_found",
                ErrorCode.TopupNotInPlan => "topup_not_in_plan",
                ErrorCode.TriggerNotFound => "trigger_not_found",
                ErrorCode.Unauthorized => "unauthorized",
                ErrorCode.UnsupportedMediaType => "unsupported_media_type",
                ErrorCode.UpstreamFailure => "upstream_failure",
                ErrorCode.ValidationFailed => "validation_failed",
                ErrorCode.VerificationRequired => "verification_required",
                ErrorCode.VoiceCloningNotIncluded => "voice_cloning_not_included",
                ErrorCode.VoiceNotFound => "voice_not_found",
                ErrorCode.WatermarkAudioUnusable => "watermark_audio_unusable",
                ErrorCode.WatermarkDetectionUnavailable => "watermark_detection_unavailable",
                ErrorCode.WorkspaceFreeLimit => "workspace_free_limit",
                ErrorCode.WorkspaceLastOwner => "workspace_last_owner",
                ErrorCode.WorkspaceLastWorkspace => "workspace_last_workspace",
                ErrorCode.WorkspaceNotFound => "workspace_not_found",
                ErrorCode.WorkspaceSingleOwner => "workspace_single_owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "account_deletion_blocked" => ErrorCode.AccountDeletionBlocked,
                "agent_in_use" => ErrorCode.AgentInUse,
                "agent_not_found" => ErrorCode.AgentNotFound,
                "agent_publish_gate_failed" => ErrorCode.AgentPublishGateFailed,
                "agent_publish_gate_required" => ErrorCode.AgentPublishGateRequired,
                "agent_run_action_stale" => ErrorCode.AgentRunActionStale,
                "agent_run_not_found" => ErrorCode.AgentRunNotFound,
                "agent_run_not_pending" => ErrorCode.AgentRunNotPending,
                "agent_test_not_found" => ErrorCode.AgentTestNotFound,
                "audio_asset_not_found" => ErrorCode.AudioAssetNotFound,
                "bad_request" => ErrorCode.BadRequest,
                "batch_calls_not_included" => ErrorCode.BatchCallsNotIncluded,
                "batch_not_found" => ErrorCode.BatchNotFound,
                "brain_in_use" => ErrorCode.BrainInUse,
                "brain_not_found" => ErrorCode.BrainNotFound,
                "builtin_not_found" => ErrorCode.BuiltinNotFound,
                "call_not_active" => ErrorCode.CallNotActive,
                "call_not_found" => ErrorCode.CallNotFound,
                "caller_not_found" => ErrorCode.CallerNotFound,
                "channel_instance_not_found" => ErrorCode.ChannelInstanceNotFound,
                "concurrency_limit_reached" => ErrorCode.ConcurrencyLimitReached,
                "conflict" => ErrorCode.Conflict,
                "consent_challenge_already_used" => ErrorCode.ConsentChallengeAlreadyUsed,
                "consent_challenge_expired" => ErrorCode.ConsentChallengeExpired,
                "consent_challenge_not_found" => ErrorCode.ConsentChallengeNotFound,
                "consent_phrase_mismatch" => ErrorCode.ConsentPhraseMismatch,
                "consent_recording_unusable" => ErrorCode.ConsentRecordingUnusable,
                "consent_speaker_mismatch" => ErrorCode.ConsentSpeakerMismatch,
                "consent_verification_unavailable" => ErrorCode.ConsentVerificationUnavailable,
                "contact_identifier_conflict" => ErrorCode.ContactIdentifierConflict,
                "contact_identifier_not_found" => ErrorCode.ContactIdentifierNotFound,
                "contact_not_found" => ErrorCode.ContactNotFound,
                "contact_resolver_not_found" => ErrorCode.ContactResolverNotFound,
                "content_policy_violation" => ErrorCode.ContentPolicyViolation,
                "conversation_not_found" => ErrorCode.ConversationNotFound,
                "credential_in_use" => ErrorCode.CredentialInUse,
                "credential_not_found" => ErrorCode.CredentialNotFound,
                "credit_purchase_unpaid" => ErrorCode.CreditPurchaseUnpaid,
                "cross_project_reference" => ErrorCode.CrossProjectReference,
                "destination_not_allowed" => ErrorCode.DestinationNotAllowed,
                "durable_runs_not_in_plan" => ErrorCode.DurableRunsNotInPlan,
                "forbidden" => ErrorCode.Forbidden,
                "funded_balance_required" => ErrorCode.FundedBalanceRequired,
                "idempotency_conflict" => ErrorCode.IdempotencyConflict,
                "insufficient_scope" => ErrorCode.InsufficientScope,
                "intended_use_required" => ErrorCode.IntendedUseRequired,
                "internal_error" => ErrorCode.InternalError,
                "international_dialing_not_enabled" => ErrorCode.InternationalDialingNotEnabled,
                "invalid_api_version" => ErrorCode.InvalidApiVersion,
                "invite_already_pending" => ErrorCode.InviteAlreadyPending,
                "invite_email_mismatch" => ErrorCode.InviteEmailMismatch,
                "invite_not_found" => ErrorCode.InviteNotFound,
                "kb_document_not_found" => ErrorCode.KbDocumentNotFound,
                "kb_folder_not_found" => ErrorCode.KbFolderNotFound,
                "kb_not_found" => ErrorCode.KbNotFound,
                "message_not_found" => ErrorCode.MessageNotFound,
                "method_not_allowed" => ErrorCode.MethodNotAllowed,
                "model_retired" => ErrorCode.ModelRetired,
                "not_found" => ErrorCode.NotFound,
                "number_not_sms_capable" => ErrorCode.NumberNotSmsCapable,
                "payload_too_large" => ErrorCode.PayloadTooLarge,
                "payment_required" => ErrorCode.PaymentRequired,
                "phone_number_not_found" => ErrorCode.PhoneNumberNotFound,
                "phone_number_quota_reached" => ErrorCode.PhoneNumberQuotaReached,
                "project_archived" => ErrorCode.ProjectArchived,
                "project_has_scoped_credentials" => ErrorCode.ProjectHasScopedCredentials,
                "project_limit_reached" => ErrorCode.ProjectLimitReached,
                "project_name_taken" => ErrorCode.ProjectNameTaken,
                "project_not_archived" => ErrorCode.ProjectNotArchived,
                "project_not_found" => ErrorCode.ProjectNotFound,
                "project_not_purged" => ErrorCode.ProjectNotPurged,
                "project_restore_window_expired" => ErrorCode.ProjectRestoreWindowExpired,
                "project_spend_limit_exceeded" => ErrorCode.ProjectSpendLimitExceeded,
                "project_too_large_to_promote" => ErrorCode.ProjectTooLargeToPromote,
                "purchased_numbers_not_included" => ErrorCode.PurchasedNumbersNotIncluded,
                "rate_limited" => ErrorCode.RateLimited,
                "relay_displaces_agent" => ErrorCode.RelayDisplacesAgent,
                "service_account_limit_reached" => ErrorCode.ServiceAccountLimitReached,
                "service_accounts_not_in_plan" => ErrorCode.ServiceAccountsNotInPlan,
                "service_unavailable" => ErrorCode.ServiceUnavailable,
                "share_link_exhausted" => ErrorCode.ShareLinkExhausted,
                "share_link_limit_reached" => ErrorCode.ShareLinkLimitReached,
                "share_link_not_found" => ErrorCode.ShareLinkNotFound,
                "sip_trunk_not_found" => ErrorCode.SipTrunkNotFound,
                "speech_marks_unsupported" => ErrorCode.SpeechMarksUnsupported,
                "spend_budget_exceeded" => ErrorCode.SpendBudgetExceeded,
                "spend_cap_exceeded" => ErrorCode.SpendCapExceeded,
                "team_not_found" => ErrorCode.TeamNotFound,
                "text_channel_not_in_plan" => ErrorCode.TextChannelNotInPlan,
                "text_message_quota_exceeded" => ErrorCode.TextMessageQuotaExceeded,
                "text_turn_failed" => ErrorCode.TextTurnFailed,
                "thread_not_found" => ErrorCode.ThreadNotFound,
                "too_many_voices" => ErrorCode.TooManyVoices,
                "tool_config_shared" => ErrorCode.ToolConfigShared,
                "tool_not_found" => ErrorCode.ToolNotFound,
                "topup_not_in_plan" => ErrorCode.TopupNotInPlan,
                "trigger_not_found" => ErrorCode.TriggerNotFound,
                "unauthorized" => ErrorCode.Unauthorized,
                "unsupported_media_type" => ErrorCode.UnsupportedMediaType,
                "upstream_failure" => ErrorCode.UpstreamFailure,
                "validation_failed" => ErrorCode.ValidationFailed,
                "verification_required" => ErrorCode.VerificationRequired,
                "voice_cloning_not_included" => ErrorCode.VoiceCloningNotIncluded,
                "voice_not_found" => ErrorCode.VoiceNotFound,
                "watermark_audio_unusable" => ErrorCode.WatermarkAudioUnusable,
                "watermark_detection_unavailable" => ErrorCode.WatermarkDetectionUnavailable,
                "workspace_free_limit" => ErrorCode.WorkspaceFreeLimit,
                "workspace_last_owner" => ErrorCode.WorkspaceLastOwner,
                "workspace_last_workspace" => ErrorCode.WorkspaceLastWorkspace,
                "workspace_not_found" => ErrorCode.WorkspaceNotFound,
                "workspace_single_owner" => ErrorCode.WorkspaceSingleOwner,
                _ => null,
            };
        }
    }
}