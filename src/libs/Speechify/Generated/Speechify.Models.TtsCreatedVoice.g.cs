
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreatedVoice
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsCreatedVoiceGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsCreatedVoiceGender Gender { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Speechify.TtsCreateVoiceModel> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsCreatedVoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsCreatedVoiceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreatedVoice" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="gender"></param>
        /// <param name="locale"></param>
        /// <param name="id"></param>
        /// <param name="models"></param>
        /// <param name="type"></param>
        /// <param name="avatarImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreatedVoice(
            string displayName,
            global::Speechify.TtsCreatedVoiceGender gender,
            string locale,
            string id,
            global::System.Collections.Generic.IList<global::Speechify.TtsCreateVoiceModel> models,
            global::Speechify.TtsCreatedVoiceType type,
            string? avatarImage)
        {
            this.AvatarImage = avatarImage;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Gender = gender;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreatedVoice" /> class.
        /// </summary>
        public TtsCreatedVoice()
        {
        }
    }
}