
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Which procedure ran on a call, and at which version. A body is<br/>
    /// immutable per version, so the pair reconstructs exactly what the model<br/>
    /// was told however far the catalog has moved since.
    /// </summary>
    public sealed partial class SkillPin
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillPin" /> class.
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillPin(
            string skillId,
            string name,
            int version)
        {
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillPin" /> class.
        /// </summary>
        public SkillPin()
        {
        }

    }
}