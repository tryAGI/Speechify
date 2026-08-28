
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Union-like result of a completed test run. Exactly one of<br/>
    /// `reply`, `tool_call`, or `simulation` is populated, matching<br/>
    /// the `test_type`.
    /// </summary>
    public sealed partial class TestRunResult
    {
        /// <summary>
        /// Discriminates the shape of `AgentTest.config`.<br/>
        /// - `reply` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TestType TestType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// Top-level verdict explanation duplicated from the inner result for quick rendering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rationale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply")]
        public global::Speechify.ReplyResult? Reply { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call")]
        public global::Speechify.ToolCallResult? ToolCall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulation")]
        public global::Speechify.SimulationResult? Simulation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunResult" /> class.
        /// </summary>
        /// <param name="testType">
        /// Discriminates the shape of `AgentTest.config`.<br/>
        /// - `reply` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </param>
        /// <param name="passed"></param>
        /// <param name="rationale">
        /// Top-level verdict explanation duplicated from the inner result for quick rendering.
        /// </param>
        /// <param name="durationMs"></param>
        /// <param name="reply"></param>
        /// <param name="toolCall"></param>
        /// <param name="simulation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestRunResult(
            global::Speechify.TestType testType,
            bool passed,
            string rationale,
            long durationMs,
            global::Speechify.ReplyResult? reply,
            global::Speechify.ToolCallResult? toolCall,
            global::Speechify.SimulationResult? simulation)
        {
            this.TestType = testType;
            this.Passed = passed;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.DurationMs = durationMs;
            this.Reply = reply;
            this.ToolCall = toolCall;
            this.Simulation = simulation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunResult" /> class.
        /// </summary>
        public TestRunResult()
        {
        }

    }
}