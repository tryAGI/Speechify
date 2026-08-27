
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One argument the LLM can pass when calling the tool. Mirrors the JSON-Schema subset standard function-calling schemas support.
    /// </summary>
    public sealed partial class ToolParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Permitted JSON-Schema primitive types for tool params.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ToolParamTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ToolParamType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParam" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Permitted JSON-Schema primitive types for tool params.
        /// </param>
        /// <param name="description"></param>
        /// <param name="required"></param>
        /// <param name="enum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolParam(
            string name,
            global::Speechify.ToolParamType type,
            string description,
            bool required,
            global::System.Collections.Generic.IList<string>? @enum)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.Enum = @enum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParam" /> class.
        /// </summary>
        public ToolParam()
        {
        }

    }
}