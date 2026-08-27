
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional overrides for LiveKit's detection thresholds and<br/>
    /// timeouts. Cross-field rule (enforced at the application<br/>
    /// validator): `timeout_seconds` must be greater than or equal<br/>
    /// to `no_speech_threshold_seconds` when both are set.
    /// </summary>
    public sealed partial class AmdConfigTuning
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_speech_threshold_seconds")]
        public double? HumanSpeechThresholdSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_speech_threshold_seconds")]
        public double? NoSpeechThresholdSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_prompt")]
        public string? ClassificationPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AmdConfigTuning" /> class.
        /// </summary>
        /// <param name="humanSpeechThresholdSeconds"></param>
        /// <param name="noSpeechThresholdSeconds"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="classificationPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AmdConfigTuning(
            double? humanSpeechThresholdSeconds,
            double? noSpeechThresholdSeconds,
            double? timeoutSeconds,
            string? classificationPrompt)
        {
            this.HumanSpeechThresholdSeconds = humanSpeechThresholdSeconds;
            this.NoSpeechThresholdSeconds = noSpeechThresholdSeconds;
            this.TimeoutSeconds = timeoutSeconds;
            this.ClassificationPrompt = classificationPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmdConfigTuning" /> class.
        /// </summary>
        public AmdConfigTuning()
        {
        }

    }
}