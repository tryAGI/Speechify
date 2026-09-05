#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Get Knowledge Base Coverage<br/>
        /// Report what callers asked that this knowledge base did not cover<br/>
        /// over a trailing window, and which of its documents no search<br/>
        /// surfaced. Built from the searches agents ran against it: a health<br/>
        /// strip (searches by verdict, conversations, median latency, documents<br/>
        /// used), the partial and insufficient questions clustered by the<br/>
        /// content words they share, and the ready documents no search in the<br/>
        /// window retrieved a passage from. Documents added in the last 24<br/>
        /// hours are not listed as unused yet.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="days">
        /// Default Value: 30
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseCoverage> GetCoverageAsync(
            string kbId,
            int? days = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Knowledge Base Coverage<br/>
        /// Report what callers asked that this knowledge base did not cover<br/>
        /// over a trailing window, and which of its documents no search<br/>
        /// surfaced. Built from the searches agents ran against it: a health<br/>
        /// strip (searches by verdict, conversations, median latency, documents<br/>
        /// used), the partial and insufficient questions clustered by the<br/>
        /// content words they share, and the ready documents no search in the<br/>
        /// window retrieved a passage from. Documents added in the last 24<br/>
        /// hours are not listed as unused yet.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="days">
        /// Default Value: 30
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseCoverage>> GetCoverageAsResponseAsync(
            string kbId,
            int? days = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}