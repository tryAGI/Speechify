#nullable enable

namespace Speechify
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Import Phone Number<br/>
        /// Import a phone number into the workspace. The `provider` field<br/>
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
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> ImportAsync(

            global::Speechify.ImportPhoneNumberRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Phone Number<br/>
        /// Import a phone number into the workspace. The `provider` field<br/>
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
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.PhoneNumber>> ImportAsResponseAsync(

            global::Speechify.ImportPhoneNumberRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Phone Number<br/>
        /// Import a phone number into the workspace. The `provider` field<br/>
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
        /// <param name="speechifyVersion"></param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="e164">
        /// The phone number in E.164 format. For `provider=livekit` this<br/>
        /// is the number you want LiveKit to purchase. For `provider=twilio`,<br/>
        /// `provider=telnyx`, and `provider=byoc` it is the number you<br/>
        /// already own.
        /// </param>
        /// <param name="provider">
        /// Which provider the number came from. Determines the provisioning<br/>
        /// and portability path.<br/>
        /// - `livekit` - LiveKit owns the carrier relationship; US inbound only.<br/>
        /// - `twilio` - Customer's own Twilio number bridged via Elastic SIP Trunk.<br/>
        /// - `telnyx` - Customer's own Telnyx number bridged via a Telnyx FQDN connection.<br/>
        /// - `byoc` - Any SIP provider using a customer-supplied trunk.<br/>
        /// - `twilio_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` on Speechify's master Twilio account; billed to Speechify.<br/>
        /// - `telnyx_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` (with `provider=telnyx`) on Speechify's master Telnyx account; billed to Speechify.<br/>
        /// - `verified_caller_id` - Customer-verified outbound caller ID on<br/>
        ///   their own Twilio account (Twilio's OutgoingCallerIds resource).<br/>
        ///   Server-determined at import time: when an `e164` submitted with<br/>
        ///   `provider=twilio` is not a full DID on the customer's account but<br/>
        ///   IS a verified caller ID, the resulting row gets this provider.<br/>
        ///   Outbound-only, never agent-bindable, rides the customer's<br/>
        ///   existing shared Twilio trunk for outbound routing. Requires a<br/>
        ///   prior `twilio` full-DID import from the same account; without<br/>
        ///   it the import returns 400.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label.
        /// </param>
        /// <param name="trunkId">
        /// For `provider=byoc`: the SIP trunk to bind this number to.<br/>
        /// Prefixed wire identifier (`trunk_&lt;26 char Crockford base32&gt;`).<br/>
        /// Not required for `provider=livekit`, `provider=twilio`, or<br/>
        /// `provider=telnyx`.
        /// </param>
        /// <param name="agentId">
        /// Optional agent to bind on import. Prefixed wire identifier<br/>
        /// (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="twilio">
        /// Twilio credentials for the one-click import flow. Used only when<br/>
        /// `provider=twilio`. The Account SID and Auth Token are used to<br/>
        /// provision an Elastic SIP Trunk on the customer's Twilio account<br/>
        /// pointing at LiveKit's SIP endpoint, then stored for future trunk<br/>
        /// management operations.
        /// </param>
        /// <param name="telnyx">
        /// Telnyx connection details for the bring-your-own-connection import<br/>
        /// flow. Used only when `provider=telnyx`. You provision an FQDN<br/>
        /// connection on your Telnyx account whose inbound calls forward to<br/>
        /// Speechify's LiveKit SIP ingress, assign the number to it, then import<br/>
        /// by passing the connection's id. A second number on the same connection<br/>
        /// reuses the one shared trunk + dispatch rule.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> ImportAsync(
            string e164,
            global::Speechify.PhoneNumberProvider provider,
            string? speechifyVersion = default,
            string? projectId = default,
            string? label = default,
            string? trunkId = default,
            string? agentId = default,
            global::Speechify.TwilioImportSpec? twilio = default,
            global::Speechify.TelnyxImportSpec? telnyx = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}