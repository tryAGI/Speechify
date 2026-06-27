
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Single-resource envelope used by GET / PATCH /v1/agents/callers/{caller_id}.
    /// </summary>
    public sealed partial class GetCallerResponse
    {
        /// <summary>
        /// First-class Caller entity. Identified by<br/>
        /// the (tenant, agent, identity) triple. Memories and conversations<br/>
        /// FK at it via `caller_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.Caller Caller { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCallerResponse" /> class.
        /// </summary>
        /// <param name="caller">
        /// First-class Caller entity. Identified by<br/>
        /// the (tenant, agent, identity) triple. Memories and conversations<br/>
        /// FK at it via `caller_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCallerResponse(
            global::Speechify.Caller caller)
        {
            this.Caller = caller ?? throw new global::System.ArgumentNullException(nameof(caller));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCallerResponse" /> class.
        /// </summary>
        public GetCallerResponse()
        {
        }

    }
}