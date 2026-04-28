
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Fallback when a mockable tool is called but no configured mock<br/>
    /// matches the call arguments.<br/>
    /// - `call_real_tool` - pass-through: actually invoke the underlying tool.<br/>
    /// - `finish_with_error` - fail: short-circuit the run to an `error`<br/>
    ///   status. Useful when a test wants to assert that a specific mocked<br/>
    ///   response path is taken - any unmocked tool call aborts the run.<br/>
    /// - `skip` - return an empty stub (`{"skipped":true}`) to the agent so<br/>
    ///   the simulation proceeds without treating the call as a failure.<br/>
    ///   Useful when a tool's output is irrelevant to the behaviour under<br/>
    ///   test but the model may still decide to call it.
    /// </summary>
    public enum TtsNoMatchBehavior
    {
        /// <summary>
        /// actually invoke the underlying tool.
        /// </summary>
        CallRealTool,
        /// <summary>
        /// short-circuit the run to an `error`
        /// </summary>
        FinishWithError,
        /// <summary>
        /// true}`) to the agent so
        /// </summary>
        Skip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsNoMatchBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsNoMatchBehavior value)
        {
            return value switch
            {
                TtsNoMatchBehavior.CallRealTool => "call_real_tool",
                TtsNoMatchBehavior.FinishWithError => "finish_with_error",
                TtsNoMatchBehavior.Skip => "skip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsNoMatchBehavior? ToEnum(string value)
        {
            return value switch
            {
                "call_real_tool" => TtsNoMatchBehavior.CallRealTool,
                "finish_with_error" => TtsNoMatchBehavior.FinishWithError,
                "skip" => TtsNoMatchBehavior.Skip,
                _ => null,
            };
        }
    }
}