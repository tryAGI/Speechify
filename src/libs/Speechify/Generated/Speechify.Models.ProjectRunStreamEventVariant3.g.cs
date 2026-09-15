
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Every run that was live when this connection opened has been sent.<br/>
    /// Sent once per connection, after the opening `run.updated` events.
    /// </summary>
    public sealed partial class ProjectRunStreamEventVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ProjectRunStreamEventVariant3TypeJsonConverter))]
        public global::Speechify.ProjectRunStreamEventVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRunStreamEventVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRunStreamEventVariant3(
            global::Speechify.ProjectRunStreamEventVariant3Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRunStreamEventVariant3" /> class.
        /// </summary>
        public ProjectRunStreamEventVariant3()
        {
        }

    }
}