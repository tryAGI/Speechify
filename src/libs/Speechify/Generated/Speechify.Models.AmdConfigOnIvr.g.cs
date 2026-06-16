
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Action when AMD returns category=machine-ivr.
    /// </summary>
    public sealed partial class AmdConfigOnIvr
    {
        /// <summary>
        /// proceed: hand control to the agent's flow as if the<br/>
        /// called party were human. hangup: terminate immediately.<br/>
        /// navigate: hand control to the IVR Navigator subagent<br/>
        /// with menu-memoization-aware session config (cache hit<br/>
        /// seeds the agent context; cache miss triggers cold<br/>
        /// discovery and the post-call pipeline extracts the<br/>
        /// menu for future calls).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AmdConfigOnIvrActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AmdConfigOnIvrAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AmdConfigOnIvr" /> class.
        /// </summary>
        /// <param name="action">
        /// proceed: hand control to the agent's flow as if the<br/>
        /// called party were human. hangup: terminate immediately.<br/>
        /// navigate: hand control to the IVR Navigator subagent<br/>
        /// with menu-memoization-aware session config (cache hit<br/>
        /// seeds the agent context; cache miss triggers cold<br/>
        /// discovery and the post-call pipeline extracts the<br/>
        /// menu for future calls).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AmdConfigOnIvr(
            global::Speechify.AmdConfigOnIvrAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmdConfigOnIvr" /> class.
        /// </summary>
        public AmdConfigOnIvr()
        {
        }

    }
}