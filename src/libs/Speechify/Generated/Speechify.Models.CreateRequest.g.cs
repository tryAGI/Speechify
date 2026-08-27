
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRequest
    {
        /// <summary>
        /// Name of the personal voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Native language (locale) of the personal voice (e.g. en-US, es-ES, etc.)<br/>
        /// Default Value: en-US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Gender marker for the personal voice<br/>
        /// male GenderMale<br/>
        /// female GenderFemale<br/>
        /// not_specified GenderNotSpecified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender Gender { get; set; }

        /// <summary>
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Sample { get; set; }

        /// <summary>
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samplename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Samplename { get; set; }

        /// <summary>
        /// Avatar image file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public byte[]? Avatar { get; set; }

        /// <summary>
        /// Avatar image file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarname")]
        public string? Avatarname { get; set; }

        /// <summary>
        /// The `id` of the consent challenge this create consumes, from<br/>
        /// `POST /v1/voices/consent-challenges`. Single use: once a<br/>
        /// create has consumed it, whether or not that create<br/>
        /// succeeded, it cannot be used again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent_challenge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsentChallengeId { get; set; }

        /// <summary>
        /// Recording of the speaker reading the challenge's `phrase`<br/>
        /// aloud. This is the consent record for the voice, not a<br/>
        /// second voice sample: it must be the same person as in<br/>
        /// `sample`, and it is retained as evidence. 5-30 seconds, at<br/>
        /// most 25 MB, in any common audio container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent_recording")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ConsentRecording { get; set; }

        /// <summary>
        /// Recording of the speaker reading the challenge's `phrase`<br/>
        /// aloud. This is the consent record for the voice, not a<br/>
        /// second voice sample: it must be the same person as in<br/>
        /// `sample`, and it is retained as evidence. 5-30 seconds, at<br/>
        /// most 25 MB, in any common audio container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent_recordingname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsentRecordingname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the personal voice
        /// </param>
        /// <param name="gender">
        /// Gender marker for the personal voice<br/>
        /// male GenderMale<br/>
        /// female GenderFemale<br/>
        /// not_specified GenderNotSpecified
        /// </param>
        /// <param name="sample">
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </param>
        /// <param name="samplename">
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </param>
        /// <param name="consentChallengeId">
        /// The `id` of the consent challenge this create consumes, from<br/>
        /// `POST /v1/voices/consent-challenges`. Single use: once a<br/>
        /// create has consumed it, whether or not that create<br/>
        /// succeeded, it cannot be used again.
        /// </param>
        /// <param name="consentRecording">
        /// Recording of the speaker reading the challenge's `phrase`<br/>
        /// aloud. This is the consent record for the voice, not a<br/>
        /// second voice sample: it must be the same person as in<br/>
        /// `sample`, and it is retained as evidence. 5-30 seconds, at<br/>
        /// most 25 MB, in any common audio container.
        /// </param>
        /// <param name="consentRecordingname">
        /// Recording of the speaker reading the challenge's `phrase`<br/>
        /// aloud. This is the consent record for the voice, not a<br/>
        /// second voice sample: it must be the same person as in<br/>
        /// `sample`, and it is retained as evidence. 5-30 seconds, at<br/>
        /// most 25 MB, in any common audio container.
        /// </param>
        /// <param name="locale">
        /// Native language (locale) of the personal voice (e.g. en-US, es-ES, etc.)<br/>
        /// Default Value: en-US
        /// </param>
        /// <param name="avatar">
        /// Avatar image file
        /// </param>
        /// <param name="avatarname">
        /// Avatar image file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest(
            string name,
            global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender gender,
            byte[] sample,
            string samplename,
            string consentChallengeId,
            byte[] consentRecording,
            string consentRecordingname,
            string? locale,
            byte[]? avatar,
            string? avatarname)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Locale = locale;
            this.Gender = gender;
            this.Sample = sample ?? throw new global::System.ArgumentNullException(nameof(sample));
            this.Samplename = samplename ?? throw new global::System.ArgumentNullException(nameof(samplename));
            this.Avatar = avatar;
            this.Avatarname = avatarname;
            this.ConsentChallengeId = consentChallengeId ?? throw new global::System.ArgumentNullException(nameof(consentChallengeId));
            this.ConsentRecording = consentRecording ?? throw new global::System.ArgumentNullException(nameof(consentRecording));
            this.ConsentRecordingname = consentRecordingname ?? throw new global::System.ArgumentNullException(nameof(consentRecordingname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        public CreateRequest()
        {
        }

    }
}