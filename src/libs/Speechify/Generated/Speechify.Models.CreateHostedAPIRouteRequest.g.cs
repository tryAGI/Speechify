
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateHostedAPIRouteRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateHostedApiRouteRequestMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CreateHostedApiRouteRequestMethod Method { get; set; }

        /// <summary>
        /// Lowercase segments of letters, digits, `. _ -` or a `{param}`; `/openapi.json` and `/_runs` are reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
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
        /// ends in `*`, file_root and file_index for a whole published tree).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedAPIResolver Resolver { get; set; }

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
        /// Enabled when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHostedAPIRouteRequest" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="path">
        /// Lowercase segments of letters, digits, `. _ -` or a `{param}`; `/openapi.json` and `/_runs` are reserved.
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
        /// ends in `*`, file_root and file_index for a whole published tree).
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="responseSchema"></param>
        /// <param name="cacheTtlSeconds"></param>
        /// <param name="enabled">
        /// Enabled when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateHostedAPIRouteRequest(
            global::Speechify.CreateHostedApiRouteRequestMethod method,
            string path,
            global::Speechify.HostedAPIResolver resolver,
            string? name,
            string? description,
            object? responseSchema,
            int? cacheTtlSeconds,
            bool? enabled)
        {
            this.Method = method;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Name = name;
            this.Description = description;
            this.Resolver = resolver ?? throw new global::System.ArgumentNullException(nameof(resolver));
            this.ResponseSchema = responseSchema;
            this.CacheTtlSeconds = cacheTtlSeconds;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHostedAPIRouteRequest" /> class.
        /// </summary>
        public CreateHostedAPIRouteRequest()
        {
        }

    }
}