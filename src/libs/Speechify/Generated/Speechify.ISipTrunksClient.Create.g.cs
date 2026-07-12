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
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}