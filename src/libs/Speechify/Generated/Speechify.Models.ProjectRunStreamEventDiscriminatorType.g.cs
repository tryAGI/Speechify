
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectRunStreamEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        RunEnded,
        /// <summary>
        ///
        /// </summary>
        RunUpdated,
        /// <summary>
        ///
        /// </summary>
        RunsSynced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectRunStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectRunStreamEventDiscriminatorType value)
        {
            return value switch
            {
                ProjectRunStreamEventDiscriminatorType.RunEnded => "run.ended",
                ProjectRunStreamEventDiscriminatorType.RunUpdated => "run.updated",
                ProjectRunStreamEventDiscriminatorType.RunsSynced => "runs.synced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectRunStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "run.ended" => ProjectRunStreamEventDiscriminatorType.RunEnded,
                "run.updated" => ProjectRunStreamEventDiscriminatorType.RunUpdated,
                "runs.synced" => ProjectRunStreamEventDiscriminatorType.RunsSynced,
                _ => null,
            };
        }
    }
}