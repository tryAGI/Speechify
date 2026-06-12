
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListIVRMenusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("menus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsIVRMenuListEntry> Menus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListIVRMenusResponse" /> class.
        /// </summary>
        /// <param name="menus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListIVRMenusResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsIVRMenuListEntry> menus)
        {
            this.Menus = menus ?? throw new global::System.ArgumentNullException(nameof(menus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListIVRMenusResponse" /> class.
        /// </summary>
        public TtsListIVRMenusResponse()
        {
        }

    }
}