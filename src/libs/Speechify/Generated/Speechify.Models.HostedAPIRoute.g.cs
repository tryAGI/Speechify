
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// What answers a route. `type` selects the fields that apply:<br/>
        /// `store_query` (store_id, collection, where, order_by, limit),<br/>
        /// `store_document` (store_id, collection, document_id),<br/>
        /// `run_latest` (trigger_id of a schedule trigger),<br/>
        /// `run` (trigger_id of a webhook trigger, wait_seconds).
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
        /// Cache-Control max-age on GET responses; 0 disables caching.
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
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="resolver">
        /// What answers a route. `type` selects the fields that apply:<br/>
        /// `store_query` (store_id, collection, where, order_by, limit),<br/>
        /// `store_document` (store_id, collection, document_id),<br/>
        /// `run_latest` (trigger_id of a schedule trigger),<br/>
        /// `run` (trigger_id of a webhook trigger, wait_seconds).
        /// </param>
        /// <param name="cacheTtlSeconds">
        /// Cache-Control max-age on GET responses; 0 disables caching.
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