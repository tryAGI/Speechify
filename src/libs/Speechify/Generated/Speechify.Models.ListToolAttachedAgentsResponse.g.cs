
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response shape for GET /v1/agents/tools/{id}/attached-agents.<br/>
    /// Agents are tenant-scoped and ordered by name ASC.
    /// </summary>
    public sealed partial class ListToolAttachedAgentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ToolAttachedAgent> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolAttachedAgentsResponse" /> class.
        /// </summary>
        /// <param name="agents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListToolAttachedAgentsResponse(
            global::System.Collections.Generic.IList<global::Speechify.ToolAttachedAgent> agents)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolAttachedAgentsResponse" /> class.
        /// </summary>
        public ListToolAttachedAgentsResponse()
        {
        }

    }
}