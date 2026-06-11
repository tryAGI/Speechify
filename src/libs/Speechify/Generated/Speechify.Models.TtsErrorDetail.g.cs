
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsErrorDetail
    {
        /// <summary>
        /// Stable machine-readable error code. Additive only: codes are<br/>
        /// never renamed, only deprecated. SDKs may map each code to a<br/>
        /// typed exception class. Status-code semantics:<br/>
        /// 4xx codes describe caller-fixable issues; 5xx codes describe<br/>
        /// server-side failures and are safe to retry with backoff for<br/>
        /// idempotent requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsErrorCode Code { get; set; }

        /// <summary>
        /// Human-readable explanation of this specific occurrence.<br/>
        /// Safe to surface in UI banners or pass to support. The<br/>
        /// wording can change between releases; clients should<br/>
        /// match on `code`, not on the message string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Per-field validation errors as `path -&gt; message`. Only<br/>
        /// present on 400 responses caused by request validation<br/>
        /// (typically code=`validation_failed`). Keys are field<br/>
        /// paths in dotted/bracket notation; values are short<br/>
        /// human explanations safe to inline-surface next to the<br/>
        /// offending form field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.Dictionary<string, string>? Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsErrorDetail" /> class.
        /// </summary>
        /// <param name="code">
        /// Stable machine-readable error code. Additive only: codes are<br/>
        /// never renamed, only deprecated. SDKs may map each code to a<br/>
        /// typed exception class. Status-code semantics:<br/>
        /// 4xx codes describe caller-fixable issues; 5xx codes describe<br/>
        /// server-side failures and are safe to retry with backoff for<br/>
        /// idempotent requests.
        /// </param>
        /// <param name="message">
        /// Human-readable explanation of this specific occurrence.<br/>
        /// Safe to surface in UI banners or pass to support. The<br/>
        /// wording can change between releases; clients should<br/>
        /// match on `code`, not on the message string.
        /// </param>
        /// <param name="fields">
        /// Per-field validation errors as `path -&gt; message`. Only<br/>
        /// present on 400 responses caused by request validation<br/>
        /// (typically code=`validation_failed`). Keys are field<br/>
        /// paths in dotted/bracket notation; values are short<br/>
        /// human explanations safe to inline-surface next to the<br/>
        /// offending form field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsErrorDetail(
            global::Speechify.TtsErrorCode code,
            string message,
            global::System.Collections.Generic.Dictionary<string, string>? fields)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsErrorDetail" /> class.
        /// </summary>
        public TtsErrorDetail()
        {
        }

    }
}