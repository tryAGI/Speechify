
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=webhook`.
    /// </summary>
    public sealed partial class TtsWebhookToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Default Value: POST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsWebhookToolConfigMethodJsonConverter))]
        public global::Speechify.TtsWebhookToolConfigMethod? Method { get; set; }

        /// <summary>
        /// Static headers sent with every call. `Authorization` and `X-Speechify-Signature` are reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Per-call timeout in milliseconds.<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsToolParam>? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsWebhookToolConfig" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method">
        /// Default Value: POST
        /// </param>
        /// <param name="headers">
        /// Static headers sent with every call. `Authorization` and `X-Speechify-Signature` are reserved.
        /// </param>
        /// <param name="timeoutMs">
        /// Per-call timeout in milliseconds.<br/>
        /// Default Value: 10000
        /// </param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsWebhookToolConfig(
            string url,
            global::Speechify.TtsWebhookToolConfigMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? timeoutMs,
            global::System.Collections.Generic.IList<global::Speechify.TtsToolParam>? @params)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.Headers = headers;
            this.TimeoutMs = timeoutMs;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsWebhookToolConfig" /> class.
        /// </summary>
        public TtsWebhookToolConfig()
        {
        }
    }
}