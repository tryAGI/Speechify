
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A share link: a revocable, capped URL that lets anyone hold a voice<br/>
    /// conversation with an agent without signing in.<br/>
    /// The bearer token is not part of this shape. A list read is fired on<br/>
    /// every page mount and the token is a credential that spends money, so<br/>
    /// it is fetched one link at a time from `revealShareLinkToken` instead.<br/>
    /// `token_prefix` is what a list can show.
    /// </summary>
    public sealed partial class ShareLink
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The owner's own note on the link, for telling several apart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The token's leading characters, kept so a list can show a<br/>
        /// recognisable masked label. Useless as a guess on its own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenPrefix { get; set; }

        /// <summary>
        /// Whether `revealShareLinkToken` can return this link's URL. False<br/>
        /// for links created before the token was stored recoverably: theirs<br/>
        /// was hashed and discarded, so the only way to share again is a new<br/>
        /// link. Read it before offering a copy action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_recoverable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TokenRecoverable { get; set; }

        /// <summary>
        /// The link's resolved lifecycle state, computed server-side so<br/>
        /// every client agrees on what "expired" means.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ShareLinkStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ShareLinkStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_at")]
        public global::System.DateTime? RevokedAt { get; set; }

        /// <summary>
        /// Total conversation time this link may ever authorise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetSeconds { get; set; }

        /// <summary>
        /// Conversation time settled against the link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SecondsUsed { get; set; }

        /// <summary>
        /// Conversation time held by calls currently in flight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds_reserved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SecondsReserved { get; set; }

        /// <summary>
        /// What a new call can still draw on: the budget minus settled and<br/>
        /// in-flight time. Reservations count against it, so two<br/>
        /// simultaneous starts cannot both spend the tail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds_remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SecondsRemaining { get; set; }

        /// <summary>
        /// Ceiling on any single call opened through this link. Clamped at<br/>
        /// dispatch against the agent's own limit and the workspace plan,<br/>
        /// so a link can shorten a call but never lengthen one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCallDurationSeconds { get; set; }

        /// <summary>
        /// How many calls this link may run at once. Bounded separately<br/>
        /// from the workspace's own concurrency cap, so a widely-shared<br/>
        /// link cannot consume the capacity the owner's real callers need.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxConcurrent { get; set; }

        /// <summary>
        /// Tools the owner opted this link into, by id. Empty means the<br/>
        /// default posture: the agent's built-in call controls and<br/>
        /// knowledge search only, with no webhook, MCP or transfer tool —<br/>
        /// a link recipient is a stranger, not the owner's customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tool_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedToolIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareLink" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="label">
        /// The owner's own note on the link, for telling several apart.
        /// </param>
        /// <param name="tokenPrefix">
        /// The token's leading characters, kept so a list can show a<br/>
        /// recognisable masked label. Useless as a guess on its own.
        /// </param>
        /// <param name="tokenRecoverable">
        /// Whether `revealShareLinkToken` can return this link's URL. False<br/>
        /// for links created before the token was stored recoverably: theirs<br/>
        /// was hashed and discarded, so the only way to share again is a new<br/>
        /// link. Read it before offering a copy action.
        /// </param>
        /// <param name="status">
        /// The link's resolved lifecycle state, computed server-side so<br/>
        /// every client agrees on what "expired" means.
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="budgetSeconds">
        /// Total conversation time this link may ever authorise.
        /// </param>
        /// <param name="secondsUsed">
        /// Conversation time settled against the link.
        /// </param>
        /// <param name="secondsReserved">
        /// Conversation time held by calls currently in flight.
        /// </param>
        /// <param name="secondsRemaining">
        /// What a new call can still draw on: the budget minus settled and<br/>
        /// in-flight time. Reservations count against it, so two<br/>
        /// simultaneous starts cannot both spend the tail.
        /// </param>
        /// <param name="maxCallDurationSeconds">
        /// Ceiling on any single call opened through this link. Clamped at<br/>
        /// dispatch against the agent's own limit and the workspace plan,<br/>
        /// so a link can shorten a call but never lengthen one.
        /// </param>
        /// <param name="maxConcurrent">
        /// How many calls this link may run at once. Bounded separately<br/>
        /// from the workspace's own concurrency cap, so a widely-shared<br/>
        /// link cannot consume the capacity the owner's real callers need.
        /// </param>
        /// <param name="allowedToolIds">
        /// Tools the owner opted this link into, by id. Empty means the<br/>
        /// default posture: the agent's built-in call controls and<br/>
        /// knowledge search only, with no webhook, MCP or transfer tool —<br/>
        /// a link recipient is a stranger, not the owner's customer.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="revokedAt"></param>
        /// <param name="lastUsedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShareLink(
            string id,
            string agentId,
            string label,
            string tokenPrefix,
            bool tokenRecoverable,
            global::Speechify.ShareLinkStatus status,
            global::System.DateTime expiresAt,
            int budgetSeconds,
            int secondsUsed,
            int secondsReserved,
            int secondsRemaining,
            int maxCallDurationSeconds,
            int maxConcurrent,
            global::System.Collections.Generic.IList<string> allowedToolIds,
            global::System.DateTime createdAt,
            global::System.DateTime? revokedAt,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.TokenPrefix = tokenPrefix ?? throw new global::System.ArgumentNullException(nameof(tokenPrefix));
            this.TokenRecoverable = tokenRecoverable;
            this.Status = status;
            this.ExpiresAt = expiresAt;
            this.RevokedAt = revokedAt;
            this.BudgetSeconds = budgetSeconds;
            this.SecondsUsed = secondsUsed;
            this.SecondsReserved = secondsReserved;
            this.SecondsRemaining = secondsRemaining;
            this.MaxCallDurationSeconds = maxCallDurationSeconds;
            this.MaxConcurrent = maxConcurrent;
            this.AllowedToolIds = allowedToolIds ?? throw new global::System.ArgumentNullException(nameof(allowedToolIds));
            this.LastUsedAt = lastUsedAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareLink" /> class.
        /// </summary>
        public ShareLink()
        {
        }

    }
}