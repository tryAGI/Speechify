
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectRunStreamEventVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        RunUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectRunStreamEventVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectRunStreamEventVariant1Type value)
        {
            return value switch
            {
                ProjectRunStreamEventVariant1Type.RunUpdated => "run.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectRunStreamEventVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "run.updated" => ProjectRunStreamEventVariant1Type.RunUpdated,
                _ => null,
            };
        }
    }
}