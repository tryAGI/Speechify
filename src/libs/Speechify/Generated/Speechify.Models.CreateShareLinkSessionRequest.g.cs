
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/share-links/sessions`. The token travels in<br/>
    /// the body rather than the URL so it does not reach request logs.
    /// </summary>
    public sealed partial class CreateShareLinkSessionRequest
    {
        /// <summary>
        /// The share link's opaque bearer token.
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
        /// Initializes a new instance of the <see cref="CreateShareLinkSessionRequest" /> class.
        /// </summary>
        /// <param name="token">
        /// The share link's opaque bearer token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateShareLinkSessionRequest(
            string token)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareLinkSessionRequest" /> class.
        /// </summary>
        public CreateShareLinkSessionRequest()
        {
        }

    }
}