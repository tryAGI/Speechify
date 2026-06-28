
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-recipient variable overrides injected into the agent prompt.<br/>
    /// Values may be any JSON type, matching the outbound-call and<br/>
    /// web-session `dynamic_variables` surfaces. CSV uploads carry<br/>
    /// string values.
    /// </summary>
    public sealed partial class BatchRecipientRequestDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}