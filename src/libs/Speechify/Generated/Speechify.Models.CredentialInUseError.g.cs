
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 409 body when a credential delete is refused because it is still<br/>
    /// referenced. The standard `Error` envelope (so clients read<br/>
    /// `error.code` = `credential_in_use` and `request_id`); the referrers to<br/>
    /// detach ride the structured `error.details.used_by` extension.
    /// </summary>
    public sealed partial class CredentialInUseError
    {
        /// <summary>
        /// The error block on a credential-in-use 409: the standard `ErrorDetail`<br/>
        /// (`code` = `credential_in_use`) whose structured `details.used_by` names<br/>
        /// exactly what to detach first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialInUseErrorDetail Error { get; set; }

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
        /// Initializes a new instance of the <see cref="CredentialInUseError" /> class.
        /// </summary>
        /// <param name="error">
        /// The error block on a credential-in-use 409: the standard `ErrorDetail`<br/>
        /// (`code` = `credential_in_use`) whose structured `details.used_by` names<br/>
        /// exactly what to detach first.
        /// </param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialInUseError(
            global::Speechify.CredentialInUseErrorDetail error,
            string? requestId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialInUseError" /> class.
        /// </summary>
        public CredentialInUseError()
        {
        }

    }
}