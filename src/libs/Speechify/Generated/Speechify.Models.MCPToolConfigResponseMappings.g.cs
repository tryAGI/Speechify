
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What each of the server's tools' JSON results passes through before<br/>
    /// the agent reads it, keyed by the remote tool name: an item bound, a<br/>
    /// projection and derived string fields. Applies on durable runs only;<br/>
    /// a live session's MCP call is made by the worker's own client and<br/>
    /// never crosses the control plane, so a live agent sees the server's<br/>
    /// answer as it came. A tool you do not name here is passed through.
    /// </summary>
    public sealed partial class MCPToolConfigResponseMappings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}