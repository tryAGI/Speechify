#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsPhoneNumbersClient
    {
        /// <summary>
        /// List<br/>
        /// List all phone numbers in the caller's workspace.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}