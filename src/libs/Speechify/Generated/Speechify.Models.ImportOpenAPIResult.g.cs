
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The compiled operations, or a structured failure. On success `error`<br/>
    /// is absent; on failure `operations` and `skipped` are empty, `document`<br/>
    /// is absent and `error` carries the reason.
    /// </summary>
    public sealed partial class ImportOpenAPIResult
    {
        /// <summary>
        /// What the document said about itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Speechify.ImportedOpenAPIDocument? Document { get; set; }

        /// <summary>
        /// The document's first https server, or the `base_url` the request<br/>
        /// supplied. Use it as the tool's `base_url` unless the vendor gave<br/>
        /// this workspace its own host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Every operation the compiler could represent, in document order and<br/>
        /// in the shape `OpenAPIToolConfig.operations` takes. Copy the ones<br/>
        /// the agent should call (at most 40), then add `action_class` and<br/>
        /// `response` to them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.OpenAPIOperation> Operations { get; set; }

        /// <summary>
        /// Every operation the compiler could not represent, with the reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.SkippedOpenAPIOperation> Skipped { get; set; }

        /// <summary>
        /// Why nothing compiled: a refused `spec_url`, a credential that does<br/>
        /// not resolve or cannot mint a token, a fetch that failed (with the<br/>
        /// HTTP status the document URL answered), a document too large, or a<br/>
        /// document that does not parse as OpenAPI 3.x. Absent on success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportOpenAPIResult" /> class.
        /// </summary>
        /// <param name="operations">
        /// Every operation the compiler could represent, in document order and<br/>
        /// in the shape `OpenAPIToolConfig.operations` takes. Copy the ones<br/>
        /// the agent should call (at most 40), then add `action_class` and<br/>
        /// `response` to them.
        /// </param>
        /// <param name="skipped">
        /// Every operation the compiler could not represent, with the reason.
        /// </param>
        /// <param name="document">
        /// What the document said about itself.
        /// </param>
        /// <param name="baseUrl">
        /// The document's first https server, or the `base_url` the request<br/>
        /// supplied. Use it as the tool's `base_url` unless the vendor gave<br/>
        /// this workspace its own host.
        /// </param>
        /// <param name="error">
        /// Why nothing compiled: a refused `spec_url`, a credential that does<br/>
        /// not resolve or cannot mint a token, a fetch that failed (with the<br/>
        /// HTTP status the document URL answered), a document too large, or a<br/>
        /// document that does not parse as OpenAPI 3.x. Absent on success.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportOpenAPIResult(
            global::System.Collections.Generic.IList<global::Speechify.OpenAPIOperation> operations,
            global::System.Collections.Generic.IList<global::Speechify.SkippedOpenAPIOperation> skipped,
            global::Speechify.ImportedOpenAPIDocument? document,
            string? baseUrl,
            string? error)
        {
            this.Document = document;
            this.BaseUrl = baseUrl;
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
            this.Skipped = skipped ?? throw new global::System.ArgumentNullException(nameof(skipped));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportOpenAPIResult" /> class.
        /// </summary>
        public ImportOpenAPIResult()
        {
        }

    }
}