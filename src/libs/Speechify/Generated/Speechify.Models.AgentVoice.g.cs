
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
        /// Voice provenance. Always `shared` on this endpoint — personal<br/>
        /// / cloned voices are not exposed here; they stay on<br/>
        /// `GET /v1/voices`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentVoiceTypeJsonConverter))]
        public global::Speechify.AgentVoiceType Type { get; set; }

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
        /// Speaker gender as classified by VMS. `not_specified` is used<br/>
        /// when the source dataset didn't carry the metadata; the<br/>
        /// console treats it as a neutral display label rather than a<br/>
        /// filter gap.
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
        /// <param name="displayName"></param>
        /// <param name="models"></param>
        /// <param name="gender">
        /// Speaker gender as classified by VMS. `not_specified` is used<br/>
        /// when the source dataset didn't carry the metadata; the<br/>
        /// console treats it as a neutral display label rather than a<br/>
        /// filter gap.
        /// </param>
        /// <param name="locale">
        /// Default locale for the voice (BCP-47-ish, e.g. `en-US`).
        /// </param>
        /// <param name="type">
        /// Voice provenance. Always `shared` on this endpoint — personal<br/>
        /// / cloned voices are not exposed here; they stay on<br/>
        /// `GET /v1/voices`.
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
            string displayName,
            global::System.Collections.Generic.IList<global::Speechify.AgentVoiceModel> models,
            global::Speechify.AgentVoiceGender gender,
            string locale,
            global::Speechify.AgentVoiceType type,
            string? previewAudio,
            string? avatarImage,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
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