#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// Type-specific configuration. Must match the shape for the given `type`.
    /// </summary>
    public readonly partial struct TtsCreateAgentTestRequestConfig : global::System.IEquatable<TtsCreateAgentTestRequestConfig>
    {
        /// <summary>
        /// Configuration for a `reply` test. The runner sends `context` as<br/>
        /// a user message and asks an LLM judge to evaluate the agent response<br/>
        /// against `success_criteria`. Optional few-shot examples sharpen the<br/>
        /// judge's calibration. Use `initial_chat_history` to prepend prior<br/>
        /// turns before `context`; when the history already ends with a user<br/>
        /// message, `context` may be omitted and the agent is evaluated on<br/>
        /// its reply to that last history turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.TtsReplyConfig? ReplyConfig { get; init; }
#else
        public global::Speechify.TtsReplyConfig? ReplyConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReplyConfig))]
#endif
        public bool IsReplyConfig => ReplyConfig != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReplyConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.TtsReplyConfig? value)
        {
            value = ReplyConfig;
            return IsReplyConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.TtsReplyConfig PickReplyConfig() => IsReplyConfig
            ? ReplyConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReplyConfig' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickToolCallConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.TtsToolCallConfig? value)
        {
            value = ToolCallConfig;
            return IsToolCallConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.TtsToolCallConfig PickToolCallConfig() => IsToolCallConfig
            ? ToolCallConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCallConfig' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for a `simulation` test. An AI caller drives a<br/>
        /// multi-turn conversation with the agent according to `scenario`.<br/>
        /// After `max_turns` exchanges (or when the agent ends the call),<br/>
        /// the unified post-call evaluator scores the synthetic transcript<br/>
        /// against the agent's configured evaluation criteria + data<br/>
        /// collection fields. A test passes when no configured criterion<br/>
        /// fails and every `data_assertions` entry passes.
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
        public bool TryPickSimulationConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.TtsSimulationConfig? value)
        {
            value = SimulationConfig;
            return IsSimulationConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.TtsSimulationConfig PickSimulationConfig() => IsSimulationConfig
            ? SimulationConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SimulationConfig' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsCreateAgentTestRequestConfig(global::Speechify.TtsReplyConfig value) => new TtsCreateAgentTestRequestConfig((global::Speechify.TtsReplyConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsReplyConfig?(TtsCreateAgentTestRequestConfig @this) => @this.ReplyConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsCreateAgentTestRequestConfig(global::Speechify.TtsReplyConfig? value)
        {
            ReplyConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TtsCreateAgentTestRequestConfig FromReplyConfig(global::Speechify.TtsReplyConfig? value) => new TtsCreateAgentTestRequestConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsCreateAgentTestRequestConfig(global::Speechify.TtsToolCallConfig value) => new TtsCreateAgentTestRequestConfig((global::Speechify.TtsToolCallConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsToolCallConfig?(TtsCreateAgentTestRequestConfig @this) => @this.ToolCallConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsCreateAgentTestRequestConfig(global::Speechify.TtsToolCallConfig? value)
        {
            ToolCallConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TtsCreateAgentTestRequestConfig FromToolCallConfig(global::Speechify.TtsToolCallConfig? value) => new TtsCreateAgentTestRequestConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsCreateAgentTestRequestConfig(global::Speechify.TtsSimulationConfig value) => new TtsCreateAgentTestRequestConfig((global::Speechify.TtsSimulationConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsSimulationConfig?(TtsCreateAgentTestRequestConfig @this) => @this.SimulationConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsCreateAgentTestRequestConfig(global::Speechify.TtsSimulationConfig? value)
        {
            SimulationConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TtsCreateAgentTestRequestConfig FromSimulationConfig(global::Speechify.TtsSimulationConfig? value) => new TtsCreateAgentTestRequestConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public TtsCreateAgentTestRequestConfig(
            global::Speechify.TtsReplyConfig? replyConfig,
            global::Speechify.TtsToolCallConfig? toolCallConfig,
            global::Speechify.TtsSimulationConfig? simulationConfig
            )
        {
            ReplyConfig = replyConfig;
            ToolCallConfig = toolCallConfig;
            SimulationConfig = simulationConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SimulationConfig as object ??
            ToolCallConfig as object ??
            ReplyConfig as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReplyConfig?.ToString() ??
            ToolCallConfig?.ToString() ??
            SimulationConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReplyConfig && !IsToolCallConfig && !IsSimulationConfig || !IsReplyConfig && IsToolCallConfig && !IsSimulationConfig || !IsReplyConfig && !IsToolCallConfig && IsSimulationConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.TtsReplyConfig, TResult>? replyConfig = null,
            global::System.Func<global::Speechify.TtsToolCallConfig, TResult>? toolCallConfig = null,
            global::System.Func<global::Speechify.TtsSimulationConfig, TResult>? simulationConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReplyConfig && replyConfig != null)
            {
                return replyConfig(ReplyConfig!);
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
            global::System.Action<global::Speechify.TtsReplyConfig>? replyConfig = null,

            global::System.Action<global::Speechify.TtsToolCallConfig>? toolCallConfig = null,

            global::System.Action<global::Speechify.TtsSimulationConfig>? simulationConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReplyConfig)
            {
                replyConfig?.Invoke(ReplyConfig!);
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
        public void Switch(
            global::System.Action<global::Speechify.TtsReplyConfig>? replyConfig = null,
            global::System.Action<global::Speechify.TtsToolCallConfig>? toolCallConfig = null,
            global::System.Action<global::Speechify.TtsSimulationConfig>? simulationConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReplyConfig)
            {
                replyConfig?.Invoke(ReplyConfig!);
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
                ReplyConfig,
                typeof(global::Speechify.TtsReplyConfig),
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
        public bool Equals(TtsCreateAgentTestRequestConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsReplyConfig?>.Default.Equals(ReplyConfig, other.ReplyConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsToolCallConfig?>.Default.Equals(ToolCallConfig, other.ToolCallConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsSimulationConfig?>.Default.Equals(SimulationConfig, other.SimulationConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TtsCreateAgentTestRequestConfig obj1, TtsCreateAgentTestRequestConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TtsCreateAgentTestRequestConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TtsCreateAgentTestRequestConfig obj1, TtsCreateAgentTestRequestConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TtsCreateAgentTestRequestConfig o && Equals(o);
        }
    }
}
