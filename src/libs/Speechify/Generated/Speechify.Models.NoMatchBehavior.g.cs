
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Fallback when a mockable tool is called but no configured mock<br/>
    /// matches the call arguments.<br/>
    /// - `call_real_tool` - pass-through: actually invoke the underlying<br/>
    ///   tool (a webhook tool POSTs to the customer endpoint). Use only<br/>
    ///   when the real call is safe to make from a test.<br/>
    /// - `finish_with_error` - fail: the run finishes as a `failed`<br/>
    ///   verdict. Useful when a test wants to assert that a specific<br/>
    ///   mocked response path is taken - any unmocked tool call fails the<br/>
    ///   test.<br/>
    /// - `skip` - return an empty stub (`{"skipped":true}`) to the agent so<br/>
    ///   the simulation proceeds without treating the call as a failure.<br/>
    ///   Useful when a tool's output is irrelevant to the behaviour under<br/>
    ///   test but the model may still decide to call it. This is the<br/>
    ///   default for a test with no mock configuration.
    /// </summary>
    public enum NoMatchBehavior
    {
        /// <summary>
        /// actually invoke the underlying
        /// </summary>
        CallRealTool,
        /// <summary>
        /// the run finishes as a `failed`
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
    public static class NoMatchBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NoMatchBehavior value)
        {
            return value switch
            {
                NoMatchBehavior.CallRealTool => "call_real_tool",
                NoMatchBehavior.FinishWithError => "finish_with_error",
                NoMatchBehavior.Skip => "skip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NoMatchBehavior? ToEnum(string value)
        {
            return value switch
            {
                "call_real_tool" => NoMatchBehavior.CallRealTool,
                "finish_with_error" => NoMatchBehavior.FinishWithError,
                "skip" => NoMatchBehavior.Skip,
                _ => null,
            };
        }
    }
}