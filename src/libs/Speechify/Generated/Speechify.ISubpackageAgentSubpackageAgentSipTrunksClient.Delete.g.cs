#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentSipTrunksClient
    {
        /// <summary>
        /// Delete SIP Trunk<br/>
        /// Delete a SIP trunk. This also removes the backing LiveKit inbound<br/>
        /// trunk, outbound trunk, and dispatch rule if they were provisioned<br/>
        /// by us. Phone numbers attached to this trunk are left in place but<br/>
        /// become non-functional until rebound to a new trunk.
        /// </summary>
        /// <param name="sipTrunkId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string sipTrunkId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete SIP Trunk<br/>
        /// Delete a SIP trunk. This also removes the backing LiveKit inbound<br/>
        /// trunk, outbound trunk, and dispatch rule if they were provisioned<br/>
        /// by us. Phone numbers attached to this trunk are left in place but<br/>
        /// become non-functional until rebound to a new trunk.
        /// </summary>
        /// <param name="sipTrunkId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string sipTrunkId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}