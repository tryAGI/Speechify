
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialConfigViewCustomHeaders
    {
        /// <summary>
        /// The configured header names; the values are write-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> HeaderNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewCustomHeaders" /> class.
        /// </summary>
        /// <param name="headerNames">
        /// The configured header names; the values are write-only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfigViewCustomHeaders(
            global::System.Collections.Generic.IList<string> headerNames)
        {
            this.HeaderNames = headerNames ?? throw new global::System.ArgumentNullException(nameof(headerNames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewCustomHeaders" /> class.
        /// </summary>
        public CredentialConfigViewCustomHeaders()
        {
        }

    }
}