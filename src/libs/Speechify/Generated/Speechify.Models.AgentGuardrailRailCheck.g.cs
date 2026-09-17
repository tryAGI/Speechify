
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The check the rail runs. `injection_patterns`: instruction<br/>
    /// override, prompt extraction, jailbreak and injected-role<br/>
    /// patterns (pre_input, post_retrieval). `pii_patterns`: SSN,<br/>
    /// card, email and phone patterns (post_output, post_retrieval).<br/>
    /// `secret_patterns`: private keys, cloud and provider tokens,<br/>
    /// JWTs and credential assignments (post_output,<br/>
    /// post_retrieval). `tool_authz`: refuse a gated tool fed<br/>
    /// arguments that derive from untrusted text (pre_tool_call;<br/>
    /// observe or block only). `moderation`: the platform content<br/>
    /// classifier with the same categories the speech API refuses<br/>
    /// (post_output, pre_input; observe or block only). A<br/>
    /// classifier's verdict is collected at the last moment before<br/>
    /// the caller could hear the reply and never delays it beyond a<br/>
    /// bounded wait.
    /// </summary>
    public enum AgentGuardrailRailCheck
    {
        /// <summary>
        /// instruction
        /// </summary>
        InjectionPatterns,
        /// <summary>
        /// the platform content
        /// </summary>
        Moderation,
        /// <summary>
        /// SSN,
        /// </summary>
        PiiPatterns,
        /// <summary>
        /// private keys, cloud and provider tokens,
        /// </summary>
        SecretPatterns,
        /// <summary>
        /// refuse a gated tool fed
        /// </summary>
        ToolAuthz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentGuardrailRailCheckExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGuardrailRailCheck value)
        {
            return value switch
            {
                AgentGuardrailRailCheck.InjectionPatterns => "injection_patterns",
                AgentGuardrailRailCheck.Moderation => "moderation",
                AgentGuardrailRailCheck.PiiPatterns => "pii_patterns",
                AgentGuardrailRailCheck.SecretPatterns => "secret_patterns",
                AgentGuardrailRailCheck.ToolAuthz => "tool_authz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGuardrailRailCheck? ToEnum(string value)
        {
            return value switch
            {
                "injection_patterns" => AgentGuardrailRailCheck.InjectionPatterns,
                "moderation" => AgentGuardrailRailCheck.Moderation,
                "pii_patterns" => AgentGuardrailRailCheck.PiiPatterns,
                "secret_patterns" => AgentGuardrailRailCheck.SecretPatterns,
                "tool_authz" => AgentGuardrailRailCheck.ToolAuthz,
                _ => null,
            };
        }
    }
}