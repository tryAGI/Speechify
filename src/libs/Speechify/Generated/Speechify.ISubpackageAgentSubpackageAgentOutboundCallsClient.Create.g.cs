#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentOutboundCallsClient
    {
        /// <summary>
        /// Create Outbound Call<br/>
        /// Place an outbound call from an agent to a phone number. LiveKit<br/>
        /// originates the SIP INVITE through the outbound trunk bound to the<br/>
        /// agent's workspace; the agent worker is dispatched into the room<br/>
        /// automatically.<br/>
        /// The response is returned as soon as LiveKit accepts the INVITE.<br/>
        /// Poll `GET /v1/agents/conversations/{conversation_id}` for status<br/>
        /// transitions: `pending` → `active` (answered) → `completed`.<br/>
        /// Requires a Twilio or BYOC trunk. LiveKit-native numbers are<br/>
        /// inbound-only.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.CreateOutboundCallResponse> CreateAsync(

            global::Speechify.CreateOutboundCallRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Outbound Call<br/>
        /// Place an outbound call from an agent to a phone number. LiveKit<br/>
        /// originates the SIP INVITE through the outbound trunk bound to the<br/>
        /// agent's workspace; the agent worker is dispatched into the room<br/>
        /// automatically.<br/>
        /// The response is returned as soon as LiveKit accepts the INVITE.<br/>
        /// Poll `GET /v1/agents/conversations/{conversation_id}` for status<br/>
        /// transitions: `pending` → `active` (answered) → `completed`.<br/>
        /// Requires a Twilio or BYOC trunk. LiveKit-native numbers are<br/>
        /// inbound-only.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.CreateOutboundCallResponse>> CreateAsResponseAsync(

            global::Speechify.CreateOutboundCallRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Outbound Call<br/>
        /// Place an outbound call from an agent to a phone number. LiveKit<br/>
        /// originates the SIP INVITE through the outbound trunk bound to the<br/>
        /// agent's workspace; the agent worker is dispatched into the room<br/>
        /// automatically.<br/>
        /// The response is returned as soon as LiveKit accepts the INVITE.<br/>
        /// Poll `GET /v1/agents/conversations/{conversation_id}` for status<br/>
        /// transitions: `pending` → `active` (answered) → `completed`.<br/>
        /// Requires a Twilio or BYOC trunk. LiveKit-native numbers are<br/>
        /// inbound-only.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="agentId">
        /// ID of the agent that handles the answered call.
        /// </param>
        /// <param name="to">
        /// Destination phone number in E.164 format (e.g. `+12025559876`).
        /// </param>
        /// <param name="callerIdNumber">
        /// The number shown to the callee as caller ID, in E.164 format.<br/>
        /// Defaults to the first outbound-capable number in the workspace.<br/>
        /// Useful for multi-number campaigns where you want to rotate<br/>
        /// caller IDs.
        /// </param>
        /// <param name="dtmfPrefix">
        /// DTMF digits dialed automatically after the call is answered,<br/>
        /// before the agent begins speaking. Use this for IVR navigation<br/>
        /// (e.g. `1ww2` presses 1, waits two seconds, presses 2). `w`<br/>
        /// is a half-second pause; `W` is a one-second pause.
        /// </param>
        /// <param name="dynamicVariables">
        /// Per-call variable overrides merged on top of the agent's stored<br/>
        /// defaults. Keys must not use the reserved `system__` prefix.<br/>
        /// Useful for injecting per-call context (customer name, order ID)<br/>
        /// into the agent prompt.
        /// </param>
        /// <param name="ringingTimeoutMs">
        /// How long to wait for the callee to answer before abandoning,<br/>
        /// in milliseconds. Defaults to 30000 (30s). Capped at 80000 (80s).
        /// </param>
        /// <param name="amd">
        /// Optional per-call override for the AMD routing config. When<br/>
        /// set, wholesale-replaces the agent's stored AMD shape for<br/>
        /// this single call (PATCH-replace, not merge). Unlocks the<br/>
        /// batch-campaign pattern: one agent dialling many recipients<br/>
        /// with per-row tailored voicemail messages via the existing<br/>
        /// dynamic_variables substitution. Validation rules match<br/>
        /// the agent-update boundary.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.CreateOutboundCallResponse> CreateAsync(
            string agentId,
            string to,
            string? speechifyVersion = default,
            string? callerIdNumber = default,
            string? dtmfPrefix = default,
            object? dynamicVariables = default,
            int? ringingTimeoutMs = default,
            global::Speechify.AMDConfig? amd = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}