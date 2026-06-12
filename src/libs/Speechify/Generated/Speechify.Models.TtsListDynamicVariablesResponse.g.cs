
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response for `GET /v1/agents/{id}/variables`. Returns both the<br/>
    /// customer-scope variable catalogue and the read-only `system__*`<br/>
    /// catalogue so the editor UI has a single source of truth.
    /// </summary>
    public sealed partial class TtsListDynamicVariablesResponse
    {
        /// <summary>
        /// Customer-defined variables for this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsDynamicVariable> Variables { get; set; }

        /// <summary>
        /// Platform-populated `system__*` variables, provided for<br/>
        /// reference. This list is the same for every agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsSystemVariableDoc> SystemVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListDynamicVariablesResponse" /> class.
        /// </summary>
        /// <param name="variables">
        /// Customer-defined variables for this agent.
        /// </param>
        /// <param name="systemVariables">
        /// Platform-populated `system__*` variables, provided for<br/>
        /// reference. This list is the same for every agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListDynamicVariablesResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsDynamicVariable> variables,
            global::System.Collections.Generic.IList<global::Speechify.TtsSystemVariableDoc> systemVariables)
        {
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.SystemVariables = systemVariables ?? throw new global::System.ArgumentNullException(nameof(systemVariables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListDynamicVariablesResponse" /> class.
        /// </summary>
        public TtsListDynamicVariablesResponse()
        {
        }

    }
}