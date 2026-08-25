
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The kind of resource the entry names.
    /// </summary>
    public enum PromoteAttentionKind
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        AudioAsset,
        /// <summary>
        /// 
        /// </summary>
        KnowledgeBase,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        WebhookEndpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromoteAttentionKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromoteAttentionKind value)
        {
            return value switch
            {
                PromoteAttentionKind.Agent => "agent",
                PromoteAttentionKind.AudioAsset => "audio_asset",
                PromoteAttentionKind.KnowledgeBase => "knowledge_base",
                PromoteAttentionKind.Tool => "tool",
                PromoteAttentionKind.WebhookEndpoint => "webhook_endpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromoteAttentionKind? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PromoteAttentionKind.Agent,
                "audio_asset" => PromoteAttentionKind.AudioAsset,
                "knowledge_base" => PromoteAttentionKind.KnowledgeBase,
                "tool" => PromoteAttentionKind.Tool,
                "webhook_endpoint" => PromoteAttentionKind.WebhookEndpoint,
                _ => null,
            };
        }
    }
}