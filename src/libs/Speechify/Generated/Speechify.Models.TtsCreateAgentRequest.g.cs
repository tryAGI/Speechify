
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Spoken verbatim at session start — no LLM round trip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Optional chat model slug. Leave empty to use the Speechify default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// Voice slug from the VMS catalog (see GET /v1/voices). Required — the server rejects writes with an unknown or empty slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// Optional per-agent hostname allowlist (see Agent schema).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_enabled")]
        public bool? MemoryEnabled { get; set; }

        /// <summary>
        /// Default Value: 90
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_retention_days")]
        public int? MemoryRetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateAgentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="voiceId">
        /// Voice slug from the VMS catalog (see GET /v1/voices). Required — the server rejects writes with an unknown or empty slug.
        /// </param>
        /// <param name="slug">
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage">
        /// Spoken verbatim at session start — no LLM round trip.
        /// </param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="llmModel">
        /// Optional chat model slug. Leave empty to use the Speechify default.
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="config"></param>
        /// <param name="isPublic">
        /// Default Value: false
        /// </param>
        /// <param name="allowedOrigins"></param>
        /// <param name="hostnameAllowlist">
        /// Optional per-agent hostname allowlist (see Agent schema).
        /// </param>
        /// <param name="memoryEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="memoryRetentionDays">
        /// Default Value: 90
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateAgentRequest(
            string name,
            string voiceId,
            string? slug,
            string? prompt,
            string? firstMessage,
            string? language,
            string? llmModel,
            double? temperature,
            object? config,
            bool? isPublic,
            global::System.Collections.Generic.IList<string>? allowedOrigins,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist,
            bool? memoryEnabled,
            int? memoryRetentionDays)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug;
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.LlmModel = llmModel;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Temperature = temperature;
            this.Config = config;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins;
            this.HostnameAllowlist = hostnameAllowlist;
            this.MemoryEnabled = memoryEnabled;
            this.MemoryRetentionDays = memoryRetentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateAgentRequest" /> class.
        /// </summary>
        public TtsCreateAgentRequest()
        {
        }
    }
}