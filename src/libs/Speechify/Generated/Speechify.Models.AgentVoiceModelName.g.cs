
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentVoiceModelName
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
        Simba35Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentVoiceModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentVoiceModelName value)
        {
            return value switch
            {
                AgentVoiceModelName.Simba30 => "simba-3.0",
                AgentVoiceModelName.Simba32 => "simba-3.2",
                AgentVoiceModelName.Simba35Turbo => "simba-3.5-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentVoiceModelName? ToEnum(string value)
        {
            return value switch
            {
                "simba-3.0" => AgentVoiceModelName.Simba30,
                "simba-3.2" => AgentVoiceModelName.Simba32,
                "simba-3.5-turbo" => AgentVoiceModelName.Simba35Turbo,
                _ => null,
            };
        }
    }
}