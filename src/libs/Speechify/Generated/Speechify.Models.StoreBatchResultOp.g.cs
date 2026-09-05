
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum StoreBatchResultOp
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
    public static class StoreBatchResultOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreBatchResultOp value)
        {
            return value switch
            {
                StoreBatchResultOp.Delete => "delete",
                StoreBatchResultOp.Set => "set",
                StoreBatchResultOp.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreBatchResultOp? ToEnum(string value)
        {
            return value switch
            {
                "delete" => StoreBatchResultOp.Delete,
                "set" => StoreBatchResultOp.Set,
                "update" => StoreBatchResultOp.Update,
                _ => null,
            };
        }
    }
}