
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Stable code a client can branch on. `credential_not_attached`: the<br/>
    /// source referenced a vault credential, which never travels.<br/>
    /// `webhook_secret_reminted`: a fresh signing secret was minted; rotate<br/>
    /// to read it. `webhook_secret_not_copied`: the agent's customer-set<br/>
    /// post-call secret was cleared. `renamed`: the copy took a suffixed<br/>
    /// name. `phone_number_not_copied`: the source agent had numbers bound.<br/>
    /// `documents_not_copied`: the knowledge base held uploaded or pasted<br/>
    /// documents. `import_not_requeued`: URL sources could not be queued.<br/>
    /// `audio_asset_not_copied`: no asset storage is configured here.
    /// </summary>
    public enum PromoteAttentionReason
    {
        /// <summary>
        /// no asset storage is configured here.
        /// </summary>
        AudioAssetNotCopied,
        /// <summary>
        /// the
        /// </summary>
        CredentialNotAttached,
        /// <summary>
        /// the knowledge base held uploaded or pasted
        /// </summary>
        DocumentsNotCopied,
        /// <summary>
        /// URL sources could not be queued.
        /// </summary>
        ImportNotRequeued,
        /// <summary>
        /// the source agent had numbers bound.
        /// </summary>
        PhoneNumberNotCopied,
        /// <summary>
        /// the copy took a suffixed
        /// </summary>
        Renamed,
        /// <summary>
        /// the agent's customer-set
        /// </summary>
        WebhookSecretNotCopied,
        /// <summary>
        /// a fresh signing secret was minted; rotate
        /// </summary>
        WebhookSecretReminted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromoteAttentionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromoteAttentionReason value)
        {
            return value switch
            {
                PromoteAttentionReason.AudioAssetNotCopied => "audio_asset_not_copied",
                PromoteAttentionReason.CredentialNotAttached => "credential_not_attached",
                PromoteAttentionReason.DocumentsNotCopied => "documents_not_copied",
                PromoteAttentionReason.ImportNotRequeued => "import_not_requeued",
                PromoteAttentionReason.PhoneNumberNotCopied => "phone_number_not_copied",
                PromoteAttentionReason.Renamed => "renamed",
                PromoteAttentionReason.WebhookSecretNotCopied => "webhook_secret_not_copied",
                PromoteAttentionReason.WebhookSecretReminted => "webhook_secret_reminted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromoteAttentionReason? ToEnum(string value)
        {
            return value switch
            {
                "audio_asset_not_copied" => PromoteAttentionReason.AudioAssetNotCopied,
                "credential_not_attached" => PromoteAttentionReason.CredentialNotAttached,
                "documents_not_copied" => PromoteAttentionReason.DocumentsNotCopied,
                "import_not_requeued" => PromoteAttentionReason.ImportNotRequeued,
                "phone_number_not_copied" => PromoteAttentionReason.PhoneNumberNotCopied,
                "renamed" => PromoteAttentionReason.Renamed,
                "webhook_secret_not_copied" => PromoteAttentionReason.WebhookSecretNotCopied,
                "webhook_secret_reminted" => PromoteAttentionReason.WebhookSecretReminted,
                _ => null,
            };
        }
    }
}