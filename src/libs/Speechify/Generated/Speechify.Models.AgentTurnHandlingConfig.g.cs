
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Turn-handling and silence-timeout configuration.
    /// </summary>
    public sealed partial class AgentTurnHandlingConfig
    {
        /// <summary>
        /// Minimum silence, in seconds, the agent waits for after the<br/>
        /// caller stops talking before it starts replying. Applies to<br/>
        /// every turn on the call. Raise it when the agent talks over a<br/>
        /// caller who pauses mid-sentence, or over an IVR menu that<br/>
        /// breaks between options. It is a floor on listening rather<br/>
        /// than a pause before speaking, so it adds to the time every<br/>
        /// reply takes to arrive. Null lets turn detection decide, which<br/>
        /// waits 0.3s when it is confident the caller finished and up to<br/>
        /// 1.2s when it is not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public string? ResponseDelaySeconds { get; set; }

        /// <summary>
        /// How long the agent tolerates silence before ending the call,<br/>
        /// in seconds. Null uses the platform default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_timeout_seconds")]
        public int? InactivityTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnHandlingConfig" /> class.
        /// </summary>
        /// <param name="responseDelaySeconds">
        /// Minimum silence, in seconds, the agent waits for after the<br/>
        /// caller stops talking before it starts replying. Applies to<br/>
        /// every turn on the call. Raise it when the agent talks over a<br/>
        /// caller who pauses mid-sentence, or over an IVR menu that<br/>
        /// breaks between options. It is a floor on listening rather<br/>
        /// than a pause before speaking, so it adds to the time every<br/>
        /// reply takes to arrive. Null lets turn detection decide, which<br/>
        /// waits 0.3s when it is confident the caller finished and up to<br/>
        /// 1.2s when it is not.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// How long the agent tolerates silence before ending the call,<br/>
        /// in seconds. Null uses the platform default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTurnHandlingConfig(
            string? responseDelaySeconds,
            int? inactivityTimeoutSeconds)
        {
            this.ResponseDelaySeconds = responseDelaySeconds;
            this.InactivityTimeoutSeconds = inactivityTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnHandlingConfig" /> class.
        /// </summary>
        public AgentTurnHandlingConfig()
        {
        }

    }
}