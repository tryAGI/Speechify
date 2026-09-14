
#nullable enable

namespace Speechify
{
    /// <summary>
    /// An operation the compiler could not represent, and why.
    /// </summary>
    public sealed partial class SkippedOpenAPIOperation
    {
        /// <summary>
        /// The operationId exactly as the document wrote it, absent when it<br/>
        /// has none. It is not an `OpenAPIOperation.id`: a skipped operation<br/>
        /// is never given one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        public string? OperationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Why it was skipped, for example a request body that is not JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkippedOpenAPIOperation" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="path"></param>
        /// <param name="reason">
        /// Why it was skipped, for example a request body that is not JSON.
        /// </param>
        /// <param name="operationId">
        /// The operationId exactly as the document wrote it, absent when it<br/>
        /// has none. It is not an `OpenAPIOperation.id`: a skipped operation<br/>
        /// is never given one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkippedOpenAPIOperation(
            string method,
            string path,
            string reason,
            string? operationId)
        {
            this.OperationId = operationId;
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkippedOpenAPIOperation" /> class.
        /// </summary>
        public SkippedOpenAPIOperation()
        {
        }

    }
}