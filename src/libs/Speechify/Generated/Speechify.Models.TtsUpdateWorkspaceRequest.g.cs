
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for PATCH /v1/tenants/current.
    /// </summary>
    public sealed partial class TtsUpdateWorkspaceRequest
    {
        /// <summary>
        /// New display name. Required; must be 120 characters or fewer.
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
        /// Initializes a new instance of the <see cref="TtsUpdateWorkspaceRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New display name. Required; must be 120 characters or fewer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateWorkspaceRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateWorkspaceRequest" /> class.
        /// </summary>
        public TtsUpdateWorkspaceRequest()
        {
        }
    }
}