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
        /// piece of text the agent writes, as it writes it, a<br/>
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
        /// `run.reply.delta` carries the agent's text piece by piece, so a chat<br/>
        /// built on runs shows the answer forming instead of a spinner. Each<br/>
        /// piece names the journal position it is written at (`seq`) and how<br/>
        /// many characters of that position's text precede it (`offset`). Keep<br/>
        /// one buffer per `seq`: append a piece whose `offset` equals what you<br/>
        /// hold, and on any other `offset` cut the buffer to it first (that only<br/>
        /// happens after a step was re-executed, and means the earlier text is<br/>
        /// void). Text is counted in Unicode code points.<br/>
        /// Which text a buffer turns out to be is settled by the event that<br/>
        /// closes it. A `run.step.added` at the same `seq` closes it as that<br/>
        /// step's `content` - the plan of a tool call, which the agent wrote<br/>
        /// before deciding to act - and the next piece starts a new buffer at a<br/>
        /// later `seq`. `run.ended` closes the open buffer as the reply, and its<br/>
        /// `output.reply` is the authoritative copy: replace the buffer with it.<br/>
        /// A `run.ended` with no `output` (the run failed, was cancelled, or<br/>
        /// stopped short) means the open buffer was abandoned mid-sentence -<br/>
        /// show it as such or drop it; it is not an answer. A run parked in<br/>
        /// `requires_action` never leaves a buffer open, because the text it<br/>
        /// wrote before parking lands as the plan step first. A client that<br/>
        /// never subscribes to `run.reply.delta` sees exactly the stream it saw<br/>
        /// before the event existed. An agent on a custom LLM endpoint answers<br/>
        /// whole, with no pieces before the step lands.<br/>
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