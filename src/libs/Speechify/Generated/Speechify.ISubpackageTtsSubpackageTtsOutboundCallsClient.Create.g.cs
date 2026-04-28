#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsOutboundCallsClient
    {
        /// <summary>
        /// Create<br/>
        /// Place an outbound call from an agent to a phone number. LiveKit<br/>
        /// originates the SIP INVITE through the outbound trunk bound to the<br/>
        /// agent's workspace; the agent worker is dispatched into the room<br/>
        /// automatically.<br/>
        /// The response is returned as soon as LiveKit accepts the INVITE.<br/>
        /// Poll `GET /v1/conversations/{conversation_id}` for status<br/>
        /// transitions: `pending` → `active` (answered) → `completed`.<br/>
        /// Requires a Twilio or BYOC trunk. LiveKit-native numbers are<br/>
        /// inbound-only.
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
        /// Place an outbound call from an agent to a phone number. LiveKit<br/>
        /// originates the SIP INVITE through the outbound trunk bound to the<br/>
        /// agent's workspace; the agent worker is dispatched into the room<br/>
        /// automatically.<br/>
        /// The response is returned as soon as LiveKit accepts the INVITE.<br/>
        /// Poll `GET /v1/conversations/{conversation_id}` for status<br/>
        /// transitions: `pending` → `active` (answered) → `completed`.<br/>
        /// Requires a Twilio or BYOC trunk. LiveKit-native numbers are<br/>
        /// inbound-only.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}