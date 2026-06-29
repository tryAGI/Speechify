
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The route to run. `waymark-fast` favors latency, `waymark-moa`<br/>
    /// balances quality and cost, and `waymark-max` runs the widest panel<br/>
    /// for the highest quality. Access to the higher routes depends on your<br/>
    /// plan.
    /// </summary>
    public enum AnthropicMessageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        WaymarkFast,
        /// <summary>
        /// 
        /// </summary>
        WaymarkMax,
        /// <summary>
        /// 
        /// </summary>
        WaymarkMoa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicMessageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicMessageRequestModel value)
        {
            return value switch
            {
                AnthropicMessageRequestModel.WaymarkFast => "waymark-fast",
                AnthropicMessageRequestModel.WaymarkMax => "waymark-max",
                AnthropicMessageRequestModel.WaymarkMoa => "waymark-moa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicMessageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "waymark-fast" => AnthropicMessageRequestModel.WaymarkFast,
                "waymark-max" => AnthropicMessageRequestModel.WaymarkMax,
                "waymark-moa" => AnthropicMessageRequestModel.WaymarkMoa,
                _ => null,
            };
        }
    }
}