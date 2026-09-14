
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Dependency tracking for a credential: the resources that reference it,<br/>
    /// so a rotate/delete can't silently break a live integration. `count` is<br/>
    /// the total; `references` lists them (empty when unreferenced).
    /// </summary>
    public sealed partial class CredentialUsedBy
    {
        /// <summary>
        /// Number of resources referencing this credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.CredentialReference> References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialUsedBy" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of resources referencing this credential.
        /// </param>
        /// <param name="references"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialUsedBy(
            int count,
            global::System.Collections.Generic.IList<global::Speechify.CredentialReference> references)
        {
            this.Count = count;
            this.References = references ?? throw new global::System.ArgumentNullException(nameof(references));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialUsedBy" /> class.
        /// </summary>
        public CredentialUsedBy()
        {
        }

    }
}