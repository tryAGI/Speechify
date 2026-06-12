
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListFlowTemplatesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsFlowTemplate> Templates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListFlowTemplatesResponse" /> class.
        /// </summary>
        /// <param name="templates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListFlowTemplatesResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsFlowTemplate> templates)
        {
            this.Templates = templates ?? throw new global::System.ArgumentNullException(nameof(templates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListFlowTemplatesResponse" /> class.
        /// </summary>
        public TtsListFlowTemplatesResponse()
        {
        }

    }
}