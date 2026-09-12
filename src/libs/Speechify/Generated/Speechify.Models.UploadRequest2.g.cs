
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadRequest2
    {
        /// <summary>
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The person this file is for, in your own vocabulary - the same value<br/>
        /// a run, a conversation and a widget session take. Only a run acting<br/>
        /// for that person can read it. Omit for a workspace-wide file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity")]
        public string? UserIdentity { get; set; }

        /// <summary>
        /// How long to keep it. `ephemeral` (the default) is working material<br/>
        /// for a run and is deleted after 14 days. `kept` survives until you<br/>
        /// delete it - use it for anything an agent produced that you intend to<br/>
        /// keep or serve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.V1FilesPostRequestBodyContentMultipartFormDataSchemaKindJsonConverter))]
        public global::Speechify.V1FilesPostRequestBodyContentMultipartFormDataSchemaKind? Kind { get; set; }

        /// <summary>
        /// Publish the file under this name so a hosted-API route can serve it,<br/>
        /// for example `index.html` or `reports/q3.html`. Unique among the<br/>
        /// workspace's live files, and only valid on a `kept` file with no<br/>
        /// `user_identity` - a path on something that expires in a fortnight is<br/>
        /// a URL that breaks, and a route answers whoever holds the URL, so it<br/>
        /// has no person to scope to. A path already in use answers `409`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The project to create the file in, as a `proj_...` id; omit for the<br/>
        /// caller's default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequest2" /> class.
        /// </summary>
        /// <param name="file">
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </param>
        /// <param name="filename">
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </param>
        /// <param name="userIdentity">
        /// The person this file is for, in your own vocabulary - the same value<br/>
        /// a run, a conversation and a widget session take. Only a run acting<br/>
        /// for that person can read it. Omit for a workspace-wide file.
        /// </param>
        /// <param name="kind">
        /// How long to keep it. `ephemeral` (the default) is working material<br/>
        /// for a run and is deleted after 14 days. `kept` survives until you<br/>
        /// delete it - use it for anything an agent produced that you intend to<br/>
        /// keep or serve.
        /// </param>
        /// <param name="path">
        /// Publish the file under this name so a hosted-API route can serve it,<br/>
        /// for example `index.html` or `reports/q3.html`. Unique among the<br/>
        /// workspace's live files, and only valid on a `kept` file with no<br/>
        /// `user_identity` - a path on something that expires in a fortnight is<br/>
        /// a URL that breaks, and a route answers whoever holds the URL, so it<br/>
        /// has no person to scope to. A path already in use answers `409`.
        /// </param>
        /// <param name="projectId">
        /// The project to create the file in, as a `proj_...` id; omit for the<br/>
        /// caller's default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadRequest2(
            byte[] file,
            string filename,
            string? userIdentity,
            global::Speechify.V1FilesPostRequestBodyContentMultipartFormDataSchemaKind? kind,
            string? path,
            string? projectId)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.UserIdentity = userIdentity;
            this.Kind = kind;
            this.Path = path;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequest2" /> class.
        /// </summary>
        public UploadRequest2()
        {
        }

    }
}