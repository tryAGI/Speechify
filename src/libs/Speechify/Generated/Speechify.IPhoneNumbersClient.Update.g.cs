#nullable enable

namespace Speechify
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's own attributes (today: `label`), or bind it<br/>
        /// to your own webhook brain with `relay`. `source` and `e164` are<br/>
        /// immutable after import. To bind or unbind an agent, use the<br/>
        /// relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`;<br/>
        /// a number carries an agent binding or a relay binding, never both, and<br/>
        /// setting one clears the other. The FIRST `relay` bind returns its<br/>
        /// signing secret exactly once; a later `relay` PATCH edits the settings<br/>
        /// and leaves the secret alone, so the copy you stored keeps verifying<br/>
        /// (use rotate-secret to replace it). Binding a relay requires the Phone<br/>
        /// product to be enabled for the workspace.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> UpdateAsync(
            string phoneNumberId,

            global::Speechify.UpdatePhoneNumberRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's own attributes (today: `label`), or bind it<br/>
        /// to your own webhook brain with `relay`. `source` and `e164` are<br/>
        /// immutable after import. To bind or unbind an agent, use the<br/>
        /// relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`;<br/>
        /// a number carries an agent binding or a relay binding, never both, and<br/>
        /// setting one clears the other. The FIRST `relay` bind returns its<br/>
        /// signing secret exactly once; a later `relay` PATCH edits the settings<br/>
        /// and leaves the secret alone, so the copy you stored keeps verifying<br/>
        /// (use rotate-secret to replace it). Binding a relay requires the Phone<br/>
        /// product to be enabled for the workspace.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.PhoneNumber>> UpdateAsResponseAsync(
            string phoneNumberId,

            global::Speechify.UpdatePhoneNumberRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's own attributes (today: `label`), or bind it<br/>
        /// to your own webhook brain with `relay`. `source` and `e164` are<br/>
        /// immutable after import. To bind or unbind an agent, use the<br/>
        /// relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`;<br/>
        /// a number carries an agent binding or a relay binding, never both, and<br/>
        /// setting one clears the other. The FIRST `relay` bind returns its<br/>
        /// signing secret exactly once; a later `relay` PATCH edits the settings<br/>
        /// and leaves the secret alone, so the copy you stored keeps verifying<br/>
        /// (use rotate-secret to replace it). Binding a relay requires the Phone<br/>
        /// product to be enabled for the workspace.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="projectId">
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </param>
        /// <param name="label">
        /// New label. Pass an empty string to clear.
        /// </param>
        /// <param name="relay">
        /// Binds a number's traffic to your own HTTPS endpoint. The endpoint<br/>
        /// must be `https://` and publicly resolvable - private-network and<br/>
        /// literal-IP targets in reserved ranges are rejected. Binding a relay<br/>
        /// atomically clears any agent binding on the number.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> UpdateAsync(
            string phoneNumberId,
            string? speechifyVersion = default,
            string? projectId = default,
            string? label = default,
            global::Speechify.RelayBinding? relay = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}