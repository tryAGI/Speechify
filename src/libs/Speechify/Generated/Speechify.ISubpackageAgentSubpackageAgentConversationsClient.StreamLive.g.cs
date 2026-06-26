#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// Stream Live Conversation<br/>
        /// Server-Sent Events stream of an in-progress conversation's<br/>
        /// transcript and status, for the live-monitoring console surface.<br/>
        /// Holds the connection open and tails the transcript: emits a<br/>
        /// `message` event per turn (its `data` is a Message object), a<br/>
        /// `status` event when the conversation status changes, and a<br/>
        /// terminal `end` event when the call completes. Resumes after a<br/>
        /// dropped connection via the standard `Last-Event-ID` header. Same<br/>
        /// read access as List Messages.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> StreamLiveAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}