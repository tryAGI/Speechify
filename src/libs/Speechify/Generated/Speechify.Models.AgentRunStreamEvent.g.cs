#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// One event on the run event stream. The `type` field discriminates the<br/>
    /// variants and mirrors the SSE `event:` name, so an event is identifiable<br/>
    /// from its `data:` payload alone - which matters most for<br/>
    /// `run.status.changed` and `run.ended`, whose bodies are otherwise<br/>
    /// identical. Ignore event types you do not recognize.
    /// </summary>
    public readonly partial struct AgentRunStreamEvent : global::System.IEquatable<AgentRunStreamEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Speechify.AgentRunStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// A journal step was committed. Everything an AgentRunStep carries is<br/>
        /// inlined here, so this is the same shape List Run Steps returns with the<br/>
        /// discriminator added. The SSE `id:` is the step's `seq`, which is what a<br/>
        /// reconnect resumes from through `Last-Event-ID`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.AgentRunStreamEventVariant1? RunStepAdded { get; init; }
#else
        public global::Speechify.AgentRunStreamEventVariant1? RunStepAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepAdded))]
#endif
        public bool IsRunStepAdded => RunStepAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunStepAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.AgentRunStreamEventVariant1? value)
        {
            value = RunStepAdded;
            return IsRunStepAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.AgentRunStreamEventVariant1 PickRunStepAdded() => IsRunStepAdded
            ? RunStepAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunStepAdded' but the value was {ToString()}.");

        /// <summary>
        /// A piece of the agent's answer, sent as it is written. It is only ever<br/>
        /// the answer, never the agent's plan, so appending every piece in order<br/>
        /// gives the reply. `seq` is the journal position the answer is written at<br/>
        /// and `offset` the number of characters (Unicode code points) of it<br/>
        /// before this piece; place the piece at its offset. `run.ended` closes<br/>
        /// the answer, and its `output.reply` is the copy to keep. The SSE `id:`<br/>
        /// records the position reached, so a reconnect through `Last-Event-ID`<br/>
        /// resumes without replaying text already rendered.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.AgentRunStreamEventVariant2? RunReplyDelta { get; init; }
#else
        public global::Speechify.AgentRunStreamEventVariant2? RunReplyDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunReplyDelta))]
#endif
        public bool IsRunReplyDelta => RunReplyDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunReplyDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.AgentRunStreamEventVariant2? value)
        {
            value = RunReplyDelta;
            return IsRunReplyDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.AgentRunStreamEventVariant2 PickRunReplyDelta() => IsRunReplyDelta
            ? RunReplyDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunReplyDelta' but the value was {ToString()}.");

        /// <summary>
        /// The run moved to a new status. Not terminal: a run reporting<br/>
        /// `requires_action` is waiting on a human and the stream keeps tailing,<br/>
        /// which is precisely when a client most needs to be told.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.AgentRunStreamEventVariant3? RunStatusChanged { get; init; }
#else
        public global::Speechify.AgentRunStreamEventVariant3? RunStatusChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStatusChanged))]
#endif
        public bool IsRunStatusChanged => RunStatusChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunStatusChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.AgentRunStreamEventVariant3? value)
        {
            value = RunStatusChanged;
            return IsRunStatusChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.AgentRunStreamEventVariant3 PickRunStatusChanged() => IsRunStatusChanged
            ? RunStatusChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunStatusChanged' but the value was {ToString()}.");

        /// <summary>
        /// The run settled, and this event carries its answer. It is the last event<br/>
        /// on the stream - there is no `[DONE]` sentinel - and it is everything a<br/>
        /// client needs, so following a run to completion takes no follow-up<br/>
        /// request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.AgentRunStreamEventVariant4? RunEnded { get; init; }
#else
        public global::Speechify.AgentRunStreamEventVariant4? RunEnded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunEnded))]
