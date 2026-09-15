
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedApiMountConflictErrorError
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ErrorCode Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.Dictionary<string, string>? Fields { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Speechify.HostedApiMountConflictErrorErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiMountConflictErrorError" /> class.
        /// </summary>
        /// <param name="code">
        /// Stable machine-readable error code. Additive only: codes are<br/>
        /// never renamed, only deprecated. SDKs may map each code to a<br/>
        /// typed exception class. Status-code semantics:<br/>
        /// 4xx codes describe caller-fixable issues; 5xx codes describe<br/>
        /// server-side failures and are safe to retry with backoff for<br/>
        /// idempotent requests.
        /// </param>
        /// <param name="message"></param>
        /// <param name="fields"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedApiMountConflictErrorError(
            global::Speechify.ErrorCode code,
            string message,
            global::System.Collections.Generic.Dictionary<string, string>? fields,
            global::Speechify.HostedApiMountConflictErrorErrorDetails? details)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Fields = fields;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiMountConflictErrorError" /> class.
        /// </summary>
        public HostedApiMountConflictErrorError()
        {
        }

    }
}