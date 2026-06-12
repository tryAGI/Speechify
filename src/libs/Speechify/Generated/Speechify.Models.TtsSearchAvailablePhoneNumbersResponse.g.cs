
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response for `GET /v1/agents/phone-numbers/available`.
    /// </summary>
    public sealed partial class TtsSearchAvailablePhoneNumbersResponse
    {
        /// <summary>
        /// Available numbers (may be empty if no inventory matches).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsAvailablePhoneNumber> Numbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSearchAvailablePhoneNumbersResponse" /> class.
        /// </summary>
        /// <param name="numbers">
        /// Available numbers (may be empty if no inventory matches).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSearchAvailablePhoneNumbersResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsAvailablePhoneNumber> numbers)
        {
            this.Numbers = numbers ?? throw new global::System.ArgumentNullException(nameof(numbers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSearchAvailablePhoneNumbersResponse" /> class.
        /// </summary>
        public TtsSearchAvailablePhoneNumbersResponse()
        {
        }

    }
}