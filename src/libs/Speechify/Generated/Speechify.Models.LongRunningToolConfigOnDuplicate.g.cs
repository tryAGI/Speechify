
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What happens when the model calls this tool while a previous<br/>
    /// call of the SAME tool is still running. `reject` (the default<br/>
    /// whenever `long_running` is set) refuses the second call and<br/>
    /// tells the model the first is still in flight, so a slow<br/>
    /// side-effecting webhook cannot be fired twice in one turn.<br/>
    /// `allow` restores the unguarded behaviour for a read-only tool<br/>
    /// the model legitimately fans out over several arguments —<br/>
    /// duplicates are matched by tool name alone, never by<br/>
    /// arguments.
    /// </summary>
    public enum LongRunningToolConfigOnDuplicate
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Reject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LongRunningToolConfigOnDuplicateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LongRunningToolConfigOnDuplicate value)
        {
            return value switch
            {
                LongRunningToolConfigOnDuplicate.Allow => "allow",
                LongRunningToolConfigOnDuplicate.Reject => "reject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LongRunningToolConfigOnDuplicate? ToEnum(string value)
        {
            return value switch
            {
                "allow" => LongRunningToolConfigOnDuplicate.Allow,
                "reject" => LongRunningToolConfigOnDuplicate.Reject,
                _ => null,
            };
        }
    }
}