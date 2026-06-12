
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response for `GET /v1/agents/sip-trunks`.
    /// </summary>
    public sealed partial class TtsListSIPTrunksResponse
    {
        /// <summary>
        /// SIP trunks in the workspace (up to 20).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsSIPTrunk> Trunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListSIPTrunksResponse" /> class.
        /// </summary>
        /// <param name="trunks">
        /// SIP trunks in the workspace (up to 20).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListSIPTrunksResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsSIPTrunk> trunks)
        {
            this.Trunks = trunks ?? throw new global::System.ArgumentNullException(nameof(trunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListSIPTrunksResponse" /> class.
        /// </summary>
        public TtsListSIPTrunksResponse()
        {
        }

    }
}