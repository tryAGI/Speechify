
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Language-model configuration. Omit the whole block on create to<br/>
    /// run on the platform default model. On update (merge-patch) send<br/>
    /// only the sub-fields you want to change: an explicit null clears a<br/>
    /// nullable field to its default, a value sets it, and anything<br/>
    /// omitted is left unchanged. `provider`/`model` are validated as a<br/>
    /// pair, inheriting the omitted half from the stored value.
    /// </summary>
    public sealed partial class AgentLLMConfig
    {
        /// <summary>
        /// LLM backend. Null (or omit) uses the platform default,<br/>
        /// resolved server-side at dispatch. `openai` and `speechify`<br/>
        /// pair with a `model` from the allowed table. `custom` points<br/>
        /// the worker at any OpenAI / vLLM-compatible endpoint - see<br/>
        /// `base_url`, `credential_id`, `extra_body`. Must be paired with<br/>
        /// a non-null `model`; setting one without the other is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentLlmConfigProviderJsonConverter))]
        public global::Speechify.AgentLlmConfigProvider? Provider { get; set; }

        /// <summary>
        /// Chat model slug. Null (or omit) uses the platform default.<br/>
        /// For `openai` / `speechify` it must be a slug from the allowed<br/>
        /// table; for `custom` it is free-form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Custom OpenAI/vLLM-compatible endpoint base URL. Required<br/>
        /// when `provider` is `custom`, rejected otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// `cred_&lt;crockford&gt;` id of a `bearer` credential in the<br/>
        /// workspace vault holding the custom endpoint's API key. The<br/>
        /// secret lives in the vault and is resolved server-side at<br/>
        /// dispatch, never inlined on the agent. On write, send a value<br/>
        /// to point at a credential, an empty string to clear it, or omit<br/>
        /// it to keep the stored reference unchanged. On read, the<br/>
        /// referenced `cred_` id, or null when none is referenced. Create<br/>
        /// the credential first via `POST /v1/credentials`. Valid only<br/>
        /// when `provider` is `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// JSON object forwarded verbatim to the custom endpoint as the<br/>
        /// chat.completions `extra_body` (reasoning / sampling knobs).<br/>
        /// Valid only when `provider` is `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_body")]
        public object? ExtraBody { get; set; }

        /// <summary>
        /// Sampling temperature in the range 0.0-1.0. Defaults to 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMConfig" /> class.
        /// </summary>
        /// <param name="provider">
        /// LLM backend. Null (or omit) uses the platform default,<br/>
        /// resolved server-side at dispatch. `openai` and `speechify`<br/>
        /// pair with a `model` from the allowed table. `custom` points<br/>
        /// the worker at any OpenAI / vLLM-compatible endpoint - see<br/>
        /// `base_url`, `credential_id`, `extra_body`. Must be paired with<br/>
        /// a non-null `model`; setting one without the other is rejected.
        /// </param>
        /// <param name="model">
        /// Chat model slug. Null (or omit) uses the platform default.<br/>
        /// For `openai` / `speechify` it must be a slug from the allowed<br/>
        /// table; for `custom` it is free-form.
        /// </param>
        /// <param name="baseUrl">
        /// Custom OpenAI/vLLM-compatible endpoint base URL. Required<br/>
        /// when `provider` is `custom`, rejected otherwise.
        /// </param>
        /// <param name="credentialId">
        /// `cred_&lt;crockford&gt;` id of a `bearer` credential in the<br/>
        /// workspace vault holding the custom endpoint's API key. The<br/>
        /// secret lives in the vault and is resolved server-side at<br/>
        /// dispatch, never inlined on the agent. On write, send a value<br/>
        /// to point at a credential, an empty string to clear it, or omit<br/>
        /// it to keep the stored reference unchanged. On read, the<br/>
        /// referenced `cred_` id, or null when none is referenced. Create<br/>
        /// the credential first via `POST /v1/credentials`. Valid only<br/>
        /// when `provider` is `custom`.
        /// </param>
        /// <param name="extraBody">
        /// JSON object forwarded verbatim to the custom endpoint as the<br/>
        /// chat.completions `extra_body` (reasoning / sampling knobs).<br/>
        /// Valid only when `provider` is `custom`.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature in the range 0.0-1.0. Defaults to 0.5.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMConfig(
            global::Speechify.AgentLlmConfigProvider? provider,
            string? model,
            string? baseUrl,
            string? credentialId,
            object? extraBody,
            double? temperature)
        {
            this.Provider = provider;
            this.Model = model;
            this.BaseUrl = baseUrl;
            this.CredentialId = credentialId;
            this.ExtraBody = extraBody;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMConfig" /> class.
        /// </summary>
        public AgentLLMConfig()
        {
        }

    }
}