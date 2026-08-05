
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A share link's bearer token, so the owner can copy the URL again.
    /// </summary>
    public sealed partial class RevealShareLinkTokenResponse
    {
        /// <summary>
        /// The link's opaque bearer token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevealShareLinkTokenResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// The link's opaque bearer token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevealShareLinkTokenResponse(
            string token)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevealShareLinkTokenResponse" /> class.
        /// </summary>
        public RevealShareLinkTokenResponse()
        {
        }

    }
}