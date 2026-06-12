
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
    public enum TtsCreateAgentRequestLlmProvider
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
    public static class TtsCreateAgentRequestLlmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsCreateAgentRequestLlmProvider value)
        {
            return value switch
            {
                TtsCreateAgentRequestLlmProvider.Custom => "custom",
                TtsCreateAgentRequestLlmProvider.Openai => "openai",
                TtsCreateAgentRequestLlmProvider.Speechify => "speechify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsCreateAgentRequestLlmProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TtsCreateAgentRequestLlmProvider.Custom,
                "openai" => TtsCreateAgentRequestLlmProvider.Openai,
                "speechify" => TtsCreateAgentRequestLlmProvider.Speechify,
                _ => null,
            };
        }
    }
}