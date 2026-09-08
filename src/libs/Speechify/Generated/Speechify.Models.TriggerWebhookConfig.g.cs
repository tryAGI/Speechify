
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The inbound-fire config of a webhook trigger.
    /// </summary>
    public sealed partial class TriggerWebhookConfig
    {
        /// <summary>
        /// The run-variable key the POST body is bound to. Defaults to `payload`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_variable")]
        public string? PayloadVariable { get; set; }

        /// <summary>
        /// Who names the person a fired run acts for. Defaults to `trigger`.<br/>
        /// `trigger` uses `run.user_identity`, so every fire on<br/>
        /// this trigger acts for the same person - or for nobody, when it is<br/>
        /// unset.<br/>
        /// `fire` takes the person from each delivery, as a<br/>
        /// `Speechify-User-Identity` header on the fire request. One trigger<br/>
        /// then serves every person your connector watches, instead of one<br/>
        /// trigger per person. `run.user_identity` must be empty when you<br/>
        /// choose it: a trigger that both pins a person and reads one per<br/>
        /// delivery would run silently as the pinned person whenever your<br/>
        /// connector forgot the header, so the combination is refused with a<br/>
        /// `400` when the trigger is saved.<br/>
        /// A fire that names a person the trigger does not accept, and a fire<br/>
        /// that names nobody on a `fire`-sourced trigger, are both refused<br/>
        /// with a `400` rather than quietly running for the wrong person.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TriggerWebhookConfigUserIdentitySourceJsonConverter))]
        public global::Speechify.TriggerWebhookConfigUserIdentitySource? UserIdentitySource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerWebhookConfig" /> class.
        /// </summary>
        /// <param name="payloadVariable">
        /// The run-variable key the POST body is bound to. Defaults to `payload`.
        /// </param>
        /// <param name="userIdentitySource">
        /// Who names the person a fired run acts for. Defaults to `trigger`.<br/>
        /// `trigger` uses `run.user_identity`, so every fire on<br/>
        /// this trigger acts for the same person - or for nobody, when it is<br/>
        /// unset.<br/>
        /// `fire` takes the person from each delivery, as a<br/>
        /// `Speechify-User-Identity` header on the fire request. One trigger<br/>
        /// then serves every person your connector watches, instead of one<br/>
        /// trigger per person. `run.user_identity` must be empty when you<br/>
        /// choose it: a trigger that both pins a person and reads one per<br/>
        /// delivery would run silently as the pinned person whenever your<br/>
        /// connector forgot the header, so the combination is refused with a<br/>
        /// `400` when the trigger is saved.<br/>
        /// A fire that names a person the trigger does not accept, and a fire<br/>
        /// that names nobody on a `fire`-sourced trigger, are both refused<br/>
        /// with a `400` rather than quietly running for the wrong person.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerWebhookConfig(
            string? payloadVariable,
            global::Speechify.TriggerWebhookConfigUserIdentitySource? userIdentitySource)
        {
            this.PayloadVariable = payloadVariable;
            this.UserIdentitySource = userIdentitySource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerWebhookConfig" /> class.
        /// </summary>
        public TriggerWebhookConfig()
        {
        }

    }
}