
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
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsAdminClient SubpackageTtsSubpackageTtsAdmin { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsAgentsClient SubpackageTtsSubpackageTtsAgents { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsAudioClient SubpackageTtsSubpackageTtsAudio { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsAudioAssetsClient SubpackageTtsSubpackageTtsAudioAssets { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsBatchCallsClient SubpackageTtsSubpackageTtsBatchCalls { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsCallersClient SubpackageTtsSubpackageTtsCallers { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsConversationsClient SubpackageTtsSubpackageTtsConversations { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsFlowClient SubpackageTtsSubpackageTtsFlow { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsIvrMemoryClient SubpackageTtsSubpackageTtsIvrMemory { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsKnowledgeBasesClient SubpackageTtsSubpackageTtsKnowledgeBases { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsMemoriesClient SubpackageTtsSubpackageTtsMemories { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsOutboundCallsClient SubpackageTtsSubpackageTtsOutboundCalls { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsPhoneNumbersClient SubpackageTtsSubpackageTtsPhoneNumbers { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsSipTrunksClient SubpackageTtsSubpackageTtsSipTrunks { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsTestsClient SubpackageTtsSubpackageTtsTests { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsToolsClient SubpackageTtsSubpackageTtsTools { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTtsSubpackageTtsVoicesClient SubpackageTtsSubpackageTtsVoices { get; }

    }
}