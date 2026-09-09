#nullable enable

namespace Speechify
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload File<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB) so a run<br/>
        /// can be handed it: pass the returned `id` in `attachments` on<br/>
        /// `POST /v1/agents/{agent_id}/runs`, a team run, or a trigger's run spec.<br/>
        /// Scope it with `user_identity` to the person it belongs to, and only a<br/>
        /// run acting for that person can read it; leave it empty and any run in<br/>
        /// the workspace can.<br/>
        /// `kind` decides how long it lives. The default, `ephemeral`, is deleted<br/>
        /// automatically 14 days after upload (`expires_at`) - working material<br/>
        /// rather than a corpus; for documents an agent should search later, use a<br/>
        /// knowledge base. Send `kind: kept` for something that survives until you<br/>
        /// delete it, and give a `kept` file a `path` to publish it where a<br/>
        /// hosted-API route can serve it. A workspace's `kept` files are bounded by<br/>
        /// its plan; past the ceiling an upload answers `409`<br/>
        /// `file_storage_limit_reached`. An upload past the 25 MiB size limit<br/>
        /// answers `413` `payload_too_large`, whatever the size of the body.<br/>
        /// An agent reads an attached file inside the run through its `read_file`<br/>
        /// tool: PDF, HTML, Markdown and plain text are extracted, and an image is<br/>
        /// transcribed and described by a vision model.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.File> UploadAsync(

            global::Speechify.UploadRequest2 request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB) so a run<br/>
        /// can be handed it: pass the returned `id` in `attachments` on<br/>
        /// `POST /v1/agents/{agent_id}/runs`, a team run, or a trigger's run spec.<br/>
        /// Scope it with `user_identity` to the person it belongs to, and only a<br/>
        /// run acting for that person can read it; leave it empty and any run in<br/>
        /// the workspace can.<br/>
        /// `kind` decides how long it lives. The default, `ephemeral`, is deleted<br/>
        /// automatically 14 days after upload (`expires_at`) - working material<br/>
        /// rather than a corpus; for documents an agent should search later, use a<br/>
        /// knowledge base. Send `kind: kept` for something that survives until you<br/>
        /// delete it, and give a `kept` file a `path` to publish it where a<br/>
        /// hosted-API route can serve it. A workspace's `kept` files are bounded by<br/>
        /// its plan; past the ceiling an upload answers `409`<br/>
        /// `file_storage_limit_reached`. An upload past the 25 MiB size limit<br/>
        /// answers `413` `payload_too_large`, whatever the size of the body.<br/>
        /// An agent reads an attached file inside the run through its `read_file`<br/>
        /// tool: PDF, HTML, Markdown and plain text are extracted, and an image is<br/>
        /// transcribed and described by a vision model.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.File>> UploadAsResponseAsync(

            global::Speechify.UploadRequest2 request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB) so a run<br/>
        /// can be handed it: pass the returned `id` in `attachments` on<br/>
        /// `POST /v1/agents/{agent_id}/runs`, a team run, or a trigger's run spec.<br/>
        /// Scope it with `user_identity` to the person it belongs to, and only a<br/>
        /// run acting for that person can read it; leave it empty and any run in<br/>
        /// the workspace can.<br/>
        /// `kind` decides how long it lives. The default, `ephemeral`, is deleted<br/>
        /// automatically 14 days after upload (`expires_at`) - working material<br/>
        /// rather than a corpus; for documents an agent should search later, use a<br/>
        /// knowledge base. Send `kind: kept` for something that survives until you<br/>
        /// delete it, and give a `kept` file a `path` to publish it where a<br/>
        /// hosted-API route can serve it. A workspace's `kept` files are bounded by<br/>
        /// its plan; past the ceiling an upload answers `409`<br/>
        /// `file_storage_limit_reached`. An upload past the 25 MiB size limit<br/>
        /// answers `413` `payload_too_large`, whatever the size of the body.<br/>
        /// An agent reads an attached file inside the run through its `read_file`<br/>
        /// tool: PDF, HTML, Markdown and plain text are extracted, and an image is<br/>
        /// transcribed and described by a vision model.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="file">
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </param>
        /// <param name="filename">
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </param>
        /// <param name="userIdentity">
        /// The person this file is for, in your own vocabulary - the same value<br/>
        /// a run, a conversation and a widget session take. Only a run acting<br/>
        /// for that person can read it. Omit for a workspace-wide file.
        /// </param>
        /// <param name="kind">
        /// How long to keep it. `ephemeral` (the default) is working material<br/>
        /// for a run and is deleted after 14 days. `kept` survives until you<br/>
        /// delete it - use it for anything an agent produced that you intend to<br/>
        /// keep or serve.
        /// </param>
        /// <param name="path">
        /// Publish the file under this name so a hosted-API route can serve it,<br/>
        /// for example `index.html` or `reports/q3.html`. Unique among the<br/>
        /// workspace's live files, and only valid on a `kept` file with no<br/>
        /// `user_identity` - a path on something that expires in a fortnight is<br/>
        /// a URL that breaks, and a route answers whoever holds the URL, so it<br/>
        /// has no person to scope to. A path already in use answers `409`.
        /// </param>
        /// <param name="projectId">
        /// The project to create the file in, as a `proj_...` id; omit for the<br/>
        /// caller's default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.File> UploadAsync(
            byte[] file,
            string filename,
            string? speechifyVersion = default,
            string? userIdentity = default,
            global::Speechify.V1FilesPostRequestBodyContentMultipartFormDataSchemaKind? kind = default,
            string? path = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload File<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB) so a run<br/>
        /// can be handed it: pass the returned `id` in `attachments` on<br/>
        /// `POST /v1/agents/{agent_id}/runs`, a team run, or a trigger's run spec.<br/>
        /// Scope it with `user_identity` to the person it belongs to, and only a<br/>
        /// run acting for that person can read it; leave it empty and any run in<br/>
        /// the workspace can.<br/>
        /// `kind` decides how long it lives. The default, `ephemeral`, is deleted<br/>
        /// automatically 14 days after upload (`expires_at`) - working material<br/>
        /// rather than a corpus; for documents an agent should search later, use a<br/>
        /// knowledge base. Send `kind: kept` for something that survives until you<br/>
        /// delete it, and give a `kept` file a `path` to publish it where a<br/>
        /// hosted-API route can serve it. A workspace's `kept` files are bounded by<br/>
        /// its plan; past the ceiling an upload answers `409`<br/>
        /// `file_storage_limit_reached`. An upload past the 25 MiB size limit<br/>
        /// answers `413` `payload_too_large`, whatever the size of the body.<br/>
        /// An agent reads an attached file inside the run through its `read_file`<br/>
        /// tool: PDF, HTML, Markdown and plain text are extracted, and an image is<br/>
        /// transcribed and described by a vision model.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="file">
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </param>
        /// <param name="filename">
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </param>
        /// <param name="userIdentity">
        /// The person this file is for, in your own vocabulary - the same value<br/>
        /// a run, a conversation and a widget session take. Only a run acting<br/>
        /// for that person can read it. Omit for a workspace-wide file.
        /// </param>
        /// <param name="kind">
        /// How long to keep it. `ephemeral` (the default) is working material<br/>
        /// for a run and is deleted after 14 days. `kept` survives until you<br/>
        /// delete it - use it for anything an agent produced that you intend to<br/>
        /// keep or serve.
        /// </param>
        /// <param name="path">
        /// Publish the file under this name so a hosted-API route can serve it,<br/>
        /// for example `index.html` or `reports/q3.html`. Unique among the<br/>
        /// workspace's live files, and only valid on a `kept` file with no<br/>
        /// `user_identity` - a path on something that expires in a fortnight is<br/>
        /// a URL that breaks, and a route answers whoever holds the URL, so it<br/>
        /// has no person to scope to. A path already in use answers `409`.
        /// </param>
        /// <param name="projectId">
        /// The project to create the file in, as a `proj_...` id; omit for the<br/>
        /// caller's default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.File> UploadAsync(
            global::System.IO.Stream file,
            string filename,
            string? speechifyVersion = default,
            string? userIdentity = default,
            global::Speechify.V1FilesPostRequestBodyContentMultipartFormDataSchemaKind? kind = default,
            string? path = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB) so a run<br/>
        /// can be handed it: pass the returned `id` in `attachments` on<br/>
        /// `POST /v1/agents/{agent_id}/runs`, a team run, or a trigger's run spec.<br/>
        /// Scope it with `user_identity` to the person it belongs to, and only a<br/>
        /// run acting for that person can read it; leave it empty and any run in<br/>
        /// the workspace can.<br/>
        /// `kind` decides how long it lives. The default, `ephemeral`, is deleted<br/>
        /// automatically 14 days after upload (`expires_at`) - working material<br/>
        /// rather than a corpus; for documents an agent should search later, use a<br/>
        /// knowledge base. Send `kind: kept` for something that survives until you<br/>
        /// delete it, and give a `kept` file a `path` to publish it where a<br/>
        /// hosted-API route can serve it. A workspace's `kept` files are bounded by<br/>
        /// its plan; past the ceiling an upload answers `409`<br/>
        /// `file_storage_limit_reached`. An upload past the 25 MiB size limit<br/>
        /// answers `413` `payload_too_large`, whatever the size of the body.<br/>
        /// An agent reads an attached file inside the run through its `read_file`<br/>
        /// tool: PDF, HTML, Markdown and plain text are extracted, and an image is<br/>
        /// transcribed and described by a vision model.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="file">
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </param>
        /// <param name="filename">
        /// The file to store (at most 25 MiB). The part's `filename` is stored<br/>
        /// as sent apart from surrounding whitespace, which is trimmed, and it<br/>
        /// is a name rather than a path: at most 255 characters, no `/` or `\`,<br/>
        /// and not `.` or `..`. A name carrying one is refused with<br/>
        /// `validation_failed` instead of being shortened to its last segment -<br/>
        /// where the bytes live is derived from your workspace and the file's<br/>
        /// own id, never from the name you send.
        /// </param>
        /// <param name="userIdentity">
        /// The person this file is for, in your own vocabulary - the same value<br/>
        /// a run, a conversation and a widget session take. Only a run acting<br/>
        /// for that person can read it. Omit for a workspace-wide file.
        /// </param>
        /// <param name="kind">
        /// How long to keep it. `ephemeral` (the default) is working material<br/>
        /// for a run and is deleted after 14 days. `kept` survives until you<br/>
        /// delete it - use it for anything an agent produced that you intend to<br/>
        /// keep or serve.
        /// </param>
        /// <param name="path">
        /// Publish the file under this name so a hosted-API route can serve it,<br/>
        /// for example `index.html` or `reports/q3.html`. Unique among the<br/>
        /// workspace's live files, and only valid on a `kept` file with no<br/>
        /// `user_identity` - a path on something that expires in a fortnight is<br/>
        /// a URL that breaks, and a route answers whoever holds the URL, so it<br/>
        /// has no person to scope to. A path already in use answers `409`.
        /// </param>
        /// <param name="projectId">
        /// The project to create the file in, as a `proj_...` id; omit for the<br/>
        /// caller's default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.File>> UploadAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? speechifyVersion = default,
            string? userIdentity = default,
            global::Speechify.V1FilesPostRequestBodyContentMultipartFormDataSchemaKind? kind = default,
            string? path = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}