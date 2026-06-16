
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One customer-scope variable definition on an agent. Referenced in<br/>
    /// prompts, first messages, and webhook tool configs via `{{key}}` or<br/>
    /// `{{key|json}}`. Missing variables render as empty string at dispatch<br/>
    /// time - a typo never breaks a session.
    /// </summary>
    public sealed partial class DynamicVariable
    {
        /// <summary>
        /// Variable name. Must match `[a-zA-Z0-9_]+`. The `system__` prefix<br/>
        /// is reserved for platform-populated variables and will be rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Declared type of a customer-scope variable. Enforced at save time<br/>
        /// and again at session-start when an override value is supplied.<br/>
        /// - `string`  - plain text value; interpolated verbatim with `{{name}}`<br/>
        /// - `number`  - numeric value; rendered as its decimal representation<br/>
        /// - `boolean` - `true` or `false`<br/>
        /// - `json`    - any valid JSON value; use `{{name|json}}` to inject<br/>
        ///               safely inside JSON tool bodies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.DynamicVariableTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.DynamicVariableType Type { get; set; }

        /// <summary>
        /// Optional default value used when no per-session override is<br/>
        /// supplied. Must conform to the declared `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public object? Default { get; set; }

        /// <summary>
        /// Human-readable note shown in the console variable editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariable" /> class.
        /// </summary>
        /// <param name="key">
        /// Variable name. Must match `[a-zA-Z0-9_]+`. The `system__` prefix<br/>
        /// is reserved for platform-populated variables and will be rejected.
        /// </param>
        /// <param name="type">
        /// Declared type of a customer-scope variable. Enforced at save time<br/>
        /// and again at session-start when an override value is supplied.<br/>
        /// - `string`  - plain text value; interpolated verbatim with `{{name}}`<br/>
        /// - `number`  - numeric value; rendered as its decimal representation<br/>
        /// - `boolean` - `true` or `false`<br/>
        /// - `json`    - any valid JSON value; use `{{name|json}}` to inject<br/>
        ///               safely inside JSON tool bodies
        /// </param>
        /// <param name="default">
        /// Optional default value used when no per-session override is<br/>
        /// supplied. Must conform to the declared `type`.
        /// </param>
        /// <param name="description">
        /// Human-readable note shown in the console variable editor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicVariable(
            string key,
            global::Speechify.DynamicVariableType type,
            object? @default,
            string? description)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.Default = @default;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariable" /> class.
        /// </summary>
        public DynamicVariable()
        {
        }

    }
}