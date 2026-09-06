
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `always` keeps the document in every prompt; `on_demand`<br/>
    /// returns it to retrieval.
    /// </summary>
    public enum V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode
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
    public static class V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode value)
        {
            return value switch
            {
                V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode.Always => "always",
                V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode.OnDemand => "on_demand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode? ToEnum(string value)
        {
            return value switch
            {
                "always" => V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode.Always,
                "on_demand" => V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode.OnDemand,
                _ => null,
            };
        }
    }
}