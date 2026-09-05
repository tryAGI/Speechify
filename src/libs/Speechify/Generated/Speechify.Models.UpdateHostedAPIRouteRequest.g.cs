
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
        /// `run_latest` (trigger_id of a schedule trigger),<br/>
        /// `run` (trigger_id of a webhook trigger, wait_seconds).
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
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="resolver">
        /// What answers a route. `type` selects the fields that apply:<br/>
        /// `store_query` (store_id, collection, where, order_by, limit),<br/>
        /// `store_document` (store_id, collection, document_id),<br/>
        /// `run_latest` (trigger_id of a schedule trigger),<br/>
        /// `run` (trigger_id of a webhook trigger, wait_seconds).
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