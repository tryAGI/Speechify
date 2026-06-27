
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body for `PATCH /v1/agents/{agent_id}/variables`. Replaces the<br/>
    /// stored variable list wholesale. Pass an empty array to clear all<br/>
    /// variables. Up to 20 variables per agent.
    /// </summary>
    public sealed partial class UpdateDynamicVariablesRequest
    {
        /// <summary>
        /// The new variable list. Replaces the existing list entirely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.DynamicVariable> Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDynamicVariablesRequest" /> class.
        /// </summary>
        /// <param name="variables">
        /// The new variable list. Replaces the existing list entirely.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDynamicVariablesRequest(
            global::System.Collections.Generic.IList<global::Speechify.DynamicVariable> variables)
        {
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDynamicVariablesRequest" /> class.
        /// </summary>
        public UpdateDynamicVariablesRequest()
        {
        }

    }
}