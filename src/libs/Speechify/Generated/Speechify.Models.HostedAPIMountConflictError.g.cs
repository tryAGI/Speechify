
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 409 body of a mount. On `mount_plan_changed`, `error.details.plan` is<br/>
    /// the current plan as a dry run of every operation answers it, with its<br/>
    /// own `plan_digest`.
    /// </summary>
    public sealed partial class HostedAPIMountConflictError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedApiMountConflictErrorError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIMountConflictError" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIMountConflictError(
            global::Speechify.HostedApiMountConflictErrorError error,
            string? requestId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIMountConflictError" /> class.
        /// </summary>
        public HostedAPIMountConflictError()
        {
        }

    }
}