
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedAPIMount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.HostedApiMountToolKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedApiMountToolKind ToolKind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NamePrefix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PathPrefix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DryRun { get; set; }

        /// <summary>
        /// One entry per operation the connector offers, in its order, then one per stale route whose operation it no longer offers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.HostedAPIMountOperation> Operations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedAPIMountSummary Summary { get; set; }

        /// <summary>
        /// Names this plan's content: every operation the connector offers and<br/>
        /// every route the API holds for it, whatever `operations` selects,<br/>
        /// and nothing that moves without the plan changing. Send it back as<br/>
        /// the apply's `plan_digest` to write only this plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanDigest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIMount" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="toolName"></param>
        /// <param name="toolKind"></param>
        /// <param name="namePrefix"></param>
        /// <param name="pathPrefix"></param>
        /// <param name="dryRun"></param>
        /// <param name="operations">
        /// One entry per operation the connector offers, in its order, then one per stale route whose operation it no longer offers.
        /// </param>
        /// <param name="summary"></param>
        /// <param name="planDigest">
        /// Names this plan's content: every operation the connector offers and<br/>
        /// every route the API holds for it, whatever `operations` selects,<br/>
        /// and nothing that moves without the plan changing. Send it back as<br/>
        /// the apply's `plan_digest` to write only this plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIMount(
            string toolId,
            string toolName,
            global::Speechify.HostedApiMountToolKind toolKind,
            string namePrefix,
            string pathPrefix,
            bool dryRun,
            global::System.Collections.Generic.IList<global::Speechify.HostedAPIMountOperation> operations,
            global::Speechify.HostedAPIMountSummary summary,
            string planDigest)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolKind = toolKind;
            this.NamePrefix = namePrefix ?? throw new global::System.ArgumentNullException(nameof(namePrefix));
            this.PathPrefix = pathPrefix ?? throw new global::System.ArgumentNullException(nameof(pathPrefix));
            this.DryRun = dryRun;
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.PlanDigest = planDigest ?? throw new global::System.ArgumentNullException(nameof(planDigest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIMount" /> class.
        /// </summary>
        public HostedAPIMount()
        {
        }

    }
}