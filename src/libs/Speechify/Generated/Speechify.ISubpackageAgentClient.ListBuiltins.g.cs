#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Agent Builtins<br/>
        /// List every builtin instance configured on this agent. Each row<br/>
        /// is one instance of a worker-resident capability (`end_call`,<br/>
        /// `play_audio`, etc.) bound to this specific agent with its own<br/>
        /// LLM-facing name, description, and per-call config. Same builtin<br/>
        /// may appear N times on one agent — typically two `play_audio`<br/>
        /// rows bound to different audio assets.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentBuiltinsResponse> ListBuiltinsAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Builtins<br/>
        /// List every builtin instance configured on this agent. Each row<br/>
        /// is one instance of a worker-resident capability (`end_call`,<br/>
        /// `play_audio`, etc.) bound to this specific agent with its own<br/>
        /// LLM-facing name, description, and per-call config. Same builtin<br/>
        /// may appear N times on one agent — typically two `play_audio`<br/>
        /// rows bound to different audio assets.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentBuiltinsResponse>> ListBuiltinsAsResponseAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}