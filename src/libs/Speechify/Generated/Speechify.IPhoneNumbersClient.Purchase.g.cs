#nullable enable

namespace Speechify
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Purchase a phone number on Speechify's master Twilio account.<br/>
        /// The number is billed to Speechify until released. A plan that<br/>
        /// includes no purchased numbers (e.g. Free) returns 402; a plan<br/>
        /// that has used its full included quota returns 422. This is<br/>
        /// independent of the overall 100-number cap.<br/>
        /// `e164` must come from a recent `SearchAvailablePhoneNumbers`<br/>
        /// response — carriers reject buys against numbers that are no<br/>
        /// longer in inventory. The returned phone number is wired for<br/>
        /// both inbound (when `agent_id` is set, or after binding the<br/>
        /// number to an agent via<br/>
        /// `POST /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`) and<br/>
        /// outbound calls (via the workspace's shared outbound trunk).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> PurchaseAsync(

            global::Speechify.PurchasePhoneNumberRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Purchase a phone number on Speechify's master Twilio account.<br/>
        /// The number is billed to Speechify until released. A plan that<br/>
        /// includes no purchased numbers (e.g. Free) returns 402; a plan<br/>
        /// that has used its full included quota returns 422. This is<br/>
        /// independent of the overall 100-number cap.<br/>
        /// `e164` must come from a recent `SearchAvailablePhoneNumbers`<br/>
        /// response — carriers reject buys against numbers that are no<br/>
        /// longer in inventory. The returned phone number is wired for<br/>
        /// both inbound (when `agent_id` is set, or after binding the<br/>
        /// number to an agent via<br/>
        /// `POST /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`) and<br/>
        /// outbound calls (via the workspace's shared outbound trunk).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.PhoneNumber>> PurchaseAsResponseAsync(

            global::Speechify.PurchasePhoneNumberRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Purchase a phone number on Speechify's master Twilio account.<br/>
        /// The number is billed to Speechify until released. A plan that<br/>
        /// includes no purchased numbers (e.g. Free) returns 402; a plan<br/>
        /// that has used its full included quota returns 422. This is<br/>
        /// independent of the overall 100-number cap.<br/>
        /// `e164` must come from a recent `SearchAvailablePhoneNumbers`<br/>
        /// response — carriers reject buys against numbers that are no<br/>
        /// longer in inventory. The returned phone number is wired for<br/>
        /// both inbound (when `agent_id` is set, or after binding the<br/>
        /// number to an agent via<br/>
        /// `POST /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`) and<br/>
        /// outbound calls (via the workspace's shared outbound trunk).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="e164">
        /// The E.164 number to buy. Must currently be in carrier inventory.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label.
        /// </param>
        /// <param name="provider">
        /// Which carrier's Speechify-managed account to buy on. Optional;<br/>
        /// defaults to `twilio_purchased`.
        /// </param>
        /// <param name="agentId">
        /// Optional agent to bind the number to at purchase time.<br/>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="intendedUse">
        /// Optional workspace-level intended-use declaration recorded with<br/>
        /// the purchase (replaces any earlier declaration). May be required<br/>
        /// by the workspace trust policy.
        /// </param>
        /// <param name="tosAccepted">
        /// Set true to record the ToS/consent attestation for this<br/>
        /// workspace. Recorded once - a repeat purchase never moves the<br/>
        /// original attestation's actor or timestamp.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> PurchaseAsync(
            string e164,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? projectId = default,
            string? label = default,
            global::Speechify.PurchasedPhoneNumberProvider? provider = default,
            string? agentId = default,
            global::Speechify.IntendedUse? intendedUse = default,
            bool? tosAccepted = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}