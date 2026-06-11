
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
        BadRequest,
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
        CredentialNotFound,
        /// <summary>
        /// 
        /// </summary>
        Forbidden,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
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
        PaymentMethodRequired,
        /// <summary>
        /// 
        /// </summary>
        PaymentRequired,
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
                TtsErrorCode.BadRequest => "bad_request",
                TtsErrorCode.CallerNotFound => "caller_not_found",
                TtsErrorCode.Conflict => "conflict",
                TtsErrorCode.CredentialNotFound => "credential_not_found",
                TtsErrorCode.Forbidden => "forbidden",
                TtsErrorCode.InternalError => "internal_error",
                TtsErrorCode.MethodNotAllowed => "method_not_allowed",
                TtsErrorCode.NotFound => "not_found",
                TtsErrorCode.PayloadTooLarge => "payload_too_large",
                TtsErrorCode.PaymentMethodRequired => "payment_method_required",
                TtsErrorCode.PaymentRequired => "payment_required",
                TtsErrorCode.RateLimited => "rate_limited",
                TtsErrorCode.ServiceUnavailable => "service_unavailable",
                TtsErrorCode.Unauthorized => "unauthorized",
                TtsErrorCode.UnsupportedMediaType => "unsupported_media_type",
                TtsErrorCode.UpstreamFailure => "upstream_failure",
                TtsErrorCode.ValidationFailed => "validation_failed",
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
                "bad_request" => TtsErrorCode.BadRequest,
                "caller_not_found" => TtsErrorCode.CallerNotFound,
                "conflict" => TtsErrorCode.Conflict,
                "credential_not_found" => TtsErrorCode.CredentialNotFound,
                "forbidden" => TtsErrorCode.Forbidden,
                "internal_error" => TtsErrorCode.InternalError,
                "method_not_allowed" => TtsErrorCode.MethodNotAllowed,
                "not_found" => TtsErrorCode.NotFound,
                "payload_too_large" => TtsErrorCode.PayloadTooLarge,
                "payment_method_required" => TtsErrorCode.PaymentMethodRequired,
                "payment_required" => TtsErrorCode.PaymentRequired,
                "rate_limited" => TtsErrorCode.RateLimited,
                "service_unavailable" => TtsErrorCode.ServiceUnavailable,
                "unauthorized" => TtsErrorCode.Unauthorized,
                "unsupported_media_type" => TtsErrorCode.UnsupportedMediaType,
                "upstream_failure" => TtsErrorCode.UpstreamFailure,
                "validation_failed" => TtsErrorCode.ValidationFailed,
                _ => null,
            };
        }
    }
}