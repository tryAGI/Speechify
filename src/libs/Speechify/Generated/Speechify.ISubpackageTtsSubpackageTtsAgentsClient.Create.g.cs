#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> CreateAsync(

            global::Speechify.TtsCreateAgentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="name"></param>
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
        /// <param name="voiceId">
        /// Voice slug from the VMS catalog (see GET /v1/voices). Required — the server rejects writes with an unknown or empty slug.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> CreateAsync(
            string name,
            string voiceId,
            string? slug = default,
            string? prompt = default,
            string? firstMessage = default,
            string? language = default,
            string? llmModel = default,
            double? temperature = default,
            object? config = default,
            bool? isPublic = default,
            global::System.Collections.Generic.IList<string>? allowedOrigins = default,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist = default,
            bool? memoryEnabled = default,
            int? memoryRetentionDays = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}