
#nullable enable

namespace Speechify
{
    /// <summary>
    /// All fields optional (merge-patch): an omitted field is left unchanged.<br/>
    /// `type` is immutable.
    /// </summary>
    public sealed partial class UpdateAgentTriggerRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The durable run a trigger starts when it fires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        public global::Speechify.TriggerRunSpec? Run { get; set; }

        /// <summary>
        /// The cadence of a schedule trigger. Set exactly one of `cron` or<br/>
        /// `interval_seconds`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public global::Speechify.TriggerScheduleConfig? Schedule { get; set; }

        /// <summary>
        /// The inbound-fire config of a webhook trigger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::Speechify.TriggerWebhookConfig? Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentTriggerRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="run">
        /// The durable run a trigger starts when it fires.
        /// </param>
        /// <param name="schedule">
        /// The cadence of a schedule trigger. Set exactly one of `cron` or<br/>
        /// `interval_seconds`.
        /// </param>
        /// <param name="webhook">
        /// The inbound-fire config of a webhook trigger.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentTriggerRequest(
            string? name,
            bool? enabled,
            global::Speechify.TriggerRunSpec? run,
            global::Speechify.TriggerScheduleConfig? schedule,
            global::Speechify.TriggerWebhookConfig? webhook)
        {
            this.Name = name;
            this.Enabled = enabled;
            this.Run = run;
            this.Schedule = schedule;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentTriggerRequest" /> class.
        /// </summary>
        public UpdateAgentTriggerRequest()
        {
        }

    }
}