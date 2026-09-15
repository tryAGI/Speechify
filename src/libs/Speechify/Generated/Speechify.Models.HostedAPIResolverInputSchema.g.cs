
#nullable enable

namespace Speechify
{
    /// <summary>
    /// For a `tool` route on an `mcp` tool: the MCP tool's input schema<br/>
    /// as the server listed it when the route was last written, pinned so<br/>
    /// the MCP face lists it and every call is checked against it without<br/>
    /// reaching the server. Set by the platform on every write that<br/>
    /// carries a resolver; a value you send is replaced. Absent on an<br/>
    /// openapi route, whose schema the definition holds. Write the route<br/>
    /// again to pick up a schema the server changed.
    /// </summary>
    public sealed partial class HostedAPIResolverInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}