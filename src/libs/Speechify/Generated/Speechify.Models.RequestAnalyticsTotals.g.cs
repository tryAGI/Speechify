
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Window-wide rollups.
    /// </summary>
    public sealed partial class RequestAnalyticsTotals
    {
        /// <summary>
        /// Total requests in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// Responses with a 4xx or 5xx status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errors { get; set; }

        /// <summary>
        /// Responses with a 5xx status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ServerErrors { get; set; }

        /// <summary>
        /// Share of non-error responses, 0..1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SuccessRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsTotals" /> class.
        /// </summary>
        /// <param name="requests">
        /// Total requests in the window.
        /// </param>
        /// <param name="errors">
        /// Responses with a 4xx or 5xx status.
        /// </param>
        /// <param name="serverErrors">
        /// Responses with a 5xx status.
        /// </param>
        /// <param name="successRate">
        /// Share of non-error responses, 0..1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsTotals(
            int requests,
            int errors,
            int serverErrors,
            double successRate)
        {
            this.Requests = requests;
            this.Errors = errors;
            this.ServerErrors = serverErrors;
            this.SuccessRate = successRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsTotals" /> class.
        /// </summary>
        public RequestAnalyticsTotals()
        {
        }

    }
}