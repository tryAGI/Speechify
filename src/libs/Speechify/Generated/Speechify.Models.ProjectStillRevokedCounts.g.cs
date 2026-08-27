
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the restore deliberately left revoked: the credentials the purge<br/>
    /// killed. Every field is a real count, including zero.
    /// </summary>
    public sealed partial class ProjectStillRevokedCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        public int? ApiKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_accounts")]
        public int? ServiceAccounts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public int? Credentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_endpoints")]
        public int? WebhookEndpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStillRevokedCounts" /> class.
        /// </summary>
        /// <param name="apiKeys"></param>
        /// <param name="serviceAccounts"></param>
        /// <param name="credentials"></param>
        /// <param name="webhookEndpoints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectStillRevokedCounts(
            int? apiKeys,
            int? serviceAccounts,
            int? credentials,
            int? webhookEndpoints)
        {
            this.ApiKeys = apiKeys;
            this.ServiceAccounts = serviceAccounts;
            this.Credentials = credentials;
            this.WebhookEndpoints = webhookEndpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStillRevokedCounts" /> class.
        /// </summary>
        public ProjectStillRevokedCounts()
        {
        }

    }
}