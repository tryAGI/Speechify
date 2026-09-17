
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=client`. Execution happens in the caller's browser / SDK.
    /// </summary>
    public sealed partial class ClientToolConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.ToolParam>? Params { get; set; }

        /// <summary>
        /// Per-call timeout in milliseconds. Defaults to 10000 server-side when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Send the request to the client only after the agent has finished<br/>
        /// saying the words of the reply that called the tool. Set it on a<br/>
        /// tool that ends the agent's turn on the client (resume playback,<br/>
        /// hand off, close the sheet), so the spoken handoff is heard before<br/>
        /// the client acts. Off by default: a lookup runs while the agent<br/>
        /// speaks its lead-in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_speech")]
        public bool? AfterSpeech { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfig" /> class.
        /// </summary>
        /// <param name="params"></param>
        /// <param name="timeoutMs">
        /// Per-call timeout in milliseconds. Defaults to 10000 server-side when omitted.
        /// </param>
        /// <param name="afterSpeech">
        /// Send the request to the client only after the agent has finished<br/>
        /// saying the words of the reply that called the tool. Set it on a<br/>
        /// tool that ends the agent's turn on the client (resume playback,<br/>
        /// hand off, close the sheet), so the spoken handoff is heard before<br/>
        /// the client acts. Off by default: a lookup runs while the agent<br/>
        /// speaks its lead-in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolConfig(
            global::System.Collections.Generic.IList<global::Speechify.ToolParam>? @params,
            int? timeoutMs,
            bool? afterSpeech)
        {
            this.Params = @params;
            this.TimeoutMs = timeoutMs;
            this.AfterSpeech = afterSpeech;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfig" /> class.
        /// </summary>
        public ClientToolConfig()
        {
        }

    }
}