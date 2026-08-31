#nullable enable

namespace Speechify
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Update Phone Number<br/>
        /// Update a phone number's own attributes (today: `label`), or point it<br/>
        /// at one of your external brains with `brain_id`. `source` and `e164` are<br/>
        /// immutable after import. To bind or unbind an agent, use the<br/>
        /// relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`;<br/>
        /// a number's brain is a hosted agent or a brain of your own, never both,<br/>
        /// and setting one clears the other. `brain_id: null` takes the brain off<br/>
        /// the number and leaves the brain itself untouched, so releasing a number<br/>
        /// never destroys the service definition behind it. Pointing a number at a<br/>
        /// brain requires the Phone product to be enabled for the workspace.
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
        /// Update a phone number's own attributes (today: `label`), or point it<br/>
        /// at one of your external brains with `brain_id`. `source` and `e164` are<br/>
        /// immutable after import. To bind or unbind an agent, use the<br/>
        /// relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`;<br/>
        /// a number's brain is a hosted agent or a brain of your own, never both,<br/>
        /// and setting one clears the other. `brain_id: null` takes the brain off<br/>
        /// the number and leaves the brain itself untouched, so releasing a number<br/>
        /// never destroys the service definition behind it. Pointing a number at a<br/>
        /// brain requires the Phone product to be enabled for the workspace.
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
        /// Update a phone number's own attributes (today: `label`), or point it<br/>
        /// at one of your external brains with `brain_id`. `source` and `e164` are<br/>
        /// immutable after import. To bind or unbind an agent, use the<br/>
        /// relationship endpoints<br/>
        /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`;<br/>
        /// a number's brain is a hosted agent or a brain of your own, never both,<br/>
        /// and setting one clears the other. `brain_id: null` takes the brain off<br/>
        /// the number and leaves the brain itself untouched, so releasing a number<br/>
        /// never destroys the service definition behind it. Pointing a number at a<br/>
        /// brain requires the Phone product to be enabled for the workspace.
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
        /// <param name="brainId">
        /// Point this number at one of your external brains: a `brain_...`<br/>
        /// id binds it, an explicit null takes it off the number, omitted<br/>
        /// leaves the binding unchanged. Only a reference ever rides this body<br/>
        /// - the endpoint and its signing secret belong to the brain and are<br/>
        /// edited at `/v1/agents/brains/{brain_id}`, so rotating the secret<br/>
        /// there is enough and no number has to be re-saved.
        /// </param>
        /// <param name="replaceAgentBinding">
        /// Acknowledges that this bind takes the number away from a hosted<br/>
        /// agent that is still answering on it. Without it, pointing an<br/>
        /// agent-bound number at an external brain is refused with<br/>
        /// `409 relay_displaces_agent` naming the agent, so the displacement<br/>
        /// is never a surprise. Re-pointing one brain at another does not need<br/>
        /// it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PhoneNumber> UpdateAsync(
            string phoneNumberId,
            string? speechifyVersion = default,
            string? projectId = default,
            string? label = default,
            string? brainId = default,
            bool? replaceAgentBinding = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}