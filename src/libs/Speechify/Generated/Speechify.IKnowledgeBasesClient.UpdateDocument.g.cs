#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Update Knowledge Base Document<br/>
        /// Update a document: move it between folders via `folder_id`, or pin<br/>
        /// it into every prompt via `injection_mode`. The two are independent;<br/>
        /// a body naming only one leaves the other unchanged. A pin is refused<br/>
        /// with 422 when the knowledge base's pinned documents would exceed<br/>
        /// the prompt budget, naming the token counts.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocumentDetail> UpdateDocumentAsync(
            string kbId,
            string documentId,

            global::Speechify.UpdateDocumentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Knowledge Base Document<br/>
        /// Update a document: move it between folders via `folder_id`, or pin<br/>
        /// it into every prompt via `injection_mode`. The two are independent;<br/>
        /// a body naming only one leaves the other unchanged. A pin is refused<br/>
        /// with 422 when the knowledge base's pinned documents would exceed<br/>
        /// the prompt budget, naming the token counts.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseDocumentDetail>> UpdateDocumentAsResponseAsync(
            string kbId,
            string documentId,

            global::Speechify.UpdateDocumentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Knowledge Base Document<br/>
        /// Update a document: move it between folders via `folder_id`, or pin<br/>
        /// it into every prompt via `injection_mode`. The two are independent;<br/>
        /// a body naming only one leaves the other unchanged. A pin is refused<br/>
        /// with 422 when the knowledge base's pinned documents would exceed<br/>
        /// the prompt budget, naming the token counts.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="folderId">
        /// Destination folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null moves the<br/>
        /// document to the knowledge base root.
        /// </param>
        /// <param name="injectionMode">
        /// `always` keeps the document in every prompt; `on_demand`<br/>
        /// returns it to retrieval.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocumentDetail> UpdateDocumentAsync(
            string kbId,
            string documentId,
            string? speechifyVersion = default,
            string? folderId = default,
            global::Speechify.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode? injectionMode = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}