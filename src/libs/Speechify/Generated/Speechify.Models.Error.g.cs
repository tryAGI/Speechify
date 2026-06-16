
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Standard error envelope returned on every non-2xx response.<br/>
    /// Content-Type is `application/json`. The shape mirrors OpenAI /<br/>
    /// Anthropic / Stripe style: a machine-readable `error.code` for<br/>
    /// SDK consumers to switch on, a human `error.message` for UI,<br/>
    /// and an optional `error.fields` map for per-field validation<br/>
    /// errors. `request_id` matches the `X-Request-ID` response<br/>
    /// header and is what customers quote when filing support<br/>
    /// tickets.
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ErrorDetail Error1 { get; set; }

        /// <summary>
        /// Server-side request identifier. Echoes the<br/>
        /// `X-Request-ID` response header. Stable across the<br/>
        /// request's lifetime, written to structured logs, and<br/>
        /// useful when reporting issues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="error1"></param>
        /// <param name="requestId">
        /// Server-side request identifier. Echoes the<br/>
        /// `X-Request-ID` response header. Stable across the<br/>
        /// request's lifetime, written to structured logs, and<br/>
        /// useful when reporting issues.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            global::Speechify.ErrorDetail error1,
            string? requestId)
        {
            this.Error1 = error1 ?? throw new global::System.ArgumentNullException(nameof(error1));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }

    }
}