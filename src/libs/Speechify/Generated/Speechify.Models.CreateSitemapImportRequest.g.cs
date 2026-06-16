
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSitemapImportRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSitemapImportRequest" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="folderId">
        /// Folder to import the documents into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSitemapImportRequest(
            string url,
            string? folderId)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSitemapImportRequest" /> class.
        /// </summary>
        public CreateSitemapImportRequest()
        {
        }

    }
}