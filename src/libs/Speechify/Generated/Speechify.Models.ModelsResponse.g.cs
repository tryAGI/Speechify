
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The catalog of text-to-speech models available for synthesis.
    /// </summary>
    public sealed partial class ModelsResponse
    {
        /// <summary>
        /// The models selectable on the single-utterance synthesis endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.Model> Models { get; set; }

        /// <summary>
        /// The multi-speaker models selectable on POST /v1/audio/dialogue.<br/>
        /// Disjoint from `models`: a dialogue model consumes a<br/>
        /// speaker-attributed script rather than one utterance, so it is<br/>
        /// rejected on the single-utterance endpoints and vice versa. Its<br/>
        /// `default` marks the model that endpoint resolves to when a request<br/>
        /// omits `model`, independently of the `models` default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialogue_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.Model> DialogueModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// The models selectable on the single-utterance synthesis endpoints.
        /// </param>
        /// <param name="dialogueModels">
        /// The multi-speaker models selectable on POST /v1/audio/dialogue.<br/>
        /// Disjoint from `models`: a dialogue model consumes a<br/>
        /// speaker-attributed script rather than one utterance, so it is<br/>
        /// rejected on the single-utterance endpoints and vice versa. Its<br/>
        /// `default` marks the model that endpoint resolves to when a request<br/>
        /// omits `model`, independently of the `models` default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsResponse(
            global::System.Collections.Generic.IList<global::Speechify.Model> models,
            global::System.Collections.Generic.IList<global::Speechify.Model> dialogueModels)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.DialogueModels = dialogueModels ?? throw new global::System.ArgumentNullException(nameof(dialogueModels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        public ModelsResponse()
        {
        }

    }
}