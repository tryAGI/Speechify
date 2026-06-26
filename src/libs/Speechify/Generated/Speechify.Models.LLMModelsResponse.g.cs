
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
        /// The provider/model pair an agent left on the "Platform default" picker<br/>
        /// entry resolves to at dispatch time. Introduced 2026-06-25 (pin<br/>
        /// `Speechify-Version: 2026-06-24` or earlier to receive the previous flat<br/>
        /// `platform_default_provider` / `platform_default_model` fields instead).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.LLMPlatformDefault PlatformDefault { get; set; }

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
        /// <param name="platformDefault">
        /// The provider/model pair an agent left on the "Platform default" picker<br/>
        /// entry resolves to at dispatch time. Introduced 2026-06-25 (pin<br/>
        /// `Speechify-Version: 2026-06-24` or earlier to receive the previous flat<br/>
        /// `platform_default_provider` / `platform_default_model` fields instead).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMModelsResponse(
            global::System.Collections.Generic.IList<global::Speechify.LLMModelInfo> models,
            bool customEndpointAllowed,
            global::Speechify.LLMPlatformDefault platformDefault)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.CustomEndpointAllowed = customEndpointAllowed;
            this.PlatformDefault = platformDefault ?? throw new global::System.ArgumentNullException(nameof(platformDefault));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelsResponse" /> class.
        /// </summary>
        public LLMModelsResponse()
        {
        }

    }
}