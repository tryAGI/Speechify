
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedApiResolverWhereItemsOp
    {
        /// <summary>
        ///
        /// </summary>
        Eq,
        /// <summary>
        ///
        /// </summary>
        Gt,
        /// <summary>
        ///
        /// </summary>
        Gte,
        /// <summary>
        ///
        /// </summary>
        In,
        /// <summary>
        ///
        /// </summary>
        Lt,
        /// <summary>
        ///
        /// </summary>
        Lte,
        /// <summary>
        ///
        /// </summary>
        Ne,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedApiResolverWhereItemsOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedApiResolverWhereItemsOp value)
        {
            return value switch
            {
                HostedApiResolverWhereItemsOp.Eq => "eq",
                HostedApiResolverWhereItemsOp.Gt => "gt",
                HostedApiResolverWhereItemsOp.Gte => "gte",
                HostedApiResolverWhereItemsOp.In => "in",
                HostedApiResolverWhereItemsOp.Lt => "lt",
                HostedApiResolverWhereItemsOp.Lte => "lte",
                HostedApiResolverWhereItemsOp.Ne => "ne",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedApiResolverWhereItemsOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => HostedApiResolverWhereItemsOp.Eq,
                "gt" => HostedApiResolverWhereItemsOp.Gt,
                "gte" => HostedApiResolverWhereItemsOp.Gte,
                "in" => HostedApiResolverWhereItemsOp.In,
                "lt" => HostedApiResolverWhereItemsOp.Lt,
                "lte" => HostedApiResolverWhereItemsOp.Lte,
                "ne" => HostedApiResolverWhereItemsOp.Ne,
                _ => null,
            };
        }
    }
}