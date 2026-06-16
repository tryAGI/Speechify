
#nullable enable

namespace Speechify
{
    /// <summary>
    /// LLM backend. Leave empty (or omit both `llm_provider` and<br/>
    /// `llm_model`) to use the platform default (today: Speechify<br/>
    /// Kimi K2.6, resolved server-side at dispatch). When set,<br/>
    /// must be paired with a non-empty `llm_model`; mixing a<br/>
    /// populated provider with an empty model is rejected as a<br/>
    /// 400. `custom` additionally requires `llm_base_url`.
    /// </summary>
    public enum CreateAgentRequestLlmProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
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
    public static class CreateAgentRequestLlmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentRequestLlmProvider value)
        {
            return value switch
            {
                CreateAgentRequestLlmProvider.Custom => "custom",
                CreateAgentRequestLlmProvider.Openai => "openai",
                CreateAgentRequestLlmProvider.Speechify => "speechify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentRequestLlmProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateAgentRequestLlmProvider.Custom,
                "openai" => CreateAgentRequestLlmProvider.Openai,
                "speechify" => CreateAgentRequestLlmProvider.Speechify,
                _ => null,
            };
        }
    }
}