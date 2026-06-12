
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for POST /v1/knowledge-bases/{id}/documents/urls. Submit<br/>
    /// 1..N URLs in a single async import. The server dedupes and<br/>
    /// validates each entry before queueing. The per-import cap is<br/>
    /// operator-tunable (default 250) via kbUrlBatchMaxUrls; the<br/>
    /// server returns 400 when the resolved list exceeds the cap, so<br/>
    /// no maxItems is encoded in the schema to avoid SDK-side false<br/>
    /// rejections when an operator raises the limit.
    /// </summary>
    public sealed partial class TtsCreateURLBatchImportRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// Folder to import the documents into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateURLBatchImportRequest" /> class.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="folderId">
        /// Folder to import the documents into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateURLBatchImportRequest(
            global::System.Collections.Generic.IList<string> urls,
            string? folderId)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateURLBatchImportRequest" /> class.
        /// </summary>
        public TtsCreateURLBatchImportRequest()
        {
        }

    }
}