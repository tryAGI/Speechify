
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Acknowledgement of an inbound webhook fire.
    /// </summary>
    public sealed partial class AgentTriggerFireResponse
    {
        /// <summary>
        /// The started durable run, present when dispatch succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// The fire's dispatch status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentTriggerFireResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentTriggerFireResponseStatus Status { get; set; }

        /// <summary>
        /// True when a duplicate delivery replayed the original fire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replayed")]
        public bool? Replayed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTriggerFireResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The fire's dispatch status.
        /// </param>
        /// <param name="runId">
        /// The started durable run, present when dispatch succeeded.
        /// </param>
        /// <param name="replayed">
        /// True when a duplicate delivery replayed the original fire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTriggerFireResponse(
            global::Speechify.AgentTriggerFireResponseStatus status,
            string? runId,
            bool? replayed)
        {
            this.RunId = runId;
            this.Status = status;
            this.Replayed = replayed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTriggerFireResponse" /> class.
        /// </summary>
        public AgentTriggerFireResponse()
        {
        }

    }
}