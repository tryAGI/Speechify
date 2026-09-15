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
        /// same shape List Run Steps returns), a `run.reply.delta` event for each<br/>
        /// piece of the agent's answer, as it writes it, a<br/>
        /// `run.status.changed` event when the run's status moves, and a terminal<br/>
        /// `run.ended` event carrying the final status and, when the run stopped<br/>
        /// short, its `incomplete_reason`. Consumers must ignore unknown event<br/>
        /// types.<br/>
        /// A picture or chart the agent makes arrives before the run ends: the<br/>
        /// `observation` step for the tool call that made it carries the file<br/>
        /// under `files`, so a client can show it the moment that step is<br/>
        /// delivered. `run.ended` lists every file the run produced.<br/>
        /// A run waiting on a human approval is not terminal: the stream reports<br/>
        /// `requires_action` and keeps tailing, so the client learns it has<br/>
        /// something to decide.<br/>
        /// ## The reply arrives as it is written<br/>
        /// `run.reply.delta` carries the agent's answer piece by piece, so a chat<br/>
        /// built on runs shows the answer forming instead of a spinner. It<br/>
        /// carries the answer and nothing else: what the agent writes on the way<br/>
        /// to it, such as the plan behind a tool call, never rides this event and<br/>
        /// reaches the stream only as the `content` of a `run.step.added` plan<br/>
        /// step. Appending the pieces in order gives the answer, so a piece can be<br/>
        /// shown the moment it arrives.<br/>
        /// Each piece names the journal position the answer is written at<br/>
        /// (`seq`) and how many characters of it precede the piece (`offset`).<br/>
        /// Append a piece whose `offset` equals what you hold; on any other<br/>
        /// `offset`, or a different `seq`, cut what you hold to that `offset`<br/>
        /// first. That only happens after a step was re-executed, and means the<br/>
        /// earlier text is void. Text is counted in Unicode code points.<br/>
        /// `run.ended` closes the answer, and its `output.reply` is the<br/>
        /// authoritative copy: replace what you hold with it. A `run.ended` with<br/>
        /// no `output` (the run failed, was cancelled, or stopped short) means the<br/>
        /// answer was abandoned mid-sentence - show it as such or drop it. A<br/>
        /// client that never subscribes to `run.reply.delta` sees exactly the<br/>
        /// stream it saw before the event existed.<br/>
        /// Not every run streams its answer, because not every model says which<br/>
        /// of its text is the answer while writing it. The platform default<br/>
        /// model does. An agent on another model or on a custom LLM endpoint, and<br/>
        /// a run with an `output_schema` (whose answer is not final until it is<br/>
        /// checked), answers whole: no pieces, and the reply on `run.ended`.<br/>
        /// Following a run costs nothing beyond the run: the stream is not<br/>
        /// metered, and its read load is a few small queries per second per<br/>
        /// subscriber, a little more while the answer is being written.<br/>
        /// ## The stream is expected to reconnect<br/>
        /// **The server closes the connection after 4 minutes whether or not the<br/>
        /// run has settled**, so a long run spans several connections. Only<br/>
        /// `run.ended` means the run is over - a closed socket does not. The<br/>
        /// response opens with `retry: 2000`, so a browser `EventSource`<br/>
        /// reconnects on its own; a hand-rolled client must do the same.<br/>
        /// Resume with the standard `Last-Event-ID` header. Step events carry<br/>
        /// their `seq` as the event id; reply pieces carry the seq of the last<br/>
        /// step plus the position reached in the text being written, so a<br/>
        /// reconnect continues exactly where it left off and never replays text<br/>
        /// the client already rendered. Status events carry no id, and an absent<br/>
        /// or unparseable `Last-Event-ID` replays the journal from the beginning<br/>
        /// rather than skipping it. On every connection, including a resume, the<br/>
        /// server emits one `run.status.changed` carrying the run's current<br/>
        /// status before it starts tailing. A `: keepalive` comment arrives every<br/>
        /// 15 seconds so an intermediary does not time the connection out while<br/>
        /// the agent is thinking.<br/>
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