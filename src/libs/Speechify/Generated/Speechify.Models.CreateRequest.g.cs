
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
        /// notSpecified GenderNotSpecified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender Gender { get; set; }

        /// <summary>
        /// Audio sample file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Sample { get; set; }

        /// <summary>
        /// Audio sample file
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
        /// A **string** representing the user consent information in JSON format<br/>
        /// This should include the fullName and email of the consenting individual.<br/>
        /// For example, `{"fullName": "John Doe", "email": "john@example.com"}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Consent { get; set; }

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
        /// notSpecified GenderNotSpecified
        /// </param>
        /// <param name="sample">
        /// Audio sample file
        /// </param>
        /// <param name="samplename">
        /// Audio sample file
        /// </param>
        /// <param name="consent">
        /// A **string** representing the user consent information in JSON format<br/>
        /// This should include the fullName and email of the consenting individual.<br/>
        /// For example, `{"fullName": "John Doe", "email": "john@example.com"}`
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
            string consent,
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
            this.Consent = consent ?? throw new global::System.ArgumentNullException(nameof(consent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        public CreateRequest()
        {
        }

    }
}