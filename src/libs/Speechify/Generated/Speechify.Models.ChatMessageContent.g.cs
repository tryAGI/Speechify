#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// The message content. A plain string for most messages; OpenAI-style<br/>
    /// content-part arrays are also accepted for multimodal input.
    /// </summary>
    public readonly partial struct ChatMessageContent : global::System.IEquatable<ChatMessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatMessageContentVariant1 { get; init; }
#else
        public string? ChatMessageContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessageContentVariant1))]
#endif
        public bool IsChatMessageContentVariant1 => ChatMessageContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatMessageContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ChatMessageContentVariant1;
            return IsChatMessageContentVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickChatMessageContentVariant1() => IsChatMessageContentVariant1
            ? ChatMessageContentVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatMessageContentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? ChatMessageContentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? ChatMessageContentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessageContentVariant2))]
#endif
        public bool IsChatMessageContentVariant2 => ChatMessageContentVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatMessageContentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<object>? value)
        {
            value = ChatMessageContentVariant2;
            return IsChatMessageContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object> PickChatMessageContentVariant2() => IsChatMessageContentVariant2
            ? ChatMessageContentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatMessageContentVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContent(string value) => new ChatMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatMessageContent @this) => @this.ChatMessageContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(string? value)
        {
            ChatMessageContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessageContent FromChatMessageContentVariant1(string? value) => new ChatMessageContent(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(
            string? chatMessageContentVariant1,
            global::System.Collections.Generic.IList<object>? chatMessageContentVariant2
            )
        {
            ChatMessageContentVariant1 = chatMessageContentVariant1;
            ChatMessageContentVariant2 = chatMessageContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatMessageContentVariant2 as object ??
            ChatMessageContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatMessageContentVariant1?.ToString() ??
            ChatMessageContentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatMessageContentVariant1 && !IsChatMessageContentVariant2 || !IsChatMessageContentVariant1 && IsChatMessageContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? chatMessageContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>, TResult>? chatMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessageContentVariant1 && chatMessageContentVariant1 != null)
            {
                return chatMessageContentVariant1(ChatMessageContentVariant1!);
            }
            else if (IsChatMessageContentVariant2 && chatMessageContentVariant2 != null)
            {
                return chatMessageContentVariant2(ChatMessageContentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? chatMessageContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<object>>? chatMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessageContentVariant1)
            {
                chatMessageContentVariant1?.Invoke(ChatMessageContentVariant1!);
            }
            else if (IsChatMessageContentVariant2)
            {
                chatMessageContentVariant2?.Invoke(ChatMessageContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? chatMessageContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>>? chatMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessageContentVariant1)
            {
                chatMessageContentVariant1?.Invoke(ChatMessageContentVariant1!);
            }
            else if (IsChatMessageContentVariant2)
            {
                chatMessageContentVariant2?.Invoke(ChatMessageContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatMessageContentVariant1,
                typeof(string),
                ChatMessageContentVariant2,
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
        public bool Equals(ChatMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatMessageContentVariant1, other.ChatMessageContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(ChatMessageContentVariant2, other.ChatMessageContentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageContent obj1, ChatMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageContent obj1, ChatMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageContent o && Equals(o);
        }
    }
}
