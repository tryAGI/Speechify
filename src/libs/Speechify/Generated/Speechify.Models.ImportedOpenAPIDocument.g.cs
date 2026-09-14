
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the document said about itself.
    /// </summary>
    public sealed partial class ImportedOpenAPIDocument
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// How many operations compiled (the length of `operations`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OperationCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportedOpenAPIDocument" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="version"></param>
        /// <param name="operationCount">
        /// How many operations compiled (the length of `operations`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportedOpenAPIDocument(
            string title,
            string version,
            int operationCount)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.OperationCount = operationCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportedOpenAPIDocument" /> class.
        /// </summary>
        public ImportedOpenAPIDocument()
        {
        }

    }
}