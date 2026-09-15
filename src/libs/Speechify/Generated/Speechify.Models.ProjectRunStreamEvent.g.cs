#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// One event on the project run stream. The `type` field discriminates the<br/>
    /// variants and mirrors the SSE `event:` name, so an event is identifiable<br/>
    /// from its `data:` payload alone. Ignore event types you do not recognize.
    /// </summary>
    public readonly partial struct ProjectRunStreamEvent : global::System.IEquatable<ProjectRunStreamEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Speechify.ProjectRunStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// A run that has not finished, as it stands: sent for every live run when<br/>
        /// the stream opens, when a run appears, and whenever its `status` or<br/>
        /// `pending_action` changes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.ProjectRunStreamEventVariant1? RunUpdated { get; init; }
#else
        public global::Speechify.ProjectRunStreamEventVariant1? RunUpdated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunUpdated))]
#endif
        public bool IsRunUpdated => RunUpdated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.ProjectRunStreamEventVariant1? value)
        {
            value = RunUpdated;
            return IsRunUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.ProjectRunStreamEventVariant1 PickRunUpdated() => IsRunUpdated
            ? RunUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunUpdated' but the value was {ToString()}.");

        /// <summary>
        /// A run settled. It is the run's last event on the stream; the answer is<br/>
        /// not on it, so read the run with Get Run when you need what it produced.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.ProjectRunStreamEventVariant2? RunEnded { get; init; }
#else
        public global::Speechify.ProjectRunStreamEventVariant2? RunEnded { get; }
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
            out global::Speechify.ProjectRunStreamEventVariant2? value)
        {
            value = RunEnded;
            return IsRunEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.ProjectRunStreamEventVariant2 PickRunEnded() => IsRunEnded
            ? RunEnded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunEnded' but the value was {ToString()}.");

        /// <summary>
        /// Every run that was live when this connection opened has been sent.<br/>
        /// Sent once per connection, after the opening `run.updated` events.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.ProjectRunStreamEventVariant3? RunsSynced { get; init; }
#else
        public global::Speechify.ProjectRunStreamEventVariant3? RunsSynced { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunsSynced))]
#endif
        public bool IsRunsSynced => RunsSynced != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunsSynced(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.ProjectRunStreamEventVariant3? value)
        {
            value = RunsSynced;
            return IsRunsSynced;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.ProjectRunStreamEventVariant3 PickRunsSynced() => IsRunsSynced
            ? RunsSynced!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunsSynced' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProjectRunStreamEvent(global::Speechify.ProjectRunStreamEventVariant1 value) => new ProjectRunStreamEvent((global::Speechify.ProjectRunStreamEventVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.ProjectRunStreamEventVariant1?(ProjectRunStreamEvent @this) => @this.RunUpdated;

        /// <summary>
        ///
        /// </summary>
        public ProjectRunStreamEvent(global::Speechify.ProjectRunStreamEventVariant1? value)
        {
            RunUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProjectRunStreamEvent FromRunUpdated(global::Speechify.ProjectRunStreamEventVariant1? value) => new ProjectRunStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProjectRunStreamEvent(global::Speechify.ProjectRunStreamEventVariant2 value) => new ProjectRunStreamEvent((global::Speechify.ProjectRunStreamEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.ProjectRunStreamEventVariant2?(ProjectRunStreamEvent @this) => @this.RunEnded;

        /// <summary>
        ///
        /// </summary>
        public ProjectRunStreamEvent(global::Speechify.ProjectRunStreamEventVariant2? value)
        {
            RunEnded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProjectRunStreamEvent FromRunEnded(global::Speechify.ProjectRunStreamEventVariant2? value) => new ProjectRunStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProjectRunStreamEvent(global::Speechify.ProjectRunStreamEventVariant3 value) => new ProjectRunStreamEvent((global::Speechify.ProjectRunStreamEventVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.ProjectRunStreamEventVariant3?(ProjectRunStreamEvent @this) => @this.RunsSynced;

        /// <summary>
        ///
        /// </summary>
        public ProjectRunStreamEvent(global::Speechify.ProjectRunStreamEventVariant3? value)
        {
            RunsSynced = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProjectRunStreamEvent FromRunsSynced(global::Speechify.ProjectRunStreamEventVariant3? value) => new ProjectRunStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ProjectRunStreamEvent(
            global::Speechify.ProjectRunStreamEventDiscriminatorType? type,
            global::Speechify.ProjectRunStreamEventVariant1? runUpdated,
            global::Speechify.ProjectRunStreamEventVariant2? runEnded,
            global::Speechify.ProjectRunStreamEventVariant3? runsSynced
            )
        {
            Type = type;

            RunUpdated = runUpdated;
            RunEnded = runEnded;
            RunsSynced = runsSynced;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RunsSynced as object ??
            RunEnded as object ??
            RunUpdated as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RunUpdated?.ToString() ??
            RunEnded?.ToString() ??
            RunsSynced?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRunUpdated && !IsRunEnded && !IsRunsSynced || !IsRunUpdated && IsRunEnded && !IsRunsSynced || !IsRunUpdated && !IsRunEnded && IsRunsSynced;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.ProjectRunStreamEventVariant1, TResult>? runUpdated = null,
            global::System.Func<global::Speechify.ProjectRunStreamEventVariant2, TResult>? runEnded = null,
            global::System.Func<global::Speechify.ProjectRunStreamEventVariant3, TResult>? runsSynced = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunUpdated && runUpdated != null)
            {
                return runUpdated(RunUpdated!);
            }
            else if (IsRunEnded && runEnded != null)
            {
                return runEnded(RunEnded!);
            }
            else if (IsRunsSynced && runsSynced != null)
            {
                return runsSynced(RunsSynced!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Speechify.ProjectRunStreamEventVariant1>? runUpdated = null,

            global::System.Action<global::Speechify.ProjectRunStreamEventVariant2>? runEnded = null,

            global::System.Action<global::Speechify.ProjectRunStreamEventVariant3>? runsSynced = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunUpdated)
            {
                runUpdated?.Invoke(RunUpdated!);
            }
            else if (IsRunEnded)
            {
                runEnded?.Invoke(RunEnded!);
            }
            else if (IsRunsSynced)
            {
                runsSynced?.Invoke(RunsSynced!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Speechify.ProjectRunStreamEventVariant1>? runUpdated = null,
            global::System.Action<global::Speechify.ProjectRunStreamEventVariant2>? runEnded = null,
            global::System.Action<global::Speechify.ProjectRunStreamEventVariant3>? runsSynced = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunUpdated)
            {
                runUpdated?.Invoke(RunUpdated!);
            }
            else if (IsRunEnded)
            {
                runEnded?.Invoke(RunEnded!);
            }
            else if (IsRunsSynced)
            {
                runsSynced?.Invoke(RunsSynced!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunUpdated,
                typeof(global::Speechify.ProjectRunStreamEventVariant1),
                RunEnded,
                typeof(global::Speechify.ProjectRunStreamEventVariant2),
                RunsSynced,
                typeof(global::Speechify.ProjectRunStreamEventVariant3),
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
        public bool Equals(ProjectRunStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.ProjectRunStreamEventVariant1?>.Default.Equals(RunUpdated, other.RunUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.ProjectRunStreamEventVariant2?>.Default.Equals(RunEnded, other.RunEnded) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.ProjectRunStreamEventVariant3?>.Default.Equals(RunsSynced, other.RunsSynced)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProjectRunStreamEvent obj1, ProjectRunStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProjectRunStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProjectRunStreamEvent obj1, ProjectRunStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProjectRunStreamEvent o && Equals(o);
        }
    }
}
