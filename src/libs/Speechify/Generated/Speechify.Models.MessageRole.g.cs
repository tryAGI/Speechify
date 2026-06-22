
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Who produced the turn: `user` is the caller, `assistant` the AI<br/>
    /// agent, `tool` a tool call, `system` a transcript annotation (such<br/>
    /// as the take-over window markers), and `operator` a human<br/>
    /// operator's speech while they have taken the call over.
    /// </summary>
    public enum MessageRole
    {
        /// <summary>
        /// `user` is the caller, `assistant` the AI
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Operator,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// `user` is the caller, `assistant` the AI
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageRole value)
        {
            return value switch
            {
                MessageRole.Assistant => "assistant",
                MessageRole.Operator => "operator",
                MessageRole.System => "system",
                MessageRole.Tool => "tool",
                MessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageRole.Assistant,
                "operator" => MessageRole.Operator,
                "system" => MessageRole.System,
                "tool" => MessageRole.Tool,
                "user" => MessageRole.User,
                _ => null,
            };
        }
    }
}