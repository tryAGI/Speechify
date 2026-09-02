
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The rendered arguments of a `tool_call`, with credential-shaped values redacted.
    /// </summary>
    public sealed partial class AgentRunStepArgs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}