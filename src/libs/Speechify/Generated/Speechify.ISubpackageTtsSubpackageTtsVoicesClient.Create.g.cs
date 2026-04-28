#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsVoicesClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a personal (cloned) voice for the user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsCreatedVoice> CreateAsync(

            global::Speechify.CreateRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Create a personal (cloned) voice for the user
        /// </summary>
        /// <param name="name">
        /// Name of the personal voice
        /// </param>
        /// <param name="locale">
        /// Native language (locale) of the personal voice (e.g. en-US, es-ES, etc.)<br/>
        /// Default Value: en-US
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
        /// <param name="avatar">
        /// Avatar image file
        /// </param>
        /// <param name="avatarname">
        /// Avatar image file
        /// </param>
        /// <param name="consent">
        /// A **string** representing the user consent information in JSON format<br/>
        /// This should include the fullName and email of the consenting individual.<br/>
        /// For example, `{"fullName": "John Doe", "email": "john@example.com"}`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsCreatedVoice> CreateAsync(
            string name,
            global::Speechify.TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender gender,
            byte[] sample,
            string samplename,
            string consent,
            string? locale = default,
            byte[]? avatar = default,
            string? avatarname = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}