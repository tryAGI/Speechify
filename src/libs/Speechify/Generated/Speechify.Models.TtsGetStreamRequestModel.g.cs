
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Model used for audio synthesis. `simba-base` and `simba-turbo` are deprecated. Use `simba-english` or `simba-multilingual` instead.<br/>
    /// Default Value: simba-english
    /// </summary>
    public enum TtsGetStreamRequestModel
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
    public static class TtsGetStreamRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsGetStreamRequestModel value)
        {
            return value switch
            {
                TtsGetStreamRequestModel.SimbaBase => "simba-base",
                TtsGetStreamRequestModel.SimbaEnglish => "simba-english",
                TtsGetStreamRequestModel.SimbaMultilingual => "simba-multilingual",
                TtsGetStreamRequestModel.SimbaTurbo => "simba-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsGetStreamRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "simba-base" => TtsGetStreamRequestModel.SimbaBase,
                "simba-english" => TtsGetStreamRequestModel.SimbaEnglish,
                "simba-multilingual" => TtsGetStreamRequestModel.SimbaMultilingual,
                "simba-turbo" => TtsGetStreamRequestModel.SimbaTurbo,
                _ => null,
            };
        }
    }
}