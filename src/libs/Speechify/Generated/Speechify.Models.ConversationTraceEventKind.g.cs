
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The kind of action.
    /// </summary>
    public enum ConversationTraceEventKind
    {
        /// <summary>
        /// 
        /// </summary>
        Dtmf,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationTraceEventKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationTraceEventKind value)
        {
            return value switch
            {
                ConversationTraceEventKind.Dtmf => "dtmf",
                ConversationTraceEventKind.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationTraceEventKind? ToEnum(string value)
        {
            return value switch
            {
                "dtmf" => ConversationTraceEventKind.Dtmf,
                "tool" => ConversationTraceEventKind.Tool,
                _ => null,
            };
        }
    }
}