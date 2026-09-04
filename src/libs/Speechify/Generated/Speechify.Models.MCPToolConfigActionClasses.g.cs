
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What each of the server's own tools does, keyed by the remote tool<br/>
    /// name. One MCP tool is a whole server of mixed verbs, so without<br/>
    /// this the server carries a single impact and an autonomous run<br/>
    /// either treats its writes as safe or stops for a human on its<br/>
    /// lookups. Classify the lookups `read` and they run unattended.<br/>
    /// A tool you do not name here keeps the server-level class, which is<br/>
    /// deliberately the cautious one. An explicit server-level `approval`<br/>
    /// still wins over everything here, so gating a whole server stays a<br/>
    /// single switch you can trust.
    /// </summary>
    public sealed partial class MCPToolConfigActionClasses
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}