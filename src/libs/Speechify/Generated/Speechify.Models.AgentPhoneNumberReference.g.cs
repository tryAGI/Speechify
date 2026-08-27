
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One live phone number whose binding pins the agent.
    /// </summary>
    public sealed partial class AgentPhoneNumberReference
    {
        /// <summary>
        /// Always `phone_number`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentPhoneNumberReferenceResourceTypeJsonConverter))]
        public global::Speechify.AgentPhoneNumberReferenceResourceType ResourceType { get; set; }

        /// <summary>
        /// The number's prefixed external id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The number in E.164.
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
        /// Initializes a new instance of the <see cref="AgentPhoneNumberReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The number's prefixed external id.
        /// </param>
        /// <param name="name">
        /// The number in E.164.
        /// </param>
        /// <param name="resourceType">
        /// Always `phone_number`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPhoneNumberReference(
            string id,
            string name,
            global::Speechify.AgentPhoneNumberReferenceResourceType resourceType)
        {
            this.ResourceType = resourceType;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPhoneNumberReference" /> class.
        /// </summary>
        public AgentPhoneNumberReference()
        {
        }

    }
}