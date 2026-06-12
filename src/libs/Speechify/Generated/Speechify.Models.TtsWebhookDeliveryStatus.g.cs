
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Lifecycle of a post-call webhook delivery row. The sender<br/>
    /// updates the same row across retries so the UI always sees the<br/>
    /// latest outcome.
    /// </summary>
    public enum TtsWebhookDeliveryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Delivered,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsWebhookDeliveryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsWebhookDeliveryStatus value)
        {
            return value switch
            {
                TtsWebhookDeliveryStatus.Delivered => "delivered",
                TtsWebhookDeliveryStatus.Failed => "failed",
                TtsWebhookDeliveryStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsWebhookDeliveryStatus? ToEnum(string value)
        {
            return value switch
            {
                "delivered" => TtsWebhookDeliveryStatus.Delivered,
                "failed" => TtsWebhookDeliveryStatus.Failed,
                "pending" => TtsWebhookDeliveryStatus.Pending,
                _ => null,
            };
        }
    }
}