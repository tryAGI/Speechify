
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Controls tool-call interception during a test run.
    /// </summary>
    public sealed partial class TtsToolMockConfig
    {
        /// <summary>
        /// Controls which tool calls the runner intercepts during a run.<br/>
        /// System tools (`end_call`, `transfer_to_number`, etc.) are never<br/>
        /// mocked regardless of strategy.<br/>
        /// - `none` - no interception; all tools are called normally.<br/>
        /// - `all` - every non-system tool call is intercepted and matched<br/>
        ///   against the `mocks` list.<br/>
        /// - `selected` - only tools explicitly listed in `mocks` are<br/>
        ///   intercepted; others are called normally.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsMockingStrategyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsMockingStrategy Strategy { get; set; }

        /// <summary>
        /// Canned responses for specific tools (order matters - first match wins).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mocks")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsToolMock>? Mocks { get; set; }

        /// <summary>
        /// Fallback when a mockable tool is called but no configured mock<br/>
        /// matches the call arguments.<br/>
        /// - `call_real_tool` - pass-through: actually invoke the underlying tool.<br/>
        /// - `finish_with_error` - fail: short-circuit the run to an `error`<br/>
        ///   status. Useful when a test wants to assert that a specific mocked<br/>
        ///   response path is taken - any unmocked tool call aborts the run.<br/>
        /// - `skip` - return an empty stub (`{"skipped":true}`) to the agent so<br/>
        ///   the simulation proceeds without treating the call as a failure.<br/>
        ///   Useful when a tool's output is irrelevant to the behaviour under<br/>
        ///   test but the model may still decide to call it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_match_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsNoMatchBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsNoMatchBehavior NoMatchBehavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsToolMockConfig" /> class.
        /// </summary>
        /// <param name="strategy">
        /// Controls which tool calls the runner intercepts during a run.<br/>
        /// System tools (`end_call`, `transfer_to_number`, etc.) are never<br/>
        /// mocked regardless of strategy.<br/>
        /// - `none` - no interception; all tools are called normally.<br/>
        /// - `all` - every non-system tool call is intercepted and matched<br/>
        ///   against the `mocks` list.<br/>
        /// - `selected` - only tools explicitly listed in `mocks` are<br/>
        ///   intercepted; others are called normally.
        /// </param>
        /// <param name="noMatchBehavior">
        /// Fallback when a mockable tool is called but no configured mock<br/>
        /// matches the call arguments.<br/>
        /// - `call_real_tool` - pass-through: actually invoke the underlying tool.<br/>
        /// - `finish_with_error` - fail: short-circuit the run to an `error`<br/>
        ///   status. Useful when a test wants to assert that a specific mocked<br/>
        ///   response path is taken - any unmocked tool call aborts the run.<br/>
        /// - `skip` - return an empty stub (`{"skipped":true}`) to the agent so<br/>
        ///   the simulation proceeds without treating the call as a failure.<br/>
        ///   Useful when a tool's output is irrelevant to the behaviour under<br/>
        ///   test but the model may still decide to call it.
        /// </param>
        /// <param name="mocks">
        /// Canned responses for specific tools (order matters - first match wins).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsToolMockConfig(
            global::Speechify.TtsMockingStrategy strategy,
            global::Speechify.TtsNoMatchBehavior noMatchBehavior,
            global::System.Collections.Generic.IList<global::Speechify.TtsToolMock>? mocks)
        {
            this.Strategy = strategy;
            this.Mocks = mocks;
            this.NoMatchBehavior = noMatchBehavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsToolMockConfig" /> class.
        /// </summary>
        public TtsToolMockConfig()
        {
        }
    }
}