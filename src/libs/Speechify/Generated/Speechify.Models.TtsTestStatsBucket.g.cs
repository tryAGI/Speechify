
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One daily point on the aggregate pass-rate chart.
    /// </summary>
    public sealed partial class TtsTestStatsBucket
    {
        /// <summary>
        /// ISO date (YYYY-MM-DD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errored { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestStatsBucket" /> class.
        /// </summary>
        /// <param name="day">
        /// ISO date (YYYY-MM-DD).
        /// </param>
        /// <param name="passed"></param>
        /// <param name="failed"></param>
        /// <param name="errored"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTestStatsBucket(
            string day,
            int passed,
            int failed,
            int errored)
        {
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.Passed = passed;
            this.Failed = failed;
            this.Errored = errored;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestStatsBucket" /> class.
        /// </summary>
        public TtsTestStatsBucket()
        {
        }

    }
}