
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How easily the caller takes the floor from a speaking agent,<br/>
    /// and how patiently the agent waits before treating a pause as<br/>
    /// the end of the caller's turn. Null follows the platform and<br/>
    /// behaves identically to `medium`.<br/>
    /// `low` makes the agent hard to interrupt: background noise,<br/>
    /// hold music, and one- or two-word sounds no longer stop it<br/>
    /// mid-sentence (it needs 1.5s of speech and at least 3 words),<br/>
    /// and it waits 0.4s longer before taking a pause as the end of<br/>
    /// a turn. Use it for noisy lines and for callers who pause<br/>
    /// mid-thought. `high` is the opposite: the agent yields after<br/>
    /// 0.4s of caller speech and takes the turn sooner.<br/>
    /// Neither setting changes ordinary turn-taking - a one-word<br/>
    /// answer still replies normally when the agent is silent; the<br/>
    /// word threshold only applies to interrupting speech already in<br/>
    /// progress. Two limits worth knowing: the word threshold needs<br/>
    /// transcription, so it does not apply to agents running the<br/>
    /// realtime audio model, and setting `response_delay_seconds`<br/>
    /// takes over the silence window entirely - the level no longer<br/>
    /// lengthens or shortens how long the agent waits, though it still<br/>
    /// governs how easily the caller interrupts.
    /// </summary>
    public enum AgentTurnHandlingConfigInterruptionSensitivity
    {
        /// <summary>
        /// the agent yields after
        /// </summary>
        High,
        /// <summary>
        /// background noise,
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTurnHandlingConfigInterruptionSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTurnHandlingConfigInterruptionSensitivity value)
        {
            return value switch
            {
                AgentTurnHandlingConfigInterruptionSensitivity.High => "high",
                AgentTurnHandlingConfigInterruptionSensitivity.Low => "low",
                AgentTurnHandlingConfigInterruptionSensitivity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTurnHandlingConfigInterruptionSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentTurnHandlingConfigInterruptionSensitivity.High,
                "low" => AgentTurnHandlingConfigInterruptionSensitivity.Low,
                "medium" => AgentTurnHandlingConfigInterruptionSensitivity.Medium,
                _ => null,
            };
        }
    }
}