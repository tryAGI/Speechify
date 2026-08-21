
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
        AgentNotFound,
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
        BuiltinNotFound,
        /// <summary>
        /// 
        /// </summary>
        CallerNotFound,
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
        Forbidden,
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
        ProjectHasScopedCredentials,
        /// <summary>
        /// 
        /// </summary>
        ProjectLimitReached,
        /// <summary>
        /// 
        /// </summary>
        ProjectNotFound,
        /// <summary>
        /// 
        /// </summary>
        ProjectSpendLimitExceeded,
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
        VoiceCloningNotIncluded,
        /// <summary>
        /// 
        /// </summary>
        VoiceNotFound,
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
                ErrorCode.AgentNotFound => "agent_not_found",
                ErrorCode.AgentTestNotFound => "agent_test_not_found",
                ErrorCode.AudioAssetNotFound => "audio_asset_not_found",
                ErrorCode.BadRequest => "bad_request",
                ErrorCode.BatchCallsNotIncluded => "batch_calls_not_included",
                ErrorCode.BatchNotFound => "batch_not_found",
                ErrorCode.BuiltinNotFound => "builtin_not_found",
                ErrorCode.CallerNotFound => "caller_not_found",
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
                ErrorCode.Forbidden => "forbidden",
                ErrorCode.IdempotencyConflict => "idempotency_conflict",
                ErrorCode.InsufficientScope => "insufficient_scope",
                ErrorCode.InternalError => "internal_error",
                ErrorCode.InternationalDialingNotEnabled => "international_dialing_not_enabled",
                ErrorCode.InvalidApiVersion => "invalid_api_version",
                ErrorCode.InviteAlreadyPending => "invite_already_pending",
                ErrorCode.InviteEmailMismatch => "invite_email_mismatch",
                ErrorCode.InviteNotFound => "invite_not_found",
                ErrorCode.KbDocumentNotFound => "kb_document_not_found",
                ErrorCode.KbFolderNotFound => "kb_folder_not_found",
                ErrorCode.KbNotFound => "kb_not_found",
                ErrorCode.MethodNotAllowed => "method_not_allowed",
                ErrorCode.ModelRetired => "model_retired",
                ErrorCode.NotFound => "not_found",
                ErrorCode.PayloadTooLarge => "payload_too_large",
                ErrorCode.PaymentRequired => "payment_required",
                ErrorCode.PhoneNumberNotFound => "phone_number_not_found",
                ErrorCode.PhoneNumberQuotaReached => "phone_number_quota_reached",
                ErrorCode.ProjectHasScopedCredentials => "project_has_scoped_credentials",
                ErrorCode.ProjectLimitReached => "project_limit_reached",
                ErrorCode.ProjectNotFound => "project_not_found",
                ErrorCode.ProjectSpendLimitExceeded => "project_spend_limit_exceeded",
                ErrorCode.PurchasedNumbersNotIncluded => "purchased_numbers_not_included",
                ErrorCode.RateLimited => "rate_limited",
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
                ErrorCode.TooManyVoices => "too_many_voices",
                ErrorCode.ToolConfigShared => "tool_config_shared",
                ErrorCode.ToolNotFound => "tool_not_found",
                ErrorCode.TopupNotInPlan => "topup_not_in_plan",
                ErrorCode.Unauthorized => "unauthorized",
                ErrorCode.UnsupportedMediaType => "unsupported_media_type",
                ErrorCode.UpstreamFailure => "upstream_failure",
                ErrorCode.ValidationFailed => "validation_failed",
                ErrorCode.VoiceCloningNotIncluded => "voice_cloning_not_included",
                ErrorCode.VoiceNotFound => "voice_not_found",
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
                "agent_not_found" => ErrorCode.AgentNotFound,
                "agent_test_not_found" => ErrorCode.AgentTestNotFound,
                "audio_asset_not_found" => ErrorCode.AudioAssetNotFound,
                "bad_request" => ErrorCode.BadRequest,
                "batch_calls_not_included" => ErrorCode.BatchCallsNotIncluded,
                "batch_not_found" => ErrorCode.BatchNotFound,
                "builtin_not_found" => ErrorCode.BuiltinNotFound,
                "caller_not_found" => ErrorCode.CallerNotFound,
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
                "forbidden" => ErrorCode.Forbidden,
                "idempotency_conflict" => ErrorCode.IdempotencyConflict,
                "insufficient_scope" => ErrorCode.InsufficientScope,
                "internal_error" => ErrorCode.InternalError,
                "international_dialing_not_enabled" => ErrorCode.InternationalDialingNotEnabled,
                "invalid_api_version" => ErrorCode.InvalidApiVersion,
                "invite_already_pending" => ErrorCode.InviteAlreadyPending,
                "invite_email_mismatch" => ErrorCode.InviteEmailMismatch,
                "invite_not_found" => ErrorCode.InviteNotFound,
                "kb_document_not_found" => ErrorCode.KbDocumentNotFound,
                "kb_folder_not_found" => ErrorCode.KbFolderNotFound,
                "kb_not_found" => ErrorCode.KbNotFound,
                "method_not_allowed" => ErrorCode.MethodNotAllowed,
                "model_retired" => ErrorCode.ModelRetired,
                "not_found" => ErrorCode.NotFound,
                "payload_too_large" => ErrorCode.PayloadTooLarge,
                "payment_required" => ErrorCode.PaymentRequired,
                "phone_number_not_found" => ErrorCode.PhoneNumberNotFound,
                "phone_number_quota_reached" => ErrorCode.PhoneNumberQuotaReached,
                "project_has_scoped_credentials" => ErrorCode.ProjectHasScopedCredentials,
                "project_limit_reached" => ErrorCode.ProjectLimitReached,
                "project_not_found" => ErrorCode.ProjectNotFound,
                "project_spend_limit_exceeded" => ErrorCode.ProjectSpendLimitExceeded,
                "purchased_numbers_not_included" => ErrorCode.PurchasedNumbersNotIncluded,
                "rate_limited" => ErrorCode.RateLimited,
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
                "too_many_voices" => ErrorCode.TooManyVoices,
                "tool_config_shared" => ErrorCode.ToolConfigShared,
                "tool_not_found" => ErrorCode.ToolNotFound,
                "topup_not_in_plan" => ErrorCode.TopupNotInPlan,
                "unauthorized" => ErrorCode.Unauthorized,
                "unsupported_media_type" => ErrorCode.UnsupportedMediaType,
                "upstream_failure" => ErrorCode.UpstreamFailure,
                "validation_failed" => ErrorCode.ValidationFailed,
                "voice_cloning_not_included" => ErrorCode.VoiceCloningNotIncluded,
                "voice_not_found" => ErrorCode.VoiceNotFound,
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