
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One uploaded file a run can be handed. The bytes live in Speechify's<br/>
    /// storage and are read either by an agent inside a run (its `read_file`<br/>
    /// tool) or over `content_path`; this object is the metadata.
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The project the file belongs to; absent for the Default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The file's media type, normalised from the upload. An agent can read<br/>
        /// `application/pdf`, `text/plain`, `text/markdown`, `text/html` and<br/>
        /// `image/*` inside a run; any other type is stored and served but<br/>
        /// reports itself unreadable to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// The person this file was uploaded for. Only a run acting for that<br/>
        /// same person can read it. Absent means workspace-wide: any run in the<br/>
        /// workspace can.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity")]
        public string? UserIdentity { get; set; }

        /// <summary>
        /// The file's lifetime, declared at upload. `ephemeral` is working<br/>
        /// material for a run and is deleted 14 days after upload; `kept`<br/>
        /// survives until you delete it and carries no `expires_at` at all.<br/>
        /// Only a `kept` file can be published at a `path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.FileKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.FileKind Kind { get; set; }

        /// <summary>
        /// The name a serving layer addresses this file by, unique among the<br/>
        /// workspace's live files. Slash-separated segments of letters, digits<br/>
        /// and `. _ ~ -`; no leading slash and no `..`. Absent on a file<br/>
        /// nothing publishes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The run whose tool call produced this file. Present only on a file<br/>
        /// Speechify captured from a tool's response, absent on a customer upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Speechify.FileSource? Source { get; set; }

        /// <summary>
        /// The API path the bytes stream from (prepend the API host).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentPath { get; set; }

        /// <summary>
        /// When an `ephemeral` file is deleted automatically, 14 days after<br/>
        /// upload; after it passes, every read answers 404 and the bytes are<br/>
        /// collected. **Absent on a `kept` file**, which does not expire -<br/>
        /// rather than a far-future date you would have to recognise as "never".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filename"></param>
        /// <param name="contentType">
        /// The file's media type, normalised from the upload. An agent can read<br/>
        /// `application/pdf`, `text/plain`, `text/markdown`, `text/html` and<br/>
        /// `image/*` inside a run; any other type is stored and served but<br/>
        /// reports itself unreadable to the agent.
        /// </param>
        /// <param name="sizeBytes"></param>
        /// <param name="kind">
        /// The file's lifetime, declared at upload. `ephemeral` is working<br/>
        /// material for a run and is deleted 14 days after upload; `kept`<br/>
        /// survives until you delete it and carries no `expires_at` at all.<br/>
        /// Only a `kept` file can be published at a `path`.
        /// </param>
        /// <param name="contentPath">
        /// The API path the bytes stream from (prepend the API host).
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="projectId">
        /// The project the file belongs to; absent for the Default project.
        /// </param>
        /// <param name="userIdentity">
        /// The person this file was uploaded for. Only a run acting for that<br/>
        /// same person can read it. Absent means workspace-wide: any run in the<br/>
        /// workspace can.
        /// </param>
        /// <param name="path">
        /// The name a serving layer addresses this file by, unique among the<br/>
        /// workspace's live files. Slash-separated segments of letters, digits<br/>
        /// and `. _ ~ -`; no leading slash and no `..`. Absent on a file<br/>
        /// nothing publishes.
        /// </param>
        /// <param name="source">
        /// The run whose tool call produced this file. Present only on a file<br/>
        /// Speechify captured from a tool's response, absent on a customer upload.
        /// </param>
        /// <param name="expiresAt">
        /// When an `ephemeral` file is deleted automatically, 14 days after<br/>
        /// upload; after it passes, every read answers 404 and the bytes are<br/>
        /// collected. **Absent on a `kept` file**, which does not expire -<br/>
        /// rather than a far-future date you would have to recognise as "never".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public File(
            string id,
            string filename,
            string contentType,
            long sizeBytes,
            global::Speechify.FileKind kind,
            string contentPath,
            global::System.DateTime createdAt,
            string? projectId,
            string? userIdentity,
            string? path,
            global::Speechify.FileSource? source,
            global::System.DateTime? expiresAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.SizeBytes = sizeBytes;
            this.UserIdentity = userIdentity;
            this.Kind = kind;
            this.Path = path;
            this.Source = source;
            this.ContentPath = contentPath ?? throw new global::System.ArgumentNullException(nameof(contentPath));
            this.ExpiresAt = expiresAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }

    }
}