
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Ids minted in the target, by kind. Each list is empty, never absent, when nothing of that kind was copied.
    /// </summary>
    public sealed partial class PromoteCreated
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Agents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_bases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> KnowledgeBases { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AudioAssets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WebhookEndpoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_tests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AgentTests { get; set; }

        /// <summary>
        /// The URL re-imports queued in the target's knowledge bases; poll each for completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ImportJobs { get; set; }

        /// <summary>
        /// The project-scoped custom models copied into the target so its<br/>
        /// agents keep running on their own endpoints. A workspace-shared<br/>
        /// custom model is not copied; the target reaches it as it is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CustomModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteCreated" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="tools"></param>
        /// <param name="knowledgeBases"></param>
        /// <param name="audioAssets"></param>
        /// <param name="webhookEndpoints"></param>
        /// <param name="agentTests"></param>
        /// <param name="importJobs">
        /// The URL re-imports queued in the target's knowledge bases; poll each for completion.
        /// </param>
        /// <param name="customModels">
        /// The project-scoped custom models copied into the target so its<br/>
        /// agents keep running on their own endpoints. A workspace-shared<br/>
        /// custom model is not copied; the target reaches it as it is.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteCreated(
            global::System.Collections.Generic.IList<string> agents,
            global::System.Collections.Generic.IList<string> tools,
            global::System.Collections.Generic.IList<string> knowledgeBases,
            global::System.Collections.Generic.IList<string> audioAssets,
            global::System.Collections.Generic.IList<string> webhookEndpoints,
            global::System.Collections.Generic.IList<string> agentTests,
            global::System.Collections.Generic.IList<string> importJobs,
            global::System.Collections.Generic.IList<string> customModels)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.KnowledgeBases = knowledgeBases ?? throw new global::System.ArgumentNullException(nameof(knowledgeBases));
            this.AudioAssets = audioAssets ?? throw new global::System.ArgumentNullException(nameof(audioAssets));
            this.WebhookEndpoints = webhookEndpoints ?? throw new global::System.ArgumentNullException(nameof(webhookEndpoints));
            this.AgentTests = agentTests ?? throw new global::System.ArgumentNullException(nameof(agentTests));
            this.ImportJobs = importJobs ?? throw new global::System.ArgumentNullException(nameof(importJobs));
            this.CustomModels = customModels ?? throw new global::System.ArgumentNullException(nameof(customModels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteCreated" /> class.
        /// </summary>
        public PromoteCreated()
        {
        }

    }
}