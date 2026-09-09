#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete Project<br/>
        /// Delete a project. With no body it deletes a project that holds<br/>
        /// nothing, and refuses one that does; `mode` is how you say what should<br/>
        /// happen to what it holds.<br/>
        /// **Empty** (no body): the project is removed only while it holds no<br/>
        /// resources. A project that holds any is refused with 409<br/>
        /// `project_not_empty`, and the refusal enumerates what is inside:<br/>
        /// `error.details.resource_count` is the total, and<br/>
        /// `error.details.contents` names each kind with a count and up to five<br/>
        /// names. Every project row also carries that total as `resource_count`,<br/>
        /// so an application can find the projects it may delete in one list<br/>
        /// call. Records of work - conversations, runs, calls, callers, memories<br/>
        /// - never hold a project open and are not counted.<br/>
        /// **Detach** (`mode: detach`): only the grouping row is removed; every<br/>
        /// resource in the project moves to the implicit Default project, where<br/>
        /// it stays readable and is listed by `?project_id=default`. This is what<br/>
        /// an unqualified delete used to do silently. Refused with 409<br/>
        /// `project_has_scoped_credentials` while an API key, service account,<br/>
        /// vault credential, webhook endpoint, member grant or pending invite is<br/>
        /// scoped to the project, because detaching any of those would silently<br/>
        /// widen it.<br/>
        /// **Purge** (`mode: purge` with `confirm` equal to the project's name):<br/>
        /// available only on an ARCHIVED project, because a teardown needs a<br/>
        /// state you can sit in and reverse first; a live project is refused with<br/>
        /// the coded `409 project_not_archived`. Archive the project, confirm it<br/>
        /// is the one you mean, then purge. The project is removed WITH its<br/>
        /// contents in one transaction. Agents<br/>
        /// (with their tests), knowledge bases (with their documents), tools,<br/>
        /// audio assets, scoped webhook endpoints and scoped vault credentials<br/>
        /// are deleted; API keys and service accounts pinned to the project are<br/>
        /// revoked; member grants and pending-invite scopes on the project are<br/>
        /// cleared. The runs and conversations of a deleted agent go with that<br/>
        /// agent, transcripts and recordings included, and stop being readable<br/>
        /// the moment the purge lands - a detach leaves them alone, because a<br/>
        /// detached project's agents are still live. Callers, suite runs and<br/>
        /// memories are operational records and survive either mode, moving to<br/>
        /// the Default project; a batch call survives the project the same way,<br/>
        /// but not the agent it dialled for, so a purge's agents take their<br/>
        /// campaigns with them once they are permanently removed. External brains,<br/>
        /// skills, teams, channels, stores, hosted APIs and files are resources<br/>
        /// with their own lifecycle and their own delete, so a purge does NOT<br/>
        /// remove them either: they move to the Default project too, the teardown<br/>
        /// preview lists every one of them under `retains`, and because they DO<br/>
        /// hold a project open an unqualified delete refuses while any of them is<br/>
        /// in the project. Refused with 409 while a phone number is attached<br/>
        /// (release or move it first), while a member's only project grant is<br/>
        /// this one, or while a live invite carries only this project (clearing<br/>
        /// either would widen that person to the whole workspace, the invite one<br/>
        /// acceptance earlier). Preview either mode with<br/>
        /// `GET /v1/projects/{project_id}/teardown`.<br/>
        /// **A purge is recoverable for 30 days.** The project disappears from<br/>
        /// every list and read immediately, and its name is freed for reuse, but<br/>
        /// the project and its resources are kept and permanently deleted only<br/>
        /// once the window closes. `POST /v1/projects/{project_id}/restore`<br/>
        /// brings the project and its resources back inside that window; the<br/>
        /// credentials the purge revoked and the grants it cleared stay that way.<br/>
        /// The 409 carries the blockers under `error.details.blockers` (`kind`,<br/>
        /// typed `id`, `name`, and the `blocks` modes each refuses), their total<br/>
        /// under `error.details.blocker_count`, and, for existing clients, the<br/>
        /// same rows under `error.details.credentials`. The lists are capped at<br/>
        /// 50 rows; the counts are not, and the refusal is decided on the count.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string projectId,

            global::Speechify.DeleteProjectRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Project<br/>
        /// Delete a project. With no body it deletes a project that holds<br/>
        /// nothing, and refuses one that does; `mode` is how you say what should<br/>
        /// happen to what it holds.<br/>
        /// **Empty** (no body): the project is removed only while it holds no<br/>
        /// resources. A project that holds any is refused with 409<br/>
        /// `project_not_empty`, and the refusal enumerates what is inside:<br/>
        /// `error.details.resource_count` is the total, and<br/>
        /// `error.details.contents` names each kind with a count and up to five<br/>
        /// names. Every project row also carries that total as `resource_count`,<br/>
        /// so an application can find the projects it may delete in one list<br/>
        /// call. Records of work - conversations, runs, calls, callers, memories<br/>
        /// - never hold a project open and are not counted.<br/>
        /// **Detach** (`mode: detach`): only the grouping row is removed; every<br/>
        /// resource in the project moves to the implicit Default project, where<br/>
        /// it stays readable and is listed by `?project_id=default`. This is what<br/>
        /// an unqualified delete used to do silently. Refused with 409<br/>
        /// `project_has_scoped_credentials` while an API key, service account,<br/>
        /// vault credential, webhook endpoint, member grant or pending invite is<br/>
        /// scoped to the project, because detaching any of those would silently<br/>
        /// widen it.<br/>
        /// **Purge** (`mode: purge` with `confirm` equal to the project's name):<br/>
        /// available only on an ARCHIVED project, because a teardown needs a<br/>
        /// state you can sit in and reverse first; a live project is refused with<br/>
        /// the coded `409 project_not_archived`. Archive the project, confirm it<br/>
        /// is the one you mean, then purge. The project is removed WITH its<br/>
        /// contents in one transaction. Agents<br/>
        /// (with their tests), knowledge bases (with their documents), tools,<br/>
        /// audio assets, scoped webhook endpoints and scoped vault credentials<br/>
        /// are deleted; API keys and service accounts pinned to the project are<br/>
        /// revoked; member grants and pending-invite scopes on the project are<br/>
        /// cleared. The runs and conversations of a deleted agent go with that<br/>
        /// agent, transcripts and recordings included, and stop being readable<br/>
        /// the moment the purge lands - a detach leaves them alone, because a<br/>
        /// detached project's agents are still live. Callers, suite runs and<br/>
        /// memories are operational records and survive either mode, moving to<br/>
        /// the Default project; a batch call survives the project the same way,<br/>
        /// but not the agent it dialled for, so a purge's agents take their<br/>
        /// campaigns with them once they are permanently removed. External brains,<br/>
        /// skills, teams, channels, stores, hosted APIs and files are resources<br/>
        /// with their own lifecycle and their own delete, so a purge does NOT<br/>
        /// remove them either: they move to the Default project too, the teardown<br/>
        /// preview lists every one of them under `retains`, and because they DO<br/>
        /// hold a project open an unqualified delete refuses while any of them is<br/>
        /// in the project. Refused with 409 while a phone number is attached<br/>
        /// (release or move it first), while a member's only project grant is<br/>
        /// this one, or while a live invite carries only this project (clearing<br/>
        /// either would widen that person to the whole workspace, the invite one<br/>
        /// acceptance earlier). Preview either mode with<br/>
        /// `GET /v1/projects/{project_id}/teardown`.<br/>
        /// **A purge is recoverable for 30 days.** The project disappears from<br/>
        /// every list and read immediately, and its name is freed for reuse, but<br/>
        /// the project and its resources are kept and permanently deleted only<br/>
        /// once the window closes. `POST /v1/projects/{project_id}/restore`<br/>
        /// brings the project and its resources back inside that window; the<br/>
        /// credentials the purge revoked and the grants it cleared stay that way.<br/>
        /// The 409 carries the blockers under `error.details.blockers` (`kind`,<br/>
        /// typed `id`, `name`, and the `blocks` modes each refuses), their total<br/>
        /// under `error.details.blocker_count`, and, for existing clients, the<br/>
        /// same rows under `error.details.credentials`. The lists are capped at<br/>
        /// 50 rows; the counts are not, and the refusal is decided on the count.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string projectId,

            global::Speechify.DeleteProjectRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Project<br/>
        /// Delete a project. With no body it deletes a project that holds<br/>
        /// nothing, and refuses one that does; `mode` is how you say what should<br/>
        /// happen to what it holds.<br/>
        /// **Empty** (no body): the project is removed only while it holds no<br/>
        /// resources. A project that holds any is refused with 409<br/>
        /// `project_not_empty`, and the refusal enumerates what is inside:<br/>
        /// `error.details.resource_count` is the total, and<br/>
        /// `error.details.contents` names each kind with a count and up to five<br/>
        /// names. Every project row also carries that total as `resource_count`,<br/>
        /// so an application can find the projects it may delete in one list<br/>
        /// call. Records of work - conversations, runs, calls, callers, memories<br/>
        /// - never hold a project open and are not counted.<br/>
        /// **Detach** (`mode: detach`): only the grouping row is removed; every<br/>
        /// resource in the project moves to the implicit Default project, where<br/>
        /// it stays readable and is listed by `?project_id=default`. This is what<br/>
        /// an unqualified delete used to do silently. Refused with 409<br/>
        /// `project_has_scoped_credentials` while an API key, service account,<br/>
        /// vault credential, webhook endpoint, member grant or pending invite is<br/>
        /// scoped to the project, because detaching any of those would silently<br/>
        /// widen it.<br/>
        /// **Purge** (`mode: purge` with `confirm` equal to the project's name):<br/>
        /// available only on an ARCHIVED project, because a teardown needs a<br/>
        /// state you can sit in and reverse first; a live project is refused with<br/>
        /// the coded `409 project_not_archived`. Archive the project, confirm it<br/>
        /// is the one you mean, then purge. The project is removed WITH its<br/>
        /// contents in one transaction. Agents<br/>
        /// (with their tests), knowledge bases (with their documents), tools,<br/>
        /// audio assets, scoped webhook endpoints and scoped vault credentials<br/>
        /// are deleted; API keys and service accounts pinned to the project are<br/>
        /// revoked; member grants and pending-invite scopes on the project are<br/>
        /// cleared. The runs and conversations of a deleted agent go with that<br/>
        /// agent, transcripts and recordings included, and stop being readable<br/>
        /// the moment the purge lands - a detach leaves them alone, because a<br/>
        /// detached project's agents are still live. Callers, suite runs and<br/>
        /// memories are operational records and survive either mode, moving to<br/>
        /// the Default project; a batch call survives the project the same way,<br/>
        /// but not the agent it dialled for, so a purge's agents take their<br/>
        /// campaigns with them once they are permanently removed. External brains,<br/>
        /// skills, teams, channels, stores, hosted APIs and files are resources<br/>
        /// with their own lifecycle and their own delete, so a purge does NOT<br/>
        /// remove them either: they move to the Default project too, the teardown<br/>
        /// preview lists every one of them under `retains`, and because they DO<br/>
        /// hold a project open an unqualified delete refuses while any of them is<br/>
        /// in the project. Refused with 409 while a phone number is attached<br/>
        /// (release or move it first), while a member's only project grant is<br/>
        /// this one, or while a live invite carries only this project (clearing<br/>
        /// either would widen that person to the whole workspace, the invite one<br/>
        /// acceptance earlier). Preview either mode with<br/>
        /// `GET /v1/projects/{project_id}/teardown`.<br/>
        /// **A purge is recoverable for 30 days.** The project disappears from<br/>
        /// every list and read immediately, and its name is freed for reuse, but<br/>
        /// the project and its resources are kept and permanently deleted only<br/>
        /// once the window closes. `POST /v1/projects/{project_id}/restore`<br/>
        /// brings the project and its resources back inside that window; the<br/>
        /// credentials the purge revoked and the grants it cleared stay that way.<br/>
        /// The 409 carries the blockers under `error.details.blockers` (`kind`,<br/>
        /// typed `id`, `name`, and the `blocks` modes each refuses), their total<br/>
        /// under `error.details.blocker_count`, and, for existing clients, the<br/>
        /// same rows under `error.details.credentials`. The lists are capped at<br/>
        /// 50 rows; the counts are not, and the refusal is decided on the count.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="mode">
        /// `detach` removes the grouping row only and moves every resource<br/>
        /// to the Default project; `purge` removes the project with its<br/>
        /// contents. Omitted, the delete removes only an empty project.
        /// </param>
        /// <param name="confirm">
        /// Required for `purge`: the project's name, exactly as returned by<br/>
        /// GET. A mismatch answers 400 `validation_failed` naming this field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.DeleteProjectRequestMode? mode = default,
            string? confirm = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}