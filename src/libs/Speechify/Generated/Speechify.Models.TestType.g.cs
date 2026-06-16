
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminates the shape of `AgentTest.config`.<br/>
    /// - `reply` - send one message to the agent and judge the response with an LLM.<br/>
    /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
    /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
    /// </summary>
    public enum TestType
    {
        /// <summary>
        /// 
        /// </summary>
        Reply,
        /// <summary>
        /// 
        /// </summary>
        Simulation,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestType value)
        {
            return value switch
            {
                TestType.Reply => "reply",
                TestType.Simulation => "simulation",
                TestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestType? ToEnum(string value)
        {
            return value switch
            {
                "reply" => TestType.Reply,
                "simulation" => TestType.Simulation,
                "tool" => TestType.Tool,
                _ => null,
            };
        }
    }
}