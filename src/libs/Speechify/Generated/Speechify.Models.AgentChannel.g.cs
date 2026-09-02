
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A delivery surface an agent can serve. One agent may serve several,<br/>
    /// so `channels` is a set. `voice` runs over telephony + web (requires a<br/>
    /// `tts.voice_id`); `text` runs over the chat/widget surface. An agent<br/>
    /// with an empty set has no front door and is reached by its triggers<br/>
    /// only. There is no agent type: what an agent is (its prompt, model,<br/>
    /// knowledge and tools) is one thing, and this set is how it is reached.
    /// </summary>
    public enum AgentChannel
    {
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChannel value)
        {
            return value switch
            {
                AgentChannel.Text => "text",
                AgentChannel.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChannel? ToEnum(string value)
        {
            return value switch
            {
                "text" => AgentChannel.Text,
                "voice" => AgentChannel.Voice,
                _ => null,
            };
        }
    }
}