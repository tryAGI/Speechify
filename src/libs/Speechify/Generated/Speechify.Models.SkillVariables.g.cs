
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Defaults for the `{{tokens}}` the instructions reference. They only<br/>
    /// fill keys nothing else set - the agent's own values, the flow's and<br/>
    /// the session's all outrank them.
    /// </summary>
    public sealed partial class SkillVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}