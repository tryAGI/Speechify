
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A customer-assembled API: a slug on the shared hosted-API<br/>
    /// domain, routes answered by resolvers, and consumer keys. Build product;<br/>
    /// the customer assembles it, Speechify hosts it.
    /// </summary>
    public sealed partial class HostedAPI
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The public host, `&lt;slug&gt;.&lt;hosted-api domain&gt;`; empty where no domain is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// `consumer_key`: every request presents a `ck_` bearer minted for this<br/>
        /// API. `public`: no credential; only read resolvers may be served, and<br/>
        /// the per-IP limiter is the only bound. `user_token`: every request<br/>
        /// presents a short-lived JWT your backend signed for the calling user<br/>
        /// (`sub`, `exp` within 24 hours, optional `aud` naming this API),<br/>
        /// verified against the API's signing secret (HS256) or its registered<br/>
        /// JWKS URL (RS256 / ES256 / EdDSA). Routes bind the verified claims as<br/>
        /// `{{user.sub}}` and the response cache is keyed per user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.HostedApiAuthModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedApiAuthMode AuthMode { get; set; }

        /// <summary>
        /// Browser origins allowed to call the API (`*` for any). Empty for server-to-server only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cors_origins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CorsOrigins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Runs the API's run routes may start per UTC day; the spend ceiling behind a leaked consumer key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_run_cap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DailyRunCap { get; set; }

        /// <summary>
        /// Reads the API's store, file and run_latest routes may serve from<br/>
        /// storage per UTC day; the storage ceiling behind a hot path. Always<br/>
        /// present on a current API; optional on the wire so a reader built<br/>
        /// before it existed keeps parsing. A<br/>
        /// response served from the cache is not a read. Past the cap a read<br/>
        /// route answers 429 `route_read_limit_reached`. Without Redis nothing<br/>
        /// counts: a public route is paused by the limiter in that state, a<br/>
        /// keyed or tokened caller passes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_read_cap")]
        public int? DailyReadCap { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The key set end-user tokens are verified against when set (an<br/>
        /// `https` URL on a public host, read on demand and cached briefly).<br/>
        /// When null, tokens are verified against the API's signing secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_token_jwks_url")]
        public string? UserTokenJwksUrl { get; set; }

        /// <summary>
        /// The masked signing secret end-user tokens are verified against<br/>
        /// (the rotate-user-token-secret verb mints it); null until minted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_token_secret_hint")]
        public string? UserTokenSecretHint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPI" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="hostname">
        /// The public host, `&lt;slug&gt;.&lt;hosted-api domain&gt;`; empty where no domain is configured.
        /// </param>
        /// <param name="baseUrl"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="authMode">
        /// `consumer_key`: every request presents a `ck_` bearer minted for this<br/>
        /// API. `public`: no credential; only read resolvers may be served, and<br/>
        /// the per-IP limiter is the only bound. `user_token`: every request<br/>
        /// presents a short-lived JWT your backend signed for the calling user<br/>
        /// (`sub`, `exp` within 24 hours, optional `aud` naming this API),<br/>
        /// verified against the API's signing secret (HS256) or its registered<br/>
        /// JWKS URL (RS256 / ES256 / EdDSA). Routes bind the verified claims as<br/>
        /// `{{user.sub}}` and the response cache is keyed per user.
        /// </param>
        /// <param name="corsOrigins">
        /// Browser origins allowed to call the API (`*` for any). Empty for server-to-server only.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="dailyRunCap">
        /// Runs the API's run routes may start per UTC day; the spend ceiling behind a leaked consumer key.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="dailyReadCap">
        /// Reads the API's store, file and run_latest routes may serve from<br/>
        /// storage per UTC day; the storage ceiling behind a hot path. Always<br/>
        /// present on a current API; optional on the wire so a reader built<br/>
        /// before it existed keeps parsing. A<br/>
        /// response served from the cache is not a read. Past the cap a read<br/>
        /// route answers 429 `route_read_limit_reached`. Without Redis nothing<br/>
        /// counts: a public route is paused by the limiter in that state, a<br/>
        /// keyed or tokened caller passes.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="userTokenJwksUrl">
        /// The key set end-user tokens are verified against when set (an<br/>
        /// `https` URL on a public host, read on demand and cached briefly).<br/>
        /// When null, tokens are verified against the API's signing secret.
        /// </param>
        /// <param name="userTokenSecretHint">
        /// The masked signing secret end-user tokens are verified against<br/>
        /// (the rotate-user-token-secret verb mints it); null until minted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPI(
            string id,
            string slug,
            string hostname,
            string baseUrl,
            string name,
            string description,
            global::Speechify.HostedApiAuthMode authMode,
            global::System.Collections.Generic.IList<string> corsOrigins,
            bool enabled,
            int dailyRunCap,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int? dailyReadCap,
            string? projectId,
            string? userTokenJwksUrl,
            string? userTokenSecretHint)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.AuthMode = authMode;
            this.CorsOrigins = corsOrigins ?? throw new global::System.ArgumentNullException(nameof(corsOrigins));
            this.Enabled = enabled;
            this.DailyRunCap = dailyRunCap;
            this.DailyReadCap = dailyReadCap;
            this.ProjectId = projectId;
            this.UserTokenJwksUrl = userTokenJwksUrl;
            this.UserTokenSecretHint = userTokenSecretHint;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPI" /> class.
        /// </summary>
        public HostedAPI()
        {
        }

    }
}