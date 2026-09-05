#nullable enable

namespace Speechify
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Create Skill<br/>
        /// Create a skill at version 1. Names are unique per workspace. Every<br/>
        /// `tool_ids` and `knowledge_base_ids` entry must already exist in the<br/>
        /// same project as the skill.<br/>
        /// Bounded by the workspace's skill limit (409 `skill_limit_reached`).<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Skill> CreateAsync(

            global::Speechify.CreateSkillRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Skill<br/>
        /// Create a skill at version 1. Names are unique per workspace. Every<br/>
        /// `tool_ids` and `knowledge_base_ids` entry must already exist in the<br/>
        /// same project as the skill.<br/>
        /// Bounded by the workspace's skill limit (409 `skill_limit_reached`).<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Skill>> CreateAsResponseAsync(

            global::Speechify.CreateSkillRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Skill<br/>
        /// Create a skill at version 1. Names are unique per workspace. Every<br/>
        /// `tool_ids` and `knowledge_base_ids` entry must already exist in the<br/>
        /// same project as the skill.<br/>
        /// Bounded by the workspace's skill limit (409 `skill_limit_reached`).<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="name">
        /// 1-128 characters of letters, digits, spaces, or `. _ -`; unique per workspace.
        /// </param>
        /// <param name="description"></param>
        /// <param name="instructions">
        /// The procedure. Bounded because it rides on every dispatched turn of<br/>
        /// every agent that attaches it, so the limit is a per-turn token bill<br/>
        /// rather than a storage bound.
        /// </param>
        /// <param name="toolIds"></param>
        /// <param name="knowledgeBaseIds"></param>
        /// <param name="variables">
        /// Default token values. Keys in the reserved `system__` namespace are refused.
        /// </param>
        /// <param name="projectId">
        /// The project to create the skill in; omit for the caller's default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Skill> CreateAsync(
            string name,
            string instructions,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds = default,
            global::System.Collections.Generic.Dictionary<string, string>? variables = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}