
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A model this voice can be synthesized with. The set is filtered to<br/>
    /// what YOUR workspace's API version can select, so a voice never<br/>
    /// advertises a model your own synthesis request would reject. The<br/>
    /// legacy `simba-english` / `simba-multilingual` values appear only for<br/>
    /// a workspace pinned before API version `2026-09-21`.
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