
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Sets the workspace's single resolver. Re-sending the same body is a<br/>
    /// no-op; the signing secret is minted on first configuration only.
    /// </summary>
    public sealed partial class PutContactResolverRequest
    {
        /// <summary>
        /// HTTPS endpoint that answers `{external_id, display_name?,<br/>
        /// variables?}`. Must resolve to a public address - loopback,<br/>
        /// private-range and cloud-metadata hosts are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Park the integration without deleting it. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutContactResolverRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// HTTPS endpoint that answers `{external_id, display_name?,<br/>
        /// variables?}`. Must resolve to a public address - loopback,<br/>
        /// private-range and cloud-metadata hosts are rejected.
        /// </param>
        /// <param name="disabled">
        /// Park the integration without deleting it. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutContactResolverRequest(
            string url,
            bool? disabled)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutContactResolverRequest" /> class.
        /// </summary>
        public PutContactResolverRequest()
        {
        }

    }
}