#nullable enable

namespace Speechify
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create Voice<br/>
        /// Create a cloned voice for the workspace from a 10-30 second audio sample, with verified consent from the speaker.<br/>
        /// Cloning requires proof that the speaker agreed to it. Create a consent challenge with `POST /v1/voices/consent-challenges`, show the returned `phrase` to the speaker, record them reading it aloud, and send that recording here as `consent_recording` together with the challenge's `consent_challenge_id`. Speechify transcribes the recording, checks it against the phrase it issued, checks that its speaker is the speaker in your `sample`, and keeps it as the consent record for the voice. The person consenting therefore has to be the person being cloned. A challenge is single use and short-lived, so record and submit in one sitting.<br/>
        /// The clone belongs to the workspace rather than the member who created it, and access follows the caller's workspace role and API-key scopes exactly as for any other voice: voices scopes to list it, audio scopes to synthesize with it, and the content-management permission plus a write scope on the key to delete it. Cloned voices are usable self-serve on `simba-3.0` (and, on a workspace pinned before API version `2026-09-21`, on the retired `simba-english` and `simba-multilingual` until they are switched off on 2026-11-21). `simba-3.2` also serves cloned voices, currently as a limited release enabled per workspace; contact Speechify to have it enabled for yours.<br/>
        /// Callers pinned before `Speechify-Version: 2026-09-13` use the previous flow instead: no challenge, and a `consent` form field carrying the speaker's name and email as a JSON string. That flow is deprecated and will be removed after a sunset window announced in the changelog.
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
        /// Create a cloned voice for the workspace from a 10-30 second audio sample, with verified consent from the speaker.<br/>
        /// Cloning requires proof that the speaker agreed to it. Create a consent challenge with `POST /v1/voices/consent-challenges`, show the returned `phrase` to the speaker, record them reading it aloud, and send that recording here as `consent_recording` together with the challenge's `consent_challenge_id`. Speechify transcribes the recording, checks it against the phrase it issued, checks that its speaker is the speaker in your `sample`, and keeps it as the consent record for the voice. The person consenting therefore has to be the person being cloned. A challenge is single use and short-lived, so record and submit in one sitting.<br/>
        /// The clone belongs to the workspace rather than the member who created it, and access follows the caller's workspace role and API-key scopes exactly as for any other voice: voices scopes to list it, audio scopes to synthesize with it, and the content-management permission plus a write scope on the key to delete it. Cloned voices are usable self-serve on `simba-3.0` (and, on a workspace pinned before API version `2026-09-21`, on the retired `simba-english` and `simba-multilingual` until they are switched off on 2026-11-21). `simba-3.2` also serves cloned voices, currently as a limited release enabled per workspace; contact Speechify to have it enabled for yours.<br/>
        /// Callers pinned before `Speechify-Version: 2026-09-13` use the previous flow instead: no challenge, and a `consent` form field carrying the speaker's name and email as a JSON string. That flow is deprecated and will be removed after a sunset window announced in the changelog.
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
        /// Create a cloned voice for the workspace from a 10-30 second audio sample, with verified consent from the speaker.<br/>
        /// Cloning requires proof that the speaker agreed to it. Create a consent challenge with `POST /v1/voices/consent-challenges`, show the returned `phrase` to the speaker, record them reading it aloud, and send that recording here as `consent_recording` together with the challenge's `consent_challenge_id`. Speechify transcribes the recording, checks it against the phrase it issued, checks that its speaker is the speaker in your `sample`, and keeps it as the consent record for the voice. The person consenting therefore has to be the person being cloned. A challenge is single use and short-lived, so record and submit in one sitting.<br/>
        /// The clone belongs to the workspace rather than the member who created it, and access follows the caller's workspace role and API-key scopes exactly as for any other voice: voices scopes to list it, audio scopes to synthesize with it, and the content-management permission plus a write scope on the key to delete it. Cloned voices are usable self-serve on `simba-3.0` (and, on a workspace pinned before API version `2026-09-21`, on the retired `simba-english` and `simba-multilingual` until they are switched off on 2026-11-21). `simba-3.2` also serves cloned voices, currently as a limited release enabled per workspace; contact Speechify to have it enabled for yours.<br/>
        /// Callers pinned before `Speechify-Version: 2026-09-13` use the previous flow instead: no challenge, and a `consent` form field carrying the speaker's name and email as a JSON string. That flow is deprecated and will be removed after a sunset window announced in the changelog.
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
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </param>
        /// <param name="samplename">
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </param>
        /// <param name="avatar">
        /// Avatar image file
        /// </param>
        /// <param name="avatarname">
        /// Avatar image file
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.GetVoice> CreateAsync(
            string name,
            global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender gender,
            byte[] sample,
            string samplename,
            string consentChallengeId,
            byte[] consentRecording,
            string consentRecordingname,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? locale = default,
            byte[]? avatar = default,
            string? avatarname = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Voice<br/>
        /// Create a cloned voice for the workspace from a 10-30 second audio sample, with verified consent from the speaker.<br/>
        /// Cloning requires proof that the speaker agreed to it. Create a consent challenge with `POST /v1/voices/consent-challenges`, show the returned `phrase` to the speaker, record them reading it aloud, and send that recording here as `consent_recording` together with the challenge's `consent_challenge_id`. Speechify transcribes the recording, checks it against the phrase it issued, checks that its speaker is the speaker in your `sample`, and keeps it as the consent record for the voice. The person consenting therefore has to be the person being cloned. A challenge is single use and short-lived, so record and submit in one sitting.<br/>
        /// The clone belongs to the workspace rather than the member who created it, and access follows the caller's workspace role and API-key scopes exactly as for any other voice: voices scopes to list it, audio scopes to synthesize with it, and the content-management permission plus a write scope on the key to delete it. Cloned voices are usable self-serve on `simba-3.0` (and, on a workspace pinned before API version `2026-09-21`, on the retired `simba-english` and `simba-multilingual` until they are switched off on 2026-11-21). `simba-3.2` also serves cloned voices, currently as a limited release enabled per workspace; contact Speechify to have it enabled for yours.<br/>
        /// Callers pinned before `Speechify-Version: 2026-09-13` use the previous flow instead: no challenge, and a `consent` form field carrying the speaker's name and email as a JSON string. That flow is deprecated and will be removed after a sunset window announced in the changelog.
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
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </param>
        /// <param name="samplename">
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </param>
        /// <param name="avatar">
        /// Avatar image file
        /// </param>
        /// <param name="avatarname">
        /// Avatar image file
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.GetVoice> CreateAsync(
            string name,
            global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender gender,
            global::System.IO.Stream sample,
            string samplename,
            string consentChallengeId,
            global::System.IO.Stream consentRecording,
            string consentRecordingname,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? locale = default,
            global::System.IO.Stream? avatar = default,
            string? avatarname = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice<br/>
        /// Create a cloned voice for the workspace from a 10-30 second audio sample, with verified consent from the speaker.<br/>
        /// Cloning requires proof that the speaker agreed to it. Create a consent challenge with `POST /v1/voices/consent-challenges`, show the returned `phrase` to the speaker, record them reading it aloud, and send that recording here as `consent_recording` together with the challenge's `consent_challenge_id`. Speechify transcribes the recording, checks it against the phrase it issued, checks that its speaker is the speaker in your `sample`, and keeps it as the consent record for the voice. The person consenting therefore has to be the person being cloned. A challenge is single use and short-lived, so record and submit in one sitting.<br/>
        /// The clone belongs to the workspace rather than the member who created it, and access follows the caller's workspace role and API-key scopes exactly as for any other voice: voices scopes to list it, audio scopes to synthesize with it, and the content-management permission plus a write scope on the key to delete it. Cloned voices are usable self-serve on `simba-3.0` (and, on a workspace pinned before API version `2026-09-21`, on the retired `simba-english` and `simba-multilingual` until they are switched off on 2026-11-21). `simba-3.2` also serves cloned voices, currently as a limited release enabled per workspace; contact Speechify to have it enabled for yours.<br/>
        /// Callers pinned before `Speechify-Version: 2026-09-13` use the previous flow instead: no challenge, and a `consent` form field carrying the speaker's name and email as a JSON string. That flow is deprecated and will be removed after a sunset window announced in the changelog.
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
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </param>
        /// <param name="samplename">
        /// Audio sample of the voice to clone, 10-30 seconds of clean speech.
        /// </param>
        /// <param name="avatar">
        /// Avatar image file
        /// </param>
        /// <param name="avatarname">
        /// Avatar image file
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.GetVoice>> CreateAsResponseAsync(
            string name,
            global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender gender,
            global::System.IO.Stream sample,
            string samplename,
            string consentChallengeId,
            global::System.IO.Stream consentRecording,
            string consentRecordingname,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? locale = default,
            global::System.IO.Stream? avatar = default,
            string? avatarname = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}