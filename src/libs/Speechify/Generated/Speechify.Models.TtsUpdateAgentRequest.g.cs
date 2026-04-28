
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsUpdateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// When supplied, replaces the stored list. Pass an empty<br/>
        /// array to clear enforcement (public agent is open again).<br/>
        /// Omit the field to leave the existing value unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_enabled")]
        public bool? MemoryEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_retention_days")]
        public int? MemoryRetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="language"></param>
        /// <param name="llmModel"></param>
        /// <param name="voiceId"></param>
        /// <param name="temperature"></param>
        /// <param name="config"></param>
        /// <param name="isPublic"></param>
        /// <param name="allowedOrigins"></param>
        /// <param name="hostnameAllowlist">
        /// When supplied, replaces the stored list. Pass an empty<br/>
        /// array to clear enforcement (public agent is open again).<br/>
        /// Omit the field to leave the existing value unchanged.
        /// </param>
        /// <param name="memoryEnabled"></param>
        /// <param name="memoryRetentionDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateAgentRequest(
            string? name,
            string? prompt,
            string? firstMessage,
            string? language,
            string? llmModel,
            string? voiceId,
            double? temperature,
            object? config,
            bool? isPublic,
            global::System.Collections.Generic.IList<string>? allowedOrigins,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist,
            bool? memoryEnabled,
            int? memoryRetentionDays)
        {
            this.Name = name;
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.LlmModel = llmModel;
            this.VoiceId = voiceId;
            this.Temperature = temperature;
            this.Config = config;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins;
            this.HostnameAllowlist = hostnameAllowlist;
            this.MemoryEnabled = memoryEnabled;
            this.MemoryRetentionDays = memoryRetentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentRequest" /> class.
        /// </summary>
        public TtsUpdateAgentRequest()
        {
        }
    }
}