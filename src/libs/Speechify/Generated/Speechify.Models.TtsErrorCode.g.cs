
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
    public enum TtsErrorCode
    {
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
        Conflict,
        /// <summary>
        /// 
        /// </summary>
        ConversationNotFound,
        /// <summary>
        /// 
        /// </summary>
        CredentialNotFound,
        /// <summary>
        /// 
        /// </summary>
        Forbidden,
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
        PurchasedNumbersNotIncluded,
        /// <summary>
        /// 
        /// </summary>
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        ServiceUnavailable,
        /// <summary>
        /// 
        /// </summary>
        SipTrunkNotFound,
        /// <summary>
        /// 
        /// </summary>
        ToolNotFound,
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
        WorkspaceLastOwner,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceLastWorkspace,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsErrorCode value)
        {
            return value switch
            {
                TtsErrorCode.AgentNotFound => "agent_not_found",
                TtsErrorCode.AgentTestNotFound => "agent_test_not_found",
                TtsErrorCode.AudioAssetNotFound => "audio_asset_not_found",
                TtsErrorCode.BadRequest => "bad_request",
                TtsErrorCode.BatchCallsNotIncluded => "batch_calls_not_included",
                TtsErrorCode.BatchNotFound => "batch_not_found",
                TtsErrorCode.BuiltinNotFound => "builtin_not_found",
                TtsErrorCode.CallerNotFound => "caller_not_found",
                TtsErrorCode.Conflict => "conflict",
                TtsErrorCode.ConversationNotFound => "conversation_not_found",
                TtsErrorCode.CredentialNotFound => "credential_not_found",
                TtsErrorCode.Forbidden => "forbidden",
                TtsErrorCode.InsufficientScope => "insufficient_scope",
                TtsErrorCode.InternalError => "internal_error",
                TtsErrorCode.InviteEmailMismatch => "invite_email_mismatch",
                TtsErrorCode.InviteNotFound => "invite_not_found",
                TtsErrorCode.KbDocumentNotFound => "kb_document_not_found",
                TtsErrorCode.KbFolderNotFound => "kb_folder_not_found",
                TtsErrorCode.KbNotFound => "kb_not_found",
                TtsErrorCode.MethodNotAllowed => "method_not_allowed",
                TtsErrorCode.NotFound => "not_found",
                TtsErrorCode.PayloadTooLarge => "payload_too_large",
                TtsErrorCode.PaymentRequired => "payment_required",
                TtsErrorCode.PhoneNumberNotFound => "phone_number_not_found",
                TtsErrorCode.PhoneNumberQuotaReached => "phone_number_quota_reached",
                TtsErrorCode.PurchasedNumbersNotIncluded => "purchased_numbers_not_included",
                TtsErrorCode.RateLimited => "rate_limited",
                TtsErrorCode.ServiceUnavailable => "service_unavailable",
                TtsErrorCode.SipTrunkNotFound => "sip_trunk_not_found",
                TtsErrorCode.ToolNotFound => "tool_not_found",
                TtsErrorCode.Unauthorized => "unauthorized",
                TtsErrorCode.UnsupportedMediaType => "unsupported_media_type",
                TtsErrorCode.UpstreamFailure => "upstream_failure",
                TtsErrorCode.ValidationFailed => "validation_failed",
                TtsErrorCode.VoiceCloningNotIncluded => "voice_cloning_not_included",
                TtsErrorCode.VoiceNotFound => "voice_not_found",
                TtsErrorCode.WorkspaceLastOwner => "workspace_last_owner",
                TtsErrorCode.WorkspaceLastWorkspace => "workspace_last_workspace",
                TtsErrorCode.WorkspaceNotFound => "workspace_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "agent_not_found" => TtsErrorCode.AgentNotFound,
                "agent_test_not_found" => TtsErrorCode.AgentTestNotFound,
                "audio_asset_not_found" => TtsErrorCode.AudioAssetNotFound,
                "bad_request" => TtsErrorCode.BadRequest,
                "batch_calls_not_included" => TtsErrorCode.BatchCallsNotIncluded,
                "batch_not_found" => TtsErrorCode.BatchNotFound,
                "builtin_not_found" => TtsErrorCode.BuiltinNotFound,
                "caller_not_found" => TtsErrorCode.CallerNotFound,
                "conflict" => TtsErrorCode.Conflict,
                "conversation_not_found" => TtsErrorCode.ConversationNotFound,
                "credential_not_found" => TtsErrorCode.CredentialNotFound,
                "forbidden" => TtsErrorCode.Forbidden,
                "insufficient_scope" => TtsErrorCode.InsufficientScope,
                "internal_error" => TtsErrorCode.InternalError,
                "invite_email_mismatch" => TtsErrorCode.InviteEmailMismatch,
                "invite_not_found" => TtsErrorCode.InviteNotFound,
                "kb_document_not_found" => TtsErrorCode.KbDocumentNotFound,
                "kb_folder_not_found" => TtsErrorCode.KbFolderNotFound,
                "kb_not_found" => TtsErrorCode.KbNotFound,
                "method_not_allowed" => TtsErrorCode.MethodNotAllowed,
                "not_found" => TtsErrorCode.NotFound,
                "payload_too_large" => TtsErrorCode.PayloadTooLarge,
                "payment_required" => TtsErrorCode.PaymentRequired,
                "phone_number_not_found" => TtsErrorCode.PhoneNumberNotFound,
                "phone_number_quota_reached" => TtsErrorCode.PhoneNumberQuotaReached,
                "purchased_numbers_not_included" => TtsErrorCode.PurchasedNumbersNotIncluded,
                "rate_limited" => TtsErrorCode.RateLimited,
                "service_unavailable" => TtsErrorCode.ServiceUnavailable,
                "sip_trunk_not_found" => TtsErrorCode.SipTrunkNotFound,
                "tool_not_found" => TtsErrorCode.ToolNotFound,
                "unauthorized" => TtsErrorCode.Unauthorized,
                "unsupported_media_type" => TtsErrorCode.UnsupportedMediaType,
                "upstream_failure" => TtsErrorCode.UpstreamFailure,
                "validation_failed" => TtsErrorCode.ValidationFailed,
                "voice_cloning_not_included" => TtsErrorCode.VoiceCloningNotIncluded,
                "voice_not_found" => TtsErrorCode.VoiceNotFound,
                "workspace_last_owner" => TtsErrorCode.WorkspaceLastOwner,
                "workspace_last_workspace" => TtsErrorCode.WorkspaceLastWorkspace,
                "workspace_not_found" => TtsErrorCode.WorkspaceNotFound,
                _ => null,
            };
        }
    }
}