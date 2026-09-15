
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateHostedAPIRouteRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.UpdateHostedApiRouteRequestMethodJsonConverter))]
        public global::Speechify.UpdateHostedApiRouteRequestMethod? Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

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
        public string? Name { get; set; }

        /// <summary>
        /// What the route does. On an API with `mcp_enabled` it is the MCP<br/>
        /// tool description a client's model reads to choose the tool, so say<br/>
        /// what it returns and when to call it; a `tool` route with none falls<br/>
        /// back to the operation's summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("resolver")]
        public global::Speechify.HostedAPIResolver? Resolver { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_schema")]
        public object? ResponseSchema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_ttl_seconds")]
        public int? CacheTtlSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHostedAPIRouteRequest" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="path"></param>
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
        /// </param>
        /// <param name="responseSchema"></param>
        /// <param name="cacheTtlSeconds"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateHostedAPIRouteRequest(
            global::Speechify.UpdateHostedApiRouteRequestMethod? method,
            string? path,
            string? name,
            string? description,
            global::Speechify.HostedAPIResolver? resolver,
            object? responseSchema,
            int? cacheTtlSeconds,
            bool? enabled)
        {
            this.Method = method;
            this.Path = path;
            this.Name = name;
            this.Description = description;
            this.Resolver = resolver;
            this.ResponseSchema = responseSchema;
            this.CacheTtlSeconds = cacheTtlSeconds;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHostedAPIRouteRequest" /> class.
        /// </summary>
        public UpdateHostedAPIRouteRequest()
        {
        }

    }
}