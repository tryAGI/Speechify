
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Structured, endpoint-specific context beyond the flat<br/>
    /// `fields` map. Present only on the few errors that carry<br/>
    /// it (e.g. the `used_by` referrer list on a credential<br/>
    /// delete-conflict); its shape depends on the error `code`.<br/>
    /// Clients that don't recognise a `details` shape can ignore<br/>
    /// it - the `code` + `message` contract is unchanged.
    /// </summary>
    public sealed partial class CredentialInUseErrorDetailDetails
    {
        /// <summary>
        /// Dependency tracking for a credential: the resources that reference it,<br/>
        /// so a rotate/delete can't silently break a live integration. `count` is<br/>
        /// the total; `references` lists them (empty when unreferenced).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialUsedBy UsedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialInUseErrorDetailDetails" /> class.
        /// </summary>
        /// <param name="usedBy">
        /// Dependency tracking for a credential: the resources that reference it,<br/>
        /// so a rotate/delete can't silently break a live integration. `count` is<br/>
        /// the total; `references` lists them (empty when unreferenced).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialInUseErrorDetailDetails(
            global::Speechify.CredentialUsedBy usedBy)
        {
            this.UsedBy = usedBy ?? throw new global::System.ArgumentNullException(nameof(usedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialInUseErrorDetailDetails" /> class.
        /// </summary>
        public CredentialInUseErrorDetailDetails()
        {
        }

    }
}