
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateHostedAPIRequest
    {
        /// <summary>
        /// 3-40 lowercase letters, digits or hyphens; a DNS label, unique on the shared domain; immutable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// consumer_key when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateHostedApiRequestAuthModeJsonConverter))]
        public global::Speechify.CreateHostedApiRequestAuthMode? AuthMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cors_origins")]
        public global::System.Collections.Generic.IList<string>? CorsOrigins { get; set; }

        /// <summary>
        /// Runs the API may start per UTC day through its run routes; 1000 when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_run_cap")]
        public int? DailyRunCap { get; set; }

        /// <summary>
        /// Reads the API may serve from storage per UTC day; 100000 when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_read_cap")]
        public int? DailyReadCap { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Register the key set end-user tokens are verified against (an `https` URL on a public host).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_token_jwks_url")]
        public string? UserTokenJwksUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHostedAPIRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// 3-40 lowercase letters, digits or hyphens; a DNS label, unique on the shared domain; immutable.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="authMode">
        /// consumer_key when omitted.
        /// </param>
        /// <param name="corsOrigins"></param>
        /// <param name="dailyRunCap">
        /// Runs the API may start per UTC day through its run routes; 1000 when omitted.
        /// </param>
        /// <param name="dailyReadCap">
        /// Reads the API may serve from storage per UTC day; 100000 when omitted.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="userTokenJwksUrl">
        /// Register the key set end-user tokens are verified against (an `https` URL on a public host).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateHostedAPIRequest(
            string slug,
            string name,
            string? description,
            global::Speechify.CreateHostedApiRequestAuthMode? authMode,
            global::System.Collections.Generic.IList<string>? corsOrigins,
            int? dailyRunCap,
            int? dailyReadCap,
            string? projectId,
            string? userTokenJwksUrl)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.AuthMode = authMode;
            this.CorsOrigins = corsOrigins;
            this.DailyRunCap = dailyRunCap;
            this.DailyReadCap = dailyReadCap;
            this.ProjectId = projectId;
            this.UserTokenJwksUrl = userTokenJwksUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHostedAPIRequest" /> class.
        /// </summary>
        public CreateHostedAPIRequest()
        {
        }

    }
}