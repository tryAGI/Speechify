#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsSipTrunksClient
    {
        /// <summary>
        /// Delete<br/>
        /// Delete a SIP trunk. This also removes the backing LiveKit inbound<br/>
        /// trunk, outbound trunk, and dispatch rule if they were provisioned<br/>
        /// by us. Phone numbers attached to this trunk are left in place but<br/>
        /// become non-functional until rebound to a new trunk.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}