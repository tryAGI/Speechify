
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Highest LLM model access class an agent on this plan may select.<br/>
    /// `managed`: Speechify-served models, included on every plan.<br/>
    /// `standard`: low-cost third-party models (e.g. GPT-4.1 Mini).<br/>
    /// `premium`: flagship third-party models (e.g. GPT-4.1).
    /// </summary>
    public enum BillingEntitlementsMaxLlmModelClass
    {
        /// <summary>
        /// Speechify-served models, included on every plan.
        /// </summary>
        Managed,
        /// <summary>
        /// flagship third-party models (e.g. GPT-4.1).
        /// </summary>
        Premium,
        /// <summary>
        /// low-cost third-party models (e.g. GPT-4.1 Mini).
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingEntitlementsMaxLlmModelClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingEntitlementsMaxLlmModelClass value)
        {
            return value switch
            {
                BillingEntitlementsMaxLlmModelClass.Managed => "managed",
                BillingEntitlementsMaxLlmModelClass.Premium => "premium",
                BillingEntitlementsMaxLlmModelClass.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingEntitlementsMaxLlmModelClass? ToEnum(string value)
        {
            return value switch
            {
                "managed" => BillingEntitlementsMaxLlmModelClass.Managed,
                "premium" => BillingEntitlementsMaxLlmModelClass.Premium,
                "standard" => BillingEntitlementsMaxLlmModelClass.Standard,
                _ => null,
            };
        }
    }
}