
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
    /// ends in `*`, file_root and file_index for a whole published tree).
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
            int? waitSeconds)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIResolver" /> class.
        /// </summary>
        public HostedAPIResolver()
        {
        }

    }
}