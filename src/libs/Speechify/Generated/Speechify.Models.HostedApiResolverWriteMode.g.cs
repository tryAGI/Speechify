
#nullable enable

namespace Speechify
{
    /// <summary>
    /// For a `store_write` route: `create` mints an id and answers 201<br/>
    /// with the document; `replace` and `merge` land on `document_id`<br/>
    /// (a merge sets the fields sent and keeps the rest) and answer 200.<br/>
    /// Omitted, a route with a document_id merges and one without<br/>
    /// creates. On an API that names its caller, a replace or merge of<br/>
    /// another person's document is not found.
    /// </summary>
    public enum HostedApiResolverWriteMode
    {
        /// <summary>
        /// `create` mints an id and answers 201
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        Merge,
        /// <summary>
        ///
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedApiResolverWriteModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedApiResolverWriteMode value)
        {
            return value switch
            {
                HostedApiResolverWriteMode.Create => "create",
                HostedApiResolverWriteMode.Merge => "merge",
                HostedApiResolverWriteMode.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedApiResolverWriteMode? ToEnum(string value)
        {
            return value switch
            {
                "create" => HostedApiResolverWriteMode.Create,
                "merge" => HostedApiResolverWriteMode.Merge,
                "replace" => HostedApiResolverWriteMode.Replace,
                _ => null,
            };
        }
    }
}