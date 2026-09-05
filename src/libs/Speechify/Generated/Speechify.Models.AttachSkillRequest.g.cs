
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AttachSkillRequest
    {
        /// <summary>
        /// Version to pin. Omit to pin whatever is latest at this moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachSkillRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Version to pin. Omit to pin whatever is latest at this moment.
        /// </param>
        /// <param name="enabled">
        /// Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachSkillRequest(
            int? version,
            bool? enabled)
        {
            this.Version = version;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachSkillRequest" /> class.
        /// </summary>
        public AttachSkillRequest()
        {
        }

    }
}