#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Set Contact Resolver<br/>
        /// Configure the endpoint Speechify asks to identify an inbound caller.<br/>
        /// On an inbound call from a number nobody has linked yet, Speechify<br/>
        /// POSTs `{channel, identifier, agent_id, conversation_id}` to this URL,<br/>
        /// signed with the same `Speechify-Signature` scheme as webhooks, and<br/>
        /// expects `{external_id, display_name?, variables?}` back. The contact<br/>
        /// attaches before the first token is generated, so `{{memory}}` is<br/>
        /// populated on the agent's opening line.<br/>
        /// The call FAILS OPEN on a sub-second deadline. A slow, unreachable or<br/>
        /// malformed response degrades to a call with no contact and no memory<br/>
        /// block - never a failed call and never a delayed answer. Answers are<br/>
        /// cached briefly per (workspace, identifier kind, identifier value), so a<br/>
        /// repeat caller does not re-hit your backend; they are scoped to the<br/>
        /// configuration that produced them, so changing the URL takes effect at<br/>
        /// once rather than after the cache window.<br/>
        /// One resolver per workspace: this endpoint sets it, and re-sending the<br/>
        /// same body is a no-op. Configuring for the first time mints a signing<br/>
        /// secret and returns it once; later edits keep the secret you already<br/>
        /// deployed a verifier against and return it blank.<br/>
        /// The URL must be `https` and must resolve to a public address. A<br/>
        /// loopback, private-range or cloud-metadata host is rejected here, and<br/>
        /// blocked again at dial time.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ContactResolver> SetResolverAsync(

            global::Speechify.PutContactResolverRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Contact Resolver<br/>
        /// Configure the endpoint Speechify asks to identify an inbound caller.<br/>
        /// On an inbound call from a number nobody has linked yet, Speechify<br/>
        /// POSTs `{channel, identifier, agent_id, conversation_id}` to this URL,<br/>
        /// signed with the same `Speechify-Signature` scheme as webhooks, and<br/>
        /// expects `{external_id, display_name?, variables?}` back. The contact<br/>
        /// attaches before the first token is generated, so `{{memory}}` is<br/>
        /// populated on the agent's opening line.<br/>
        /// The call FAILS OPEN on a sub-second deadline. A slow, unreachable or<br/>
        /// malformed response degrades to a call with no contact and no memory<br/>
        /// block - never a failed call and never a delayed answer. Answers are<br/>
        /// cached briefly per (workspace, identifier kind, identifier value), so a<br/>
        /// repeat caller does not re-hit your backend; they are scoped to the<br/>
        /// configuration that produced them, so changing the URL takes effect at<br/>
        /// once rather than after the cache window.<br/>
        /// One resolver per workspace: this endpoint sets it, and re-sending the<br/>
        /// same body is a no-op. Configuring for the first time mints a signing<br/>
        /// secret and returns it once; later edits keep the secret you already<br/>
        /// deployed a verifier against and return it blank.<br/>
        /// The URL must be `https` and must resolve to a public address. A<br/>
        /// loopback, private-range or cloud-metadata host is rejected here, and<br/>
        /// blocked again at dial time.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ContactResolver>> SetResolverAsResponseAsync(

            global::Speechify.PutContactResolverRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Contact Resolver<br/>
        /// Configure the endpoint Speechify asks to identify an inbound caller.<br/>
        /// On an inbound call from a number nobody has linked yet, Speechify<br/>
        /// POSTs `{channel, identifier, agent_id, conversation_id}` to this URL,<br/>
        /// signed with the same `Speechify-Signature` scheme as webhooks, and<br/>
        /// expects `{external_id, display_name?, variables?}` back. The contact<br/>
        /// attaches before the first token is generated, so `{{memory}}` is<br/>
        /// populated on the agent's opening line.<br/>
        /// The call FAILS OPEN on a sub-second deadline. A slow, unreachable or<br/>
        /// malformed response degrades to a call with no contact and no memory<br/>
        /// block - never a failed call and never a delayed answer. Answers are<br/>
        /// cached briefly per (workspace, identifier kind, identifier value), so a<br/>
        /// repeat caller does not re-hit your backend; they are scoped to the<br/>
        /// configuration that produced them, so changing the URL takes effect at<br/>
        /// once rather than after the cache window.<br/>
        /// One resolver per workspace: this endpoint sets it, and re-sending the<br/>
        /// same body is a no-op. Configuring for the first time mints a signing<br/>
        /// secret and returns it once; later edits keep the secret you already<br/>
        /// deployed a verifier against and return it blank.<br/>
        /// The URL must be `https` and must resolve to a public address. A<br/>
        /// loopback, private-range or cloud-metadata host is rejected here, and<br/>
        /// blocked again at dial time.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="url">
        /// HTTPS endpoint that answers `{external_id, display_name?,<br/>
        /// variables?}`. Must resolve to a public address - loopback,<br/>
        /// private-range and cloud-metadata hosts are rejected.
        /// </param>
        /// <param name="disabled">
        /// Park the integration without deleting it. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ContactResolver> SetResolverAsync(
            string url,
            string? speechifyVersion = default,
            bool? disabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}