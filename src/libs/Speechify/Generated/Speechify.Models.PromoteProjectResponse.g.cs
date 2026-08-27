
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The manifest of one promote. Every id is a resource created in the<br/>
    /// target, except `reused`, which names target resources bound instead of<br/>
    /// copied. `needs_attention` is what a person must finish by hand.
    /// </summary>
    public sealed partial class PromoteProjectResponse
    {
        /// <summary>
        /// Ids minted in the target, by kind. Each list is empty, never absent, when nothing of that kind was copied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PromoteCreated Created { get; set; }

        /// <summary>
        /// Target resources bound instead of copied because an identical definition already existed there.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PromoteReused Reused { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("needs_attention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.PromoteAttention> NeedsAttention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteProjectResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// Ids minted in the target, by kind. Each list is empty, never absent, when nothing of that kind was copied.
        /// </param>
        /// <param name="reused">
        /// Target resources bound instead of copied because an identical definition already existed there.
        /// </param>
        /// <param name="needsAttention"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteProjectResponse(
            global::Speechify.PromoteCreated created,
            global::Speechify.PromoteReused reused,
            global::System.Collections.Generic.IList<global::Speechify.PromoteAttention> needsAttention)
        {
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Reused = reused ?? throw new global::System.ArgumentNullException(nameof(reused));
            this.NeedsAttention = needsAttention ?? throw new global::System.ArgumentNullException(nameof(needsAttention));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteProjectResponse" /> class.
        /// </summary>
        public PromoteProjectResponse()
        {
        }

    }
}