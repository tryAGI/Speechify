
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One row in the curated voice catalogue returned by<br/>
    /// `GET /v1/agents/voices`. Matches the slug set accepted by<br/>
    /// agent create/update.
    /// </summary>
    public sealed partial class AgentVoice
    {
        /// <summary>
        /// Voice slug. Passed verbatim as `voice_id` on agent writes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Voice provenance. `shared` is the curated catalogue every workspace<br/>
        /// sees; `personal` is a voice this workspace cloned itself (workspace-<br/>
        /// owned clones only). Both can be assigned to an agent. Treat this as an<br/>
        /// open set - new values may be added, so branch on the ones you know and<br/>
        /// fall through for the rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentVoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentVoiceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AgentVoiceModel> Models { get; set; }

        /// <summary>
        /// The model an agent on this voice synthesizes on when<br/>
        /// `tts.model` is null - what "automatic" resolves to here, stated<br/>
        /// outright rather than inferred from the order of `models`.<br/>
        /// This is the English answer. An agent that resolves through the<br/>
        /// multilingual serving (it declares `additional_languages`, or<br/>
        /// its own `language` is not English) always runs on `simba-3.0`,<br/>
        /// because no other model has a multilingual deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultModel { get; set; }

        /// <summary>
        /// Speaker gender classification for the voice. `not_specified` is<br/>
        /// used when the source dataset didn't carry the metadata; treat it<br/>
        /// as a neutral display label rather than a filter gap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentVoiceGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentVoiceGender Gender { get; set; }

        /// <summary>
        /// Default locale for the voice (BCP-47-ish, e.g. `en-US`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Preferred preview clip URL, locale-matched when possible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_audio")]
        public string? PreviewAudio { get; set; }

        /// <summary>
        /// Avatar URL for the picker UI. Null when no avatar is<br/>
        /// configured; the wire is intentionally `null` rather than<br/>
        /// `""` so the picker doesn't render a broken `&lt;img src=""&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_image")]
        public string? AvatarImage { get; set; }

        /// <summary>
        /// VMS-defined tags (e.g. `narrator`, `young`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoice" /> class.
        /// </summary>
        /// <param name="id">
        /// Voice slug. Passed verbatim as `voice_id` on agent writes.
        /// </param>
        /// <param name="type">
        /// Voice provenance. `shared` is the curated catalogue every workspace<br/>
        /// sees; `personal` is a voice this workspace cloned itself (workspace-<br/>
        /// owned clones only). Both can be assigned to an agent. Treat this as an<br/>
        /// open set - new values may be added, so branch on the ones you know and<br/>
        /// fall through for the rest.
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="models"></param>
        /// <param name="defaultModel">
        /// The model an agent on this voice synthesizes on when<br/>
        /// `tts.model` is null - what "automatic" resolves to here, stated<br/>
        /// outright rather than inferred from the order of `models`.<br/>
        /// This is the English answer. An agent that resolves through the<br/>
        /// multilingual serving (it declares `additional_languages`, or<br/>
        /// its own `language` is not English) always runs on `simba-3.0`,<br/>
        /// because no other model has a multilingual deployment.
        /// </param>
        /// <param name="gender">
        /// Speaker gender classification for the voice. `not_specified` is<br/>
        /// used when the source dataset didn't carry the metadata; treat it<br/>
        /// as a neutral display label rather than a filter gap.
        /// </param>
        /// <param name="locale">
        /// Default locale for the voice (BCP-47-ish, e.g. `en-US`).
        /// </param>
        /// <param name="previewAudio">
        /// Preferred preview clip URL, locale-matched when possible.
        /// </param>
        /// <param name="avatarImage">
        /// Avatar URL for the picker UI. Null when no avatar is<br/>
        /// configured; the wire is intentionally `null` rather than<br/>
        /// `""` so the picker doesn't render a broken `&lt;img src=""&gt;`.
        /// </param>
        /// <param name="tags">
        /// VMS-defined tags (e.g. `narrator`, `young`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVoice(
            string id,
            global::Speechify.AgentVoiceType type,
            string displayName,
            global::System.Collections.Generic.IList<global::Speechify.AgentVoiceModel> models,
            string defaultModel,
            global::Speechify.AgentVoiceGender gender,
            string locale,
            string? previewAudio,
            string? avatarImage,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.DefaultModel = defaultModel ?? throw new global::System.ArgumentNullException(nameof(defaultModel));
            this.Gender = gender;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.PreviewAudio = previewAudio;
            this.AvatarImage = avatarImage;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoice" /> class.
        /// </summary>
        public AgentVoice()
        {
        }

    }
}