
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Twilio credentials for the one-click import flow. Used only when<br/>
    /// `provider=twilio`. The Account SID and Auth Token are used to<br/>
    /// provision an Elastic SIP Trunk on the customer's Twilio account<br/>
    /// pointing at LiveKit's SIP endpoint, then stored for future trunk<br/>
    /// management operations.
    /// </summary>
    public sealed partial class TwilioImportSpec
    {
        /// <summary>
        /// Twilio Account SID (starts with `AC`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// Twilio Auth Token. Write-only - never echoed back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioImportSpec" /> class.
        /// </summary>
        /// <param name="accountSid">
        /// Twilio Account SID (starts with `AC`).
        /// </param>
        /// <param name="authToken">
        /// Twilio Auth Token. Write-only - never echoed back.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioImportSpec(
            string accountSid,
            string authToken)
        {
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.AuthToken = authToken ?? throw new global::System.ArgumentNullException(nameof(authToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioImportSpec" /> class.
        /// </summary>
        public TwilioImportSpec()
        {
        }

    }
}