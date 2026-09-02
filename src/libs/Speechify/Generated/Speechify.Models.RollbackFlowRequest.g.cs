
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RollbackFlowRequest
    {
        /// <summary>
        /// The flow version to roll back to (prefixed external id, `fver_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// On a workspace with the behavioral-eval publish gate enabled, a<br/>
        /// non-empty justification re-activates a version past a failing<br/>
        /// behavioral suite. The suite still runs and its verdict is recorded<br/>
        /// with this reason - an override bypasses blocking, not measurement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_override_reason")]
        public string? GateOverrideReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackFlowRequest" /> class.
        /// </summary>
        /// <param name="versionId">
        /// The flow version to roll back to (prefixed external id, `fver_...`).
        /// </param>
        /// <param name="gateOverrideReason">
        /// On a workspace with the behavioral-eval publish gate enabled, a<br/>
        /// non-empty justification re-activates a version past a failing<br/>
        /// behavioral suite. The suite still runs and its verdict is recorded<br/>
        /// with this reason - an override bypasses blocking, not measurement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RollbackFlowRequest(
            string versionId,
            string? gateOverrideReason)
        {
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.GateOverrideReason = gateOverrideReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackFlowRequest" /> class.
        /// </summary>
        public RollbackFlowRequest()
        {
        }

    }
}