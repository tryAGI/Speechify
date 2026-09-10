
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateHostedAPIRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.UpdateHostedApiRequestAuthModeJsonConverter))]
        public global::Speechify.UpdateHostedApiRequestAuthMode? AuthMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cors_origins")]
        public global::System.Collections.Generic.IList<string>? CorsOrigins { get; set; }

        /// <summary>
        /// A paused API answers 503 to every consumer request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_run_cap")]
        public int? DailyRunCap { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_read_cap")]
        public int? DailyReadCap { get; set; }

        /// <summary>
        /// Replace the registered key set; an empty string removes it, after which the signing secret verifies tokens again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_token_jwks_url")]
        public string? UserTokenJwksUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHostedAPIRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="authMode"></param>
        /// <param name="corsOrigins"></param>
        /// <param name="enabled">
        /// A paused API answers 503 to every consumer request.
        /// </param>
        /// <param name="dailyRunCap"></param>
        /// <param name="dailyReadCap"></param>
        /// <param name="userTokenJwksUrl">
        /// Replace the registered key set; an empty string removes it, after which the signing secret verifies tokens again.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateHostedAPIRequest(
            string? name,
            string? description,
            global::Speechify.UpdateHostedApiRequestAuthMode? authMode,
            global::System.Collections.Generic.IList<string>? corsOrigins,
            bool? enabled,
            int? dailyRunCap,
            int? dailyReadCap,
            string? userTokenJwksUrl)
        {
            this.Name = name;
            this.Description = description;
            this.AuthMode = authMode;
            this.CorsOrigins = corsOrigins;
            this.Enabled = enabled;
            this.DailyRunCap = dailyRunCap;
            this.DailyReadCap = dailyReadCap;
            this.UserTokenJwksUrl = userTokenJwksUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHostedAPIRequest" /> class.
        /// </summary>
        public UpdateHostedAPIRequest()
        {
        }

    }
}