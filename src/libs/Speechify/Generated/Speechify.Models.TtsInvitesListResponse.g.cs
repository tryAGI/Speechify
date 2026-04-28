
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsInvitesListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invites")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsInvite> Invites { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsInvitesListResponse" /> class.
        /// </summary>
        /// <param name="invites"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsInvitesListResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsInvite> invites)
        {
            this.Invites = invites ?? throw new global::System.ArgumentNullException(nameof(invites));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsInvitesListResponse" /> class.
        /// </summary>
        public TtsInvitesListResponse()
        {
        }
    }
}