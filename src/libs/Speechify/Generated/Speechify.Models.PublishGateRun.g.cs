
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A recorded publish-gate decision, projected for display. The counts are<br/>
    /// reported per suite: the behavioral suite (the workspace's own tests) and<br/>
    /// the adversarial red-team suite are scored independently.
    /// </summary>
    public sealed partial class PublishGateRun
    {
        /// <summary>
        /// What the gate decided. `overridden` means the checks did NOT pass and a<br/>
        /// human published anyway with a recorded justification - it is not a pass.<br/>
        /// `skipped_no_suite` means nothing was checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PublishGateRunDecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PublishGateRunDecision Decision { get; set; }

        /// <summary>
        /// Behavioral cases that passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PassedCount { get; set; }

        /// <summary>
        /// Behavioral cases scored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Red-team probes that passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redteam_passed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RedteamPassedCount { get; set; }

        /// <summary>
        /// Red-team probes scored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redteam_total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RedteamTotal { get; set; }

        /// <summary>
        /// When the decision was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishGateRun" /> class.
        /// </summary>
        /// <param name="decision">
        /// What the gate decided. `overridden` means the checks did NOT pass and a<br/>
        /// human published anyway with a recorded justification - it is not a pass.<br/>
        /// `skipped_no_suite` means nothing was checked.
        /// </param>
        /// <param name="passedCount">
        /// Behavioral cases that passed.
        /// </param>
        /// <param name="total">
        /// Behavioral cases scored.
        /// </param>
        /// <param name="redteamPassedCount">
        /// Red-team probes that passed.
        /// </param>
        /// <param name="redteamTotal">
        /// Red-team probes scored.
        /// </param>
        /// <param name="createdAt">
        /// When the decision was recorded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishGateRun(
            global::Speechify.PublishGateRunDecision decision,
            int passedCount,
            int total,
            int redteamPassedCount,
            int redteamTotal,
            global::System.DateTime createdAt)
        {
            this.Decision = decision;
            this.PassedCount = passedCount;
            this.Total = total;
            this.RedteamPassedCount = redteamPassedCount;
            this.RedteamTotal = redteamTotal;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishGateRun" /> class.
        /// </summary>
        public PublishGateRun()
        {
        }

    }
}