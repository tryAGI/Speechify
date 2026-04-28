
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsTenantsListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsTenant> Tenants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTenantsListResponse" /> class.
        /// </summary>
        /// <param name="tenants"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTenantsListResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsTenant> tenants)
        {
            this.Tenants = tenants ?? throw new global::System.ArgumentNullException(nameof(tenants));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTenantsListResponse" /> class.
        /// </summary>
        public TtsTenantsListResponse()
        {
        }
    }
}