#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsPhoneNumbersClient
    {
        /// <summary>
        /// Update<br/>
        /// Update a phone number. Only `label` and `agent_id` are mutable;<br/>
        /// `source` and `e164` are immutable after import. Pass `null` for<br/>
        /// `agent_id` to unbind the number from its current agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAsync(
            string id,

            object request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update<br/>
        /// Update a phone number. Only `label` and `agent_id` are mutable;<br/>
        /// `source` and `e164` are immutable after import. Pass `null` for<br/>
        /// `agent_id` to unbind the number from its current agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}