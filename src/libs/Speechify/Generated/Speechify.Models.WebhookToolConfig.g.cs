
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=webhook`.
    /// </summary>
    public sealed partial class WebhookToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.WebhookToolConfigMethodJsonConverter))]
        public global::Speechify.WebhookToolConfigMethod? Method { get; set; }

        /// <summary>
        /// Static headers sent with every call. `Authorization` and `Speechify-Signature` are reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Per-call timeout in milliseconds. Defaults to 10000 server-side when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.ToolParam>? Params { get; set; }

        /// <summary>
        /// When true the worker dispatches the HTTP request and returns<br/>
        /// immediately to the LLM with a synthetic "queued" result<br/>
        /// instead of waiting for the response body. The customer's<br/>
        /// endpoint is expected to enqueue the work and return any<br/>
        /// non-error status quickly; errors raised after dispatch are<br/>
        /// logged but never surfaced to the LLM. Use for long-running<br/>
        /// customer-side work (job triggers, async ticket creation,<br/>
        /// etc.) where blocking the call on the response would hurt<br/>
        /// the conversation. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fire_and_forget")]
        public bool? FireAndForget { get; set; }

        /// <summary>
        /// Declares the endpoint slow, so the agent speaks a filler<br/>
        /// phrase instead of leaving the caller in silence and refuses<br/>
        /// a duplicate call while one is in flight.<br/>
        /// Cannot be combined with `fire_and_forget`. That path returns<br/>
        /// to the agent before your endpoint answers, so there is no<br/>
        /// wait to fill; saving both is refused rather than storing a<br/>
        /// holding phrase that can never be spoken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_running")]
        public global::Speechify.LongRunningToolConfig? LongRunning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfig" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method"></param>
        /// <param name="headers">
        /// Static headers sent with every call. `Authorization` and `Speechify-Signature` are reserved.
        /// </param>
        /// <param name="timeoutMs">
        /// Per-call timeout in milliseconds. Defaults to 10000 server-side when omitted.
        /// </param>
        /// <param name="params"></param>
        /// <param name="fireAndForget">
        /// When true the worker dispatches the HTTP request and returns<br/>
        /// immediately to the LLM with a synthetic "queued" result<br/>
        /// instead of waiting for the response body. The customer's<br/>
        /// endpoint is expected to enqueue the work and return any<br/>
        /// non-error status quickly; errors raised after dispatch are<br/>
        /// logged but never surfaced to the LLM. Use for long-running<br/>
        /// customer-side work (job triggers, async ticket creation,<br/>
        /// etc.) where blocking the call on the response would hurt<br/>
        /// the conversation. Defaults to false.
        /// </param>
        /// <param name="longRunning">
        /// Declares the endpoint slow, so the agent speaks a filler<br/>
        /// phrase instead of leaving the caller in silence and refuses<br/>
        /// a duplicate call while one is in flight.<br/>
        /// Cannot be combined with `fire_and_forget`. That path returns<br/>
        /// to the agent before your endpoint answers, so there is no<br/>
        /// wait to fill; saving both is refused rather than storing a<br/>
        /// holding phrase that can never be spoken.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookToolConfig(
            string url,
            global::Speechify.WebhookToolConfigMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? timeoutMs,
            global::System.Collections.Generic.IList<global::Speechify.ToolParam>? @params,
            bool? fireAndForget,
            global::Speechify.LongRunningToolConfig? longRunning)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.Headers = headers;
            this.TimeoutMs = timeoutMs;
            this.Params = @params;
            this.FireAndForget = fireAndForget;
            this.LongRunning = longRunning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfig" /> class.
        /// </summary>
        public WebhookToolConfig()
        {
        }

    }
}