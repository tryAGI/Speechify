#nullable enable

namespace Speechify
{
    public partial interface IFlowClient
    {
        /// <summary>
        /// Get Flow Graph Schema<br/>
        /// Return the JSON Schema describing the flow graph node taxonomy.<br/>
        /// Unauthenticated; flow editors fetch it to validate graphs client-side.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentFlowGetSchemaResponse200> GetSchemaAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Flow Graph Schema<br/>
        /// Return the JSON Schema describing the flow graph node taxonomy.<br/>
        /// Unauthenticated; flow editors fetch it to validate graphs client-side.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentFlowGetSchemaResponse200>> GetSchemaAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}