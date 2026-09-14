
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedAPIRoute
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.HostedApiRouteMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedApiRouteMethod Method { get; set; }

        /// <summary>
        /// Lowercase segments, one-segment `{params}`, and optionally a trailing `*` that serves a published tree (file routes only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The route's name, 1-128 letters, digits, spaces, `.`, `_` or `-`.<br/>
        /// On an API with `mcp_enabled` the MCP tool's name comes from it:<br/>
        /// each run of other characters (a space included) becomes `_`,<br/>
        /// leading and trailing `_` are dropped, and the result is cut to 64<br/>
        /// characters. A route with no name is listed under a name built from<br/>
        /// its method and path, and a name two routes would share takes `_2`,<br/>
        /// `_3` in route order; the face's `tools/list` is the authority. Pick<br/>
        /// a verb-first name a model can choose by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// What the route does. On an API with `mcp_enabled` it is the MCP<br/>
        /// tool description a client's model reads to choose the tool, so say<br/>
        /// what it returns and when to call it; a `tool` route with none falls<br/>
        /// back to the operation's summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

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
        /// `tool` (tool_id of an `openapi` tool definition and the `operation`<br/>
        /// on it: the POST body is the operation's arguments, held to its<br/>
        /// argument schema, and the vendor's answer after the operation's<br/>
        /// `response` mapping is the response, or `{"text": ...}` when the vendor<br/>
        /// answered text. Only an operation whose effective class is `read`, on a<br/>
        /// tool whose `approval` is null or `auto`, may be served, and never on a<br/>
        /// public API; a route write that names anything else is refused with 400<br/>
        /// `validation_failed` on `resolver.tool_id`. Because a definition can<br/>
        /// change after its route is written, every call re-checks it: an<br/>
        /// operation no longer classified `read`, or a tool whose `approval` is no<br/>
        /// longer null or `auto`, answers 403 `route_tool_not_readable`; a tool<br/>
        /// deleted, moved to another project, no longer of kind `openapi` or<br/>
        /// without the operation answers 409 `route_tool_unavailable`, which no<br/>
        /// retry clears until the route or the tool is fixed. Arguments that do<br/>
        /// not fit the schema answer 400 `validation_failed`; the definition's<br/>
        /// `max_requests_per_minute` and the vendor's own throttle both answer 429<br/>
        /// `route_upstream_rate_limited` with `Retry-After`; a vendor error<br/>
        /// answers 502 `route_upstream_error` with the vendor's status in<br/>
        /// `error.details.upstream_status`, and an unreachable vendor or a<br/>
        /// credential that no longer resolves answers 502 `route_upstream_error`<br/>
        /// without it).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedAPIResolver Resolver { get; set; }

        /// <summary>
        /// Optional JSON Schema of the response body, rendered into the OpenAPI document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_schema")]
        public object? ResponseSchema { get; set; }

        /// <summary>
        /// Cache-Control max-age on GET responses, and the shared response<br/>
        /// cache's lifetime for store and run_latest routes; 0 disables<br/>
        /// caching, except on a public API, where a GET route with 0 is served<br/>
        /// with the platform default of 60 seconds so an anonymous crawler<br/>
        /// never reads storage per request. File routes are never in the<br/>
        /// response cache; they carry the header for the edge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_ttl_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheTtlSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIRoute" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiId"></param>
        /// <param name="method"></param>
        /// <param name="path">
        /// Lowercase segments, one-segment `{params}`, and optionally a trailing `*` that serves a published tree (file routes only).
        /// </param>
        /// <param name="name">
        /// The route's name, 1-128 letters, digits, spaces, `.`, `_` or `-`.<br/>
        /// On an API with `mcp_enabled` the MCP tool's name comes from it:<br/>
        /// each run of other characters (a space included) becomes `_`,<br/>
        /// leading and trailing `_` are dropped, and the result is cut to 64<br/>
        /// characters. A route with no name is listed under a name built from<br/>
        /// its method and path, and a name two routes would share takes `_2`,<br/>
        /// `_3` in route order; the face's `tools/list` is the authority. Pick<br/>
        /// a verb-first name a model can choose by.
        /// </param>
        /// <param name="description">
        /// What the route does. On an API with `mcp_enabled` it is the MCP<br/>
        /// tool description a client's model reads to choose the tool, so say<br/>
        /// what it returns and when to call it; a `tool` route with none falls<br/>
        /// back to the operation's summary.
        /// </param>
        /// <param name="resolver">
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
        /// `tool` (tool_id of an `openapi` tool definition and the `operation`<br/>
        /// on it: the POST body is the operation's arguments, held to its<br/>
        /// argument schema, and the vendor's answer after the operation's<br/>
        /// `response` mapping is the response, or `{"text": ...}` when the vendor<br/>
        /// answered text. Only an operation whose effective class is `read`, on a<br/>
        /// tool whose `approval` is null or `auto`, may be served, and never on a<br/>
        /// public API; a route write that names anything else is refused with 400<br/>
        /// `validation_failed` on `resolver.tool_id`. Because a definition can<br/>
        /// change after its route is written, every call re-checks it: an<br/>
        /// operation no longer classified `read`, or a tool whose `approval` is no<br/>
        /// longer null or `auto`, answers 403 `route_tool_not_readable`; a tool<br/>
        /// deleted, moved to another project, no longer of kind `openapi` or<br/>
        /// without the operation answers 409 `route_tool_unavailable`, which no<br/>
        /// retry clears until the route or the tool is fixed. Arguments that do<br/>
        /// not fit the schema answer 400 `validation_failed`; the definition's<br/>
        /// `max_requests_per_minute` and the vendor's own throttle both answer 429<br/>
        /// `route_upstream_rate_limited` with `Retry-After`; a vendor error<br/>
        /// answers 502 `route_upstream_error` with the vendor's status in<br/>
        /// `error.details.upstream_status`, and an unreachable vendor or a<br/>
        /// credential that no longer resolves answers 502 `route_upstream_error`<br/>
        /// without it).
        /// </param>
        /// <param name="cacheTtlSeconds">
        /// Cache-Control max-age on GET responses, and the shared response<br/>
        /// cache's lifetime for store and run_latest routes; 0 disables<br/>
        /// caching, except on a public API, where a GET route with 0 is served<br/>
        /// with the platform default of 60 seconds so an anonymous crawler<br/>
        /// never reads storage per request. File routes are never in the<br/>
        /// response cache; they carry the header for the edge.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="responseSchema">
        /// Optional JSON Schema of the response body, rendered into the OpenAPI document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIRoute(
            string id,
            string apiId,
            global::Speechify.HostedApiRouteMethod method,
            string path,
            string name,
            string description,
            global::Speechify.HostedAPIResolver resolver,
            int cacheTtlSeconds,
            bool enabled,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? responseSchema)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiId = apiId ?? throw new global::System.ArgumentNullException(nameof(apiId));
            this.Method = method;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Resolver = resolver ?? throw new global::System.ArgumentNullException(nameof(resolver));
            this.ResponseSchema = responseSchema;
            this.CacheTtlSeconds = cacheTtlSeconds;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIRoute" /> class.
        /// </summary>
        public HostedAPIRoute()
        {
        }

    }
}