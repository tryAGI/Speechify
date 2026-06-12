
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsDeleteMemoriesByCallerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallerIdentity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsDeleteMemoriesByCallerRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="callerIdentity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsDeleteMemoriesByCallerRequest(
            string agentId,
            string callerIdentity)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CallerIdentity = callerIdentity ?? throw new global::System.ArgumentNullException(nameof(callerIdentity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsDeleteMemoriesByCallerRequest" /> class.
        /// </summary>
        public TtsDeleteMemoriesByCallerRequest()
        {
        }

    }
}