
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What answers a route. `type` selects the fields that apply:<br/>
    /// `store_query` (store_id, collection, where, order_by, limit),<br/>
    /// `store_document` (store_id, collection, document_id),<br/>
    /// `run_latest` (trigger_id of a schedule trigger),<br/>
    /// `run` (trigger_id of a webhook trigger, wait_seconds).
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
        /// A literal id or a `{{path.x}}` / `{{query.x}}` template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

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
        /// A literal id or a `{{path.x}}` / `{{query.x}}` template.
        /// </param>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="limit">
        /// Default page size; the consumer's `limit` query parameter overrides it.
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
            global::System.Collections.Generic.IList<global::Speechify.HostedApiResolverWhereItems>? where,
            global::Speechify.HostedApiResolverOrderBy? orderBy,
            int? limit,
            string? triggerId,
            int? waitSeconds)
        {
            this.Type = type;
            this.StoreId = storeId;
            this.Collection = collection;
            this.DocumentId = documentId;
            this.Where = where;
            this.OrderBy = orderBy;
            this.Limit = limit;
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