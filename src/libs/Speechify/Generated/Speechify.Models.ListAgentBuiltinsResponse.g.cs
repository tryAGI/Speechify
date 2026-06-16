
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentBuiltinsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AgentBuiltin> Builtins { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentBuiltinsResponse" /> class.
        /// </summary>
        /// <param name="builtins"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentBuiltinsResponse(
            global::System.Collections.Generic.IList<global::Speechify.AgentBuiltin> builtins)
        {
            this.Builtins = builtins ?? throw new global::System.ArgumentNullException(nameof(builtins));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentBuiltinsResponse" /> class.
        /// </summary>
        public ListAgentBuiltinsResponse()
        {
        }

    }
}