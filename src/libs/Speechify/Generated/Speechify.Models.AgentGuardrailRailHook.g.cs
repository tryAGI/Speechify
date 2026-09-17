
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The seam the rail runs at. `pre_input`: what the caller or<br/>
    /// person said, before the model sees it. `post_retrieval`: a<br/>
    /// knowledge search hit, a fetched page or a web result, before<br/>
    /// it re-enters the model. `pre_tool_call`: a tool call, before<br/>
    /// it runs. `post_output`: what the agent is about to say or<br/>
    /// post.
    /// </summary>
    public enum AgentGuardrailRailHook
    {
        /// <summary>
        /// what the agent is about to say or
        /// </summary>
        PostOutput,
        /// <summary>
        /// a
        /// </summary>
        PostRetrieval,
        /// <summary>
        /// what the caller or
        /// </summary>
        PreInput,
        /// <summary>
        /// a tool call, before
        /// </summary>
        PreToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentGuardrailRailHookExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGuardrailRailHook value)
        {
            return value switch
            {
                AgentGuardrailRailHook.PostOutput => "post_output",
                AgentGuardrailRailHook.PostRetrieval => "post_retrieval",
                AgentGuardrailRailHook.PreInput => "pre_input",
                AgentGuardrailRailHook.PreToolCall => "pre_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGuardrailRailHook? ToEnum(string value)
        {
            return value switch
            {
                "post_output" => AgentGuardrailRailHook.PostOutput,
                "post_retrieval" => AgentGuardrailRailHook.PostRetrieval,
                "pre_input" => AgentGuardrailRailHook.PreInput,
                "pre_tool_call" => AgentGuardrailRailHook.PreToolCall,
                _ => null,
            };
        }
    }
}