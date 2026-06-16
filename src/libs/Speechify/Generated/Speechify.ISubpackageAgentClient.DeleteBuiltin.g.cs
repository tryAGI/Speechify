#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Delete Agent Builtin<br/>
        /// Delete a builtin instance from this agent. Idempotent on<br/>
        /// already-deleted ids (404). Does NOT detach references from<br/>
        /// flow nodes that name the instance; the worker logs and skips<br/>
        /// on missing-row at session start (fail-soft).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="builtinId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteBuiltinAsync(
            string id,
            string builtinId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Agent Builtin<br/>
        /// Delete a builtin instance from this agent. Idempotent on<br/>
        /// already-deleted ids (404). Does NOT detach references from<br/>
        /// flow nodes that name the instance; the worker logs and skips<br/>
        /// on missing-row at session start (fail-soft).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="builtinId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteBuiltinAsResponseAsync(
            string id,
            string builtinId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}