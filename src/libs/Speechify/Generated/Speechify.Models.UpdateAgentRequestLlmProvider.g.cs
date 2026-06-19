
#nullable enable

namespace Speechify
{
    /// <summary>
    /// LLM backend. Send an empty string together with<br/>
    /// `llm_model: ""` to clear the pair to the platform default<br/>
    /// (today: Speechify GLM-5.2). Sending one populated and<br/>
    /// one empty is rejected as a 400. Omit both to leave the<br/>
    /// stored pair unchanged. Switching to a non-`custom` provider<br/>
    /// clears any stored `llm_base_url` / `llm_api_key` /<br/>
    /// `llm_extra_body`.
    /// </summary>
    public enum UpdateAgentRequestLlmProvider
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
    public static class UpdateAgentRequestLlmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAgentRequestLlmProvider value)
        {
            return value switch
            {
                UpdateAgentRequestLlmProvider.Custom => "custom",
                UpdateAgentRequestLlmProvider.Openai => "openai",
                UpdateAgentRequestLlmProvider.Speechify => "speechify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAgentRequestLlmProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom" => UpdateAgentRequestLlmProvider.Custom,
                "openai" => UpdateAgentRequestLlmProvider.Openai,
                "speechify" => UpdateAgentRequestLlmProvider.Speechify,
                _ => null,
            };
        }
    }
}