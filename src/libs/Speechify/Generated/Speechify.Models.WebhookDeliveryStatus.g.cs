
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Lifecycle of a post-call webhook delivery row. The sender<br/>
    /// updates the same row across retries so the UI always sees the<br/>
    /// latest outcome.
    /// </summary>
    public enum WebhookDeliveryStatus
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
    public static class WebhookDeliveryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveryStatus value)
        {
            return value switch
            {
                WebhookDeliveryStatus.Delivered => "delivered",
                WebhookDeliveryStatus.Failed => "failed",
                WebhookDeliveryStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveryStatus? ToEnum(string value)
        {
            return value switch
            {
                "delivered" => WebhookDeliveryStatus.Delivered,
                "failed" => WebhookDeliveryStatus.Failed,
                "pending" => WebhookDeliveryStatus.Pending,
                _ => null,
            };
        }
    }
}