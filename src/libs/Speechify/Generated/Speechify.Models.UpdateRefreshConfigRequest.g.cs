
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body — every field optional.
    /// </summary>
    public sealed partial class UpdateRefreshConfigRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_days")]
        public int? IntervalDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_remove_enabled")]
        public bool? AutoRemoveEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRefreshConfigRequest" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="intervalDays"></param>
        /// <param name="autoRemoveEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRefreshConfigRequest(
            bool? enabled,
            int? intervalDays,
            bool? autoRemoveEnabled)
        {
            this.Enabled = enabled;
            this.IntervalDays = intervalDays;
            this.AutoRemoveEnabled = autoRemoveEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRefreshConfigRequest" /> class.
        /// </summary>
        public UpdateRefreshConfigRequest()
        {
        }

    }
}