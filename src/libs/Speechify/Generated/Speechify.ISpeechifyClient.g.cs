
#nullable enable

namespace Speechify
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISpeechifyClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechify.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Speechify.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// Creates idempotency keys for generated idempotent requests when the caller does not provide one.
        /// </summary>
        public global::System.Func<string> CreateIdempotencyKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentClient SubpackageAgent { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentAdminClient SubpackageAgentAdmin { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentAudioAssetsClient SubpackageAgentAudioAssets { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentBatchCallsClient SubpackageAgentBatchCalls { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentCallersClient SubpackageAgentCallers { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentConversationsClient SubpackageAgentConversations { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentFlowClient SubpackageAgentFlow { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentIvrMemoryClient SubpackageAgentIvrMemory { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentKnowledgeBasesClient SubpackageAgentKnowledgeBases { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentMemoriesClient SubpackageAgentMemories { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentOutboundCallsClient SubpackageAgentOutboundCalls { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentPhoneNumbersClient SubpackageAgentPhoneNumbers { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentSipTrunksClient SubpackageAgentSipTrunks { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentTestsClient SubpackageAgentTests { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentToolDefinitionsClient SubpackageAgentToolDefinitions { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAudioClient SubpackageAudio { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageVoicesClient SubpackageVoices { get; }

    }
}