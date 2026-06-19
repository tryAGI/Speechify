
#nullable enable

namespace Speechify
{
    /// <summary>
    /// LLM backend the worker constructs for this agent. Null<br/>
    /// means "use the platform default" (resolved server-side at<br/>
    /// dispatch; today: Speechify GLM-5.2). `openai` and<br/>
    /// `speechify` pair with a model from the allowed (provider,<br/>
    /// model) table. `custom` points the worker at any OpenAI /<br/>
    /// vLLM-compatible endpoint - see `llm_base_url`,<br/>
    /// `llm_api_key`, `llm_extra_body`.
    /// </summary>
    public enum AgentLlmProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// Speechify GLM-5.2). `openai` and
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Speechify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentLlmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLlmProvider value)
        {
            return value switch
            {
                AgentLlmProvider.Custom => "custom",
                AgentLlmProvider.Openai => "openai",
                AgentLlmProvider.Speechify => "speechify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLlmProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom" => AgentLlmProvider.Custom,
                "openai" => AgentLlmProvider.Openai,
                "speechify" => AgentLlmProvider.Speechify,
                _ => null,
            };
        }
    }
}