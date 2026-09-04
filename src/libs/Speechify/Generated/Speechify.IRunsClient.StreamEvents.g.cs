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
        /// something to decide.<br/>
        /// ## The stream is expected to reconnect<br/>
        /// **The server closes the connection after 4 minutes whether or not the<br/>
        /// run has settled**, so a long run spans several connections. Only<br/>
        /// `run.ended` means the run is over - a closed socket does not. The<br/>
        /// response opens with `retry: 2000`, so a browser `EventSource`<br/>
        /// reconnects on its own; a hand-rolled client must do the same.<br/>
        /// Resume with the standard `Last-Event-ID` header. Step events carry<br/>
        /// their `seq` as the event id, so a reconnect continues exactly where it<br/>
        /// left off; status events carry no id, and an absent or unparseable<br/>
        /// `Last-Event-ID` replays the journal from the beginning rather than<br/>
        /// skipping it. On every connection, including a resume, the server emits<br/>
        /// one `run.status.changed` carrying the run's current status before it<br/>
        /// starts tailing. A `: keepalive` comment arrives every 15 seconds so an<br/>
        /// intermediary does not time the connection out while the agent is<br/>
        /// thinking.<br/>
        /// Same read access as List Run Steps, and the same<br/>
        /// `402 durable_runs_not_in_plan` on a workspace without the grant.
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