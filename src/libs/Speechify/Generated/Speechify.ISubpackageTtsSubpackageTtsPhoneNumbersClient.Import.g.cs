#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsPhoneNumbersClient
    {
        /// <summary>
        /// Import<br/>
        /// Import a phone number into the workspace. The `source` field<br/>
        /// determines the provisioning path:<br/>
        /// - `livekit` - LiveKit purchases the number on your behalf. US<br/>
        ///   inbound only. Quickest path for local testing.<br/>
        /// - `twilio` - Provide your Twilio Account SID, Auth Token, and<br/>
        ///   the E.164 number you already own. We provision an Elastic SIP<br/>
        ///   Trunk on your Twilio account automatically.<br/>
        /// - `byoc` - Provide an existing SIP trunk ID. The number is<br/>
        ///   registered against that trunk.<br/>
        /// Returns 402 when the workspace has reached the 100-number cap.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ImportAsync(

            object request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import<br/>
        /// Import a phone number into the workspace. The `source` field<br/>
        /// determines the provisioning path:<br/>
        /// - `livekit` - LiveKit purchases the number on your behalf. US<br/>
        ///   inbound only. Quickest path for local testing.<br/>
        /// - `twilio` - Provide your Twilio Account SID, Auth Token, and<br/>
        ///   the E.164 number you already own. We provision an Elastic SIP<br/>
        ///   Trunk on your Twilio account automatically.<br/>
        /// - `byoc` - Provide an existing SIP trunk ID. The number is<br/>
        ///   registered against that trunk.<br/>
        /// Returns 402 when the workspace has reached the 100-number cap.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ImportAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}