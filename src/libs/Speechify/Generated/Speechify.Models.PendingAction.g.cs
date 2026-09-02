
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A human approval a run is durably parked on (present on `AgentRun` only while `status` is `requires_action`). Rendered VERBATIM for the approver - never a summary the agent wrote - so an injected agent cannot misrepresent what it is about to do. Resolve it with `submitRun`.
    /// </summary>
    public sealed partial class PendingAction
    {
        /// <summary>
        /// Stable id of this pending action; pass as `action_key` to `submitRun`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The action's class (e.g. `send_email`, `financial`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Why this action needs human approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Human-readable rendering of the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The exact structured action awaiting approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// What approving does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve_effect")]
        public string? ApproveEffect { get; set; }

        /// <summary>
        /// What denying does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deny_effect")]
        public string? DenyEffect { get; set; }

        /// <summary>
        /// What happens if the deadline passes with no response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_effect")]
        public string? TimeoutEffect { get; set; }

        /// <summary>
        /// The decision applied automatically if nobody responds by `expires_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PendingActionDefaultDecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PendingActionDefaultDecision DefaultDecision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestedAt { get; set; }

        /// <summary>
        /// When the run auto-applies `default_decision`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingAction" /> class.
        /// </summary>
        /// <param name="key">
        /// Stable id of this pending action; pass as `action_key` to `submitRun`.
        /// </param>
        /// <param name="type">
        /// The action's class (e.g. `send_email`, `financial`).
        /// </param>
        /// <param name="reason">
        /// Why this action needs human approval.
        /// </param>
        /// <param name="defaultDecision">
        /// The decision applied automatically if nobody responds by `expires_at`.
        /// </param>
        /// <param name="requestedAt"></param>
        /// <param name="expiresAt">
        /// When the run auto-applies `default_decision`.
        /// </param>
        /// <param name="summary">
        /// Human-readable rendering of the action.
        /// </param>
        /// <param name="payload">
        /// The exact structured action awaiting approval.
        /// </param>
        /// <param name="approveEffect">
        /// What approving does.
        /// </param>
        /// <param name="denyEffect">
        /// What denying does.
        /// </param>
        /// <param name="timeoutEffect">
        /// What happens if the deadline passes with no response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingAction(
            string key,
            string type,
            string reason,
            global::Speechify.PendingActionDefaultDecision defaultDecision,
            global::System.DateTime requestedAt,
            global::System.DateTime expiresAt,
            string? summary,
            object? payload,
            string? approveEffect,
            string? denyEffect,
            string? timeoutEffect)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Summary = summary;
            this.Payload = payload;
            this.ApproveEffect = approveEffect;
            this.DenyEffect = denyEffect;
            this.TimeoutEffect = timeoutEffect;
            this.DefaultDecision = defaultDecision;
            this.RequestedAt = requestedAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingAction" /> class.
        /// </summary>
        public PendingAction()
        {
        }

    }
}