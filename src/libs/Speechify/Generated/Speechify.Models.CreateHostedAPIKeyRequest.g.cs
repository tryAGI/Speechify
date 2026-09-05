
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateHostedAPIKeyRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Requests per minute; 60 when omitted, 0 for unlimited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_minute")]
        public int? RatePerMinute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHostedAPIKeyRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ratePerMinute">
        /// Requests per minute; 60 when omitted, 0 for unlimited.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateHostedAPIKeyRequest(
            string name,
            int? ratePerMinute)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RatePerMinute = ratePerMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHostedAPIKeyRequest" /> class.
        /// </summary>
        public CreateHostedAPIKeyRequest()
        {
        }

    }
}