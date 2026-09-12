
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What started the turn this row belongs to, when it was not a<br/>
    /// person. `api` marks an agent-initiated turn the workspace's own<br/>
    /// backend asked for through the conversation prompt endpoint: the<br/>
    /// `user` row is the instruction that was sent and the `assistant`<br/>
    /// row is the reply the thread saw unasked. Both rows of such a turn<br/>
    /// carry it, so a transcript reader or an evaluator can tell an<br/>
    /// unprompted correction from an answer to a person. Omitted on<br/>
    /// every turn a person or a channel started.
    /// </summary>
    public enum MessageInitiatedBy
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageInitiatedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageInitiatedBy value)
        {
            return value switch
            {
                MessageInitiatedBy.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageInitiatedBy? ToEnum(string value)
        {
            return value switch
            {
                "api" => MessageInitiatedBy.Api,
                _ => null,
            };
        }
    }
}