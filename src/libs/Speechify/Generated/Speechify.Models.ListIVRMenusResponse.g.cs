
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListIVRMenusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("menus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.IVRMenuListEntry> Menus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListIVRMenusResponse" /> class.
        /// </summary>
        /// <param name="menus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListIVRMenusResponse(
            global::System.Collections.Generic.IList<global::Speechify.IVRMenuListEntry> menus)
        {
            this.Menus = menus ?? throw new global::System.ArgumentNullException(nameof(menus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListIVRMenusResponse" /> class.
        /// </summary>
        public ListIVRMenusResponse()
        {
        }

    }
}