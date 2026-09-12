
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The chat thread a standing watch was created in and posts into.<br/>
    /// Present only on a trigger the agent registered from a conversation;<br/>
    /// it cannot be set or changed through this API - the platform resolves<br/>
    /// it from the conversation the order was given in.
    /// </summary>
    public sealed partial class TriggerThread
    {
        /// <summary>
        /// The channel instance (front door) the thread belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_instance_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelInstanceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerThread" /> class.
        /// </summary>
        /// <param name="channelInstanceId">
        /// The channel instance (front door) the thread belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerThread(
            string channelInstanceId)
        {
            this.ChannelInstanceId = channelInstanceId ?? throw new global::System.ArgumentNullException(nameof(channelInstanceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerThread" /> class.
        /// </summary>
        public TriggerThread()
        {
        }

    }
}