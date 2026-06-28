
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMemoriesByCallerRequest
    {
        /// <summary>
        /// Optional. The agent is taken from the `{agent_id}` URL path,<br/>
        /// which is authoritative; if supplied here it must match the<br/>
        /// path or the request is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

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
        /// Initializes a new instance of the <see cref="DeleteMemoriesByCallerRequest" /> class.
        /// </summary>
        /// <param name="callerIdentity"></param>
        /// <param name="agentId">
        /// Optional. The agent is taken from the `{agent_id}` URL path,<br/>
        /// which is authoritative; if supplied here it must match the<br/>
        /// path or the request is rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteMemoriesByCallerRequest(
            string callerIdentity,
            string? agentId)
        {
            this.AgentId = agentId;
            this.CallerIdentity = callerIdentity ?? throw new global::System.ArgumentNullException(nameof(callerIdentity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemoriesByCallerRequest" /> class.
        /// </summary>
        public DeleteMemoriesByCallerRequest()
        {
        }

    }
}