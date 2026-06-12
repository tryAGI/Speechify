
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsWebhookToolConfigMethod
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
    public static class TtsWebhookToolConfigMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsWebhookToolConfigMethod value)
        {
            return value switch
            {
                TtsWebhookToolConfigMethod.Get => "GET",
                TtsWebhookToolConfigMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsWebhookToolConfigMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => TtsWebhookToolConfigMethod.Get,
                "POST" => TtsWebhookToolConfigMethod.Post,
                _ => null,
            };
        }
    }
}