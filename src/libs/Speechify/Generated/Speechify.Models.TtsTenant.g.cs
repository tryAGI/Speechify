
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A workspace the caller belongs to.
    /// </summary>
    public sealed partial class TtsTenant
    {
        /// <summary>
        /// Opaque workspace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name set by the workspace owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Billing plan tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsTenantPlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsTenantPlan Plan { get; set; }

        /// <summary>
        /// Geographic region the workspace's data is pinned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsTenantDataRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsTenantDataRegion DataRegion { get; set; }

        /// <summary>
        /// When true, HIPAA-compliant retention and logging is enforced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaa_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HipaaMode { get; set; }

        /// <summary>
        /// When true, no transcript / audio payloads are retained server-side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zero_retention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ZeroRetention { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsTenant" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque workspace ID.
        /// </param>
        /// <param name="name">
        /// Display name set by the workspace owner.
        /// </param>
        /// <param name="plan">
        /// Billing plan tier.
        /// </param>
        /// <param name="dataRegion">
        /// Geographic region the workspace's data is pinned to.
        /// </param>
        /// <param name="hipaaMode">
        /// When true, HIPAA-compliant retention and logging is enforced.
        /// </param>
        /// <param name="zeroRetention">
        /// When true, no transcript / audio payloads are retained server-side.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTenant(
            string id,
            string name,
            global::Speechify.TtsTenantPlan plan,
            global::Speechify.TtsTenantDataRegion dataRegion,
            bool hipaaMode,
            bool zeroRetention,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Plan = plan;
            this.DataRegion = dataRegion;
            this.HipaaMode = hipaaMode;
            this.ZeroRetention = zeroRetention;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTenant" /> class.
        /// </summary>
        public TtsTenant()
        {
        }
    }
}