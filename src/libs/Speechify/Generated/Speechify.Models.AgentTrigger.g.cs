
#nullable enable

namespace Speechify
{
    /// <summary>
    /// An automated start condition bound to a task agent - a `schedule`<br/>
    /// (cron/interval) or a `webhook` (an inbound fire URL) that starts a<br/>
    /// durable run.
    /// </summary>
    public sealed partial class AgentTrigger
    {
        /// <summary>
        /// Prefixed wire identifier (`trigger_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentTriggerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentTriggerType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

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
        /// When a schedule trigger next fires, as an absolute UTC instant<br/>
        /// computed in the schedule's `timezone`. Absent for a webhook or a<br/>
        /// disabled schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_fire_at")]
        public global::System.DateTime? NextFireAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_fired_at")]
        public global::System.DateTime? LastFiredAt { get; set; }

        /// <summary>
        /// The outcome of the most recent fire: `dispatched` with a run,<br/>
        /// `failed` with the reason in `last_fire_error`, or `pending` while a<br/>
        /// transient failure waits for its retry. Absent until the trigger has<br/>
        /// fired once. A `failed` trigger stays `failed` until a later fire<br/>
        /// succeeds; `trigger.fire_failed` is delivered each time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_fire_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentTriggerLastFireStatusJsonConverter))]
        public global::Speechify.AgentTriggerLastFireStatus? LastFireStatus { get; set; }

        /// <summary>
        /// Why the most recent fire did not start a run: the error code a request<br/>
        /// would have been answered with and what to do about it, for example<br/>
        /// `agent_publish_gate_required: the agent's current configuration has not<br/>
        /// passed the publish gate; publish it and the next fire runs`. Empty when<br/>
        /// the last fire dispatched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_fire_error")]
        public string? LastFireError { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The inbound fire URL path for a webhook trigger; prepend the API<br/>
        /// host. Absent for a schedule trigger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fire_path")]
        public string? FirePath { get; set; }

        /// <summary>
        /// The plaintext fire token for a webhook trigger. Present in the<br/>
        /// create response ONLY and never again - store it securely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// A masked fragment of the webhook fire token, for display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_hint")]
        public string? SecretHint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTrigger" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`trigger_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="run">
        /// The durable run a trigger starts when it fires.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="schedule">
        /// The cadence of a schedule trigger. Set exactly one of `cron` or<br/>
        /// `interval_seconds`.
        /// </param>
        /// <param name="webhook">
        /// The inbound-fire config of a webhook trigger.
        /// </param>
        /// <param name="nextFireAt">
        /// When a schedule trigger next fires, as an absolute UTC instant<br/>
        /// computed in the schedule's `timezone`. Absent for a webhook or a<br/>
        /// disabled schedule.
        /// </param>
        /// <param name="lastFiredAt"></param>
        /// <param name="lastFireStatus">
        /// The outcome of the most recent fire: `dispatched` with a run,<br/>
        /// `failed` with the reason in `last_fire_error`, or `pending` while a<br/>
        /// transient failure waits for its retry. Absent until the trigger has<br/>
        /// fired once. A `failed` trigger stays `failed` until a later fire<br/>
        /// succeeds; `trigger.fire_failed` is delivered each time.
        /// </param>
        /// <param name="lastFireError">
        /// Why the most recent fire did not start a run: the error code a request<br/>
        /// would have been answered with and what to do about it, for example<br/>
        /// `agent_publish_gate_required: the agent's current configuration has not<br/>
        /// passed the publish gate; publish it and the next fire runs`. Empty when<br/>
        /// the last fire dispatched.
        /// </param>
        /// <param name="firePath">
        /// The inbound fire URL path for a webhook trigger; prepend the API<br/>
        /// host. Absent for a schedule trigger.
        /// </param>
        /// <param name="secret">
        /// The plaintext fire token for a webhook trigger. Present in the<br/>
        /// create response ONLY and never again - store it securely.
        /// </param>
        /// <param name="secretHint">
        /// A masked fragment of the webhook fire token, for display.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTrigger(
            string id,
            string agentId,
            global::Speechify.AgentTriggerType type,
            string name,
            bool enabled,
            global::Speechify.TriggerRunSpec run,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Speechify.TriggerScheduleConfig? schedule,
            global::Speechify.TriggerWebhookConfig? webhook,
            global::System.DateTime? nextFireAt,
            global::System.DateTime? lastFiredAt,
            global::Speechify.AgentTriggerLastFireStatus? lastFireStatus,
            string? lastFireError,
            string? firePath,
            string? secret,
            string? secretHint)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.Run = run ?? throw new global::System.ArgumentNullException(nameof(run));
            this.Schedule = schedule;
            this.Webhook = webhook;
            this.NextFireAt = nextFireAt;
            this.LastFiredAt = lastFiredAt;
            this.LastFireStatus = lastFireStatus;
            this.LastFireError = lastFireError;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FirePath = firePath;
            this.Secret = secret;
            this.SecretHint = secretHint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTrigger" /> class.
        /// </summary>
        public AgentTrigger()
        {
        }

    }
}