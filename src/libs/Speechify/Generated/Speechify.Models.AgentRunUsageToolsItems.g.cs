
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRunUsageToolsItems
    {
        /// <summary>
        /// The built-in's reserved name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// How many times the run called it. A call that came back an error still counts: the vendor charged for it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Calls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_micro_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CostMicroUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsageToolsItems" /> class.
        /// </summary>
        /// <param name="tool">
        /// The built-in's reserved name.
        /// </param>
        /// <param name="calls">
        /// How many times the run called it. A call that came back an error still counts: the vendor charged for it.
        /// </param>
        /// <param name="costMicroUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunUsageToolsItems(
            string tool,
            int calls,
            long costMicroUsd)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Calls = calls;
            this.CostMicroUsd = costMicroUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsageToolsItems" /> class.
        /// </summary>
        public AgentRunUsageToolsItems()
        {
        }

    }
}