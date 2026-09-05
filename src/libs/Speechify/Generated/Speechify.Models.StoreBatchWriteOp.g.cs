
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum StoreBatchWriteOp
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Set,
        /// <summary>
        ///
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreBatchWriteOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreBatchWriteOp value)
        {
            return value switch
            {
                StoreBatchWriteOp.Delete => "delete",
                StoreBatchWriteOp.Set => "set",
                StoreBatchWriteOp.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreBatchWriteOp? ToEnum(string value)
        {
            return value switch
            {
                "delete" => StoreBatchWriteOp.Delete,
                "set" => StoreBatchWriteOp.Set,
                "update" => StoreBatchWriteOp.Update,
                _ => null,
            };
        }
    }
}