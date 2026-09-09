
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `detach` removes the grouping row only and moves every resource<br/>
    /// to the Default project; `purge` removes the project with its<br/>
    /// contents. Omitted, the delete removes only an empty project.
    /// </summary>
    public enum DeleteProjectRequestMode
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
    public static class DeleteProjectRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteProjectRequestMode value)
        {
            return value switch
            {
                DeleteProjectRequestMode.Detach => "detach",
                DeleteProjectRequestMode.Purge => "purge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteProjectRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "detach" => DeleteProjectRequestMode.Detach,
                "purge" => DeleteProjectRequestMode.Purge,
                _ => null,
            };
        }
    }
}