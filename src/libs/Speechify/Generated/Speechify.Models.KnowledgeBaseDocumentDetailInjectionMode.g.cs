
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `always` places the document in every prompt of the agents its<br/>
    /// knowledge base is attached to; `on_demand` (the default) leaves it<br/>
    /// on retrieval. A knowledge base small enough to fit the automatic<br/>
    /// budget is placed in the prompt whole regardless of this setting.
    /// </summary>
    public enum KnowledgeBaseDocumentDetailInjectionMode
    {
        /// <summary>
        ///
        /// </summary>
        Always,
        /// <summary>
        ///
        /// </summary>
        OnDemand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseDocumentDetailInjectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseDocumentDetailInjectionMode value)
        {
            return value switch
            {
                KnowledgeBaseDocumentDetailInjectionMode.Always => "always",
                KnowledgeBaseDocumentDetailInjectionMode.OnDemand => "on_demand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseDocumentDetailInjectionMode? ToEnum(string value)
        {
            return value switch
            {
                "always" => KnowledgeBaseDocumentDetailInjectionMode.Always,
                "on_demand" => KnowledgeBaseDocumentDetailInjectionMode.OnDemand,
                _ => null,
            };
        }
    }
}