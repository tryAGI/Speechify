#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// The message content: a plain string for simple turns, or an<br/>
    /// array of Anthropic content blocks for multimodal / tool input.
    /// </summary>
    public readonly partial struct AnthropicMessageRequestMessagesItemsContent : global::System.IEquatable<AnthropicMessageRequestMessagesItemsContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnthropicMessageRequestMessagesItemsContentVariant1 { get; init; }
#else
        public string? AnthropicMessageRequestMessagesItemsContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicMessageRequestMessagesItemsContentVariant1))]
#endif
        public bool IsAnthropicMessageRequestMessagesItemsContentVariant1 => AnthropicMessageRequestMessagesItemsContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicMessageRequestMessagesItemsContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AnthropicMessageRequestMessagesItemsContentVariant1;
            return IsAnthropicMessageRequestMessagesItemsContentVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickAnthropicMessageRequestMessagesItemsContentVariant1() => IsAnthropicMessageRequestMessagesItemsContentVariant1
            ? AnthropicMessageRequestMessagesItemsContentVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicMessageRequestMessagesItemsContentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? AnthropicMessageRequestMessagesItemsContentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? AnthropicMessageRequestMessagesItemsContentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicMessageRequestMessagesItemsContentVariant2))]
#endif
        public bool IsAnthropicMessageRequestMessagesItemsContentVariant2 => AnthropicMessageRequestMessagesItemsContentVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicMessageRequestMessagesItemsContentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<object>? value)
        {
            value = AnthropicMessageRequestMessagesItemsContentVariant2;
            return IsAnthropicMessageRequestMessagesItemsContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object> PickAnthropicMessageRequestMessagesItemsContentVariant2() => IsAnthropicMessageRequestMessagesItemsContentVariant2
            ? AnthropicMessageRequestMessagesItemsContentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicMessageRequestMessagesItemsContentVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicMessageRequestMessagesItemsContent(string value) => new AnthropicMessageRequestMessagesItemsContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AnthropicMessageRequestMessagesItemsContent @this) => @this.AnthropicMessageRequestMessagesItemsContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicMessageRequestMessagesItemsContent(string? value)
        {
            AnthropicMessageRequestMessagesItemsContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnthropicMessageRequestMessagesItemsContent FromAnthropicMessageRequestMessagesItemsContentVariant1(string? value) => new AnthropicMessageRequestMessagesItemsContent(value);

        /// <summary>
        /// 
        /// </summary>
        public AnthropicMessageRequestMessagesItemsContent(
            string? anthropicMessageRequestMessagesItemsContentVariant1,
            global::System.Collections.Generic.IList<object>? anthropicMessageRequestMessagesItemsContentVariant2
            )
        {
            AnthropicMessageRequestMessagesItemsContentVariant1 = anthropicMessageRequestMessagesItemsContentVariant1;
            AnthropicMessageRequestMessagesItemsContentVariant2 = anthropicMessageRequestMessagesItemsContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicMessageRequestMessagesItemsContentVariant2 as object ??
            AnthropicMessageRequestMessagesItemsContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicMessageRequestMessagesItemsContentVariant1?.ToString() ??
            AnthropicMessageRequestMessagesItemsContentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicMessageRequestMessagesItemsContentVariant1 && !IsAnthropicMessageRequestMessagesItemsContentVariant2 || !IsAnthropicMessageRequestMessagesItemsContentVariant1 && IsAnthropicMessageRequestMessagesItemsContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? anthropicMessageRequestMessagesItemsContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>, TResult>? anthropicMessageRequestMessagesItemsContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicMessageRequestMessagesItemsContentVariant1 && anthropicMessageRequestMessagesItemsContentVariant1 != null)
            {
                return anthropicMessageRequestMessagesItemsContentVariant1(AnthropicMessageRequestMessagesItemsContentVariant1!);
            }
            else if (IsAnthropicMessageRequestMessagesItemsContentVariant2 && anthropicMessageRequestMessagesItemsContentVariant2 != null)
            {
                return anthropicMessageRequestMessagesItemsContentVariant2(AnthropicMessageRequestMessagesItemsContentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? anthropicMessageRequestMessagesItemsContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<object>>? anthropicMessageRequestMessagesItemsContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicMessageRequestMessagesItemsContentVariant1)
            {
                anthropicMessageRequestMessagesItemsContentVariant1?.Invoke(AnthropicMessageRequestMessagesItemsContentVariant1!);
            }
            else if (IsAnthropicMessageRequestMessagesItemsContentVariant2)
            {
                anthropicMessageRequestMessagesItemsContentVariant2?.Invoke(AnthropicMessageRequestMessagesItemsContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? anthropicMessageRequestMessagesItemsContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>>? anthropicMessageRequestMessagesItemsContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicMessageRequestMessagesItemsContentVariant1)
            {
                anthropicMessageRequestMessagesItemsContentVariant1?.Invoke(AnthropicMessageRequestMessagesItemsContentVariant1!);
            }
            else if (IsAnthropicMessageRequestMessagesItemsContentVariant2)
            {
                anthropicMessageRequestMessagesItemsContentVariant2?.Invoke(AnthropicMessageRequestMessagesItemsContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicMessageRequestMessagesItemsContentVariant1,
                typeof(string),
                AnthropicMessageRequestMessagesItemsContentVariant2,
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
        public bool Equals(AnthropicMessageRequestMessagesItemsContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnthropicMessageRequestMessagesItemsContentVariant1, other.AnthropicMessageRequestMessagesItemsContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(AnthropicMessageRequestMessagesItemsContentVariant2, other.AnthropicMessageRequestMessagesItemsContentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicMessageRequestMessagesItemsContent obj1, AnthropicMessageRequestMessagesItemsContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicMessageRequestMessagesItemsContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicMessageRequestMessagesItemsContent obj1, AnthropicMessageRequestMessagesItemsContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicMessageRequestMessagesItemsContent o && Equals(o);
        }
    }
}
