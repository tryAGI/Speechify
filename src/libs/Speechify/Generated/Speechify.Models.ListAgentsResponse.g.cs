
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.Agent> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponse" /> class.
        /// </summary>
        /// <param name="agents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentsResponse(
            global::System.Collections.Generic.IList<global::Speechify.Agent> agents)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponse" /> class.
        /// </summary>
        public ListAgentsResponse()
        {
        }

    }
}