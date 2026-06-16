
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVoiceModelName
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
    public static class CreateVoiceModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceModelName value)
        {
            return value switch
            {
                CreateVoiceModelName.Simba30 => "simba-3.0",
                CreateVoiceModelName.SimbaEnglish => "simba-english",
                CreateVoiceModelName.SimbaMultilingual => "simba-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceModelName? ToEnum(string value)
        {
            return value switch
            {
                "simba-3.0" => CreateVoiceModelName.Simba30,
                "simba-english" => CreateVoiceModelName.SimbaEnglish,
                "simba-multilingual" => CreateVoiceModelName.SimbaMultilingual,
                _ => null,
            };
        }
    }
}