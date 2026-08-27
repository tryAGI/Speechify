
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookToolConfigMethod
    {
        /// <summary>
        ///
        /// </summary>
        Get,
        /// <summary>
        ///
        /// </summary>
        Post,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookToolConfigMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolConfigMethod value)
        {
            return value switch
            {
                WebhookToolConfigMethod.Get => "GET",
                WebhookToolConfigMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookToolConfigMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => WebhookToolConfigMethod.Get,
                "POST" => WebhookToolConfigMethod.Post,
                _ => null,
            };
        }
    }
}