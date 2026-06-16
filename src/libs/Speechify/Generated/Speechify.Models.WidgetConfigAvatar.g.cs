
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetConfigAvatar
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.WidgetConfigAvatarTypeJsonConverter))]
        public global::Speechify.WidgetConfigAvatarType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orb_color_1")]
        public string? OrbColor1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orb_color_2")]
        public string? OrbColor2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigAvatar" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="imageUrl"></param>
        /// <param name="orbColor1"></param>
        /// <param name="orbColor2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetConfigAvatar(
            global::Speechify.WidgetConfigAvatarType? type,
            string? imageUrl,
            string? orbColor1,
            string? orbColor2)
        {
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.OrbColor1 = orbColor1;
            this.OrbColor2 = orbColor2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigAvatar" /> class.
        /// </summary>
        public WidgetConfigAvatar()
        {
        }

    }
}