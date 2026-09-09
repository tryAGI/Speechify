
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Who could not run this case, present only when `outcome` is<br/>
    /// `errored` (a scored case has no fault to attribute). `platform`<br/>
    /// is ours - the eval worker, the judge or the probe corpus - and is<br/>
    /// the default, so an unattributed failure is never blamed on the<br/>
    /// caller. `agent_config` is the agent's OWN configuration, today an<br/>
    /// attached MCP server that could not be reached; waiting does not<br/>
    /// fix it. A publish refused entirely by `agent_config` cases answers<br/>
    /// `422 agent_publish_gate_tool_unreachable` rather than the<br/>
    /// retryable `503 agent_publish_gate_unavailable`.
    /// </summary>
    public enum EvaluationCaseVerdictFault
    {
        /// <summary>
        ///
        /// </summary>
        AgentConfig,
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationCaseVerdictFaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationCaseVerdictFault value)
        {
            return value switch
            {
                EvaluationCaseVerdictFault.AgentConfig => "agent_config",
                EvaluationCaseVerdictFault.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationCaseVerdictFault? ToEnum(string value)
        {
            return value switch
            {
                "agent_config" => EvaluationCaseVerdictFault.AgentConfig,
                "platform" => EvaluationCaseVerdictFault.Platform,
                _ => null,
            };
        }
    }
}