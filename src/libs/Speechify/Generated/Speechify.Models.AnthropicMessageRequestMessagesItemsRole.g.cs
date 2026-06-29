
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The role of the message author.
    /// </summary>
    public enum AnthropicMessageRequestMessagesItemsRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicMessageRequestMessagesItemsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicMessageRequestMessagesItemsRole value)
        {
            return value switch
            {
                AnthropicMessageRequestMessagesItemsRole.Assistant => "assistant",
                AnthropicMessageRequestMessagesItemsRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicMessageRequestMessagesItemsRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AnthropicMessageRequestMessagesItemsRole.Assistant,
                "user" => AnthropicMessageRequestMessagesItemsRole.User,
                _ => null,
            };
        }
    }
}