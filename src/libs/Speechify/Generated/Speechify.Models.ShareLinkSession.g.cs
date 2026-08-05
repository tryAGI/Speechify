
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The realtime handles for a share-link call — exactly what the<br/>
    /// `&lt;speechify-agent&gt;` element's `sessionProvider` returns.
    /// </summary>
    public sealed partial class ShareLinkSession
    {
        /// <summary>
        /// The realtime access token for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// The realtime server URL to connect to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareLinkSession" /> class.
        /// </summary>
        /// <param name="token">
        /// The realtime access token for the session.
        /// </param>
        /// <param name="url">
        /// The realtime server URL to connect to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShareLinkSession(
            string token,
            string url)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareLinkSession" /> class.
        /// </summary>
        public ShareLinkSession()
        {
        }

    }
}