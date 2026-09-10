
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A surface that can execute a call to a tool. The values are the<br/>
    /// surfaces an agent is reached on - the same vocabulary as its<br/>
    /// `channels` - plus the autonomous run every agent can be started as,<br/>
    /// so a tool's `reach` intersected with an agent's own doors answers<br/>
    /// "will this ever fire on that agent".<br/>
    /// - `voice`: a live realtime session (a room, reached over telephony or<br/>
    ///   the browser/SDK).<br/>
    /// - `text`: the roomless turn runtime the message API and every<br/>
    ///   messaging channel, Slack included, share.<br/>
    /// - `run`: an autonomous durable run.
    /// </summary>
    public enum ToolReach
    {
        /// <summary>
        /// the roomless turn runtime the message API and every
        /// </summary>
        Run,
        /// <summary>
        /// the roomless turn runtime the message API and every
        /// </summary>
        Text,
        /// <summary>
        /// a live realtime session (a room, reached over telephony or
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolReachExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolReach value)
        {
            return value switch
            {
                ToolReach.Run => "run",
                ToolReach.Text => "text",
                ToolReach.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolReach? ToEnum(string value)
        {
            return value switch
            {
                "run" => ToolReach.Run,
                "text" => ToolReach.Text,
                "voice" => ToolReach.Voice,
                _ => null,
            };
        }
    }
}