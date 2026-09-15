
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedAPIMountSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Create { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Update { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unchanged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Unchanged { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Skip { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Stale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIMountSummary" /> class.
        /// </summary>
        /// <param name="create"></param>
        /// <param name="update"></param>
        /// <param name="unchanged"></param>
        /// <param name="skip"></param>
        /// <param name="stale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIMountSummary(
            int create,
            int update,
            int unchanged,
            int skip,
            int stale)
        {
            this.Create = create;
            this.Update = update;
            this.Unchanged = unchanged;
            this.Skip = skip;
            this.Stale = stale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIMountSummary" /> class.
        /// </summary>
        public HostedAPIMountSummary()
        {
        }

    }
}