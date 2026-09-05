
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum StoreWhereClauseOp
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
    public static class StoreWhereClauseOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreWhereClauseOp value)
        {
            return value switch
            {
                StoreWhereClauseOp.Eq => "eq",
                StoreWhereClauseOp.Gt => "gt",
                StoreWhereClauseOp.Gte => "gte",
                StoreWhereClauseOp.In => "in",
                StoreWhereClauseOp.Lt => "lt",
                StoreWhereClauseOp.Lte => "lte",
                StoreWhereClauseOp.Ne => "ne",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreWhereClauseOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => StoreWhereClauseOp.Eq,
                "gt" => StoreWhereClauseOp.Gt,
                "gte" => StoreWhereClauseOp.Gte,
                "in" => StoreWhereClauseOp.In,
                "lt" => StoreWhereClauseOp.Lt,
                "lte" => StoreWhereClauseOp.Lte,
                "ne" => StoreWhereClauseOp.Ne,
                _ => null,
            };
        }
    }
}