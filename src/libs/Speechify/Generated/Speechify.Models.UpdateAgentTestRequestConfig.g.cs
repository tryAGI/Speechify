#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// Replaces the test config when present.
    /// </summary>
    public readonly partial struct UpdateAgentTestRequestConfig : global::System.IEquatable<UpdateAgentTestRequestConfig>
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
        public global::Speechify.ReplyConfig? ReplyConfig { get; init; }
#else
        public global::Speechify.ReplyConfig? ReplyConfig { get; }
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
            out global::Speechify.ReplyConfig? value)
        {
            value = ReplyConfig;
            return IsReplyConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.ReplyConfig PickReplyConfig() => IsReplyConfig
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
        public global::Speechify.ToolCallConfig? ToolCallConfig { get; init; }
#else
        public global::Speechify.ToolCallConfig? ToolCallConfig { get; }
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
            out global::Speechify.ToolCallConfig? value)
        {
            value = ToolCallConfig;
            return IsToolCallConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.ToolCallConfig PickToolCallConfig() => IsToolCallConfig
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
        public global::Speechify.SimulationConfig? SimulationConfig { get; init; }
#else
        public global::Speechify.SimulationConfig? SimulationConfig { get; }
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
            out global::Speechify.SimulationConfig? value)
        {
            value = SimulationConfig;
            return IsSimulationConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.SimulationConfig PickSimulationConfig() => IsSimulationConfig
            ? SimulationConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SimulationConfig' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateAgentTestRequestConfig(global::Speechify.ReplyConfig value) => new UpdateAgentTestRequestConfig((global::Speechify.ReplyConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.ReplyConfig?(UpdateAgentTestRequestConfig @this) => @this.ReplyConfig;

        /// <summary>
        ///
        /// </summary>
        public UpdateAgentTestRequestConfig(global::Speechify.ReplyConfig? value)
        {
            ReplyConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateAgentTestRequestConfig FromReplyConfig(global::Speechify.ReplyConfig? value) => new UpdateAgentTestRequestConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateAgentTestRequestConfig(global::Speechify.ToolCallConfig value) => new UpdateAgentTestRequestConfig((global::Speechify.ToolCallConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.ToolCallConfig?(UpdateAgentTestRequestConfig @this) => @this.ToolCallConfig;

        /// <summary>
        ///
        /// </summary>
        public UpdateAgentTestRequestConfig(global::Speechify.ToolCallConfig? value)
        {
            ToolCallConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateAgentTestRequestConfig FromToolCallConfig(global::Speechify.ToolCallConfig? value) => new UpdateAgentTestRequestConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateAgentTestRequestConfig(global::Speechify.SimulationConfig value) => new UpdateAgentTestRequestConfig((global::Speechify.SimulationConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.SimulationConfig?(UpdateAgentTestRequestConfig @this) => @this.SimulationConfig;

        /// <summary>
        ///
        /// </summary>
        public UpdateAgentTestRequestConfig(global::Speechify.SimulationConfig? value)
        {
            SimulationConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateAgentTestRequestConfig FromSimulationConfig(global::Speechify.SimulationConfig? value) => new UpdateAgentTestRequestConfig(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateAgentTestRequestConfig(
            global::Speechify.ReplyConfig? replyConfig,
            global::Speechify.ToolCallConfig? toolCallConfig,
            global::Speechify.SimulationConfig? simulationConfig
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
            global::System.Func<global::Speechify.ReplyConfig, TResult>? replyConfig = null,
            global::System.Func<global::Speechify.ToolCallConfig, TResult>? toolCallConfig = null,
            global::System.Func<global::Speechify.SimulationConfig, TResult>? simulationConfig = null,
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
            global::System.Action<global::Speechify.ReplyConfig>? replyConfig = null,

            global::System.Action<global::Speechify.ToolCallConfig>? toolCallConfig = null,

            global::System.Action<global::Speechify.SimulationConfig>? simulationConfig = null,
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
            global::System.Action<global::Speechify.ReplyConfig>? replyConfig = null,
            global::System.Action<global::Speechify.ToolCallConfig>? toolCallConfig = null,
            global::System.Action<global::Speechify.SimulationConfig>? simulationConfig = null,
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
                typeof(global::Speechify.ReplyConfig),
                ToolCallConfig,
                typeof(global::Speechify.ToolCallConfig),
                SimulationConfig,
                typeof(global::Speechify.SimulationConfig),
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
        public bool Equals(UpdateAgentTestRequestConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.ReplyConfig?>.Default.Equals(ReplyConfig, other.ReplyConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.ToolCallConfig?>.Default.Equals(ToolCallConfig, other.ToolCallConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.SimulationConfig?>.Default.Equals(SimulationConfig, other.SimulationConfig)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateAgentTestRequestConfig obj1, UpdateAgentTestRequestConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateAgentTestRequestConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateAgentTestRequestConfig obj1, UpdateAgentTestRequestConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateAgentTestRequestConfig o && Equals(o);
        }
    }
}
