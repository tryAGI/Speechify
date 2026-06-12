
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsRefreshHistoryEntryStatus
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
    public static class TtsRefreshHistoryEntryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRefreshHistoryEntryStatus value)
        {
            return value switch
            {
                TtsRefreshHistoryEntryStatus.Changed => "changed",
                TtsRefreshHistoryEntryStatus.Failed => "failed",
                TtsRefreshHistoryEntryStatus.Removed => "removed",
                TtsRefreshHistoryEntryStatus.Running => "running",
                TtsRefreshHistoryEntryStatus.Unchanged => "unchanged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRefreshHistoryEntryStatus? ToEnum(string value)
        {
            return value switch
            {
                "changed" => TtsRefreshHistoryEntryStatus.Changed,
                "failed" => TtsRefreshHistoryEntryStatus.Failed,
                "removed" => TtsRefreshHistoryEntryStatus.Removed,
                "running" => TtsRefreshHistoryEntryStatus.Running,
                "unchanged" => TtsRefreshHistoryEntryStatus.Unchanged,
                _ => null,
            };
        }
    }
}