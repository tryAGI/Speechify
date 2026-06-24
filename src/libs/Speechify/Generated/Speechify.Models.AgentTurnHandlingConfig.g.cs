
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Turn-handling and silence-timeout configuration.
    /// </summary>
    public sealed partial class AgentTurnHandlingConfig
    {
        /// <summary>
        /// How long the agent waits after the caller stops talking<br/>
        /// before replying. Null uses the platform default. Applies only<br/>
        /// to speech-to-text stacks that use voice-activity endpointing;<br/>
        /// stacks that use semantic turn detection ignore it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public double? ResponseDelaySeconds { get; set; }

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
        /// How long the agent waits after the caller stops talking<br/>
        /// before replying. Null uses the platform default. Applies only<br/>
        /// to speech-to-text stacks that use voice-activity endpointing;<br/>
        /// stacks that use semantic turn detection ignore it.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// How long the agent tolerates silence before ending the call,<br/>
        /// in seconds. Null uses the platform default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTurnHandlingConfig(
            double? responseDelaySeconds,
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