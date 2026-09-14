#nullable enable

namespace Speechify
{
    public partial interface IToolDefinitionsClient
    {
        /// <summary>
        /// Import OpenAPI Operations<br/>
        /// Compile a vendor's OpenAPI 3.x document into the operations an<br/>
        /// `openapi` tool can carry, without persisting anything. It is the<br/>
        /// second step of connecting a REST API: store the vendor credential<br/>
        /// with `POST /v1/credentials`, import the document here, choose and<br/>
        /// classify the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then create the<br/>
        /// tool with `POST /v1/agents/tool-definitions`.<br/>
        /// Pass the document by `spec_url` (an https URL fetched server-side,<br/>
        /// with the headers of the credential `auth` names when the document<br/>
        /// sits behind the vendor's own auth) or inline as `spec`, never both.<br/>
        /// Each entry of `operations` is already in the shape<br/>
        /// `OpenAPIToolConfig.operations` takes, in document order: copy the ones<br/>
        /// the agent should have (at most 40 per tool), and add `action_class`<br/>
        /// and `response` where you need them. Use each returned `id` verbatim<br/>
        /// rather than deriving it: it is the document's operationId made safe<br/>
        /// for a function name (a run of other characters becomes one `_`, a<br/>
        /// leading digit gains `op_`, at most 64 characters), or a name built<br/>
        /// from the method and path when the document has none, and an id two<br/>
        /// operations would share takes a numeric suffix. You may rename an id<br/>
        /// before saving. The agent calls each operation as<br/>
        /// `&lt;tool name&gt;__&lt;id&gt;`, which must fit 64 characters, so shorten the tool<br/>
        /// name or rename the id when it does not. `skipped` lists every<br/>
        /// operation that could not be represented, with the reason.<br/>
        /// The document's security schemes are not imported: the tool's own<br/>
        /// `auth` is `none`, `bearer` or `oauth2_client_credentials`. Never<br/>
        /// select an API key the document declares as a header or query<br/>
        /// parameter as a parameter, since the agent would have to supply its<br/>
        /// value.<br/>
        /// A refused `spec_url`, a credential that does not resolve or cannot<br/>
        /// mint a token, a fetch that fails and a document that does not parse<br/>
        /// all answer 200 with `error` set and `operations` empty. Only a<br/>
        /// malformed request is a 400: neither or both of `spec` and `spec_url`,<br/>
        /// or a field this endpoint does not define, which is refused naming<br/>
        /// every unknown field.<br/>
        /// Needs the `content.manage` permission, as creating a tool does: the<br/>
        /// fetch sends a referenced credential's headers to `spec_url`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ImportOpenAPIResult> ImportOpenAPIAsync(

            global::Speechify.ImportOpenAPIRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import OpenAPI Operations<br/>
        /// Compile a vendor's OpenAPI 3.x document into the operations an<br/>
        /// `openapi` tool can carry, without persisting anything. It is the<br/>
        /// second step of connecting a REST API: store the vendor credential<br/>
        /// with `POST /v1/credentials`, import the document here, choose and<br/>
        /// classify the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then create the<br/>
        /// tool with `POST /v1/agents/tool-definitions`.<br/>
        /// Pass the document by `spec_url` (an https URL fetched server-side,<br/>
        /// with the headers of the credential `auth` names when the document<br/>
        /// sits behind the vendor's own auth) or inline as `spec`, never both.<br/>
        /// Each entry of `operations` is already in the shape<br/>
        /// `OpenAPIToolConfig.operations` takes, in document order: copy the ones<br/>
        /// the agent should have (at most 40 per tool), and add `action_class`<br/>
        /// and `response` where you need them. Use each returned `id` verbatim<br/>
        /// rather than deriving it: it is the document's operationId made safe<br/>
        /// for a function name (a run of other characters becomes one `_`, a<br/>
        /// leading digit gains `op_`, at most 64 characters), or a name built<br/>
        /// from the method and path when the document has none, and an id two<br/>
        /// operations would share takes a numeric suffix. You may rename an id<br/>
        /// before saving. The agent calls each operation as<br/>
        /// `&lt;tool name&gt;__&lt;id&gt;`, which must fit 64 characters, so shorten the tool<br/>
        /// name or rename the id when it does not. `skipped` lists every<br/>
        /// operation that could not be represented, with the reason.<br/>
        /// The document's security schemes are not imported: the tool's own<br/>
        /// `auth` is `none`, `bearer` or `oauth2_client_credentials`. Never<br/>
        /// select an API key the document declares as a header or query<br/>
        /// parameter as a parameter, since the agent would have to supply its<br/>
        /// value.<br/>
        /// A refused `spec_url`, a credential that does not resolve or cannot<br/>
        /// mint a token, a fetch that fails and a document that does not parse<br/>
        /// all answer 200 with `error` set and `operations` empty. Only a<br/>
        /// malformed request is a 400: neither or both of `spec` and `spec_url`,<br/>
        /// or a field this endpoint does not define, which is refused naming<br/>
        /// every unknown field.<br/>
        /// Needs the `content.manage` permission, as creating a tool does: the<br/>
        /// fetch sends a referenced credential's headers to `spec_url`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ImportOpenAPIResult>> ImportOpenAPIAsResponseAsync(

