
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/{agent_id}/runs/{run_id}/submit`.
    /// </summary>
    public sealed partial class SubmitAgentRunRequest
    {
        /// <summary>
        /// The approval disposition. `approve` resumes the run to execute the pending action; `deny` resumes it down its could-not-complete path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SubmitAgentRunRequestDecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.SubmitAgentRunRequestDecision Decision { get; set; }

        /// <summary>
        /// The pending action being decided (the run's `pending_action.key`). Required, so a decision always targets the specific action the human saw: it guards against resolving a stale action - a `409 agent_run_action_stale` if it no longer matches the run's current pending action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionKey { get; set; }

        /// <summary>
        /// Optional free-text rationale recorded on the immutable approval audit entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAgentRunRequest" /> class.
        /// </summary>
        /// <param name="decision">
        /// The approval disposition. `approve` resumes the run to execute the pending action; `deny` resumes it down its could-not-complete path.
        /// </param>
        /// <param name="actionKey">
        /// The pending action being decided (the run's `pending_action.key`). Required, so a decision always targets the specific action the human saw: it guards against resolving a stale action - a `409 agent_run_action_stale` if it no longer matches the run's current pending action.
        /// </param>
        /// <param name="note">
        /// Optional free-text rationale recorded on the immutable approval audit entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitAgentRunRequest(
            global::Speechify.SubmitAgentRunRequestDecision decision,
            string actionKey,
            string? note)
        {
            this.Decision = decision;
            this.ActionKey = actionKey ?? throw new global::System.ArgumentNullException(nameof(actionKey));
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAgentRunRequest" /> class.
        /// </summary>
        public SubmitAgentRunRequest()
        {
        }

    }
}