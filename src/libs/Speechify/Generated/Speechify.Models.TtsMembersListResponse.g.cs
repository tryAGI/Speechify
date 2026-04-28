
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsMembersListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsMember> Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsMembersListResponse" /> class.
        /// </summary>
        /// <param name="members"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsMembersListResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsMember> members)
        {
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsMembersListResponse" /> class.
        /// </summary>
        public TtsMembersListResponse()
        {
        }
    }
}