            global::Speechify.ImportOpenAPIRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import OpenAPI Operations<br/>
        /// Compile a vendor's OpenAPI 3.x document into the operations an<br/>
        /// `openapi` tool can carry, without persisting anything. It is the<br/>
        /// second step of connecting a REST API: store the vendor credential<br/>
        /// with `POST /v1/credentials`, import the document here, choose and<br/>
        /// classify the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then create the<br/>
        /// tool with `POST /v1/agents/tool-definitions`.<br/>
        /// Pass the document by `spec_url` (an https URL fetched server-side,<br/>
        /// with the headers of the credential `auth` names when the document<br/>
        /// sits behind the vendor's own auth) or inline as `spec`, never both.<br/>
        /// Each entry of `operations` is already in the shape<br/>
        /// `OpenAPIToolConfig.operations` takes, in document order: copy the ones<br/>
        /// the agent should have (at most 40 per tool), and add `action_class`<br/>
        /// and `response` where you need them. Use each returned `id` verbatim<br/>
        /// rather than deriving it: it is the document's operationId made safe<br/>
        /// for a function name (a run of other characters becomes one `_`, a<br/>
        /// leading digit gains `op_`, at most 64 characters), or a name built<br/>
        /// from the method and path when the document has none, and an id two<br/>
        /// operations would share takes a numeric suffix. You may rename an id<br/>
        /// before saving. The agent calls each operation as<br/>
        /// `&lt;tool name&gt;__&lt;id&gt;`, which must fit 64 characters, so shorten the tool<br/>
        /// name or rename the id when it does not. `skipped` lists every<br/>
        /// operation that could not be represented, with the reason.<br/>
        /// The document's security schemes are not imported: the tool's own<br/>
        /// `auth` is `none`, `bearer` or `oauth2_client_credentials`. Never<br/>
        /// select an API key the document declares as a header or query<br/>
        /// parameter as a parameter, since the agent would have to supply its<br/>
        /// value.<br/>
        /// A refused `spec_url`, a credential that does not resolve or cannot<br/>
        /// mint a token, a fetch that fails and a document that does not parse<br/>
        /// all answer 200 with `error` set and `operations` empty. Only a<br/>
        /// malformed request is a 400: neither or both of `spec` and `spec_url`,<br/>
        /// or a field this endpoint does not define, which is refused naming<br/>
        /// every unknown field.<br/>
        /// Needs the `content.manage` permission, as creating a tool does: the<br/>
        /// fetch sends a referenced credential's headers to `spec_url`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="specUrl">
        /// An https URL the server fetches the document from, with the headers<br/>
        /// of the credential `auth` names when it names one. A private or<br/>
        /// loopback address is refused. At most 2 MiB. Keep it as the tool's<br/>
        /// `spec_url` so a later import can refresh the operations.
        /// </param>
        /// <param name="spec">
        /// The document inline: a JSON object, or a string holding the JSON<br/>
        /// or YAML text. At most 2 MiB.
        /// </param>
        /// <param name="auth">
        /// How the platform authenticates to an MCP server or an OpenAPI tool's<br/>
        /// REST API: `none`, `bearer` or `oauth2_client_credentials`, a<br/>
        /// discriminated union over `type`. Other credential kinds (an API key<br/>
        /// in a custom header or query parameter, HTTP Basic) are not supported<br/>
        /// here.
        /// </param>
        /// <param name="baseUrl">
        /// Overrides the document's `servers` in the result's `base_url`: the<br/>
        /// regional or tenant host this workspace signed up to. The create<br/>
        /// endpoint requires https.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ImportOpenAPIResult> ImportOpenAPIAsync(
            string? speechifyVersion = default,
            string? specUrl = default,
            global::Speechify.ImportOpenApiRequestSpec? spec = default,
            global::Speechify.MCPAuth? auth = default,
            string? baseUrl = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}