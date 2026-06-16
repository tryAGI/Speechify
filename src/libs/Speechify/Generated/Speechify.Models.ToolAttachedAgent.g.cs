
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Minimal agent identity returned alongside a tool so the console<br/>
    /// can render "this tool is attached to: X, Y" copy before a<br/>
    /// destructive action runs.
    /// </summary>
    public sealed partial class ToolAttachedAgent
    {
        /// <summary>
        /// Opaque agent ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable agent name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolAttachedAgent" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque agent ID.
        /// </param>
        /// <param name="name">
        /// Human-readable agent name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolAttachedAgent(
            string id,
            string name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolAttachedAgent" /> class.
        /// </summary>
        public ToolAttachedAgent()
        {
        }

    }
}