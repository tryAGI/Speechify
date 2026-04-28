
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Model used for audio synthesis. `simba-base` and `simba-turbo` are deprecated. Use `simba-english` or `simba-multilingual` instead.<br/>
    /// Default Value: simba-english
    /// </summary>
    public enum TtsGetSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        SimbaBase,
        /// <summary>
        /// 
        /// </summary>
        SimbaEnglish,
        /// <summary>
        /// 
        /// </summary>
        SimbaMultilingual,
        /// <summary>
        /// 
        /// </summary>
        SimbaTurbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsGetSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsGetSpeechRequestModel value)
        {
            return value switch
            {
                TtsGetSpeechRequestModel.SimbaBase => "simba-base",
                TtsGetSpeechRequestModel.SimbaEnglish => "simba-english",
                TtsGetSpeechRequestModel.SimbaMultilingual => "simba-multilingual",
                TtsGetSpeechRequestModel.SimbaTurbo => "simba-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsGetSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "simba-base" => TtsGetSpeechRequestModel.SimbaBase,
                "simba-english" => TtsGetSpeechRequestModel.SimbaEnglish,
                "simba-multilingual" => TtsGetSpeechRequestModel.SimbaMultilingual,
                "simba-turbo" => TtsGetSpeechRequestModel.SimbaTurbo,
                _ => null,
            };
        }
    }
}