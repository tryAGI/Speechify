
#nullable enable

namespace Speechify
{
    /// <summary>
    /// GetStreamRequest is the wrapper for request parameters to the client
    /// </summary>
    public sealed partial class GetStreamRequest
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
        /// Model used for audio synthesis. Defaults to `simba-3.0`, which is streaming-native and multilingual: it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted). `simba-3.2` is the streaming-native model with the lowest TTFB and richest expressivity, and the recommended Simba 3 model; it is English only, so a non-English voice returns 400.<br/>
        /// The legacy Simba 1.6 models `simba-english` and `simba-multilingual` are retired from API version `2026-09-21`: naming one returns 400 `model_retired`. Pinning your API version to a date before `2026-09-21` keeps them working until **2026-11-21**, when both are switched off for every API version. Migrate to `simba-3.2` (English) or `simba-3.0` before then; call GET /v1/audio/models to see the set your workspace can select today.<br/>
        /// Default Value: simba-3.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.GetStreamRequestModelJsonConverter))]
        public global::Speechify.GetStreamRequestModel? Model { get; set; }

        /// <summary>
        /// GetStreamOptionsRequest is the wrapper for request parameters to the client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Speechify.GetStreamOptionsRequest? Options { get; set; }

        /// <summary>
        /// The output audio format as a `codec_sampleRate_bitrate` string. Takes precedence over the `Accept` header when set, so you can request formats the `Accept` enum does not cover (e.g. `pcm_16000`, `ulaw_8000`). `wav_*` formats are not supported on streaming - use `POST /v1/audio/speech` for wav.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AudioStreamOutputFormatJsonConverter))]
        public global::Speechify.AudioStreamOutputFormat? OutputFormat { get; set; }

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
        /// Initializes a new instance of the <see cref="GetStreamRequest" /> class.
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
        /// Model used for audio synthesis. Defaults to `simba-3.0`, which is streaming-native and multilingual: it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted). `simba-3.2` is the streaming-native model with the lowest TTFB and richest expressivity, and the recommended Simba 3 model; it is English only, so a non-English voice returns 400.<br/>
        /// The legacy Simba 1.6 models `simba-english` and `simba-multilingual` are retired from API version `2026-09-21`: naming one returns 400 `model_retired`. Pinning your API version to a date before `2026-09-21` keeps them working until **2026-11-21**, when both are switched off for every API version. Migrate to `simba-3.2` (English) or `simba-3.0` before then; call GET /v1/audio/models to see the set your workspace can select today.<br/>
        /// Default Value: simba-3.0
        /// </param>
        /// <param name="options">
        /// GetStreamOptionsRequest is the wrapper for request parameters to the client
        /// </param>
        /// <param name="outputFormat">
        /// The output audio format as a `codec_sampleRate_bitrate` string. Takes precedence over the `Accept` header when set, so you can request formats the `Accept` enum does not cover (e.g. `pcm_16000`, `ulaw_8000`). `wav_*` formats are not supported on streaming - use `POST /v1/audio/speech` for wav.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStreamRequest(
            string input,
            string voiceId,
            string? language,
            global::Speechify.GetStreamRequestModel? model,
            global::Speechify.GetStreamOptionsRequest? options,
            global::Speechify.AudioStreamOutputFormat? outputFormat)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Language = language;
            this.Model = model;
            this.Options = options;
            this.OutputFormat = outputFormat;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamRequest" /> class.
        /// </summary>
        public GetStreamRequest()
        {
        }

    }
}