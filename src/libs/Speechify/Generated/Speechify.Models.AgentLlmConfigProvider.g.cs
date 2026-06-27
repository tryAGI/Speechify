
#nullable enable

namespace Speechify
{
    /// <summary>
    /// LLM backend. Null (or omit) uses the platform default,<br/>
    /// resolved server-side at dispatch. `openai` and `speechify`<br/>
    /// pair with a `model` from the allowed table. `custom` points<br/>
    /// the worker at any OpenAI / vLLM-compatible endpoint - see<br/>
    /// `base_url`, `credential_id`, `extra_body`. Must be paired with<br/>
    /// a non-null `model`; setting one without the other is rejected.
    /// </summary>
    public enum AgentLlmConfigProvider
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
    public static class AgentLlmConfigProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLlmConfigProvider value)
        {
            return value switch
            {
                AgentLlmConfigProvider.Custom => "custom",
                AgentLlmConfigProvider.Openai => "openai",
                AgentLlmConfigProvider.Speechify => "speechify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLlmConfigProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom" => AgentLlmConfigProvider.Custom,
                "openai" => AgentLlmConfigProvider.Openai,
                "speechify" => AgentLlmConfigProvider.Speechify,
                _ => null,
            };
        }
    }
}