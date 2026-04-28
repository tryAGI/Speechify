#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Create Conversation<br/>
        /// Start a new voice conversation with the agent. Returns a realtime<br/>
        /// voice session + short-lived client token so the caller can<br/>
        /// connect the audio pipeline directly. The agent is dispatched<br/>
        /// server-side; no additional client action required.<br/>
        /// Pass `dynamic_variables` to supply per-session values that override<br/>
        /// the agent's stored variable defaults for this one conversation.<br/>
        /// Keys in the `system__` namespace are rejected at this boundary.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsCreateConversationResponse> CreateConversationAsync(
            string id,

            global::Speechify.TtsCreateConversationRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Conversation<br/>
        /// Start a new voice conversation with the agent. Returns a realtime<br/>
        /// voice session + short-lived client token so the caller can<br/>
        /// connect the audio pipeline directly. The agent is dispatched<br/>
        /// server-side; no additional client action required.<br/>
        /// Pass `dynamic_variables` to supply per-session values that override<br/>
        /// the agent's stored variable defaults for this one conversation.<br/>
        /// Keys in the `system__` namespace are rejected at this boundary.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="transport">
        /// Transport hint. Omit to use the agent's default.
        /// </param>
        /// <param name="dynamicVariables">
        /// Per-session variable overrides that merge on top of the agent's<br/>
        /// stored variable defaults for this one conversation. Keys in the<br/>
        /// reserved `system__` namespace are rejected. Values must match the<br/>
        /// declared type of the corresponding variable definition on the agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsCreateConversationResponse> CreateConversationAsync(
            string id,
            string? transport = default,
            object? dynamicVariables = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}