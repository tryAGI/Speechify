
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One resource that references a credential by id. Lets a customer see<br/>
    /// exactly what would break before rotating or deleting the secret.
    /// </summary>
    public sealed partial class CredentialReference
    {
        /// <summary>
        /// The kind of resource referencing the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CredentialReferenceResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialReferenceResourceType ResourceType { get; set; }

        /// <summary>
        /// Prefixed external id of the referencing resource (`tool_...` for a<br/>
        /// tool, `agent_...` for an agent, `chan_...` for a channel).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name of the referencing resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialReference" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// The kind of resource referencing the credential.
        /// </param>
        /// <param name="id">
        /// Prefixed external id of the referencing resource (`tool_...` for a<br/>
        /// tool, `agent_...` for an agent, `chan_...` for a channel).
        /// </param>
        /// <param name="name">
        /// Human-readable name of the referencing resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialReference(
            global::Speechify.CredentialReferenceResourceType resourceType,
            string id,
            string name)
        {
            this.ResourceType = resourceType;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialReference" /> class.
        /// </summary>
        public CredentialReference()
        {
        }

    }
}