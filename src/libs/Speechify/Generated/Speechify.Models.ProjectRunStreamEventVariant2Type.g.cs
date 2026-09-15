
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectRunStreamEventVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        RunEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectRunStreamEventVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectRunStreamEventVariant2Type value)
        {
            return value switch
            {
                ProjectRunStreamEventVariant2Type.RunEnded => "run.ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectRunStreamEventVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "run.ended" => ProjectRunStreamEventVariant2Type.RunEnded,
                _ => null,
            };
        }
    }
}