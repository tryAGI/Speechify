
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Validated menu_tree per contracts/agents/ivr_menu.schema.json. Opaque to consumers other than the worker.
    /// </summary>
    public sealed partial class TtsIvrMenuMenuTree
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}