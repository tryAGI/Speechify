
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Create a trigger. For a `schedule` trigger set `schedule`; for a<br/>
    /// `webhook` trigger set `webhook` (optional). `enabled` defaults to true.
    /// </summary>
    public sealed partial class CreateAgentTriggerRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateAgentTriggerRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CreateAgentTriggerRequestType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The durable run a trigger starts when it fires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TriggerRunSpec Run { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateAgentTriggerRequest" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="run">
        /// The durable run a trigger starts when it fires.
        /// </param>
        /// <param name="enabled"></param>
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
        public CreateAgentTriggerRequest(
            global::Speechify.CreateAgentTriggerRequestType type,
            string name,
            global::Speechify.TriggerRunSpec run,
            bool? enabled,
            global::Speechify.TriggerScheduleConfig? schedule,
            global::Speechify.TriggerWebhookConfig? webhook)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.Run = run ?? throw new global::System.ArgumentNullException(nameof(run));
            this.Schedule = schedule;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentTriggerRequest" /> class.
        /// </summary>
        public CreateAgentTriggerRequest()
        {
        }

    }
}