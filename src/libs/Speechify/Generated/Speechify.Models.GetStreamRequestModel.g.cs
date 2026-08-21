
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Model used for audio synthesis. Defaults to `simba-3.0`, which is streaming-native and multilingual: it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted). `simba-3.2` is the streaming-native model with the lowest TTFB and richest expressivity, and the recommended Simba 3 model; it is English only, so a non-English voice returns 400.<br/>
    /// The legacy Simba 1.6 models `simba-english` and `simba-multilingual` are retired from API version `2026-09-21`: naming one returns 400 `model_retired`. Pinning your API version to a date before `2026-09-21` keeps them working until **2026-11-21**, when both are switched off for every API version. Migrate to `simba-3.2` (English) or `simba-3.0` before then; call GET /v1/audio/models to see the set your workspace can select today.<br/>
    /// Default Value: simba-3.0
    /// </summary>
    public enum GetStreamRequestModel
    {
        /// <summary>
        /// it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted). `simba-3.2` is the streaming-native model with the lowest TTFB and richest expressivity, and the recommended Simba 3 model; it is English only, so a non-English voice returns 400.
        /// </summary>
        Simba30,
        /// <summary>
        /// it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted). `simba-3.2` is the streaming-native model with the lowest TTFB and richest expressivity, and the recommended Simba 3 model; it is English only, so a non-English voice returns 400.
        /// </summary>
        Simba32,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStreamRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStreamRequestModel value)
        {
            return value switch
            {
                GetStreamRequestModel.Simba30 => "simba-3.0",
                GetStreamRequestModel.Simba32 => "simba-3.2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStreamRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "simba-3.0" => GetStreamRequestModel.Simba30,
                "simba-3.2" => GetStreamRequestModel.Simba32,
                _ => null,
            };
        }
    }
}