
#nullable enable

namespace Speechify
{
    /// <summary>
    /// proceed: hand control to the agent's flow as if the<br/>
    /// called party were human. hangup: terminate immediately.<br/>
    /// navigate: hand control to the IVR Navigator subagent<br/>
    /// with menu-memoization-aware session config (cache hit<br/>
    /// seeds the agent context; cache miss triggers cold<br/>
    /// discovery and the post-call pipeline extracts the<br/>
    /// menu for future calls).
    /// </summary>
    public enum TtsAmdConfigOnIvrAction
    {
        /// <summary>
        /// terminate immediately.
        /// </summary>
        Hangup,
        /// <summary>
        /// hand control to the IVR Navigator subagent
        /// </summary>
        Navigate,
        /// <summary>
        /// hand control to the agent's flow as if the
        /// </summary>
        Proceed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsAmdConfigOnIvrActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAmdConfigOnIvrAction value)
        {
            return value switch
            {
                TtsAmdConfigOnIvrAction.Hangup => "hangup",
                TtsAmdConfigOnIvrAction.Navigate => "navigate",
                TtsAmdConfigOnIvrAction.Proceed => "proceed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAmdConfigOnIvrAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => TtsAmdConfigOnIvrAction.Hangup,
                "navigate" => TtsAmdConfigOnIvrAction.Navigate,
                "proceed" => TtsAmdConfigOnIvrAction.Proceed,
                _ => null,
            };
        }
    }
}