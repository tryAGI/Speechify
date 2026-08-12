#nullable enable

namespace Speechify
{
    public partial interface ISipTrunksClient
    {
        /// <summary>
        /// Create SIP Trunk<br/>
        /// Create a SIP trunk. For `provider=byoc` supply `sip_address` plus<br/>
        /// optional digest credentials and IP allowlist. For `provider=twilio`<br/>
        /// use `ImportPhoneNumber` with a `twilio` spec instead - trunk<br/>
        /// creation is handled automatically. Returns 422 when the workspace<br/>
        /// has reached the 20-trunk cap.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.SIPTrunk> CreateAsync(

            global::Speechify.CreateSIPTrunkRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create SIP Trunk<br/>
        /// Create a SIP trunk. For `provider=byoc` supply `sip_address` plus<br/>
        /// optional digest credentials and IP allowlist. For `provider=twilio`<br/>
        /// use `ImportPhoneNumber` with a `twilio` spec instead - trunk<br/>
        /// creation is handled automatically. Returns 422 when the workspace<br/>
        /// has reached the 20-trunk cap.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.SIPTrunk>> CreateAsResponseAsync(

            global::Speechify.CreateSIPTrunkRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create SIP Trunk<br/>
        /// Create a SIP trunk. For `provider=byoc` supply `sip_address` plus<br/>
        /// optional digest credentials and IP allowlist. For `provider=twilio`<br/>
        /// use `ImportPhoneNumber` with a `twilio` spec instead - trunk<br/>
        /// creation is handled automatically. Returns 422 when the workspace<br/>
        /// has reached the 20-trunk cap.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="name">
        /// Human-readable name for the trunk.
        /// </param>
        /// <param name="provider">
        /// Which provider backs the trunk. Informs the provisioning path and<br/>
        /// portability story.<br/>
        /// - `livekit` - Provisioned by LiveKit's native phone-number API.<br/>
        /// - `twilio` - Backed by a Twilio Elastic SIP Trunk on the customer's account.<br/>
        /// - `telnyx` - Backed by a Telnyx FQDN connection on the customer's account.<br/>
        /// - `byoc` - Any SIP provider with a customer-managed trunk.
        /// </param>
        /// <param name="direction">
        /// Whether the trunk handles inbound calls, outbound calls, or both.<br/>
        /// A `both` trunk has distinct provider inbound and outbound trunk IDs.
        /// </param>
        /// <param name="sipAddress">
        /// SIP endpoint hostname. Required for `provider=byoc`.
        /// </param>
        /// <param name="authUsername">
        /// SIP digest auth username.
        /// </param>
        /// <param name="authPassword">
        /// SIP digest auth password. Write-only.
        /// </param>
        /// <param name="allowedAddresses">
        /// IP / CIDR allowlist for inbound connections. Empty means any source is accepted.
        /// </param>
        /// <param name="destinationCountry">
        /// ISO 3166-1 alpha-2 country for the outbound dial plan.
        /// </param>
        /// <param name="transport">
        /// SIP transport protocol. `auto` lets LiveKit negotiate. Use `tls`<br/>
        /// for production where available - note that TLS is incompatible<br/>
        /// with SIP REFER (cold transfer). Trunks that need `transfer_to_number`<br/>
        /// should use `udp` or `tcp`.
        /// </param>
        /// <param name="mediaEncryption">
        /// SRTP media encryption policy.<br/>
        /// - `disable` - Unencrypted media only.<br/>
        /// - `allow` - Negotiate SRTP; fall back to unencrypted. Recommended default.<br/>
        /// - `require` - Reject calls that do not support SRTP.
        /// </param>
        /// <param name="credentials">
        /// Provider-specific credential blob (for future extensibility).
        /// </param>
        /// <param name="headersToAttributes">
        /// Map inbound SIP headers onto agent variables, so an upstream that<br/>
        /// has already identified the caller can pass that through instead of<br/>
        /// the agent re-verifying it in conversation.<br/>
        /// Each key is an extension header on the INVITE (`X-…`, a valid SIP<br/>
        /// token); each value names the variable its content is exposed under.<br/>
        /// A header mapped to `customer_id` renders in the agent's prompt, and<br/>
        /// in flow tool arguments, as `{{system__sip_customer_id}}`. Two<br/>
        /// headers may not share a variable name, which is the one rule the<br/>
        /// schema cannot state and the server rejects with<br/>
        /// `validation_failed`.<br/>
        /// Only applies to inbound calls on this trunk. For `provider=byoc`<br/>
        /// the mapping takes effect when the trunk's first phone number is<br/>
        /// imported, which is when its inbound route is provisioned.<br/>
        /// **A mapped header is an identity assertion from your own phone<br/>
        /// system, and is only as trustworthy as that system.** PSTN caller ID<br/>
        /// is spoofable and is a hint, not a credential; do not treat either as<br/>
        /// proof of identity for a high-value action. Values are passed to the<br/>
        /// agent as data, never as instructions.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.SIPTrunk> CreateAsync(
            string name,
            global::Speechify.SIPTrunkProvider provider,
            global::Speechify.SIPTrunkDirection direction,
            string? speechifyVersion = default,
            string? sipAddress = default,
            string? authUsername = default,
            string? authPassword = default,
            global::System.Collections.Generic.IList<string>? allowedAddresses = default,
            string? destinationCountry = default,
            global::Speechify.SIPTransport? transport = default,
            global::Speechify.SIPMediaEncryption? mediaEncryption = default,
            global::Speechify.CreateSipTrunkRequestCredentials? credentials = default,
            global::System.Collections.Generic.Dictionary<string, string>? headersToAttributes = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}