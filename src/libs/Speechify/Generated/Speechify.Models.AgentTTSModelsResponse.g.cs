
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `GET /v1/agents/tts-models`.
    /// </summary>
    public sealed partial class AgentTTSModelsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AgentTTSModelInfo> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTTSModelsResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTTSModelsResponse(
            global::System.Collections.Generic.IList<global::Speechify.AgentTTSModelInfo> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTTSModelsResponse" /> class.
        /// </summary>
        public AgentTTSModelsResponse()
        {
        }

    }
}