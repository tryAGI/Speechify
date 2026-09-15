
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectRunStreamEventVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        RunsSynced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectRunStreamEventVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectRunStreamEventVariant3Type value)
        {
            return value switch
            {
                ProjectRunStreamEventVariant3Type.RunsSynced => "runs.synced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectRunStreamEventVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "runs.synced" => ProjectRunStreamEventVariant3Type.RunsSynced,
                _ => null,
            };
        }
    }
}