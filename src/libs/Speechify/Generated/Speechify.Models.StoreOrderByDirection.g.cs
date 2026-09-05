
#nullable enable

namespace Speechify
{
    /// <summary>
    /// asc when omitted.
    /// </summary>
    public enum StoreOrderByDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreOrderByDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreOrderByDirection value)
        {
            return value switch
            {
                StoreOrderByDirection.Asc => "asc",
                StoreOrderByDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreOrderByDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => StoreOrderByDirection.Asc,
                "desc" => StoreOrderByDirection.Desc,
                _ => null,
            };
        }
    }
}