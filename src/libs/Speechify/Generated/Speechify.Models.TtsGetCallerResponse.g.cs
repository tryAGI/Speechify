
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Single-resource envelope used by GET / PATCH /v1/agents/callers/{id}.
    /// </summary>
    public sealed partial class TtsGetCallerResponse
    {
        /// <summary>
        /// First-class Caller entity (Phase 2 of ADR 0011). Identified by<br/>
        /// the (tenant, agent, identity) triple. Memories and conversations<br/>
        /// FK at it via `caller_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsCaller Caller { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetCallerResponse" /> class.
        /// </summary>
        /// <param name="caller">
        /// First-class Caller entity (Phase 2 of ADR 0011). Identified by<br/>
        /// the (tenant, agent, identity) triple. Memories and conversations<br/>
        /// FK at it via `caller_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsGetCallerResponse(
            global::Speechify.TtsCaller caller)
        {
            this.Caller = caller ?? throw new global::System.ArgumentNullException(nameof(caller));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetCallerResponse" /> class.
        /// </summary>
        public TtsGetCallerResponse()
        {
        }

    }
}