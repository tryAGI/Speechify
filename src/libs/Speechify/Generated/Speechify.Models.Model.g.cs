
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
        /// from `recommended`: the default accepts every voice, while the<br/>
        /// recommended model may serve a curated or English-only set.
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
        /// Whether this is a legacy model. De-emphasise it in a picker and<br/>
        /// steer new integrations to a current model. Read `retired_at` for<br/>
        /// whether it also has a withdrawal date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deprecated { get; set; }

        /// <summary>
        /// The API version at which this model stops being selectable, as<br/>
        /// `YYYY-MM-DD`. Absent when the model has no withdrawal date.<br/>
        /// It appears only while your workspace is pinned BELOW that version -<br/>
        /// at or after it the model is absent from this catalog entirely, and<br/>
        /// naming it returns 400 `model_retired`. So a present value means "you<br/>
        /// can still use this, and this is the date you lose it". Pinning your<br/>
        /// API version before this date keeps the model working, up to<br/>
        /// `sunset_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_at")]
        public global::System.DateTime? RetiredAt { get; set; }

        /// <summary>
        /// The date this model is switched off, as `YYYY-MM-DD`. Absent when no<br/>
        /// shutdown is scheduled.<br/>
        /// This is the deadline `retired_at`'s version pin runs out against:<br/>
        /// from `sunset_at` the model is unreachable on EVERY API version,<br/>
        /// including a workspace pinned below its retirement. Read the two<br/>
        /// together - a pin buys time to migrate, not a permanent exemption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sunset_at")]
        public global::System.DateTime? SunsetAt { get; set; }

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
        /// The synthesis routes this model may be passed to. Only the<br/>
        /// streaming-native models serve `/v1/audio/stream/with-timestamps`;<br/>
        /// passing a model this list omits is a 400 rather than a degraded<br/>
        /// response, so branch on it instead of discovering it at call time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Endpoints { get; set; }

        /// <summary>
        /// Whether the model's stock voices are restricted to the set curated<br/>
        /// for it. When true, pick a stock voice whose `models` array in<br/>
        /// GET /v1/voices names this model; any other stock voice is rejected.<br/>
        /// When false, every stock catalogue voice works. Cloned voices are<br/>
        /// governed separately - always read each voice's own `models` array in<br/>
        /// GET /v1/voices, which reflects what your workspace may actually<br/>
        /// synthesize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("curated_voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CuratedVoices { get; set; }

        /// <summary>
        /// Whether the model rejects a non-English voice. Independent of<br/>
        /// `languages`: a model can publish English only and still accept any<br/>
        /// voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("english_voices_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnglishVoicesOnly { get; set; }

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
        /// from `recommended`: the default accepts every voice, while the<br/>
        /// recommended model may serve a curated or English-only set.
        /// </param>
        /// <param name="recommended">
        /// Whether this is the model we recommend for new integrations.<br/>
        /// Exactly one model in the list is recommended, and it may differ<br/>
        /// from the `default`.
        /// </param>
        /// <param name="deprecated">
        /// Whether this is a legacy model. De-emphasise it in a picker and<br/>
        /// steer new integrations to a current model. Read `retired_at` for<br/>
        /// whether it also has a withdrawal date.
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
        /// <param name="endpoints">
        /// The synthesis routes this model may be passed to. Only the<br/>
        /// streaming-native models serve `/v1/audio/stream/with-timestamps`;<br/>
        /// passing a model this list omits is a 400 rather than a degraded<br/>
        /// response, so branch on it instead of discovering it at call time.
        /// </param>
        /// <param name="curatedVoices">
        /// Whether the model's stock voices are restricted to the set curated<br/>
        /// for it. When true, pick a stock voice whose `models` array in<br/>
        /// GET /v1/voices names this model; any other stock voice is rejected.<br/>
        /// When false, every stock catalogue voice works. Cloned voices are<br/>
        /// governed separately - always read each voice's own `models` array in<br/>
        /// GET /v1/voices, which reflects what your workspace may actually<br/>
        /// synthesize.
        /// </param>
        /// <param name="englishVoicesOnly">
        /// Whether the model rejects a non-English voice. Independent of<br/>
        /// `languages`: a model can publish English only and still accept any<br/>
        /// voice.
        /// </param>
        /// <param name="retiredAt">
        /// The API version at which this model stops being selectable, as<br/>
        /// `YYYY-MM-DD`. Absent when the model has no withdrawal date.<br/>
        /// It appears only while your workspace is pinned BELOW that version -<br/>
        /// at or after it the model is absent from this catalog entirely, and<br/>
        /// naming it returns 400 `model_retired`. So a present value means "you<br/>
        /// can still use this, and this is the date you lose it". Pinning your<br/>
        /// API version before this date keeps the model working, up to<br/>
        /// `sunset_at`.
        /// </param>
        /// <param name="sunsetAt">
        /// The date this model is switched off, as `YYYY-MM-DD`. Absent when no<br/>
        /// shutdown is scheduled.<br/>
        /// This is the deadline `retired_at`'s version pin runs out against:<br/>
        /// from `sunset_at` the model is unreachable on EVERY API version,<br/>
        /// including a workspace pinned below its retirement. Read the two<br/>
        /// together - a pin buys time to migrate, not a permanent exemption.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string id,
            string name,
            bool @default,
            bool recommended,
            bool deprecated,
            string description,
            global::System.Collections.Generic.IList<string> languages,
            global::System.Collections.Generic.IList<string> endpoints,
            bool curatedVoices,
            bool englishVoicesOnly,
            global::System.DateTime? retiredAt,
            global::System.DateTime? sunsetAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Default = @default;
            this.Recommended = recommended;
            this.Deprecated = deprecated;
            this.RetiredAt = retiredAt;
            this.SunsetAt = sunsetAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.CuratedVoices = curatedVoices;
            this.EnglishVoicesOnly = englishVoicesOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }

    }
}