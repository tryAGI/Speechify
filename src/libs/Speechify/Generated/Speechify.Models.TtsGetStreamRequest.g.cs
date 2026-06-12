
#nullable enable

namespace Speechify
{
    /// <summary>
    /// GetStreamRequest is the wrapper for request parameters to the client
    /// </summary>
    public sealed partial class TtsGetStreamRequest
    {
        /// <summary>
        /// Plain text or SSML to be synthesized to speech.<br/>
        /// Refer to https://docs.speechify.ai/docs/api-limits for the input size limits.<br/>
        /// Emotion, Pitch and Speed Rate are configured in the ssml input, please refer to the ssml documentation for more information: https://docs.speechify.ai/docs/ssml#prosody
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Language of the input. Follow the format of an ISO 639-1 language code and an ISO 3166-1 region code, separated by a hyphen, e.g. en-US.<br/>
        /// Please refer to the list of the supported languages and recommendations regarding this parameter: https://docs.speechify.ai/docs/language-support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Model used for audio synthesis. `simba-english` is optimized for English, `simba-multilingual` for non-English or mixed input. `simba-3.0` is the streaming-native model with lower TTFB and richer expressivity. Currently English only; multilingual coming soon. Non-English voices return 400 until multilingual support ships.<br/>
        /// Default Value: simba-english
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsGetStreamRequestModelJsonConverter))]
        public global::Speechify.TtsGetStreamRequestModel? Model { get; set; }

        /// <summary>
        /// GetStreamOptionsRequest is the wrapper for request parameters to the client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Speechify.TtsGetStreamOptionsRequest? Options { get; set; }

        /// <summary>
        /// Id of the voice to be used for synthesizing speech. Refer to /v1/voices endpoint for available voices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetStreamRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Plain text or SSML to be synthesized to speech.<br/>
        /// Refer to https://docs.speechify.ai/docs/api-limits for the input size limits.<br/>
        /// Emotion, Pitch and Speed Rate are configured in the ssml input, please refer to the ssml documentation for more information: https://docs.speechify.ai/docs/ssml#prosody
        /// </param>
        /// <param name="voiceId">
        /// Id of the voice to be used for synthesizing speech. Refer to /v1/voices endpoint for available voices
        /// </param>
        /// <param name="language">
        /// Language of the input. Follow the format of an ISO 639-1 language code and an ISO 3166-1 region code, separated by a hyphen, e.g. en-US.<br/>
        /// Please refer to the list of the supported languages and recommendations regarding this parameter: https://docs.speechify.ai/docs/language-support.
        /// </param>
        /// <param name="model">
        /// Model used for audio synthesis. `simba-english` is optimized for English, `simba-multilingual` for non-English or mixed input. `simba-3.0` is the streaming-native model with lower TTFB and richer expressivity. Currently English only; multilingual coming soon. Non-English voices return 400 until multilingual support ships.<br/>
        /// Default Value: simba-english
        /// </param>
        /// <param name="options">
        /// GetStreamOptionsRequest is the wrapper for request parameters to the client
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsGetStreamRequest(
            string input,
            string voiceId,
            string? language,
            global::Speechify.TtsGetStreamRequestModel? model,
            global::Speechify.TtsGetStreamOptionsRequest? options)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Language = language;
            this.Model = model;
            this.Options = options;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetStreamRequest" /> class.
        /// </summary>
        public TtsGetStreamRequest()
        {
        }

    }
}