
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Documents one reserved `system__*` variable that the platform<br/>
    /// auto-populates at session start. Customers cannot define or<br/>
    /// override these keys.
    /// </summary>
    public sealed partial class TtsSystemVariableDoc
    {
        /// <summary>
        /// The reserved variable key (always starts with `system__`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// What the variable contains and when it is populated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSystemVariableDoc" /> class.
        /// </summary>
        /// <param name="key">
        /// The reserved variable key (always starts with `system__`).
        /// </param>
        /// <param name="description">
        /// What the variable contains and when it is populated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSystemVariableDoc(
            string key,
            string description)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSystemVariableDoc" /> class.
        /// </summary>
        public TtsSystemVariableDoc()
        {
        }

    }
}