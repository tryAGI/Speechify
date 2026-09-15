
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedApiMountOperationChangesItems
    {
        /// <summary>
        ///
        /// </summary>
        InputSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedApiMountOperationChangesItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedApiMountOperationChangesItems value)
        {
            return value switch
            {
                HostedApiMountOperationChangesItems.InputSchema => "input_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedApiMountOperationChangesItems? ToEnum(string value)
        {
            return value switch
            {
                "input_schema" => HostedApiMountOperationChangesItems.InputSchema,
                _ => null,
            };
        }
    }
}