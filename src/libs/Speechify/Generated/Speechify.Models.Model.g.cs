
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One selectable text-to-speech model.
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Model identifier. Pass this as the `model` parameter to<br/>
        /// POST /v1/audio/speech or /v1/audio/stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable model name, for a model picker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this is the model used when a synthesis request omits<br/>
        /// `model`. Exactly one model in the list is the default. Distinct<br/>
        /// from `recommended`: the default is kept stable for backwards<br/>
        /// compatibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Default { get; set; }

        /// <summary>
        /// Whether this is the model we recommend for new integrations.<br/>
        /// Exactly one model in the list is recommended, and it may differ<br/>
        /// from the `default`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommended")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Recommended { get; set; }

        /// <summary>
        /// One-line summary of the model, for a model picker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Languages the model can synthesize, as BCP-47 locale strings<br/>
        /// matching the `language` request parameter (e.g. `en`, `fr-FR`).<br/>
        /// English-only models return `["en"]`. This set reflects current<br/>
        /// capability and can grow over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="id">
        /// Model identifier. Pass this as the `model` parameter to<br/>
        /// POST /v1/audio/speech or /v1/audio/stream.
        /// </param>
        /// <param name="name">
        /// Human-readable model name, for a model picker.
        /// </param>
        /// <param name="default">
        /// Whether this is the model used when a synthesis request omits<br/>
        /// `model`. Exactly one model in the list is the default. Distinct<br/>
        /// from `recommended`: the default is kept stable for backwards<br/>
        /// compatibility.
        /// </param>
        /// <param name="recommended">
        /// Whether this is the model we recommend for new integrations.<br/>
        /// Exactly one model in the list is recommended, and it may differ<br/>
        /// from the `default`.
        /// </param>
        /// <param name="description">
        /// One-line summary of the model, for a model picker.
        /// </param>
        /// <param name="languages">
        /// Languages the model can synthesize, as BCP-47 locale strings<br/>
        /// matching the `language` request parameter (e.g. `en`, `fr-FR`).<br/>
        /// English-only models return `["en"]`. This set reflects current<br/>
        /// capability and can grow over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string id,
            string name,
            bool @default,
            bool recommended,
            string description,
            global::System.Collections.Generic.IList<string> languages)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Default = @default;
            this.Recommended = recommended;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }

    }
}