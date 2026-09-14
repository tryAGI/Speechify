#nullable enable

namespace Speechify
{
    public partial interface IToolDefinitionsClient
    {
        /// <summary>
        /// Test OpenAPI Operation<br/>
        /// Call one operation of an `openapi` tool config that is not saved yet,<br/>
        /// through the same path a run and a live session execute it, and answer<br/>
        /// what the agent would read. Use it after<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi` and before<br/>
        /// `POST /v1/agents/tool-definitions`, to check that the arguments reach<br/>
        /// the vendor and that a `pick` / `derive` / `max_items` mapping keeps<br/>
        /// what the agent needs.<br/>
        /// Read the result in this order. `error` is set only when no call was<br/>
        /// made: a config the create endpoint would refuse, an operation the<br/>
        /// config does not have, a write operation, or a credential that does not<br/>
        /// resolve or cannot mint a token. Otherwise `outcome` says how the call<br/>
        /// ended, and only `ok` is a preview that worked. On `ok` with a JSON answer, `raw` is the<br/>
        /// vendor's answer and `mapped` is the same answer after the operation's<br/>
        /// `response` mapping, so one call shows both sides; `observation` is<br/>
        /// what the agent reads, trimmed to its observation window.<br/>
        /// Only a read operation runs (declared `read`, or a GET or HEAD that<br/>
        /// declares no class): nobody approves a test call, so a write is<br/>
        /// answered with `error` set and never reaches the vendor. Nothing is<br/>
        /// persisted and the tool's own `max_requests_per_minute` does not apply,<br/>
        /// but the call does reach the vendor and counts against the vendor's<br/>
        /// own limits. It acts with a workspace credential, so it needs the<br/>
        /// `content.manage` permission a tool create does.<br/>
        /// A malformed request is a 400: a missing `operation`, `arguments` that<br/>
        /// are not an object, or a field this endpoint does not define, which is<br/>
        /// refused naming every unknown field.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TestOpenAPICallResult> TestOpenAPICallAsync(

            global::Speechify.TestOpenAPICallRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test OpenAPI Operation<br/>
        /// Call one operation of an `openapi` tool config that is not saved yet,<br/>
        /// through the same path a run and a live session execute it, and answer<br/>
        /// what the agent would read. Use it after<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi` and before<br/>
        /// `POST /v1/agents/tool-definitions`, to check that the arguments reach<br/>
        /// the vendor and that a `pick` / `derive` / `max_items` mapping keeps<br/>
        /// what the agent needs.<br/>
        /// Read the result in this order. `error` is set only when no call was<br/>
        /// made: a config the create endpoint would refuse, an operation the<br/>
        /// config does not have, a write operation, or a credential that does not<br/>
        /// resolve or cannot mint a token. Otherwise `outcome` says how the call<br/>
        /// ended, and only `ok` is a preview that worked. On `ok` with a JSON answer, `raw` is the<br/>
        /// vendor's answer and `mapped` is the same answer after the operation's<br/>
        /// `response` mapping, so one call shows both sides; `observation` is<br/>
        /// what the agent reads, trimmed to its observation window.<br/>
        /// Only a read operation runs (declared `read`, or a GET or HEAD that<br/>
        /// declares no class): nobody approves a test call, so a write is<br/>
        /// answered with `error` set and never reaches the vendor. Nothing is<br/>
        /// persisted and the tool's own `max_requests_per_minute` does not apply,<br/>
        /// but the call does reach the vendor and counts against the vendor's<br/>
        /// own limits. It acts with a workspace credential, so it needs the<br/>
        /// `content.manage` permission a tool create does.<br/>
        /// A malformed request is a 400: a missing `operation`, `arguments` that<br/>
        /// are not an object, or a field this endpoint does not define, which is<br/>
        /// refused naming every unknown field.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TestOpenAPICallResult>> TestOpenAPICallAsResponseAsync(

            global::Speechify.TestOpenAPICallRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test OpenAPI Operation<br/>
        /// Call one operation of an `openapi` tool config that is not saved yet,<br/>
        /// through the same path a run and a live session execute it, and answer<br/>
        /// what the agent would read. Use it after<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi` and before<br/>
        /// `POST /v1/agents/tool-definitions`, to check that the arguments reach<br/>
        /// the vendor and that a `pick` / `derive` / `max_items` mapping keeps<br/>
        /// what the agent needs.<br/>
        /// Read the result in this order. `error` is set only when no call was<br/>
        /// made: a config the create endpoint would refuse, an operation the<br/>
        /// config does not have, a write operation, or a credential that does not<br/>
        /// resolve or cannot mint a token. Otherwise `outcome` says how the call<br/>
        /// ended, and only `ok` is a preview that worked. On `ok` with a JSON answer, `raw` is the<br/>
        /// vendor's answer and `mapped` is the same answer after the operation's<br/>
        /// `response` mapping, so one call shows both sides; `observation` is<br/>
        /// what the agent reads, trimmed to its observation window.<br/>
        /// Only a read operation runs (declared `read`, or a GET or HEAD that<br/>
        /// declares no class): nobody approves a test call, so a write is<br/>
        /// answered with `error` set and never reaches the vendor. Nothing is<br/>
        /// persisted and the tool's own `max_requests_per_minute` does not apply,<br/>
        /// but the call does reach the vendor and counts against the vendor's<br/>
        /// own limits. It acts with a workspace credential, so it needs the<br/>
        /// `content.manage` permission a tool create does.<br/>
        /// A malformed request is a 400: a missing `operation`, `arguments` that<br/>
        /// are not an object, or a field this endpoint does not define, which is<br/>
        /// refused naming every unknown field.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="config">
        /// The `openapi` config exactly as `POST /v1/agents/tool-definitions`<br/>
        /// takes it, with the credential by reference. The whole config is<br/>
        /// validated, not only the operation called.
        /// </param>
        /// <param name="operation">
        /// The `id` of the operation to call, one of `config.operations[].id`;<br/>
        /// the same value a hosted API `tool` route's `operation` names.
        /// </param>
        /// <param name="arguments">
        /// The arguments the agent would pass: each param by its `name`, plus<br/>
        /// `body` when the operation takes one. Omitted, the call carries none.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TestOpenAPICallResult> TestOpenAPICallAsync(
            global::Speechify.OpenAPIToolConfig config,
            string operation,
            string? speechifyVersion = default,
            object? arguments = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}