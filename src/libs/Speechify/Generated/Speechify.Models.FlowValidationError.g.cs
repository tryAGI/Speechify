
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 400 body for flow save / publish / template operations. The standard<br/>
    /// `Error` envelope (so clients read `error.code` = `validation_failed`<br/>
    /// and `request_id`) plus the per-issue `issues` array the flow editor<br/>
    /// uses for node highlighting and the Validator-tab list. `issues` is<br/>
    /// absent on a plain bad request (e.g. an undecodable body, code<br/>
    /// `bad_request`).
    /// </summary>
    public sealed partial class FlowValidationError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ErrorDetail Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::Speechify.FlowValidationIssue>? Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowValidationError" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
        /// <param name="issues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlowValidationError(
            global::Speechify.ErrorDetail error,
            string? requestId,
            global::System.Collections.Generic.IList<global::Speechify.FlowValidationIssue>? issues)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
            this.Issues = issues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowValidationError" /> class.
        /// </summary>
        public FlowValidationError()
        {
        }

    }
}