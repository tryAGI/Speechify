
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Model used for audio synthesis. `simba-english` is optimized for English, `simba-multilingual` for non-English or mixed input. `simba-3.0` is the streaming-native model with lower TTFB and richer expressivity. Currently English only; multilingual coming soon. Non-English voices return 400 until multilingual support ships.<br/>
    /// Default Value: simba-english
    /// </summary>
    public enum GetSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Simba30,
        /// <summary>
        /// 
        /// </summary>
        SimbaEnglish,
        /// <summary>
        /// 
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
                "simba-english" => GetSpeechRequestModel.SimbaEnglish,
                "simba-multilingual" => GetSpeechRequestModel.SimbaMultilingual,
                _ => null,
            };
        }
    }
}