
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
    public enum TtsMockingStrategy
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
    public static class TtsMockingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsMockingStrategy value)
        {
            return value switch
            {
                TtsMockingStrategy.All => "all",
                TtsMockingStrategy.None => "none",
                TtsMockingStrategy.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsMockingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "all" => TtsMockingStrategy.All,
                "none" => TtsMockingStrategy.None,
                "selected" => TtsMockingStrategy.Selected,
                _ => null,
            };
        }
    }
}