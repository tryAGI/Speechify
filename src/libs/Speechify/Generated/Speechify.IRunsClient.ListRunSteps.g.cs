#nullable enable

namespace Speechify
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// List Agent Run Steps<br/>
        /// List a run's **step journal**: the append-only plan-act-observe trail the<br/>
        /// durable runtime leaves behind, in order (`seq` ascending). Each step is one<br/>
        /// iteration of the loop - a `plan` (the agent's rationale), a `tool_call` (the<br/>
        /// tool and its arguments), or an `observation` (the tool's result). The run's<br/>
        /// final answer is not a step; it lives on the run object (`getRun`). Use this<br/>
        /// to render or audit exactly what a run did between its instruction and its<br/>
        /// result.<br/>
        /// Credential-shaped values in a step's arguments and content are redacted.<br/>
        /// **The journal is kept for 90 days**, after which an older run returns an<br/>
        /// empty list here. The run itself is not deleted with it: its instruction,<br/>
        /// answer and usage stay on the run object indefinitely. Export the trail<br/>
        /// if you need it beyond that window.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentRunStepsResponse> ListRunStepsAsync(
            string agentId,
            string runId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Run Steps<br/>
        /// List a run's **step journal**: the append-only plan-act-observe trail the<br/>
        /// durable runtime leaves behind, in order (`seq` ascending). Each step is one<br/>
        /// iteration of the loop - a `plan` (the agent's rationale), a `tool_call` (the<br/>
        /// tool and its arguments), or an `observation` (the tool's result). The run's<br/>
        /// final answer is not a step; it lives on the run object (`getRun`). Use this<br/>
        /// to render or audit exactly what a run did between its instruction and its<br/>
        /// result.<br/>
        /// Credential-shaped values in a step's arguments and content are redacted.<br/>
        /// **The journal is kept for 90 days**, after which an older run returns an<br/>
        /// empty list here. The run itself is not deleted with it: its instruction,<br/>
        /// answer and usage stay on the run object indefinitely. Export the trail<br/>
        /// if you need it beyond that window.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentRunStepsResponse>> ListRunStepsAsResponseAsync(
            string agentId,
            string runId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}