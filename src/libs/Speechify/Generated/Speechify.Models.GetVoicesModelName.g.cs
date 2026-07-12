
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVoicesModelName
    {
        /// <summary>
        /// 
        /// </summary>
        Simba30,
        /// <summary>
        /// 
        /// </summary>
        Simba32,
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
    public static class GetVoicesModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoicesModelName value)
        {
            return value switch
            {
                GetVoicesModelName.Simba30 => "simba-3.0",
                GetVoicesModelName.Simba32 => "simba-3.2",
                GetVoicesModelName.SimbaEnglish => "simba-english",
                GetVoicesModelName.SimbaMultilingual => "simba-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoicesModelName? ToEnum(string value)
        {
            return value switch
            {
                "simba-3.0" => GetVoicesModelName.Simba30,
                "simba-3.2" => GetVoicesModelName.Simba32,
                "simba-english" => GetVoicesModelName.SimbaEnglish,
                "simba-multilingual" => GetVoicesModelName.SimbaMultilingual,
                _ => null,
            };
        }
    }
}