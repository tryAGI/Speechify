
#nullable enable

namespace Speechify
{
    /// <summary>
    /// An agent-initiated turn as a job: what a backend polls to learn whether its instruction posted, and cancels while the worker has not started it.
    /// </summary>
    public sealed partial class ConversationPrompt
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// The one lifecycle vocabulary shared by every async job (batch<br/>
        /// calls, knowledge-base imports, agent-test runs, suite runs):<br/>
        /// `pending` → `running` → a terminal state.<br/>
        /// - `pending` - accepted but not yet executing (queued for a worker,<br/>
        ///   or deferred to a future scheduled time).<br/>
        /// - `running` - actively executing.<br/>
        /// - `completed` - ran to conclusion. The single terminal-success<br/>
        ///   verb. For a job that produces a pass/fail judgment (an agent-test<br/>
        ///   run), this means it produced a verdict - read the separate<br/>
        ///   `verdict` field for the judgment, not this status.<br/>
        /// - `failed` - could not complete (an infrastructure or input<br/>
        ///   failure), distinct from a `completed` job whose `verdict` is<br/>
        ///   `failed`.<br/>
        /// - `cancelled` - cancelled before reaching a natural terminal state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.JobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.JobStatus Status { get; set; }

        /// <summary>
        /// What the agent was asked to do, as sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Why a `failed` prompt never posted, in plain words: the conversation ended before the turn ran, the workspace's channel grant was withdrawn, the runtime gave up. Absent otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the worker picked the turn up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the prompt reached a terminal status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPrompt" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conversationId"></param>
        /// <param name="status">
        /// The one lifecycle vocabulary shared by every async job (batch<br/>
        /// calls, knowledge-base imports, agent-test runs, suite runs):<br/>
        /// `pending` → `running` → a terminal state.<br/>
        /// - `pending` - accepted but not yet executing (queued for a worker,<br/>
        ///   or deferred to a future scheduled time).<br/>
        /// - `running` - actively executing.<br/>
        /// - `completed` - ran to conclusion. The single terminal-success<br/>
        ///   verb. For a job that produces a pass/fail judgment (an agent-test<br/>
        ///   run), this means it produced a verdict - read the separate<br/>
        ///   `verdict` field for the judgment, not this status.<br/>
        /// - `failed` - could not complete (an infrastructure or input<br/>
        ///   failure), distinct from a `completed` job whose `verdict` is<br/>
        ///   `failed`.<br/>
        /// - `cancelled` - cancelled before reaching a natural terminal state.
        /// </param>
        /// <param name="instruction">
        /// What the agent was asked to do, as sent.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="error">
        /// Why a `failed` prompt never posted, in plain words: the conversation ended before the turn ran, the workspace's channel grant was withdrawn, the runtime gave up. Absent otherwise.
        /// </param>
        /// <param name="startedAt">
        /// When the worker picked the turn up.
        /// </param>
        /// <param name="endedAt">
        /// When the prompt reached a terminal status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationPrompt(
            string id,
            string conversationId,
            global::Speechify.JobStatus status,
            string instruction,
            global::System.DateTime createdAt,
            string? error,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Status = status;
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.Error = error;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPrompt" /> class.
        /// </summary>
        public ConversationPrompt()
        {
        }

    }
}