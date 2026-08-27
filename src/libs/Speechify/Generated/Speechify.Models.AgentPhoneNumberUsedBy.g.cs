
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The live phone numbers routing to the agent. `count` is the total;<br/>
    /// `references` lists them.
    /// </summary>
    public sealed partial class AgentPhoneNumberUsedBy
    {
        /// <summary>
        /// Number of live phone numbers bound to this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AgentPhoneNumberReference> References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPhoneNumberUsedBy" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of live phone numbers bound to this agent.
        /// </param>
        /// <param name="references"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPhoneNumberUsedBy(
            int count,
            global::System.Collections.Generic.IList<global::Speechify.AgentPhoneNumberReference> references)
        {
            this.Count = count;
            this.References = references ?? throw new global::System.ArgumentNullException(nameof(references));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPhoneNumberUsedBy" /> class.
        /// </summary>
        public AgentPhoneNumberUsedBy()
        {
        }

    }
}