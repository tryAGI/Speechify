
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreCollection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCollection" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="documentCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreCollection(
            string name,
            int documentCount)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DocumentCount = documentCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCollection" /> class.
        /// </summary>
        public StoreCollection()
        {
        }

    }
}