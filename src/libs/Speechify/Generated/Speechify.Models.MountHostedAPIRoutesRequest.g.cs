
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MountHostedAPIRoutesRequest
    {
        /// <summary>
        /// The `openapi` or `mcp` tool definition to mount, in the API's project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// The operations to create routes for: openapi operation ids or the<br/>
        /// MCP server's tool names. Omit to create a route for every operation<br/>
        /// a route can serve. Naming one the connector does not offer is 400<br/>
        /// `validation_failed` on `operations[i]`. Existing routes are compared<br/>
        /// whatever the selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        public global::System.Collections.Generic.IList<string>? Operations { get; set; }

        /// <summary>
        /// Prefix of each created route's name, `&lt;name_prefix&gt;__&lt;operation&gt;`. Defaults to the tool's name with other characters as `_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_prefix")]
        public string? NamePrefix { get; set; }

        /// <summary>
        /// Path each created route sits under, `&lt;path_prefix&gt;/&lt;operation&gt;`; lowercase segments of letters, digits, `.`, `_` or `-`, with no `{param}` or `*`, and not under `/mcp`, `/openapi.json` or `/_runs`. Defaults to `/&lt;name_prefix&gt;` in lowercase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path_prefix")]
        public string? PathPrefix { get; set; }

        /// <summary>
        /// Answer what the mount would do and write nothing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Create routes for operations that are not reads too, each with<br/>
        /// `allow_write: true`. Only an API whose `auth_mode` names a person<br/>
        /// takes them; the operation's `approval` must still be `auto`.<br/>
        /// Without it a write is a `skip` that says so.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_writes")]
        public bool? IncludeWrites { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MountHostedAPIRoutesRequest" /> class.
        /// </summary>
        /// <param name="toolId">
        /// The `openapi` or `mcp` tool definition to mount, in the API's project.
        /// </param>
        /// <param name="operations">
        /// The operations to create routes for: openapi operation ids or the<br/>
        /// MCP server's tool names. Omit to create a route for every operation<br/>
        /// a route can serve. Naming one the connector does not offer is 400<br/>
        /// `validation_failed` on `operations[i]`. Existing routes are compared<br/>
        /// whatever the selection.
        /// </param>
        /// <param name="namePrefix">
        /// Prefix of each created route's name, `&lt;name_prefix&gt;__&lt;operation&gt;`. Defaults to the tool's name with other characters as `_`.
        /// </param>
        /// <param name="pathPrefix">
        /// Path each created route sits under, `&lt;path_prefix&gt;/&lt;operation&gt;`; lowercase segments of letters, digits, `.`, `_` or `-`, with no `{param}` or `*`, and not under `/mcp`, `/openapi.json` or `/_runs`. Defaults to `/&lt;name_prefix&gt;` in lowercase.
        /// </param>
        /// <param name="dryRun">
        /// Answer what the mount would do and write nothing.
        /// </param>
        /// <param name="includeWrites">
        /// Create routes for operations that are not reads too, each with<br/>
        /// `allow_write: true`. Only an API whose `auth_mode` names a person<br/>
        /// takes them; the operation's `approval` must still be `auto`.<br/>
        /// Without it a write is a `skip` that says so.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MountHostedAPIRoutesRequest(
            string toolId,
            global::System.Collections.Generic.IList<string>? operations,
            string? namePrefix,
            string? pathPrefix,
            bool? dryRun,
            bool? includeWrites)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.Operations = operations;
            this.NamePrefix = namePrefix;
            this.PathPrefix = pathPrefix;
            this.DryRun = dryRun;
            this.IncludeWrites = includeWrites;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MountHostedAPIRoutesRequest" /> class.
        /// </summary>
        public MountHostedAPIRoutesRequest()
        {
        }

    }
}