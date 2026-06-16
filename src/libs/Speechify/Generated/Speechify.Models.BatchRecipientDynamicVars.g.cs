
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-recipient variable overrides injected into the agent prompt.
    /// </summary>
    public sealed partial class BatchRecipientDynamicVars
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}