#nullable enable

namespace Speechify
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Stream Project Run Events<br/>
        /// Server-Sent Events stream of every run in one project, so an<br/>
        /// application learns that work started, stopped for a person or<br/>
        /// finished without naming a run or an agent, and without polling the<br/>
        /// run list.<br/>
        /// Each event carries a run's lifecycle: its `status`, who it acts for<br/>
        /// (`user_identity`), its `metadata` - including `metadata.trigger`,<br/>
        /// which says whether a caller, a schedule or a webhook started it - its<br/>
        /// lineage, and while it waits on a person, the `pending_action` it is<br/>
        /// asking about. It never carries what the run was asked or what it<br/>
        /// answered: follow one run with Stream Run Events for its steps and its<br/>
        /// reply as it is written, or read it with Get Run.<br/>
        /// ## What arrives<br/>
        /// On every connection, including a reconnect:<br/>
        /// 1. `run.updated` for each run in the project that has not finished,<br/>
        ///    oldest first, so a client that connects late sees the work<br/>
        ///    already in flight.<br/>
        /// 2. `runs.synced`, once. Every run that was live when the stream<br/>
        ///    opened has now been sent: replace the live runs you hold with the<br/>
        ///    ones this connection sent.<br/>
        /// After that:<br/>
        /// - `run.updated` when a run appears, whatever started it, and whenever<br/>
        ///   its `status` or `pending_action` changes. A run that parks again on<br/>
        ///   a new action arrives again, carrying the new `pending_action`.<br/>
        /// - `run.ended` when a run settles (`succeeded`, `failed`, `canceled` or<br/>
        ///   `expired`). It is the run's last event on this stream.<br/>
        /// Each event carries the run as it stands, not a change to apply: key<br/>
        /// what you hold by `id` and replace it. The stream reports where a run<br/>
        /// is rather than every status it passed through, so a status a run<br/>
        /// entered and left within about a second may never appear. A delegated<br/>
        /// child is its own run, with `parent_run_id` set. Ignore event types you<br/>
        /// do not recognize.<br/>
        /// ## The stream is expected to reconnect<br/>
        /// **The server closes the connection after 4 minutes**, and a network<br/>
        /// drop can close it sooner. The response opens with `retry: 2000`, so a<br/>
        /// browser `EventSource` reconnects on its own; a hand-rolled client must<br/>
        /// reconnect and send the id of the last event it received as<br/>
        /// `Last-Event-ID`. The id is an opaque position: send it back unchanged.<br/>
        /// A reconnect within 10 minutes is sent a `run.ended` for every run that<br/>
        /// finished while it was away, so delivery is at least once: a<br/>
        /// `run.ended` you already hold can arrive again. After a longer absence,<br/>
        /// a run you held as live that is missing from the snapshot has finished;<br/>
        /// read it with Get Run. A `: keepalive` comment arrives every 15 seconds<br/>
        /// so an intermediary does not time the connection out on a quiet<br/>
        /// project.<br/>
        /// One connection covers every run in the project, and the stream is not<br/>
        /// metered: its read load is one small query a second, plus a read of the<br/>
        /// live runs when it connects.<br/>
        /// Same read access as List Runs, and the same<br/>
        /// `402 durable_runs_not_in_plan` on a workspace without the grant.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Speechify.ProjectRunStreamEvent> StreamProjectEventsAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}