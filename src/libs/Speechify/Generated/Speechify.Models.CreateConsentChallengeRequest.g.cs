
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConsentChallengeRequest
    {
        /// <summary>
        /// Full name of the person consenting to have their voice cloned.<br/>
        /// Speechify binds it to the challenge and stores it with the consent<br/>
        /// record, so the create that consumes the challenge does not carry it<br/>
        /// and cannot change it.<br/>
        /// At most 120 bytes once UTF-8 encoded, which is 120 characters of<br/>
        /// Latin script but around 40 of Chinese, Japanese or Korean. Stated in<br/>
        /// bytes rather than as a `maxLength` because the two only agree on<br/>
        /// single-byte scripts, and a character count that never over-accepts<br/>
        /// would have to refuse Latin names at 30. A name over the limit comes<br/>
        /// back as `validation_failed` reporting its measured length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConsentChallengeRequest" /> class.
        /// </summary>
        /// <param name="fullName">
        /// Full name of the person consenting to have their voice cloned.<br/>
        /// Speechify binds it to the challenge and stores it with the consent<br/>
        /// record, so the create that consumes the challenge does not carry it<br/>
        /// and cannot change it.<br/>
        /// At most 120 bytes once UTF-8 encoded, which is 120 characters of<br/>
        /// Latin script but around 40 of Chinese, Japanese or Korean. Stated in<br/>
        /// bytes rather than as a `maxLength` because the two only agree on<br/>
        /// single-byte scripts, and a character count that never over-accepts<br/>
        /// would have to refuse Latin names at 30. A name over the limit comes<br/>
        /// back as `validation_failed` reporting its measured length.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConsentChallengeRequest(
            string fullName)
        {
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConsentChallengeRequest" /> class.
        /// </summary>
        public CreateConsentChallengeRequest()
        {
        }

    }
}