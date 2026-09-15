
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A run settled. It is the run's last event on the stream; the answer is<br/>
    /// not on it, so read the run with Get Run when you need what it produced.
    /// </summary>
    public sealed partial class ProjectRunStreamEventVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ProjectRunStreamEventVariant2TypeJsonConverter))]
        public global::Speechify.ProjectRunStreamEventVariant2Type Type { get; set; }

        /// <summary>
        /// A run as the project run stream reports it: which run, whose, where it<br/>
        /// stands and what it is waiting on. Each field means what it means on the<br/>
        /// run object, except `user_identity`, which the run object carries under<br/>
        /// `input`. What the run was asked and what it answered are never here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentRunLifecycle Run { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRunStreamEventVariant2" /> class.
        /// </summary>
        /// <param name="run">
        /// A run as the project run stream reports it: which run, whose, where it<br/>
        /// stands and what it is waiting on. Each field means what it means on the<br/>
        /// run object, except `user_identity`, which the run object carries under<br/>
        /// `input`. What the run was asked and what it answered are never here.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRunStreamEventVariant2(
            global::Speechify.AgentRunLifecycle run,
            global::Speechify.ProjectRunStreamEventVariant2Type type)
        {
            this.Type = type;
            this.Run = run ?? throw new global::System.ArgumentNullException(nameof(run));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRunStreamEventVariant2" /> class.
        /// </summary>
        public ProjectRunStreamEventVariant2()
        {
        }

    }
}