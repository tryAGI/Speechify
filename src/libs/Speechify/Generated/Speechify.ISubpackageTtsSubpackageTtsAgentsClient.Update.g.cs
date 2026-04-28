#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Update<br/>
        /// Update a voice agent. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> UpdateAsync(
            string id,

            global::Speechify.TtsUpdateAgentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update<br/>
        /// Update a voice agent. Only fields present on the request body are changed.
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> UpdateAsync(
            string id,
            string? name = default,
            string? prompt = default,
            string? firstMessage = default,
            string? language = default,
            string? llmModel = default,
            string? voiceId = default,
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