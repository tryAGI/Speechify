
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
    /// single switch you can trust.<br/>
    /// Your server can also classify its own tools: a `tools/list` entry<br/>
    /// carrying `_meta: {"speechify/action_class": "communicate_external"}`<br/>
    /// declares that tool's impact. The declaration is honoured under the<br/>
    /// ceiling set by the tool definition's `action_class`: a declared<br/>
    /// class at least as strong as the definition's is used, a weaker one<br/>
    /// is held to the definition's, and an unclassified definition<br/>
    /// (`irreversible_other`) makes every declaration moot. So one server<br/>
    /// with `action_class: read` runs its reads unattended and parks a run<br/>
    /// on the tool it declared `communicate_external`, with no second<br/>
    /// server and no entry here. What you declare here beats what the<br/>
    /// server declares.
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