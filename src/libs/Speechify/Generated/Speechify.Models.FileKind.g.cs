
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The file's lifetime, declared at upload. `ephemeral` is working<br/>
    /// material for a run and is deleted 14 days after upload; `kept`<br/>
    /// survives until you delete it and carries no `expires_at` at all.<br/>
    /// Only a `kept` file can be published at a `path`.
    /// </summary>
    public enum FileKind
    {
        /// <summary>
        ///
        /// </summary>
        Ephemeral,
        /// <summary>
        ///
        /// </summary>
        Kept,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileKind value)
        {
            return value switch
            {
                FileKind.Ephemeral => "ephemeral",
                FileKind.Kept => "kept",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileKind? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => FileKind.Ephemeral,
                "kept" => FileKind.Kept,
                _ => null,
            };
        }
    }
}