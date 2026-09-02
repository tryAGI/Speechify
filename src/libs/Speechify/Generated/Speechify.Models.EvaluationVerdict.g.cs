
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The gate-branchable result: an overall pass/fail plus a per-case<br/>
    /// breakdown. `passed` is true only when every case passed — a failed<br/>
    /// or errored case fails the verdict, so a gate fails safe when a case<br/>
    /// could not be judged.
    /// </summary>
    public sealed partial class EvaluationVerdict
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PassedCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErroredCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.EvaluationCaseVerdict> Cases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationVerdict" /> class.
        /// </summary>
        /// <param name="passed"></param>
        /// <param name="total"></param>
        /// <param name="passedCount"></param>
        /// <param name="failedCount"></param>
        /// <param name="erroredCount"></param>
        /// <param name="cases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationVerdict(
            bool passed,
            int total,
            int passedCount,
            int failedCount,
            int erroredCount,
            global::System.Collections.Generic.IList<global::Speechify.EvaluationCaseVerdict> cases)
        {
            this.Passed = passed;
            this.Total = total;
            this.PassedCount = passedCount;
            this.FailedCount = failedCount;
            this.ErroredCount = erroredCount;
            this.Cases = cases ?? throw new global::System.ArgumentNullException(nameof(cases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationVerdict" /> class.
        /// </summary>
        public EvaluationVerdict()
        {
        }

    }
}