
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedApiMountOperationAction
    {
        /// <summary>
        ///
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        Skip,
        /// <summary>
        ///
        /// </summary>
        Stale,
        /// <summary>
        ///
        /// </summary>
        Unchanged,
        /// <summary>
        ///
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedApiMountOperationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedApiMountOperationAction value)
        {
            return value switch
            {
                HostedApiMountOperationAction.Create => "create",
                HostedApiMountOperationAction.Skip => "skip",
                HostedApiMountOperationAction.Stale => "stale",
                HostedApiMountOperationAction.Unchanged => "unchanged",
                HostedApiMountOperationAction.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedApiMountOperationAction? ToEnum(string value)
        {
            return value switch
            {
                "create" => HostedApiMountOperationAction.Create,
                "skip" => HostedApiMountOperationAction.Skip,
                "stale" => HostedApiMountOperationAction.Stale,
                "unchanged" => HostedApiMountOperationAction.Unchanged,
                "update" => HostedApiMountOperationAction.Update,
                _ => null,
            };
        }
    }
}