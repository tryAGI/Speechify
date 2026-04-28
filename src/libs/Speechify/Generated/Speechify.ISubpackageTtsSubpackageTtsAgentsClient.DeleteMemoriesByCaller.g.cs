#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Delete Memories By Caller<br/>
        /// Delete every memory ever extracted for a specific caller on<br/>
        /// this agent. Privacy / GDPR surface. Returns the count of rows<br/>
        /// soft-deleted; rows become permanently unreachable immediately<br/>
        /// and are hard-deleted by the retention job after the tenant's<br/>
        /// configured retention window.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsDeleteMemoriesByCallerResponse> DeleteMemoriesByCallerAsync(
            string id,

            global::Speechify.TtsDeleteMemoriesByCallerRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Memories By Caller<br/>
        /// Delete every memory ever extracted for a specific caller on<br/>
        /// this agent. Privacy / GDPR surface. Returns the count of rows<br/>
        /// soft-deleted; rows become permanently unreachable immediately<br/>
        /// and are hard-deleted by the retention job after the tenant's<br/>
        /// configured retention window.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="callerIdentity"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsDeleteMemoriesByCallerResponse> DeleteMemoriesByCallerAsync(
            string id,
            string agentId,
            string callerIdentity,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}