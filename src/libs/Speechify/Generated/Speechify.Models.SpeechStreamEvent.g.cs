#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// One event on the POST /v1/audio/stream/with-timestamps stream. The<br/>
    /// `type` field discriminates the variants and mirrors the SSE `event:`<br/>
    /// name, so an event is identifiable from its `data:` payload alone.
    /// </summary>
    public readonly partial struct SpeechStreamEvent : global::System.IEquatable<SpeechStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.SpeechStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// A run of synthesized audio, the speech marks that became final with it,<br/>
        /// or both - a chunk may carry only one of the two, and the last chunk of<br/>
        /// a stream is often marks-only. Mark times are absolute milliseconds from<br/>
        /// the start of the synthesis: concatenate the audio chunks into one<br/>
        /// stream and apply the marks against that single timeline. Which chunk a<br/>
        /// mark arrives on is a delivery detail and carries no meaning.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.SpeechStreamEventVariant1? SpeechChunk { get; init; }
#else
        public global::Speechify.SpeechStreamEventVariant1? SpeechChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechChunk))]
#endif
        public bool IsSpeechChunk => SpeechChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeechChunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.SpeechStreamEventVariant1? value)
        {
            value = SpeechChunk;
            return IsSpeechChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.SpeechStreamEventVariant1 PickSpeechChunk() => IsSpeechChunk
            ? SpeechChunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechChunk' but the value was {ToString()}.");

        /// <summary>
        /// Terminal event: the synthesis completed and no further events follow.<br/>
        /// There is no `[DONE]` sentinel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.SpeechStreamEventVariant2? SpeechDone { get; init; }
#else
        public global::Speechify.SpeechStreamEventVariant2? SpeechDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechDone))]
#endif
        public bool IsSpeechDone => SpeechDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeechDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.SpeechStreamEventVariant2? value)
        {
            value = SpeechDone;
            return IsSpeechDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.SpeechStreamEventVariant2 PickSpeechDone() => IsSpeechDone
            ? SpeechDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechDone' but the value was {ToString()}.");

        /// <summary>
        /// Terminal event carrying the standard error envelope, emitted when a<br/>
        /// failure happens after the stream has started and the status code is<br/>
        /// already committed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.SpeechStreamEventVariant3? SpeechError { get; init; }
#else
        public global::Speechify.SpeechStreamEventVariant3? SpeechError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechError))]
#endif
        public bool IsSpeechError => SpeechError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeechError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.SpeechStreamEventVariant3? value)
        {
            value = SpeechError;
            return IsSpeechError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.SpeechStreamEventVariant3 PickSpeechError() => IsSpeechError
            ? SpeechError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechError' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeechStreamEvent(global::Speechify.SpeechStreamEventVariant1 value) => new SpeechStreamEvent((global::Speechify.SpeechStreamEventVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.SpeechStreamEventVariant1?(SpeechStreamEvent @this) => @this.SpeechChunk;

        /// <summary>
        /// 
        /// </summary>
        public SpeechStreamEvent(global::Speechify.SpeechStreamEventVariant1? value)
        {
            SpeechChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeechStreamEvent FromSpeechChunk(global::Speechify.SpeechStreamEventVariant1? value) => new SpeechStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeechStreamEvent(global::Speechify.SpeechStreamEventVariant2 value) => new SpeechStreamEvent((global::Speechify.SpeechStreamEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.SpeechStreamEventVariant2?(SpeechStreamEvent @this) => @this.SpeechDone;

        /// <summary>
        /// 
        /// </summary>
        public SpeechStreamEvent(global::Speechify.SpeechStreamEventVariant2? value)
        {
            SpeechDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeechStreamEvent FromSpeechDone(global::Speechify.SpeechStreamEventVariant2? value) => new SpeechStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeechStreamEvent(global::Speechify.SpeechStreamEventVariant3 value) => new SpeechStreamEvent((global::Speechify.SpeechStreamEventVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.SpeechStreamEventVariant3?(SpeechStreamEvent @this) => @this.SpeechError;

        /// <summary>
        /// 
        /// </summary>
        public SpeechStreamEvent(global::Speechify.SpeechStreamEventVariant3? value)
        {
            SpeechError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeechStreamEvent FromSpeechError(global::Speechify.SpeechStreamEventVariant3? value) => new SpeechStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public SpeechStreamEvent(
            global::Speechify.SpeechStreamEventDiscriminatorType? type,
            global::Speechify.SpeechStreamEventVariant1? speechChunk,
            global::Speechify.SpeechStreamEventVariant2? speechDone,
            global::Speechify.SpeechStreamEventVariant3? speechError
            )
        {
            Type = type;

            SpeechChunk = speechChunk;
            SpeechDone = speechDone;
            SpeechError = speechError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpeechError as object ??
            SpeechDone as object ??
            SpeechChunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SpeechChunk?.ToString() ??
            SpeechDone?.ToString() ??
            SpeechError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpeechChunk && !IsSpeechDone && !IsSpeechError || !IsSpeechChunk && IsSpeechDone && !IsSpeechError || !IsSpeechChunk && !IsSpeechDone && IsSpeechError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.SpeechStreamEventVariant1, TResult>? speechChunk = null,
            global::System.Func<global::Speechify.SpeechStreamEventVariant2, TResult>? speechDone = null,
            global::System.Func<global::Speechify.SpeechStreamEventVariant3, TResult>? speechError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeechChunk && speechChunk != null)
            {
                return speechChunk(SpeechChunk!);
            }
            else if (IsSpeechDone && speechDone != null)
            {
                return speechDone(SpeechDone!);
            }
            else if (IsSpeechError && speechError != null)
            {
                return speechError(SpeechError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Speechify.SpeechStreamEventVariant1>? speechChunk = null,

            global::System.Action<global::Speechify.SpeechStreamEventVariant2>? speechDone = null,

            global::System.Action<global::Speechify.SpeechStreamEventVariant3>? speechError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeechChunk)
            {
                speechChunk?.Invoke(SpeechChunk!);
            }
            else if (IsSpeechDone)
            {
                speechDone?.Invoke(SpeechDone!);
            }
            else if (IsSpeechError)
            {
                speechError?.Invoke(SpeechError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Speechify.SpeechStreamEventVariant1>? speechChunk = null,
            global::System.Action<global::Speechify.SpeechStreamEventVariant2>? speechDone = null,
            global::System.Action<global::Speechify.SpeechStreamEventVariant3>? speechError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeechChunk)
            {
                speechChunk?.Invoke(SpeechChunk!);
            }
            else if (IsSpeechDone)
            {
                speechDone?.Invoke(SpeechDone!);
            }
            else if (IsSpeechError)
            {
                speechError?.Invoke(SpeechError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpeechChunk,
                typeof(global::Speechify.SpeechStreamEventVariant1),
                SpeechDone,
                typeof(global::Speechify.SpeechStreamEventVariant2),
                SpeechError,
                typeof(global::Speechify.SpeechStreamEventVariant3),
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
        public bool Equals(SpeechStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.SpeechStreamEventVariant1?>.Default.Equals(SpeechChunk, other.SpeechChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.SpeechStreamEventVariant2?>.Default.Equals(SpeechDone, other.SpeechDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.SpeechStreamEventVariant3?>.Default.Equals(SpeechError, other.SpeechError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SpeechStreamEvent obj1, SpeechStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeechStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SpeechStreamEvent obj1, SpeechStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechStreamEvent o && Equals(o);
        }
    }
}
