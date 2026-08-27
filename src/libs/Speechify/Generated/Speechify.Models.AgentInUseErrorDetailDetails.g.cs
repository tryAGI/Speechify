
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Structured, endpoint-specific context beyond the flat<br/>
    /// `fields` map. Present only on the few errors that carry<br/>
    /// it (e.g. the `used_by` referrer list on a credential<br/>
    /// delete-conflict); its shape depends on the error `code`.<br/>
    /// Clients that don't recognise a `details` shape can ignore<br/>
    /// it - the `code` + `message` contract is unchanged.
    /// </summary>
    public sealed partial class AgentInUseErrorDetailDetails
    {
        /// <summary>
        /// The live phone numbers routing to the agent. `count` is the total;<br/>
        /// `references` lists them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentPhoneNumberUsedBy UsedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInUseErrorDetailDetails" /> class.
        /// </summary>
        /// <param name="usedBy">
        /// The live phone numbers routing to the agent. `count` is the total;<br/>
        /// `references` lists them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInUseErrorDetailDetails(
            global::Speechify.AgentPhoneNumberUsedBy usedBy)
        {
            this.UsedBy = usedBy ?? throw new global::System.ArgumentNullException(nameof(usedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInUseErrorDetailDetails" /> class.
        /// </summary>
        public AgentInUseErrorDetailDetails()
        {
        }

    }
}