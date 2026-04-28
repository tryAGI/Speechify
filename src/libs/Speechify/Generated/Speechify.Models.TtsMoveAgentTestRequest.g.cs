
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/tests/{id}/move`. `folder_id: null` moves the test to root.
    /// </summary>
    public sealed partial class TtsMoveAgentTestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsMoveAgentTestRequest" /> class.
        /// </summary>
        /// <param name="folderId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsMoveAgentTestRequest(
            string? folderId)
        {
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsMoveAgentTestRequest" /> class.
        /// </summary>
        public TtsMoveAgentTestRequest()
        {
        }
    }
}