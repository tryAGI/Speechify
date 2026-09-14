
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
        /// What the API is for; also the instructions an MCP client hands its model when `mcp_enabled` is on.
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_write_cap")]
        public int? DailyWriteCap { get; set; }

        /// <summary>
        /// Switch the MCP face at `POST &lt;base_url&gt;/mcp` on or off. Refused with<br/>
        /// 400 `validation_failed` naming `mcp_enabled` when the API is, or is<br/>
        /// being made, `public`. Allow up to 15 seconds for the switch, like<br/>
        /// any route change, to reach every server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_enabled")]
        public bool? McpEnabled { get; set; }

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
        /// <param name="description">
        /// What the API is for; also the instructions an MCP client hands its model when `mcp_enabled` is on.
        /// </param>
        /// <param name="authMode"></param>
        /// <param name="corsOrigins"></param>
        /// <param name="enabled">
        /// A paused API answers 503 to every consumer request.
        /// </param>
        /// <param name="dailyRunCap"></param>
        /// <param name="dailyReadCap"></param>
        /// <param name="dailyWriteCap"></param>
        /// <param name="mcpEnabled">
        /// Switch the MCP face at `POST &lt;base_url&gt;/mcp` on or off. Refused with<br/>
        /// 400 `validation_failed` naming `mcp_enabled` when the API is, or is<br/>
        /// being made, `public`. Allow up to 15 seconds for the switch, like<br/>
        /// any route change, to reach every server.
        /// </param>
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
            int? dailyWriteCap,
            bool? mcpEnabled,
            string? userTokenJwksUrl)
        {
            this.Name = name;
            this.Description = description;
            this.AuthMode = authMode;
            this.CorsOrigins = corsOrigins;
            this.Enabled = enabled;
            this.DailyRunCap = dailyRunCap;
            this.DailyReadCap = dailyReadCap;
            this.DailyWriteCap = dailyWriteCap;
            this.McpEnabled = mcpEnabled;
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