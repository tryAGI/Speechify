
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response for `GET /v1/agents/phone-numbers`.
    /// </summary>
    public sealed partial class TtsListPhoneNumbersResponse
    {
        /// <summary>
        /// Phone numbers in the workspace (up to 100).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsPhoneNumber> Numbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListPhoneNumbersResponse" /> class.
        /// </summary>
        /// <param name="numbers">
        /// Phone numbers in the workspace (up to 100).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListPhoneNumbersResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsPhoneNumber> numbers)
        {
            this.Numbers = numbers ?? throw new global::System.ArgumentNullException(nameof(numbers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListPhoneNumbersResponse" /> class.
        /// </summary>
        public TtsListPhoneNumbersResponse()
        {
        }

    }
}