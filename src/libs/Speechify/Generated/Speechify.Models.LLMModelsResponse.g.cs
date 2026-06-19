
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMModelsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.LLMModelInfo> Models { get; set; }

        /// <summary>
        /// Whether the workspace plan permits a bring-your-own custom LLM endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_endpoint_allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CustomEndpointAllowed { get; set; }

        /// <summary>
        /// Provider the "Platform default" picker entry resolves to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_default_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlatformDefaultProvider { get; set; }

        /// <summary>
        /// Model the "Platform default" picker entry resolves to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_default_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlatformDefaultModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelsResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="customEndpointAllowed">
        /// Whether the workspace plan permits a bring-your-own custom LLM endpoint.
        /// </param>
        /// <param name="platformDefaultProvider">
        /// Provider the "Platform default" picker entry resolves to.
        /// </param>
        /// <param name="platformDefaultModel">
        /// Model the "Platform default" picker entry resolves to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMModelsResponse(
            global::System.Collections.Generic.IList<global::Speechify.LLMModelInfo> models,
            bool customEndpointAllowed,
            string platformDefaultProvider,
            string platformDefaultModel)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.CustomEndpointAllowed = customEndpointAllowed;
            this.PlatformDefaultProvider = platformDefaultProvider ?? throw new global::System.ArgumentNullException(nameof(platformDefaultProvider));
            this.PlatformDefaultModel = platformDefaultModel ?? throw new global::System.ArgumentNullException(nameof(platformDefaultModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelsResponse" /> class.
        /// </summary>
        public LLMModelsResponse()
        {
        }

    }
}