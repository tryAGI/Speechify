
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Geographic region the workspace's data is pinned to.
    /// </summary>
    public enum TtsTenantDataRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsTenantDataRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsTenantDataRegion value)
        {
            return value switch
            {
                TtsTenantDataRegion.Eu => "eu",
                TtsTenantDataRegion.In => "in",
                TtsTenantDataRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsTenantDataRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => TtsTenantDataRegion.Eu,
                "in" => TtsTenantDataRegion.In,
                "us" => TtsTenantDataRegion.Us,
                _ => null,
            };
        }
    }
}