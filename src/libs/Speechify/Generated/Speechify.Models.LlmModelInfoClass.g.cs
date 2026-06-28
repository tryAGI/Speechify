
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Access class controlling which plans may select the model.<br/>
    /// `premium` models are available only on higher plans.
    /// </summary>
    public enum LlmModelInfoClass
    {
        /// <summary>
        /// 
        /// </summary>
        Managed,
        /// <summary>
        /// 
        /// </summary>
        Premium,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmModelInfoClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmModelInfoClass value)
        {
            return value switch
            {
                LlmModelInfoClass.Managed => "managed",
                LlmModelInfoClass.Premium => "premium",
                LlmModelInfoClass.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmModelInfoClass? ToEnum(string value)
        {
            return value switch
            {
                "managed" => LlmModelInfoClass.Managed,
                "premium" => LlmModelInfoClass.Premium,
                "standard" => LlmModelInfoClass.Standard,
                _ => null,
            };
        }
    }
}