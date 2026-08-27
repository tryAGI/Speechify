
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectTeardownBlockerBlocksItems
    {
        /// <summary>
        ///
        /// </summary>
        Detach,
        /// <summary>
        ///
        /// </summary>
        Purge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectTeardownBlockerBlocksItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectTeardownBlockerBlocksItems value)
        {
            return value switch
            {
                ProjectTeardownBlockerBlocksItems.Detach => "detach",
                ProjectTeardownBlockerBlocksItems.Purge => "purge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectTeardownBlockerBlocksItems? ToEnum(string value)
        {
            return value switch
            {
                "detach" => ProjectTeardownBlockerBlocksItems.Detach,
                "purge" => ProjectTeardownBlockerBlocksItems.Purge,
                _ => null,
            };
        }
    }
}