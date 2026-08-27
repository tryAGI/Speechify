
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AmdConfigOnUnavailableAction
    {
        /// <summary>
        ///
        /// </summary>
        Hangup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AmdConfigOnUnavailableActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AmdConfigOnUnavailableAction value)
        {
            return value switch
            {
                AmdConfigOnUnavailableAction.Hangup => "hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AmdConfigOnUnavailableAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => AmdConfigOnUnavailableAction.Hangup,
                _ => null,
            };
        }
    }
}