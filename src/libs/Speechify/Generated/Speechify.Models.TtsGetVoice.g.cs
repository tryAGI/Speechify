
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsGetVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_image")]
        public string? AvatarImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsGetVoiceGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsGetVoiceGender Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsGetVoicesModel> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_audio")]
        public string? PreviewAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsGetVoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsGetVoiceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetVoice" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="gender"></param>
        /// <param name="locale"></param>
        /// <param name="id"></param>
        /// <param name="models"></param>
        /// <param name="type"></param>
        /// <param name="avatarImage"></param>
        /// <param name="previewAudio"></param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsGetVoice(
            string displayName,
            global::Speechify.TtsGetVoiceGender gender,
            string locale,
            string id,
            global::System.Collections.Generic.IList<global::Speechify.TtsGetVoicesModel> models,
            global::Speechify.TtsGetVoiceType type,
            string? avatarImage,
            string? previewAudio,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.AvatarImage = avatarImage;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Gender = gender;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.PreviewAudio = previewAudio;
            this.Tags = tags;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetVoice" /> class.
        /// </summary>
        public TtsGetVoice()
        {
        }
    }
}