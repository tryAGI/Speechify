
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the run failed. Present only on a `failed` run.
    /// </summary>
    public sealed partial class AgentRunLifecycleError
    {
        /// <summary>
        /// What class of failure this was. Branch on this, never on `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A stable human-readable sentence for the class in `code`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunLifecycleError" /> class.
        /// </summary>
        /// <param name="code">
        /// What class of failure this was. Branch on this, never on `message`.
        /// </param>
        /// <param name="message">
        /// A stable human-readable sentence for the class in `code`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunLifecycleError(
            string? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunLifecycleError" /> class.
        /// </summary>
        public AgentRunLifecycleError()
        {
        }

    }
}