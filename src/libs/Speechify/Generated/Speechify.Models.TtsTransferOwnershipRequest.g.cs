
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for POST /v1/tenants/current/transfer-owner. The target<br/>
    /// must already be a member of the current workspace — promote via<br/>
    /// invite + accept first for external users.
    /// </summary>
    public sealed partial class TtsTransferOwnershipRequest
    {
        /// <summary>
        /// Firebase UID of the member who will become the new owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTransferOwnershipRequest" /> class.
        /// </summary>
        /// <param name="userUid">
        /// Firebase UID of the member who will become the new owner.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTransferOwnershipRequest(
            string userUid)
        {
            this.UserUid = userUid ?? throw new global::System.ArgumentNullException(nameof(userUid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTransferOwnershipRequest" /> class.
        /// </summary>
        public TtsTransferOwnershipRequest()
        {
        }
    }
}