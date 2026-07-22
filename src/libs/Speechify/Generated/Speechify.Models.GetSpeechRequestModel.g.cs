
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Model used for audio synthesis. `simba-english` and `simba-multilingual` are the legacy Simba 1.6 models, kept for compatibility. `simba-3.2` is the streaming-native model with the lowest TTFB and richest expressivity, and the recommended Simba 3 model; it is English only, so a non-English voice returns 400. `simba-3.0` is streaming-native and multilingual: it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted).<br/>
    /// Default Value: simba-english
    /// </summary>
    public enum GetSpeechRequestModel
    {
        /// <summary>
        /// it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted).
        /// </summary>
        Simba30,
        /// <summary>
        /// it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted).
        /// </summary>
        Simba32,
        /// <summary>
        /// it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted).
        /// </summary>
        SimbaEnglish,
        /// <summary>
        /// it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted).
        /// </summary>
        SimbaMultilingual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpeechRequestModel value)
        {
            return value switch
            {
                GetSpeechRequestModel.Simba30 => "simba-3.0",
                GetSpeechRequestModel.Simba32 => "simba-3.2",
                GetSpeechRequestModel.SimbaEnglish => "simba-english",
                GetSpeechRequestModel.SimbaMultilingual => "simba-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "simba-3.0" => GetSpeechRequestModel.Simba30,
                "simba-3.2" => GetSpeechRequestModel.Simba32,
                "simba-english" => GetSpeechRequestModel.SimbaEnglish,
                "simba-multilingual" => GetSpeechRequestModel.SimbaMultilingual,
                _ => null,
            };
        }
    }
}