#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// A system prompt giving the model context and instructions: a plain<br/>
    /// string, or an array of Anthropic text blocks.
    /// </summary>
    public readonly partial struct AnthropicMessageRequestSystem : global::System.IEquatable<AnthropicMessageRequestSystem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnthropicMessageRequestSystemVariant1 { get; init; }
#else
        public string? AnthropicMessageRequestSystemVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicMessageRequestSystemVariant1))]
#endif
        public bool IsAnthropicMessageRequestSystemVariant1 => AnthropicMessageRequestSystemVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicMessageRequestSystemVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AnthropicMessageRequestSystemVariant1;
            return IsAnthropicMessageRequestSystemVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickAnthropicMessageRequestSystemVariant1() => IsAnthropicMessageRequestSystemVariant1
            ? AnthropicMessageRequestSystemVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicMessageRequestSystemVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? AnthropicMessageRequestSystemVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? AnthropicMessageRequestSystemVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicMessageRequestSystemVariant2))]
#endif
        public bool IsAnthropicMessageRequestSystemVariant2 => AnthropicMessageRequestSystemVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicMessageRequestSystemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<object>? value)
        {
            value = AnthropicMessageRequestSystemVariant2;
            return IsAnthropicMessageRequestSystemVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object> PickAnthropicMessageRequestSystemVariant2() => IsAnthropicMessageRequestSystemVariant2
            ? AnthropicMessageRequestSystemVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicMessageRequestSystemVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicMessageRequestSystem(string value) => new AnthropicMessageRequestSystem((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AnthropicMessageRequestSystem @this) => @this.AnthropicMessageRequestSystemVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicMessageRequestSystem(string? value)
        {
            AnthropicMessageRequestSystemVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnthropicMessageRequestSystem FromAnthropicMessageRequestSystemVariant1(string? value) => new AnthropicMessageRequestSystem(value);

        /// <summary>
        /// 
        /// </summary>
        public AnthropicMessageRequestSystem(
            string? anthropicMessageRequestSystemVariant1,
            global::System.Collections.Generic.IList<object>? anthropicMessageRequestSystemVariant2
            )
        {
            AnthropicMessageRequestSystemVariant1 = anthropicMessageRequestSystemVariant1;
            AnthropicMessageRequestSystemVariant2 = anthropicMessageRequestSystemVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicMessageRequestSystemVariant2 as object ??
            AnthropicMessageRequestSystemVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicMessageRequestSystemVariant1?.ToString() ??
            AnthropicMessageRequestSystemVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicMessageRequestSystemVariant1 && !IsAnthropicMessageRequestSystemVariant2 || !IsAnthropicMessageRequestSystemVariant1 && IsAnthropicMessageRequestSystemVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? anthropicMessageRequestSystemVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>, TResult>? anthropicMessageRequestSystemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicMessageRequestSystemVariant1 && anthropicMessageRequestSystemVariant1 != null)
            {
                return anthropicMessageRequestSystemVariant1(AnthropicMessageRequestSystemVariant1!);
            }
            else if (IsAnthropicMessageRequestSystemVariant2 && anthropicMessageRequestSystemVariant2 != null)
            {
                return anthropicMessageRequestSystemVariant2(AnthropicMessageRequestSystemVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? anthropicMessageRequestSystemVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<object>>? anthropicMessageRequestSystemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicMessageRequestSystemVariant1)
            {
                anthropicMessageRequestSystemVariant1?.Invoke(AnthropicMessageRequestSystemVariant1!);
            }
            else if (IsAnthropicMessageRequestSystemVariant2)
            {
                anthropicMessageRequestSystemVariant2?.Invoke(AnthropicMessageRequestSystemVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? anthropicMessageRequestSystemVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>>? anthropicMessageRequestSystemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicMessageRequestSystemVariant1)
            {
                anthropicMessageRequestSystemVariant1?.Invoke(AnthropicMessageRequestSystemVariant1!);
            }
            else if (IsAnthropicMessageRequestSystemVariant2)
            {
                anthropicMessageRequestSystemVariant2?.Invoke(AnthropicMessageRequestSystemVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicMessageRequestSystemVariant1,
                typeof(string),
                AnthropicMessageRequestSystemVariant2,
                typeof(global::System.Collections.Generic.IList<object>),
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
        public bool Equals(AnthropicMessageRequestSystem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnthropicMessageRequestSystemVariant1, other.AnthropicMessageRequestSystemVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(AnthropicMessageRequestSystemVariant2, other.AnthropicMessageRequestSystemVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicMessageRequestSystem obj1, AnthropicMessageRequestSystem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicMessageRequestSystem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicMessageRequestSystem obj1, AnthropicMessageRequestSystem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicMessageRequestSystem o && Equals(o);
        }
    }
}
