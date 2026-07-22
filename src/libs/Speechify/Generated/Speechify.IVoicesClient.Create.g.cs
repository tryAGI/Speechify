#nullable enable

namespace Speechify
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create Voice<br/>
        /// Create a personal (cloned) voice for the user from a 10-30 second audio sample. Cloned voices are usable self-serve on `simba-3.0`, `simba-english` and `simba-multilingual`. Synthesizing a cloned voice on `simba-3.2` currently requires manual Speechify review and approval of the voice key while we evaluate stronger safeguards, given the model's quality; contact Speechify to have a cloned voice approved for `simba-3.2`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.GetVoice> CreateAsync(

            global::Speechify.CreateRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice<br/>
        /// Create a personal (cloned) voice for the user from a 10-30 second audio sample. Cloned voices are usable self-serve on `simba-3.0`, `simba-english` and `simba-multilingual`. Synthesizing a cloned voice on `simba-3.2` currently requires manual Speechify review and approval of the voice key while we evaluate stronger safeguards, given the model's quality; contact Speechify to have a cloned voice approved for `simba-3.2`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.GetVoice>> CreateAsResponseAsync(

            global::Speechify.CreateRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice<br/>
        /// Create a personal (cloned) voice for the user from a 10-30 second audio sample. Cloned voices are usable self-serve on `simba-3.0`, `simba-english` and `simba-multilingual`. Synthesizing a cloned voice on `simba-3.2` currently requires manual Speechify review and approval of the voice key while we evaluate stronger safeguards, given the model's quality; contact Speechify to have a cloned voice approved for `simba-3.2`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
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
        /// not_specified GenderNotSpecified
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
        global::System.Threading.Tasks.Task<global::Speechify.GetVoice> CreateAsync(
            string name,
            global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender gender,
            byte[] sample,
            string samplename,
            string consent,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? locale = default,
            byte[]? avatar = default,
            string? avatarname = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Voice<br/>
        /// Create a personal (cloned) voice for the user from a 10-30 second audio sample. Cloned voices are usable self-serve on `simba-3.0`, `simba-english` and `simba-multilingual`. Synthesizing a cloned voice on `simba-3.2` currently requires manual Speechify review and approval of the voice key while we evaluate stronger safeguards, given the model's quality; contact Speechify to have a cloned voice approved for `simba-3.2`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
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
        /// not_specified GenderNotSpecified
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
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.GetVoice> CreateAsync(
            string name,
            global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender gender,
            global::System.IO.Stream sample,
            string samplename,
            string consent,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? locale = default,
            global::System.IO.Stream? avatar = default,
            string? avatarname = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice<br/>
        /// Create a personal (cloned) voice for the user from a 10-30 second audio sample. Cloned voices are usable self-serve on `simba-3.0`, `simba-english` and `simba-multilingual`. Synthesizing a cloned voice on `simba-3.2` currently requires manual Speechify review and approval of the voice key while we evaluate stronger safeguards, given the model's quality; contact Speechify to have a cloned voice approved for `simba-3.2`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
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
        /// not_specified GenderNotSpecified
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
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.GetVoice>> CreateAsResponseAsync(
            string name,
            global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender gender,
            global::System.IO.Stream sample,
            string samplename,
            string consent,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? locale = default,
            global::System.IO.Stream? avatar = default,
            string? avatarname = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}