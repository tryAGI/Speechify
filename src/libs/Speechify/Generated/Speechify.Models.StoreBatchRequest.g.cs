
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreBatchRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.StoreBatchWrite> Writes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBatchRequest" /> class.
        /// </summary>
        /// <param name="writes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreBatchRequest(
            global::System.Collections.Generic.IList<global::Speechify.StoreBatchWrite> writes)
        {
            this.Writes = writes ?? throw new global::System.ArgumentNullException(nameof(writes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBatchRequest" /> class.
        /// </summary>
        public StoreBatchRequest()
        {
        }

    }
}