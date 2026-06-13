#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsPhoneNumbersClient
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
        /// both inbound (when `agent_id` is set, or after a later<br/>
        /// `PATCH`) and outbound calls (via the workspace's shared<br/>
        /// outbound trunk).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsPhoneNumber> PurchaseAsync(

            global::Speechify.TtsPurchasePhoneNumberRequest request,
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
        /// both inbound (when `agent_id` is set, or after a later<br/>
        /// `PATCH`) and outbound calls (via the workspace's shared<br/>
        /// outbound trunk).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsPhoneNumber>> PurchaseAsResponseAsync(

            global::Speechify.TtsPurchasePhoneNumberRequest request,
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
        /// both inbound (when `agent_id` is set, or after a later<br/>
        /// `PATCH`) and outbound calls (via the workspace's shared<br/>
        /// outbound trunk).
        /// </summary>
        /// <param name="e164">
        /// The E.164 number to buy. Must currently be in carrier inventory.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label.
        /// </param>
        /// <param name="agentId">
        /// Optional agent to bind the number to at purchase time.<br/>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsPhoneNumber> PurchaseAsync(
            string e164,
            string? label = default,
            string? agentId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}