
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum RefreshHistoryEntryStatus
    {
        /// <summary>
        ///
        /// </summary>
        Changed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Removed,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Unchanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefreshHistoryEntryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefreshHistoryEntryStatus value)
        {
            return value switch
            {
                RefreshHistoryEntryStatus.Changed => "changed",
                RefreshHistoryEntryStatus.Failed => "failed",
                RefreshHistoryEntryStatus.Removed => "removed",
                RefreshHistoryEntryStatus.Running => "running",
                RefreshHistoryEntryStatus.Unchanged => "unchanged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefreshHistoryEntryStatus? ToEnum(string value)
        {
            return value switch
            {
                "changed" => RefreshHistoryEntryStatus.Changed,
                "failed" => RefreshHistoryEntryStatus.Failed,
                "removed" => RefreshHistoryEntryStatus.Removed,
                "running" => RefreshHistoryEntryStatus.Running,
                "unchanged" => RefreshHistoryEntryStatus.Unchanged,
                _ => null,
            };
        }
    }
}