
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Billing plan tier.
    /// </summary>
    public enum TtsTenantPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Business,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsTenantPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsTenantPlan value)
        {
            return value switch
            {
                TtsTenantPlan.Business => "business",
                TtsTenantPlan.Enterprise => "enterprise",
                TtsTenantPlan.Free => "free",
                TtsTenantPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsTenantPlan? ToEnum(string value)
        {
            return value switch
            {
                "business" => TtsTenantPlan.Business,
                "enterprise" => TtsTenantPlan.Enterprise,
                "free" => TtsTenantPlan.Free,
                "pro" => TtsTenantPlan.Pro,
                _ => null,
            };
        }
    }
}