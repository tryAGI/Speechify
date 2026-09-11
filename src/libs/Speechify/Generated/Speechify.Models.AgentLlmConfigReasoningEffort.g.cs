
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How hard the model thinks before it answers. `none` (the<br/>
    /// default) answers directly; `low`, `medium` and `high` let the<br/>
    /// model reason first, which makes harder analytical and<br/>
    /// multi-step tool work more reliable at the cost of a slower<br/>
    /// reply. Applies to text conversations, agent tests and runs;<br/>
    /// a spoken turn never reasons, because the thinking lands ahead<br/>
    /// of the first word and a caller hears it as silence. Valid only<br/>
    /// with the `openai` provider (including the platform default) on<br/>
    /// a model that supports reasoning - see the `reasoning` flag on<br/>
    /// `GET /v1/agents/llm-models`; rejected with 400 elsewhere, and a<br/>
    /// custom endpoint takes its reasoning knobs through<br/>
    /// `extra_body`. While reasoning is on, `temperature` is not<br/>
    /// applied. Always present on reads.
    /// </summary>
    public enum AgentLlmConfigReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentLlmConfigReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLlmConfigReasoningEffort value)
        {
            return value switch
            {
                AgentLlmConfigReasoningEffort.High => "high",
                AgentLlmConfigReasoningEffort.Low => "low",
                AgentLlmConfigReasoningEffort.Medium => "medium",
                AgentLlmConfigReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLlmConfigReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentLlmConfigReasoningEffort.High,
                "low" => AgentLlmConfigReasoningEffort.Low,
                "medium" => AgentLlmConfigReasoningEffort.Medium,
                "none" => AgentLlmConfigReasoningEffort.None,
                _ => null,
            };
        }
    }
}