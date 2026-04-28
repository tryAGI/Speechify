#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsSipTrunksClient
    {
        /// <summary>
        /// Create<br/>
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
        global::System.Threading.Tasks.Task<string> CreateAsync(

            object request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Create a SIP trunk. For `kind=byoc` supply `sip_address` plus<br/>
        /// optional digest credentials and IP allowlist. For `kind=twilio`<br/>
        /// use `ImportPhoneNumber` with a `twilio` spec instead - trunk<br/>
        /// creation is handled automatically. Returns 402 when the workspace<br/>
        /// has reached the 20-trunk cap.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}