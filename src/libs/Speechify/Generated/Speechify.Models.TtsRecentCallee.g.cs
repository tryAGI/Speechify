
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One distinct phone number this workspace has dialled, with the timestamp of the most recent outbound call to it.
    /// </summary>
    public sealed partial class TtsRecentCallee
    {
        /// <summary>
        /// E.164 phone number that was dialled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phone { get; set; }

        /// <summary>
        /// Timestamp of the most recent outbound call to this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_called_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastCalledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRecentCallee" /> class.
        /// </summary>
        /// <param name="phone">
        /// E.164 phone number that was dialled.
        /// </param>
        /// <param name="lastCalledAt">
        /// Timestamp of the most recent outbound call to this number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsRecentCallee(
            string phone,
            global::System.DateTime lastCalledAt)
        {
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
            this.LastCalledAt = lastCalledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRecentCallee" /> class.
        /// </summary>
        public TtsRecentCallee()
        {
        }

    }
}