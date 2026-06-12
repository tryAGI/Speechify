#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsSipTrunksClient
    {
        /// <summary>
        /// Create SIP Trunk<br/>
        /// Create a SIP trunk. For `kind=byoc` supply `sip_address` plus<br/>
        /// optional digest credentials and IP allowlist. For `kind=twilio`<br/>
        /// use `ImportPhoneNumber` with a `twilio` spec instead - trunk<br/>
        /// creation is handled automatically. Returns 402 when the workspace<br/>
        /// has reached the 20-trunk cap.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsSIPTrunk> CreateAsync(

            global::Speechify.TtsCreateSIPTrunkRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create SIP Trunk<br/>
        /// Create a SIP trunk. For `kind=byoc` supply `sip_address` plus<br/>
        /// optional digest credentials and IP allowlist. For `kind=twilio`<br/>
        /// use `ImportPhoneNumber` with a `twilio` spec instead - trunk<br/>
        /// creation is handled automatically. Returns 402 when the workspace<br/>
        /// has reached the 20-trunk cap.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsSIPTrunk>> CreateAsResponseAsync(

            global::Speechify.TtsCreateSIPTrunkRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create SIP Trunk<br/>
        /// Create a SIP trunk. For `kind=byoc` supply `sip_address` plus<br/>
        /// optional digest credentials and IP allowlist. For `kind=twilio`<br/>
        /// use `ImportPhoneNumber` with a `twilio` spec instead - trunk<br/>
        /// creation is handled automatically. Returns 402 when the workspace<br/>
        /// has reached the 20-trunk cap.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the trunk.
        /// </param>
        /// <param name="kind">
        /// Where the trunk came from. Informs the provisioning path and<br/>
        /// portability story.<br/>
        /// - `livekit` - Provisioned by LiveKit's native phone-number API.<br/>
        /// - `twilio` - Backed by a Twilio Elastic SIP Trunk on the customer's account.<br/>
        /// - `byoc` - Any SIP provider with a customer-managed trunk.
        /// </param>
        /// <param name="direction">
        /// Whether the trunk handles inbound calls, outbound calls, or both.<br/>
        /// A `both` trunk has distinct LiveKit inbound and outbound trunk IDs.
        /// </param>
        /// <param name="sipAddress">
        /// SIP endpoint hostname. Required for `kind=byoc`.
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
        global::System.Threading.Tasks.Task<global::Speechify.TtsSIPTrunk> CreateAsync(
            string name,
            global::Speechify.TtsSIPTrunkKind kind,
            global::Speechify.TtsSIPTrunkDirection direction,
            string? sipAddress = default,
            string? authUsername = default,
            string? authPassword = default,
            global::System.Collections.Generic.IList<string>? allowedAddresses = default,
            string? destinationCountry = default,
            global::Speechify.TtsSIPTransport? transport = default,
            global::Speechify.TtsSIPMediaEncryption? mediaEncryption = default,
            global::Speechify.TtsCreateSipTrunkRequestCredentials? credentials = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}