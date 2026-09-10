
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Which front door the conversation arrived through, one level<br/>
    /// coarser than `transport`, and the value to display or group a<br/>
    /// conversation's channel by. Both telephony directions are<br/>
    /// `voice`; the browser / SDK realtime path is `web`; the message<br/>
    /// API is `text`; a conversation reached over a provider front<br/>
    /// door names that provider (`slack`) rather than the transport it<br/>
    /// shares with the message API.
    /// </summary>
    public enum ConversationChannel
    {
        /// <summary>
        ///
        /// </summary>
        Slack,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Voice,
        /// <summary>
        ///
        /// </summary>
        Web,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationChannel value)
        {
            return value switch
            {
                ConversationChannel.Slack => "slack",
                ConversationChannel.Text => "text",
                ConversationChannel.Voice => "voice",
                ConversationChannel.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationChannel? ToEnum(string value)
        {
            return value switch
            {
                "slack" => ConversationChannel.Slack,
                "text" => ConversationChannel.Text,
                "voice" => ConversationChannel.Voice,
                "web" => ConversationChannel.Web,
                _ => null,
            };
        }
    }
}