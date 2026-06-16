
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentTestsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AgentTestWithLastRun> Tests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentTestsResponse" /> class.
        /// </summary>
        /// <param name="tests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentTestsResponse(
            global::System.Collections.Generic.IList<global::Speechify.AgentTestWithLastRun> tests)
        {
            this.Tests = tests ?? throw new global::System.ArgumentNullException(nameof(tests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentTestsResponse" /> class.
        /// </summary>
        public ListAgentTestsResponse()
        {
        }

    }
}