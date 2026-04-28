
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsAgent
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// ISO 639-1 code, e.g. 'en'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Chat model slug. Leave empty to use the Speechify default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmModel { get; set; }

        /// <summary>
        /// Speechify voice slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// Free-form agent config JSON (evaluation_config is read via its own endpoint).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// When true, the `&lt;speechify-agent&gt;` web component can start a<br/>
        /// session against this agent without an API key, subject to<br/>
        /// the `allowed_origins` allowlist. When false (default), only<br/>
        /// authenticated callers can start sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// Exact `Origin` header values (e.g. `https://example.com`)<br/>
        /// that are allowed to start public sessions. Empty array<br/>
        /// with `is_public = true` means any origin is accepted —<br/>
        /// intended for open demos. No subdomain wildcards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Optional per-agent hostname allowlist enforced at<br/>
        /// session-creation time. When set and non-empty, the<br/>
        /// `Origin` header's hostname must be an exact member.<br/>
        /// Bare hostnames only — no scheme, port, or path. Up to<br/>
        /// 10 entries. Omit (null) or leave empty for no<br/>
        /// enforcement (public agents accept any hostname).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        /// When true, the post-call extractor writes durable facts about<br/>
        /// each caller; at conversation-start the retriever injects the<br/>
        /// top matches into the system prompt via the `{{memory}}`<br/>
        /// template variable. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MemoryEnabled { get; set; }

        /// <summary>
        /// Maximum age (in days) of memories kept and surfaced to the<br/>
        /// retriever. 0 disables the cap. Defaults to 90.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_retention_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryRetentionDays { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsAgent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="language">
        /// ISO 639-1 code, e.g. 'en'.
        /// </param>
        /// <param name="llmModel">
        /// Chat model slug. Leave empty to use the Speechify default.
        /// </param>
        /// <param name="voiceId">
        /// Speechify voice slug.
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="isPublic">
        /// When true, the `&lt;speechify-agent&gt;` web component can start a<br/>
        /// session against this agent without an API key, subject to<br/>
        /// the `allowed_origins` allowlist. When false (default), only<br/>
        /// authenticated callers can start sessions.
        /// </param>
        /// <param name="allowedOrigins">
        /// Exact `Origin` header values (e.g. `https://example.com`)<br/>
        /// that are allowed to start public sessions. Empty array<br/>
        /// with `is_public = true` means any origin is accepted —<br/>
        /// intended for open demos. No subdomain wildcards.
        /// </param>
        /// <param name="memoryEnabled">
        /// When true, the post-call extractor writes durable facts about<br/>
        /// each caller; at conversation-start the retriever injects the<br/>
        /// top matches into the system prompt via the `{{memory}}`<br/>
        /// template variable. Defaults to false.
        /// </param>
        /// <param name="memoryRetentionDays">
        /// Maximum age (in days) of memories kept and surfaced to the<br/>
        /// retriever. 0 disables the cap. Defaults to 90.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="config">
        /// Free-form agent config JSON (evaluation_config is read via its own endpoint).
        /// </param>
        /// <param name="hostnameAllowlist">
        /// Optional per-agent hostname allowlist enforced at<br/>
        /// session-creation time. When set and non-empty, the<br/>
        /// `Origin` header's hostname must be an exact member.<br/>
        /// Bare hostnames only — no scheme, port, or path. Up to<br/>
        /// 10 entries. Omit (null) or leave empty for no<br/>
        /// enforcement (public agents accept any hostname).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAgent(
            string id,
            string name,
            string slug,
            string language,
            string llmModel,
            string voiceId,
            double temperature,
            bool isPublic,
            global::System.Collections.Generic.IList<string> allowedOrigins,
            bool memoryEnabled,
            int memoryRetentionDays,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? prompt,
            string? firstMessage,
            object? config,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.LlmModel = llmModel ?? throw new global::System.ArgumentNullException(nameof(llmModel));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Temperature = temperature;
            this.Config = config;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins ?? throw new global::System.ArgumentNullException(nameof(allowedOrigins));
            this.HostnameAllowlist = hostnameAllowlist;
            this.MemoryEnabled = memoryEnabled;
            this.MemoryRetentionDays = memoryRetentionDays;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgent" /> class.
        /// </summary>
        public TtsAgent()
        {
        }
    }
}