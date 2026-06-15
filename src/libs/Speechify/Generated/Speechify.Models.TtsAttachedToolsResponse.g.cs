
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Bare list of the tools attached to an agent. Not paginated —<br/>
    /// an agent's tool attachment count is bounded by configuration,<br/>
    /// not by data scale.
    /// </summary>
    public sealed partial class TtsAttachedToolsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsTool> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAttachedToolsResponse" /> class.
        /// </summary>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAttachedToolsResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsTool> tools)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAttachedToolsResponse" /> class.
        /// </summary>
        public TtsAttachedToolsResponse()
        {
        }

    }
}