
#nullable enable

namespace Speechify
{
    /// <summary>
    /// An arbitrary set of headers sent on every outbound tool<br/>
    /// request. Useful for vendor signature schemes that don't fit<br/>
    /// Basic / Bearer.
    /// </summary>
    public sealed partial class CustomHeadersConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomHeadersConfig" /> class.
        /// </summary>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomHeadersConfig(
            global::System.Collections.Generic.Dictionary<string, string> headers)
        {
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomHeadersConfig" /> class.
        /// </summary>
        public CustomHeadersConfig()
        {
        }

    }
}