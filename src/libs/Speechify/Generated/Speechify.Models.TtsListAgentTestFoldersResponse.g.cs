
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListAgentTestFoldersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestFolder> Folders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListAgentTestFoldersResponse" /> class.
        /// </summary>
        /// <param name="folders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListAgentTestFoldersResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestFolder> folders)
        {
            this.Folders = folders ?? throw new global::System.ArgumentNullException(nameof(folders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListAgentTestFoldersResponse" /> class.
        /// </summary>
        public TtsListAgentTestFoldersResponse()
        {
        }

    }
}