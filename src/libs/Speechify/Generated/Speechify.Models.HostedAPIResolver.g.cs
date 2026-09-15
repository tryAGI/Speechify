
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What answers a route. `type` selects the fields that apply:<br/>
    /// `store_query` (store_id, collection, where, order_by, limit),<br/>
    /// `store_document` (store_id, collection, document_id),<br/>
    /// `store_aggregate` (store_id, collection, where, group_by, metrics:<br/>
    /// a summary in one request, from the same implementation as the<br/>
    /// collection's `aggregate` operation),<br/>
    /// `store_write` (store_id, collection, write_mode, document_id: the<br/>
    /// request body lands as a document, the fast path past a run for the<br/>
    /// one thing a read resolver cannot do; POST only, never on a public<br/>
    /// API, and on an API that names its caller the document is that<br/>
    /// person's),<br/>
    /// `run_latest` (trigger_id of a schedule trigger),<br/>
    /// `run` (trigger_id of a webhook trigger, wait_seconds),<br/>
    /// `file` (file_path of one published file; or, on a route whose path<br/>
    /// ends in `*`, file_root and file_index for a whole published tree),<br/>
    /// `tool` (tool_id of an `openapi` or `mcp` tool definition and the<br/>
    /// `operation` on it, an openapi operation's id or one of the MCP<br/>
    /// server's tools by name: the POST body is the arguments, held to their<br/>
    /// schema, and the connector's answer after the tool's response mapping<br/>
    /// is the response. An openapi vendor's JSON comes back as it came, or<br/>
    /// `{"text": ...}` when it answered text; an MCP tool answers its<br/>
    /// structured content, its text when that text is JSON, `{"text": ...}`<br/>
    /// for plain text, or `{"content": [...]}` with every block as the server<br/>
    /// sent it when one is not text. For an `mcp` tool the route write lists<br/>
    /// the server's tools and pins the chosen tool's input schema on the<br/>
    /// route as `input_schema`, so the MCP face and every call use the pin<br/>
    /// and an upstream change reaches no consumer until the route is written<br/>
    /// again. An operation whose effective class is `read`, on a tool whose<br/>
    /// `approval` is null or `auto`, may be served on any API but a public<br/>
    /// one. An operation that is not a read is served only on a route with<br/>
    /// `allow_write: true`, on an API whose `auth_mode` names a person<br/>
    /// (`owner`, `workspace` or `user_token`), and still only with an<br/>
    /// `approval` of null or `auto`: a write through a route acts for the<br/>
    /// member or end user calling, who is sent to the connector as<br/>
    /// `Speechify-User-Identity`, a service account is refused, every write<br/>
    /// counts against `daily_write_cap` (429 `route_write_limit_reached`) and<br/>
    /// claims the caller's `Idempotency-Key` so a retry replays the first<br/>
    /// answer. A route write that breaks any of this is refused with 400<br/>
    /// `validation_failed` on `resolver.tool_id`, `resolver.operation` or<br/>
    /// `resolver.allow_write`, as is an MCP server that cannot be listed.<br/>
    /// Because a definition can change after its route is written, every call<br/>
    /// re-checks it: an operation no longer classified `read` on a route not<br/>
    /// switched to writes, or a tool whose `approval` is no longer null or<br/>
    /// `auto`, answers 403 `route_tool_not_readable`; a tool<br/>
    /// deleted, moved to another project, or without the operation (an MCP<br/>
    /// server that no longer lists the tool) answers 409<br/>
    /// `route_tool_unavailable`, which no<br/>
    /// retry clears until the route or the tool is fixed, and names which<br/>
    /// of the three happened in `error.details.reason` (`tool_deleted`,<br/>
    /// `tool_moved`, `operation_removed`). Both refusals carry what the API's<br/>
    /// owner changes to fix the route in `error.details.fix`. Arguments that do<br/>
    /// not fit the schema answer 400 `validation_failed`; the definition's<br/>
    /// `max_requests_per_minute` and the vendor's own throttle both answer 429<br/>
    /// `route_upstream_rate_limited` with `Retry-After`; a vendor error<br/>
    /// answers 502 `route_upstream_error` with the vendor's status in<br/>
    /// `error.details.upstream_status`, an MCP tool that reports an error<br/>
    /// answers it with the tool's own message in `error.details.tool_error`,<br/>
    /// and an unreachable vendor or a credential that no longer resolves<br/>
    /// answers 502 `route_upstream_error` without either).
    /// </summary>
    public sealed partial class HostedAPIResolver
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.HostedApiResolverTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedApiResolverType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public string? StoreId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// A literal id, a `{{path.x}}` / `{{query.x}}` / `{{body.x}}` template bound from the request, or a `{{user.x}}` claim of the verified caller. On a `store_write` route it names the document a replace or merge lands on, and is refused on a create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// For a `store_write` route: `create` mints an id and answers 201<br/>
        /// with the document; `replace` and `merge` land on `document_id`<br/>
        /// (a merge sets the fields sent and keeps the rest) and answer 200.<br/>
        /// Omitted, a route with a document_id merges and one without<br/>
        /// creates. On an API that names its caller, a replace or merge of<br/>
        /// another person's document is not found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.HostedApiResolverWriteModeJsonConverter))]
        public global::Speechify.HostedApiResolverWriteMode? WriteMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where")]
        public global::System.Collections.Generic.IList<global::Speechify.HostedApiResolverWhereItems>? Where { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public global::Speechify.HostedApiResolverOrderBy? OrderBy { get; set; }

        /// <summary>
        /// Default page size; the consumer's `limit` query parameter overrides it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// For a `store_aggregate` route, the projected field to group by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// For a `store_aggregate` route, the reductions to answer with; the where clauses bind from the request as on a query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::Speechify.StoreAggregateMetric>? Metrics { get; set; }

        /// <summary>
        /// The path a `kept` file was published under, for a `file` route on<br/>
        /// a path without a wildcard. The route answers that file's bytes<br/>
        /// under the file's own media type - the only route type that does<br/>
        /// not return JSON - so a page renders and a spreadsheet downloads.<br/>
        /// Must be a GET.<br/>
        /// A literal path, or a `{{path.x}}` template that replaces the whole<br/>
        /// value and binds one segment of the URL. A template embedded in a<br/>
        /// longer path (`a/{{path.x}}.html`) is refused - substitution here<br/>
        /// replaces the value, it does not interpolate into it. To serve many<br/>
        /// files, or a nested tree, mount a route ending in `*` and use<br/>
        /// file_root instead.<br/>
        /// Only a `kept`, workspace-wide file is reachable: working material<br/>
        /// handed to a run cannot be published by pointing a route at it, and<br/>
        /// a file uploaded for one person is never served by a route, because<br/>
        /// a route answers whoever holds the URL. A `{{user.x}}` template may<br/>
        /// shape the path on a `user_token` API, but the file it reaches is<br/>
        /// still one the workspace published. A path with nothing at it<br/>
        /// answers `404`, so an artifact can be wired before it is uploaded<br/>
        /// and replaced without touching the route.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public string? FilePath { get; set; }

        /// <summary>
        /// For a `file` route whose path ends in `*`: the published-path<br/>
        /// prefix the tree lives under (`dash` serves `dash/index.html` at<br/>
        /// `/app/index.html` on a route at `/app/*`). Empty serves every<br/>
        /// published file under the route. A rebuild that renames the tree's<br/>
        /// assets touches no route. Refused on a route without the wildcard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_root")]
        public string? FileRoot { get; set; }

        /// <summary>
        /// For a tree route: the entry document, relative to file_root, that<br/>
        /// a bare prefix answers and that an unmatched path with no file<br/>
        /// extension falls back to, so a client-routed application survives<br/>
        /// a refresh and a deep link. A missing asset with an extension stays<br/>
        /// a 404. Omit for a plain file tree.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_index")]
        public string? FileIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        public string? TriggerId { get; set; }

        /// <summary>
        /// How long a `run` route waits for the run before answering 202 (default 20; 0 answers 202 at once).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_seconds")]
        public int? WaitSeconds { get; set; }

        /// <summary>
        /// For a `tool` route: the `openapi` or `mcp` tool definition whose<br/>
        /// operation the route calls, as `POST /v1/agents/tool-definitions`<br/>
        /// returned it. It must live in the API's project (409<br/>
        /// `cross_project_reference` otherwise). The route refuses a definition<br/>
        /// of another kind, an operation whose effective class is not `read`,<br/>
        /// and a tool whose `approval` is set to anything but `auto`, since a<br/>
        /// route has nobody to approve a call: set it to null or `auto` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        public string? ToolId { get; set; }

        /// <summary>
        /// For a `tool` route: the operation to call. On an `openapi` tool it<br/>
        /// is the definition's `operations[].id` (the same value<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call` takes as<br/>
        /// `operation`); on an `mcp` tool it is the server's own tool name,<br/>
        /// as `POST /v1/agents/tool-definitions/test-mcp-connection` lists<br/>
        /// it. The route is a POST whose JSON body is the arguments, validated<br/>
        /// against the definition's argument schema for an openapi operation<br/>
        /// and against `input_schema` for an MCP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public string? Operation { get; set; }

        /// <summary>
        /// For a `tool` route: serve an operation that is not a read (refused<br/>
        /// on an operation that is one). Only on<br/>
        /// an API whose `auth_mode` is `owner`, `workspace` or `user_token`,<br/>
        /// and only for an operation whose effective `approval` is `auto`;<br/>
        /// the API cannot then be switched to `consumer_key` or `public`<br/>
        /// while the route serves writes. A write acts for the person<br/>
        /// calling, counts against `daily_write_cap`, and claims<br/>
        /// `Idempotency-Key`. On the MCP face the tool is not read-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_write")]
        public bool? AllowWrite { get; set; }

        /// <summary>
        /// For a `tool` route on an `mcp` tool: the MCP tool's input schema<br/>
        /// as the server listed it when the route was last written, pinned so<br/>
        /// the MCP face lists it and every call is checked against it without<br/>
        /// reaching the server. Set by the platform on every write that<br/>
        /// carries a resolver; a value you send is replaced. Absent on an<br/>
        /// openapi route, whose schema the definition holds. Write the route<br/>
        /// again to pick up a schema the server changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIResolver" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="documentId">
        /// A literal id, a `{{path.x}}` / `{{query.x}}` / `{{body.x}}` template bound from the request, or a `{{user.x}}` claim of the verified caller. On a `store_write` route it names the document a replace or merge lands on, and is refused on a create.
        /// </param>
        /// <param name="writeMode">
        /// For a `store_write` route: `create` mints an id and answers 201<br/>
        /// with the document; `replace` and `merge` land on `document_id`<br/>
        /// (a merge sets the fields sent and keeps the rest) and answer 200.<br/>
        /// Omitted, a route with a document_id merges and one without<br/>
        /// creates. On an API that names its caller, a replace or merge of<br/>
        /// another person's document is not found.
        /// </param>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="limit">
        /// Default page size; the consumer's `limit` query parameter overrides it.
        /// </param>
        /// <param name="groupBy">
        /// For a `store_aggregate` route, the projected field to group by.
        /// </param>
        /// <param name="metrics">
        /// For a `store_aggregate` route, the reductions to answer with; the where clauses bind from the request as on a query.
        /// </param>
        /// <param name="filePath">
        /// The path a `kept` file was published under, for a `file` route on<br/>
        /// a path without a wildcard. The route answers that file's bytes<br/>
        /// under the file's own media type - the only route type that does<br/>
        /// not return JSON - so a page renders and a spreadsheet downloads.<br/>
        /// Must be a GET.<br/>
        /// A literal path, or a `{{path.x}}` template that replaces the whole<br/>
        /// value and binds one segment of the URL. A template embedded in a<br/>
        /// longer path (`a/{{path.x}}.html`) is refused - substitution here<br/>
        /// replaces the value, it does not interpolate into it. To serve many<br/>
        /// files, or a nested tree, mount a route ending in `*` and use<br/>
        /// file_root instead.<br/>
        /// Only a `kept`, workspace-wide file is reachable: working material<br/>
        /// handed to a run cannot be published by pointing a route at it, and<br/>
        /// a file uploaded for one person is never served by a route, because<br/>
        /// a route answers whoever holds the URL. A `{{user.x}}` template may<br/>
        /// shape the path on a `user_token` API, but the file it reaches is<br/>
        /// still one the workspace published. A path with nothing at it<br/>
        /// answers `404`, so an artifact can be wired before it is uploaded<br/>
        /// and replaced without touching the route.
        /// </param>
        /// <param name="fileRoot">
        /// For a `file` route whose path ends in `*`: the published-path<br/>
        /// prefix the tree lives under (`dash` serves `dash/index.html` at<br/>
        /// `/app/index.html` on a route at `/app/*`). Empty serves every<br/>
        /// published file under the route. A rebuild that renames the tree's<br/>
        /// assets touches no route. Refused on a route without the wildcard.
        /// </param>
        /// <param name="fileIndex">
        /// For a tree route: the entry document, relative to file_root, that<br/>
        /// a bare prefix answers and that an unmatched path with no file<br/>
        /// extension falls back to, so a client-routed application survives<br/>
        /// a refresh and a deep link. A missing asset with an extension stays<br/>
        /// a 404. Omit for a plain file tree.
        /// </param>
        /// <param name="triggerId"></param>
        /// <param name="waitSeconds">
        /// How long a `run` route waits for the run before answering 202 (default 20; 0 answers 202 at once).
        /// </param>
        /// <param name="toolId">
        /// For a `tool` route: the `openapi` or `mcp` tool definition whose<br/>
        /// operation the route calls, as `POST /v1/agents/tool-definitions`<br/>
        /// returned it. It must live in the API's project (409<br/>
        /// `cross_project_reference` otherwise). The route refuses a definition<br/>
        /// of another kind, an operation whose effective class is not `read`,<br/>
        /// and a tool whose `approval` is set to anything but `auto`, since a<br/>
        /// route has nobody to approve a call: set it to null or `auto` first.
        /// </param>
        /// <param name="operation">
        /// For a `tool` route: the operation to call. On an `openapi` tool it<br/>
        /// is the definition's `operations[].id` (the same value<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call` takes as<br/>
        /// `operation`); on an `mcp` tool it is the server's own tool name,<br/>
        /// as `POST /v1/agents/tool-definitions/test-mcp-connection` lists<br/>
        /// it. The route is a POST whose JSON body is the arguments, validated<br/>
        /// against the definition's argument schema for an openapi operation<br/>
        /// and against `input_schema` for an MCP tool.
        /// </param>
        /// <param name="allowWrite">
        /// For a `tool` route: serve an operation that is not a read (refused<br/>
        /// on an operation that is one). Only on<br/>
        /// an API whose `auth_mode` is `owner`, `workspace` or `user_token`,<br/>
        /// and only for an operation whose effective `approval` is `auto`;<br/>
        /// the API cannot then be switched to `consumer_key` or `public`<br/>
        /// while the route serves writes. A write acts for the person<br/>
        /// calling, counts against `daily_write_cap`, and claims<br/>
        /// `Idempotency-Key`. On the MCP face the tool is not read-only.
        /// </param>
        /// <param name="inputSchema">
        /// For a `tool` route on an `mcp` tool: the MCP tool's input schema<br/>
        /// as the server listed it when the route was last written, pinned so<br/>
        /// the MCP face lists it and every call is checked against it without<br/>
        /// reaching the server. Set by the platform on every write that<br/>
        /// carries a resolver; a value you send is replaced. Absent on an<br/>
        /// openapi route, whose schema the definition holds. Write the route<br/>
        /// again to pick up a schema the server changed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIResolver(
            global::Speechify.HostedApiResolverType type,
            string? storeId,
            string? collection,
            string? documentId,
            global::Speechify.HostedApiResolverWriteMode? writeMode,
            global::System.Collections.Generic.IList<global::Speechify.HostedApiResolverWhereItems>? where,
            global::Speechify.HostedApiResolverOrderBy? orderBy,
            int? limit,
            string? groupBy,
            global::System.Collections.Generic.IList<global::Speechify.StoreAggregateMetric>? metrics,
            string? filePath,
            string? fileRoot,
            string? fileIndex,
            string? triggerId,
            int? waitSeconds,
            string? toolId,
            string? operation,
            bool? allowWrite,
            object? inputSchema)
        {
            this.Type = type;
            this.StoreId = storeId;
            this.Collection = collection;
            this.DocumentId = documentId;
            this.WriteMode = writeMode;
            this.Where = where;
            this.OrderBy = orderBy;
            this.Limit = limit;
            this.GroupBy = groupBy;
            this.Metrics = metrics;
            this.FilePath = filePath;
            this.FileRoot = fileRoot;
            this.FileIndex = fileIndex;
            this.TriggerId = triggerId;
            this.WaitSeconds = waitSeconds;
            this.ToolId = toolId;
            this.Operation = operation;
            this.AllowWrite = allowWrite;
            this.InputSchema = inputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIResolver" /> class.
        /// </summary>
        public HostedAPIResolver()
        {
        }

    }
}