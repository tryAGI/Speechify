
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-instance configuration shape. The schema depends on<br/>
    /// `builtin` — see the per-builtin contracts under<br/>
    /// `/contracts/tools/system_*.schema.json`. Null when the<br/>
    /// builtin takes no instance-level config.
    /// </summary>
    public sealed partial class AgentBuiltinConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}