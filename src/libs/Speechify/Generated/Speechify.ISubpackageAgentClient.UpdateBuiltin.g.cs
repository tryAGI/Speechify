#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Update Agent Builtin<br/>
        /// Update a builtin instance. All fields optional; omitting a<br/>
        /// field leaves it unchanged. The underlying `builtin` (which<br/>
        /// capability the instance maps to) is intentionally NOT<br/>
        /// patchable — change of identity would surprise the worker, so<br/>
        /// the customer should delete and recreate instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="builtinId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentBuiltin> UpdateBuiltinAsync(
            string id,
            string builtinId,

            global::Speechify.UpdateAgentBuiltinRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Builtin<br/>
        /// Update a builtin instance. All fields optional; omitting a<br/>
        /// field leaves it unchanged. The underlying `builtin` (which<br/>
        /// capability the instance maps to) is intentionally NOT<br/>
        /// patchable — change of identity would surprise the worker, so<br/>
        /// the customer should delete and recreate instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="builtinId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentBuiltin>> UpdateBuiltinAsResponseAsync(
            string id,
            string builtinId,

            global::Speechify.UpdateAgentBuiltinRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Builtin<br/>
        /// Update a builtin instance. All fields optional; omitting a<br/>
        /// field leaves it unchanged. The underlying `builtin` (which<br/>
        /// capability the instance maps to) is intentionally NOT<br/>
        /// patchable — change of identity would surprise the worker, so<br/>
        /// the customer should delete and recreate instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="builtinId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Per-instance configuration matching the per-builtin schema.
        /// </param>
        /// <param name="params">
        /// Per-call parameter descriptors.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentBuiltin> UpdateBuiltinAsync(
            string id,
            string builtinId,
            string? name = default,
            string? description = default,
            object? config = default,
            global::System.Collections.Generic.IList<object>? @params = default,
            bool? enabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}