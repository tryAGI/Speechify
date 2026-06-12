
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional reason captured in structured logs. The column today<br/>
    /// is the timestamp, not the cause; a future audit table may<br/>
    /// persist the reason if customer demand justifies it.
    /// </summary>
    public sealed partial class TtsInvalidateIVRMenuRequest
    {
        /// <summary>
        /// Operator-debug cause string. Bounded to 256 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsInvalidateIVRMenuRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// Operator-debug cause string. Bounded to 256 chars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsInvalidateIVRMenuRequest(
            string? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsInvalidateIVRMenuRequest" /> class.
        /// </summary>
        public TtsInvalidateIVRMenuRequest()
        {
        }

    }
}