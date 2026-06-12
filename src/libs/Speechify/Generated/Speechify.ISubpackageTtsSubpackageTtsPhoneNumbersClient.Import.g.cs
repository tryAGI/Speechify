#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsPhoneNumbersClient
    {
        /// <summary>
        /// Import Phone Number<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.TtsPhoneNumber> ImportAsync(

            global::Speechify.TtsImportPhoneNumberRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Phone Number<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsPhoneNumber>> ImportAsResponseAsync(

            global::Speechify.TtsImportPhoneNumberRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Phone Number<br/>
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
        /// <param name="e164">
        /// The phone number in E.164 format. For `source=livekit` this<br/>
        /// is the number you want LiveKit to purchase. For `source=twilio`<br/>
        /// and `source=byoc` it is the number you already own.
        /// </param>
        /// <param name="source">
        /// Where the number came from. Determines the provisioning and<br/>
        /// portability path.<br/>
        /// - `livekit` - LiveKit owns the carrier relationship; US inbound only.<br/>
        /// - `twilio` - Customer's own Twilio number bridged via Elastic SIP Trunk.<br/>
        /// - `byoc` - Any SIP provider using a customer-supplied trunk.<br/>
        /// - `twilio_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` on Speechify's master Twilio account; billed to Speechify.<br/>
        /// - `verified_caller_id` - Customer-verified outbound caller ID on<br/>
        ///   their own Twilio account (Twilio's OutgoingCallerIds resource).<br/>
        ///   Server-determined at import time: when an `e164` submitted with<br/>
        ///   `source=twilio` is not a full DID on the customer's account but<br/>
        ///   IS a verified caller ID, the resulting row gets this source.<br/>
        ///   Outbound-only, never agent-bindable, rides the customer's<br/>
        ///   existing shared Twilio trunk for outbound routing. Requires a<br/>
        ///   prior `twilio` full-DID import from the same account; without<br/>
        ///   it the import returns 400.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label.
        /// </param>
        /// <param name="trunkId">
        /// For `source=byoc`: the SIP trunk to bind this number to.<br/>
        /// Prefixed wire identifier (`trunk_&lt;26 char Crockford base32&gt;`).<br/>
        /// Not required for `source=livekit` or `source=twilio`.
        /// </param>
        /// <param name="agentId">
        /// Optional agent to bind on import. Prefixed wire identifier<br/>
        /// (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="twilio">
        /// Twilio credentials for the one-click import flow. Used only when<br/>
        /// `source=twilio`. The Account SID and Auth Token are used to<br/>
        /// provision an Elastic SIP Trunk on the customer's Twilio account<br/>
        /// pointing at LiveKit's SIP endpoint, then stored for future trunk<br/>
        /// management operations.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsPhoneNumber> ImportAsync(
            string e164,
            global::Speechify.TtsPhoneNumberSource source,
            string? label = default,
            string? trunkId = default,
            string? agentId = default,
            global::Speechify.TtsTwilioImportSpec? twilio = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}