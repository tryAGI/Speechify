
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
        /// The API's display name; the server title an MCP client shows when `mcp_enabled` is on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// What the API is for. When `mcp_enabled` is on it is also the<br/>
        /// instructions an MCP client hands its model, so say what the tools<br/>
        /// are for and when to use them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Who the API answers, narrowest first. `owner`: only the API's owner,<br/>
        /// with their own Speechify API key or console session. `workspace`:<br/>
        /// any member of the owning workspace, the same way. `user_token`:<br/>
        /// every request presents a short-lived JWT your backend signed for the<br/>
        /// calling user (`sub`, `exp` within 24 hours, optional `aud` naming<br/>
        /// this API), verified against the API's signing secret (HS256) or its<br/>
        /// registered JWKS URL (RS256 / ES256 / EdDSA). `consumer_key`: every<br/>
        /// request presents a `ck_` bearer minted for this API. `public`: no<br/>
        /// credential; only read resolvers may be served, the per-IP limiter is<br/>
        /// the only bound, and a workspace can refuse it as policy<br/>
        /// (`hosted_apis_public_allowed`). The three modes that name a person<br/>
        /// (`owner`, `workspace`, `user_token`) let routes bind `{{user.sub}}`,<br/>
        /// key the response cache per person, and stamp a written document as<br/>
        /// that person's.
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
        /// Reads the API's store, file, run_latest and tool routes may serve<br/>
        /// per UTC day; the ceiling behind a hot path, and for a tool route<br/>
        /// behind the vendor budget its calls draw on. Always present on a<br/>
        /// current API; optional on the wire so a reader built<br/>
        /// before it existed keeps parsing. A<br/>
        /// response served from the cache is not a read. Past the cap a read<br/>
        /// route answers 429 `route_read_limit_reached`. Without Redis nothing<br/>
        /// counts: a public route is paused by the limiter in that state, a<br/>
        /// keyed or tokened caller passes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_read_cap")]
        public int? DailyReadCap { get; set; }

        /// <summary>
        /// Documents the API's write routes may land per UTC day; the storage<br/>
        /// ceiling behind a leaked key on a write route. Past the cap a write<br/>
        /// route answers 429 `route_write_limit_reached`. Optional on the wire<br/>
        /// for the same reason as `daily_read_cap`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_write_cap")]
        public int? DailyWriteCap { get; set; }

        /// <summary>
        /// Whether the API also serves its routes as an MCP server at<br/>
        /// `POST &lt;base_url&gt;/mcp` (streamable HTTP, stateless, POST only): every<br/>
        /// enabled route except a file route is listed as a tool, named by the<br/>
        /// route's `name` and described by its `description`, and a call runs<br/>
        /// under the same audience, consumer keys, per-key limits, daily caps<br/>
        /// and request log the route has. An MCP client authenticates with the<br/>
        /// same bearer a plain consumer sends (a `ck_` consumer key, an<br/>
        /// end-user token, or a Speechify API key on a `workspace` or `owner`<br/>
        /// API); the API's OpenAPI document names the address under<br/>
        /// `x-speechify-mcp.url`. Off for a new API, where `/mcp` answers 404<br/>
        /// `hosted_mcp_not_enabled`; never true on a `public` API (refused<br/>
        /// with 400 on either switch). Optional on the wire for the same<br/>
        /// reason as `daily_read_cap`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_enabled")]
        public bool? McpEnabled { get; set; }

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
        /// <param name="name">
        /// The API's display name; the server title an MCP client shows when `mcp_enabled` is on.
        /// </param>
        /// <param name="description">
        /// What the API is for. When `mcp_enabled` is on it is also the<br/>
        /// instructions an MCP client hands its model, so say what the tools<br/>
        /// are for and when to use them.
        /// </param>
        /// <param name="authMode">
        /// Who the API answers, narrowest first. `owner`: only the API's owner,<br/>
        /// with their own Speechify API key or console session. `workspace`:<br/>
        /// any member of the owning workspace, the same way. `user_token`:<br/>
        /// every request presents a short-lived JWT your backend signed for the<br/>
        /// calling user (`sub`, `exp` within 24 hours, optional `aud` naming<br/>
        /// this API), verified against the API's signing secret (HS256) or its<br/>
        /// registered JWKS URL (RS256 / ES256 / EdDSA). `consumer_key`: every<br/>
        /// request presents a `ck_` bearer minted for this API. `public`: no<br/>
        /// credential; only read resolvers may be served, the per-IP limiter is<br/>
        /// the only bound, and a workspace can refuse it as policy<br/>
        /// (`hosted_apis_public_allowed`). The three modes that name a person<br/>
        /// (`owner`, `workspace`, `user_token`) let routes bind `{{user.sub}}`,<br/>
        /// key the response cache per person, and stamp a written document as<br/>
        /// that person's.
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
        /// Reads the API's store, file, run_latest and tool routes may serve<br/>
        /// per UTC day; the ceiling behind a hot path, and for a tool route<br/>
        /// behind the vendor budget its calls draw on. Always present on a<br/>
        /// current API; optional on the wire so a reader built<br/>
        /// before it existed keeps parsing. A<br/>
        /// response served from the cache is not a read. Past the cap a read<br/>
        /// route answers 429 `route_read_limit_reached`. Without Redis nothing<br/>
        /// counts: a public route is paused by the limiter in that state, a<br/>
        /// keyed or tokened caller passes.
        /// </param>
        /// <param name="dailyWriteCap">
        /// Documents the API's write routes may land per UTC day; the storage<br/>
        /// ceiling behind a leaked key on a write route. Past the cap a write<br/>
        /// route answers 429 `route_write_limit_reached`. Optional on the wire<br/>
        /// for the same reason as `daily_read_cap`.
        /// </param>
        /// <param name="mcpEnabled">
        /// Whether the API also serves its routes as an MCP server at<br/>
        /// `POST &lt;base_url&gt;/mcp` (streamable HTTP, stateless, POST only): every<br/>
        /// enabled route except a file route is listed as a tool, named by the<br/>
        /// route's `name` and described by its `description`, and a call runs<br/>
        /// under the same audience, consumer keys, per-key limits, daily caps<br/>
        /// and request log the route has. An MCP client authenticates with the<br/>
        /// same bearer a plain consumer sends (a `ck_` consumer key, an<br/>
        /// end-user token, or a Speechify API key on a `workspace` or `owner`<br/>
        /// API); the API's OpenAPI document names the address under<br/>
        /// `x-speechify-mcp.url`. Off for a new API, where `/mcp` answers 404<br/>
        /// `hosted_mcp_not_enabled`; never true on a `public` API (refused<br/>
        /// with 400 on either switch). Optional on the wire for the same<br/>
        /// reason as `daily_read_cap`.
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
            int? dailyWriteCap,
            bool? mcpEnabled,
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
            this.DailyWriteCap = dailyWriteCap;
            this.McpEnabled = mcpEnabled;
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