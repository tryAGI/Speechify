#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// Type-specific configuration document.
    /// </summary>
    public readonly partial struct TtsAgentTestConfig : global::System.IEquatable<TtsAgentTestConfig>
    {
        /// <summary>
        /// Configuration for a `scenario` test. The runner sends `context` as<br/>
        /// a user message and asks an LLM judge to evaluate the agent response<br/>
        /// against `success_criteria`. Optional few-shot examples sharpen the<br/>
        /// judge's calibration. Use `initial_chat_history` to prepend prior<br/>
        /// turns before `context`; when the history already ends with a user<br/>
        /// message, `context` may be omitted and the agent is evaluated on<br/>
        /// its reply to that last history turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.TtsScenarioConfig? ScenarioConfig { get; init; }
#else
        public global::Speechify.TtsScenarioConfig? ScenarioConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScenarioConfig))]
#endif
        public bool IsScenarioConfig => ScenarioConfig != null;

        /// <summary>
        /// Configuration for a `tool` test. The runner sends `context` as a<br/>
        /// user message and asserts that the agent calls `expected_tool` with<br/>
        /// arguments matching all `parameter_checks`. Use<br/>
        /// `initial_chat_history` to test tool invocations that only make<br/>
        /// sense mid-conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.TtsToolCallConfig? ToolCallConfig { get; init; }
#else
        public global::Speechify.TtsToolCallConfig? ToolCallConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallConfig))]
#endif
        public bool IsToolCallConfig => ToolCallConfig != null;

        /// <summary>
        /// Configuration for a `simulation` test. An AI caller drives a<br/>
        /// multi-turn conversation with the agent according to `scenario`.<br/>
        /// After `max_turns` exchanges (or when the agent ends the call), an<br/>
        /// LLM judge evaluates whether `success_condition` was met.<br/>
        /// Use `initial_chat_history` to seed the conversation at a specific<br/>
        /// mid-flow state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.TtsSimulationConfig? SimulationConfig { get; init; }
#else
        public global::Speechify.TtsSimulationConfig? SimulationConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SimulationConfig))]
#endif
        public bool IsSimulationConfig => SimulationConfig != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsAgentTestConfig(global::Speechify.TtsScenarioConfig value) => new TtsAgentTestConfig((global::Speechify.TtsScenarioConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsScenarioConfig?(TtsAgentTestConfig @this) => @this.ScenarioConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsAgentTestConfig(global::Speechify.TtsScenarioConfig? value)
        {
            ScenarioConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsAgentTestConfig(global::Speechify.TtsToolCallConfig value) => new TtsAgentTestConfig((global::Speechify.TtsToolCallConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsToolCallConfig?(TtsAgentTestConfig @this) => @this.ToolCallConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsAgentTestConfig(global::Speechify.TtsToolCallConfig? value)
        {
            ToolCallConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsAgentTestConfig(global::Speechify.TtsSimulationConfig value) => new TtsAgentTestConfig((global::Speechify.TtsSimulationConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsSimulationConfig?(TtsAgentTestConfig @this) => @this.SimulationConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsAgentTestConfig(global::Speechify.TtsSimulationConfig? value)
        {
            SimulationConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TtsAgentTestConfig(
            global::Speechify.TtsScenarioConfig? scenarioConfig,
            global::Speechify.TtsToolCallConfig? toolCallConfig,
            global::Speechify.TtsSimulationConfig? simulationConfig
            )
        {
            ScenarioConfig = scenarioConfig;
            ToolCallConfig = toolCallConfig;
            SimulationConfig = simulationConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SimulationConfig as object ??
            ToolCallConfig as object ??
            ScenarioConfig as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScenarioConfig?.ToString() ??
            ToolCallConfig?.ToString() ??
            SimulationConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScenarioConfig && !IsToolCallConfig && !IsSimulationConfig || !IsScenarioConfig && IsToolCallConfig && !IsSimulationConfig || !IsScenarioConfig && !IsToolCallConfig && IsSimulationConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.TtsScenarioConfig?, TResult>? scenarioConfig = null,
            global::System.Func<global::Speechify.TtsToolCallConfig?, TResult>? toolCallConfig = null,
            global::System.Func<global::Speechify.TtsSimulationConfig?, TResult>? simulationConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScenarioConfig && scenarioConfig != null)
            {
                return scenarioConfig(ScenarioConfig!);
            }
            else if (IsToolCallConfig && toolCallConfig != null)
            {
                return toolCallConfig(ToolCallConfig!);
            }
            else if (IsSimulationConfig && simulationConfig != null)
            {
                return simulationConfig(SimulationConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Speechify.TtsScenarioConfig?>? scenarioConfig = null,
            global::System.Action<global::Speechify.TtsToolCallConfig?>? toolCallConfig = null,
            global::System.Action<global::Speechify.TtsSimulationConfig?>? simulationConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScenarioConfig)
            {
                scenarioConfig?.Invoke(ScenarioConfig!);
            }
            else if (IsToolCallConfig)
            {
                toolCallConfig?.Invoke(ToolCallConfig!);
            }
            else if (IsSimulationConfig)
            {
                simulationConfig?.Invoke(SimulationConfig!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScenarioConfig,
                typeof(global::Speechify.TtsScenarioConfig),
                ToolCallConfig,
                typeof(global::Speechify.TtsToolCallConfig),
                SimulationConfig,
                typeof(global::Speechify.TtsSimulationConfig),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TtsAgentTestConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsScenarioConfig?>.Default.Equals(ScenarioConfig, other.ScenarioConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsToolCallConfig?>.Default.Equals(ToolCallConfig, other.ToolCallConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsSimulationConfig?>.Default.Equals(SimulationConfig, other.SimulationConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TtsAgentTestConfig obj1, TtsAgentTestConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TtsAgentTestConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TtsAgentTestConfig obj1, TtsAgentTestConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TtsAgentTestConfig o && Equals(o);
        }
    }
}
