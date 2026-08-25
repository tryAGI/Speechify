#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Promote Project<br/>
        /// Copy this project's configuration into another project in the same<br/>
        /// workspace, creating equivalent resources there. Use it to move a<br/>
        /// staging environment into production, or to seed one client's project<br/>
        /// from another's.<br/>
        /// Copied: agents with every setting (prompt, voice, model, memory and<br/>
        /// consent settings, builtin tools, tool and knowledge-base bindings, the<br/>
        /// draft and published flow versions, test definitions), tool<br/>
        /// definitions, knowledge bases with their folders (URL sources are<br/>
        /// re-imported in the target through the normal import path, so the<br/>
        /// response lists the import jobs to poll), audio assets (the object is<br/>
        /// copied), and the webhook endpoints scoped to the source.<br/>
        /// Never copied: vault credentials, API keys and service accounts, phone<br/>
        /// numbers and SIP trunks, conversations, callers, memories, call and<br/>
        /// test history, batch calls, member grants, spend limits, uploaded or<br/>
        /// pasted knowledge-base documents, and every secret. A copied tool or<br/>
        /// agent that referenced a credential has the reference cleared, every<br/>
        /// server-minted signing secret is minted fresh, and each such item is<br/>
        /// listed under `needs_attention` so nothing is silently half-configured.<br/>
        /// A copy keeps its name. Where the target already holds a resource of<br/>
        /// the same kind and name, the copy is suffixed (`name (2)`, or `name_2`<br/>
        /// for tools) and listed under `needs_attention` with reason `renamed`;<br/>
        /// a target tool whose definition is identical to the source's is bound<br/>
        /// instead of duplicated and appears under `reused`.<br/>
        /// The copy runs in one transaction. A project holding more than 200<br/>
        /// resources (agents, tools, knowledge bases, URL sources, audio assets,<br/>
        /// webhook endpoints and tests together) answers `409<br/>
        /// project_too_large_to_promote`. Send an `Idempotency-Key` header to<br/>
        /// make a retry safe: the first manifest is replayed rather than the<br/>
        /// project copied twice. Both projects must be reachable to the caller;<br/>
        /// a project-pinned credential cannot promote.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PromoteProjectResponse> PromoteAsync(
            string projectId,

            global::Speechify.PromoteProjectRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promote Project<br/>
        /// Copy this project's configuration into another project in the same<br/>
        /// workspace, creating equivalent resources there. Use it to move a<br/>
        /// staging environment into production, or to seed one client's project<br/>
        /// from another's.<br/>
        /// Copied: agents with every setting (prompt, voice, model, memory and<br/>
        /// consent settings, builtin tools, tool and knowledge-base bindings, the<br/>
        /// draft and published flow versions, test definitions), tool<br/>
        /// definitions, knowledge bases with their folders (URL sources are<br/>
        /// re-imported in the target through the normal import path, so the<br/>
        /// response lists the import jobs to poll), audio assets (the object is<br/>
        /// copied), and the webhook endpoints scoped to the source.<br/>
        /// Never copied: vault credentials, API keys and service accounts, phone<br/>
        /// numbers and SIP trunks, conversations, callers, memories, call and<br/>
        /// test history, batch calls, member grants, spend limits, uploaded or<br/>
        /// pasted knowledge-base documents, and every secret. A copied tool or<br/>
        /// agent that referenced a credential has the reference cleared, every<br/>
        /// server-minted signing secret is minted fresh, and each such item is<br/>
        /// listed under `needs_attention` so nothing is silently half-configured.<br/>
        /// A copy keeps its name. Where the target already holds a resource of<br/>
        /// the same kind and name, the copy is suffixed (`name (2)`, or `name_2`<br/>
        /// for tools) and listed under `needs_attention` with reason `renamed`;<br/>
        /// a target tool whose definition is identical to the source's is bound<br/>
        /// instead of duplicated and appears under `reused`.<br/>
        /// The copy runs in one transaction. A project holding more than 200<br/>
        /// resources (agents, tools, knowledge bases, URL sources, audio assets,<br/>
        /// webhook endpoints and tests together) answers `409<br/>
        /// project_too_large_to_promote`. Send an `Idempotency-Key` header to<br/>
        /// make a retry safe: the first manifest is replayed rather than the<br/>
        /// project copied twice. Both projects must be reachable to the caller;<br/>
        /// a project-pinned credential cannot promote.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.PromoteProjectResponse>> PromoteAsResponseAsync(
            string projectId,

            global::Speechify.PromoteProjectRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promote Project<br/>
        /// Copy this project's configuration into another project in the same<br/>
        /// workspace, creating equivalent resources there. Use it to move a<br/>
        /// staging environment into production, or to seed one client's project<br/>
        /// from another's.<br/>
        /// Copied: agents with every setting (prompt, voice, model, memory and<br/>
        /// consent settings, builtin tools, tool and knowledge-base bindings, the<br/>
        /// draft and published flow versions, test definitions), tool<br/>
        /// definitions, knowledge bases with their folders (URL sources are<br/>
        /// re-imported in the target through the normal import path, so the<br/>
        /// response lists the import jobs to poll), audio assets (the object is<br/>
        /// copied), and the webhook endpoints scoped to the source.<br/>
        /// Never copied: vault credentials, API keys and service accounts, phone<br/>
        /// numbers and SIP trunks, conversations, callers, memories, call and<br/>
        /// test history, batch calls, member grants, spend limits, uploaded or<br/>
        /// pasted knowledge-base documents, and every secret. A copied tool or<br/>
        /// agent that referenced a credential has the reference cleared, every<br/>
        /// server-minted signing secret is minted fresh, and each such item is<br/>
        /// listed under `needs_attention` so nothing is silently half-configured.<br/>
        /// A copy keeps its name. Where the target already holds a resource of<br/>
        /// the same kind and name, the copy is suffixed (`name (2)`, or `name_2`<br/>
        /// for tools) and listed under `needs_attention` with reason `renamed`;<br/>
        /// a target tool whose definition is identical to the source's is bound<br/>
        /// instead of duplicated and appears under `reused`.<br/>
        /// The copy runs in one transaction. A project holding more than 200<br/>
        /// resources (agents, tools, knowledge bases, URL sources, audio assets,<br/>
        /// webhook endpoints and tests together) answers `409<br/>
        /// project_too_large_to_promote`. Send an `Idempotency-Key` header to<br/>
        /// make a retry safe: the first manifest is replayed rather than the<br/>
        /// project copied twice. Both projects must be reachable to the caller;<br/>
        /// a project-pinned credential cannot promote.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="targetProjectId">
        /// The project to copy into. Must differ from the source and belong to the same workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PromoteProjectResponse> PromoteAsync(
            string projectId,
            string targetProjectId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}