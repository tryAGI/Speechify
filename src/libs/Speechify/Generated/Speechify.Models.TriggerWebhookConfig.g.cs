
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerWebhookConfig(
            string? payloadVariable)
        {
            this.PayloadVariable = payloadVariable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerWebhookConfig" /> class.
        /// </summary>
        public TriggerWebhookConfig()
        {
        }

    }
}