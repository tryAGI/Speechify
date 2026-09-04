#nullable enable

namespace Speechify
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Stream Run Events<br/>
        /// Server-Sent Events stream of a run's progress, so a client can follow<br/>
        /// a long-running agent instead of polling it.<br/>
        /// Holds the connection open and tails the run's journal: a<br/>
        /// `run.step.added` event per step (its `data` is a RunStep object, the<br/>
        /// same shape List Run Steps returns), a `run.status.changed` event when<br/>
        /// the run's status moves, and a terminal `run.ended` event carrying the<br/>
        /// final status and, when the run stopped short, its<br/>
        /// `incomplete_reason`. Consumers must ignore unknown event types.<br/>
        /// A run waiting on a human approval is not terminal: the stream reports<br/>
        /// `requires_action` and keeps tailing, so the client learns it has<br/>
        /// something to decide. Each step event carries its `seq` as the event<br/>
        /// id, so a dropped connection resumes exactly where it left off through<br/>
        /// the standard `Last-Event-ID` header. Same read access as List Run<br/>
        /// Steps.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Speechify.AgentRunStreamEvent> StreamEventsAsync(
            string agentId,
            string runId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}