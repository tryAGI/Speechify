
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Controls which tool calls the runner intercepts during a run.<br/>
    /// System tools (`end_call`, `transfer_to_number`, etc.) are never<br/>
    /// mocked regardless of strategy.<br/>
    /// - `none` - no interception; all tools are called normally.<br/>
    /// - `all` - every non-system tool call is intercepted and matched<br/>
    ///   against the `mocks` list.<br/>
    /// - `selected` - only tools explicitly listed in `mocks` are<br/>
    ///   intercepted; others are called normally.
    /// </summary>
    public enum MockingStrategy
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MockingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MockingStrategy value)
        {
            return value switch
            {
                MockingStrategy.All => "all",
                MockingStrategy.None => "none",
                MockingStrategy.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MockingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "all" => MockingStrategy.All,
                "none" => MockingStrategy.None,
                "selected" => MockingStrategy.Selected,
                _ => null,
            };
        }
    }
}