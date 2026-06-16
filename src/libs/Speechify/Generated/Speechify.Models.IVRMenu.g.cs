
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One memorized IVR menu level. Identified by the<br/>
    /// SHA-256 fingerprint of the normalized greeting transcript;<br/>
    /// scoped to the caller's workspace (foreign-tenant menus are<br/>
    /// never returned).<br/>
    /// `menu_tree` is the validated JSONB blob the worker consumes:<br/>
    /// prompt text plus the options offered (label + DTMF). Sub-menus<br/>
    /// reached by pressing an option are their own rows, looked up at<br/>
    /// descent time by a fresh fingerprint - the tree structure is the<br/>
    /// implicit graph of fingerprint -&gt; fingerprint transitions.<br/>
    /// `confidence_score` is `succeeded_traversals / total_traversals`.<br/>
    /// The worker's plan-then-execute fast path only activates at or<br/>
    /// above 0.5.<br/>
    /// `invalidated_at` is non-null on a soft-deleted row; the API<br/>
    /// filters these out of list / lookup / get responses so this field<br/>
    /// is informational only.
    /// </summary>
    public sealed partial class IVRMenu
    {
        /// <summary>
        /// Prefixed wire identifier (`menu_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FingerprintId { get; set; }

        /// <summary>
        /// Null on the cross-tenant promoted slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SchemaVersion { get; set; }

        /// <summary>
        /// Validated menu_tree per contracts/agents/ivr_menu.schema.json. Opaque to consumers other than the worker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("menu_tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.IvrMenuMenuTree MenuTree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfidenceScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded_traversals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SucceededTraversals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_traversals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTraversals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_validated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastValidatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidated_at")]
        public global::System.DateTime? InvalidatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="IVRMenu" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`menu_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="fingerprintId"></param>
        /// <param name="schemaVersion"></param>
        /// <param name="menuTree">
        /// Validated menu_tree per contracts/agents/ivr_menu.schema.json. Opaque to consumers other than the worker.
        /// </param>
        /// <param name="confidenceScore"></param>
        /// <param name="succeededTraversals"></param>
        /// <param name="totalTraversals"></param>
        /// <param name="lastValidatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="tenantId">
        /// Null on the cross-tenant promoted slot.
        /// </param>
        /// <param name="invalidatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IVRMenu(
            string id,
            string fingerprintId,
            int schemaVersion,
            global::Speechify.IvrMenuMenuTree menuTree,
            double confidenceScore,
            int succeededTraversals,
            int totalTraversals,
            global::System.DateTime lastValidatedAt,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? tenantId,
            global::System.DateTime? invalidatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FingerprintId = fingerprintId ?? throw new global::System.ArgumentNullException(nameof(fingerprintId));
            this.TenantId = tenantId;
            this.SchemaVersion = schemaVersion;
            this.MenuTree = menuTree ?? throw new global::System.ArgumentNullException(nameof(menuTree));
            this.ConfidenceScore = confidenceScore;
            this.SucceededTraversals = succeededTraversals;
            this.TotalTraversals = totalTraversals;
            this.LastValidatedAt = lastValidatedAt;
            this.InvalidatedAt = invalidatedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IVRMenu" /> class.
        /// </summary>
        public IVRMenu()
        {
        }

    }
}