#endif
        public bool IsRunEnded => RunEnded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.AgentRunStreamEventVariant4? value)
        {
            value = RunEnded;
            return IsRunEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.AgentRunStreamEventVariant4 PickRunEnded() => IsRunEnded
            ? RunEnded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunEnded' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentRunStreamEvent(global::Speechify.AgentRunStreamEventVariant1 value) => new AgentRunStreamEvent((global::Speechify.AgentRunStreamEventVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.AgentRunStreamEventVariant1?(AgentRunStreamEvent @this) => @this.RunStepAdded;

        /// <summary>
        ///
        /// </summary>
        public AgentRunStreamEvent(global::Speechify.AgentRunStreamEventVariant1? value)
        {
            RunStepAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentRunStreamEvent FromRunStepAdded(global::Speechify.AgentRunStreamEventVariant1? value) => new AgentRunStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentRunStreamEvent(global::Speechify.AgentRunStreamEventVariant2 value) => new AgentRunStreamEvent((global::Speechify.AgentRunStreamEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.AgentRunStreamEventVariant2?(AgentRunStreamEvent @this) => @this.RunReplyDelta;

        /// <summary>
        ///
        /// </summary>
        public AgentRunStreamEvent(global::Speechify.AgentRunStreamEventVariant2? value)
        {
            RunReplyDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentRunStreamEvent FromRunReplyDelta(global::Speechify.AgentRunStreamEventVariant2? value) => new AgentRunStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentRunStreamEvent(global::Speechify.AgentRunStreamEventVariant3 value) => new AgentRunStreamEvent((global::Speechify.AgentRunStreamEventVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.AgentRunStreamEventVariant3?(AgentRunStreamEvent @this) => @this.RunStatusChanged;

        /// <summary>
        ///
        /// </summary>
        public AgentRunStreamEvent(global::Speechify.AgentRunStreamEventVariant3? value)
        {
            RunStatusChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentRunStreamEvent FromRunStatusChanged(global::Speechify.AgentRunStreamEventVariant3? value) => new AgentRunStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentRunStreamEvent(global::Speechify.AgentRunStreamEventVariant4 value) => new AgentRunStreamEvent((global::Speechify.AgentRunStreamEventVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.AgentRunStreamEventVariant4?(AgentRunStreamEvent @this) => @this.RunEnded;

        /// <summary>
        ///
        /// </summary>
        public AgentRunStreamEvent(global::Speechify.AgentRunStreamEventVariant4? value)
        {
            RunEnded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentRunStreamEvent FromRunEnded(global::Speechify.AgentRunStreamEventVariant4? value) => new AgentRunStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public AgentRunStreamEvent(
            global::Speechify.AgentRunStreamEventDiscriminatorType? type,
            global::Speechify.AgentRunStreamEventVariant1? runStepAdded,
            global::Speechify.AgentRunStreamEventVariant2? runReplyDelta,
            global::Speechify.AgentRunStreamEventVariant3? runStatusChanged,
            global::Speechify.AgentRunStreamEventVariant4? runEnded
            )
        {
            Type = type;

            RunStepAdded = runStepAdded;
            RunReplyDelta = runReplyDelta;
            RunStatusChanged = runStatusChanged;
            RunEnded = runEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RunEnded as object ??
            RunStatusChanged as object ??
            RunReplyDelta as object ??
            RunStepAdded as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RunStepAdded?.ToString() ??
            RunReplyDelta?.ToString() ??
            RunStatusChanged?.ToString() ??
            RunEnded?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRunStepAdded && !IsRunReplyDelta && !IsRunStatusChanged && !IsRunEnded || !IsRunStepAdded && IsRunReplyDelta && !IsRunStatusChanged && !IsRunEnded || !IsRunStepAdded && !IsRunReplyDelta && IsRunStatusChanged && !IsRunEnded || !IsRunStepAdded && !IsRunReplyDelta && !IsRunStatusChanged && IsRunEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.AgentRunStreamEventVariant1, TResult>? runStepAdded = null,
            global::System.Func<global::Speechify.AgentRunStreamEventVariant2, TResult>? runReplyDelta = null,
            global::System.Func<global::Speechify.AgentRunStreamEventVariant3, TResult>? runStatusChanged = null,
            global::System.Func<global::Speechify.AgentRunStreamEventVariant4, TResult>? runEnded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepAdded && runStepAdded != null)
            {
                return runStepAdded(RunStepAdded!);
            }
            else if (IsRunReplyDelta && runReplyDelta != null)
            {
                return runReplyDelta(RunReplyDelta!);
            }
            else if (IsRunStatusChanged && runStatusChanged != null)
            {
                return runStatusChanged(RunStatusChanged!);
            }
            else if (IsRunEnded && runEnded != null)
            {
                return runEnded(RunEnded!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Speechify.AgentRunStreamEventVariant1>? runStepAdded = null,

            global::System.Action<global::Speechify.AgentRunStreamEventVariant2>? runReplyDelta = null,

            global::System.Action<global::Speechify.AgentRunStreamEventVariant3>? runStatusChanged = null,

            global::System.Action<global::Speechify.AgentRunStreamEventVariant4>? runEnded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepAdded)
            {
                runStepAdded?.Invoke(RunStepAdded!);
            }
            else if (IsRunReplyDelta)
            {
                runReplyDelta?.Invoke(RunReplyDelta!);
            }
            else if (IsRunStatusChanged)
            {
                runStatusChanged?.Invoke(RunStatusChanged!);
            }
            else if (IsRunEnded)
            {
                runEnded?.Invoke(RunEnded!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Speechify.AgentRunStreamEventVariant1>? runStepAdded = null,
            global::System.Action<global::Speechify.AgentRunStreamEventVariant2>? runReplyDelta = null,
            global::System.Action<global::Speechify.AgentRunStreamEventVariant3>? runStatusChanged = null,
            global::System.Action<global::Speechify.AgentRunStreamEventVariant4>? runEnded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepAdded)
            {
                runStepAdded?.Invoke(RunStepAdded!);
            }
            else if (IsRunReplyDelta)
            {
                runReplyDelta?.Invoke(RunReplyDelta!);
            }
            else if (IsRunStatusChanged)
            {
                runStatusChanged?.Invoke(RunStatusChanged!);
            }
            else if (IsRunEnded)
            {
                runEnded?.Invoke(RunEnded!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunStepAdded,
                typeof(global::Speechify.AgentRunStreamEventVariant1),
                RunReplyDelta,
                typeof(global::Speechify.AgentRunStreamEventVariant2),
                RunStatusChanged,
                typeof(global::Speechify.AgentRunStreamEventVariant3),
                RunEnded,
                typeof(global::Speechify.AgentRunStreamEventVariant4),
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
        public bool Equals(AgentRunStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.AgentRunStreamEventVariant1?>.Default.Equals(RunStepAdded, other.RunStepAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.AgentRunStreamEventVariant2?>.Default.Equals(RunReplyDelta, other.RunReplyDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.AgentRunStreamEventVariant3?>.Default.Equals(RunStatusChanged, other.RunStatusChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.AgentRunStreamEventVariant4?>.Default.Equals(RunEnded, other.RunEnded)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentRunStreamEvent obj1, AgentRunStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentRunStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentRunStreamEvent obj1, AgentRunStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentRunStreamEvent o && Equals(o);
        }
    }
}
