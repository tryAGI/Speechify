
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A run that has not finished, as it stands: sent for every live run when<br/>
    /// the stream opens, when a run appears, and whenever its `status` or<br/>
    /// `pending_action` changes.
    /// </summary>
    public sealed partial class ProjectRunStreamEventVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ProjectRunStreamEventVariant1TypeJsonConverter))]
        public global::Speechify.ProjectRunStreamEventVariant1Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ProjectRunStreamEventVariant1" /> class.
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
        public ProjectRunStreamEventVariant1(
            global::Speechify.AgentRunLifecycle run,
            global::Speechify.ProjectRunStreamEventVariant1Type type)
        {
            this.Type = type;
            this.Run = run ?? throw new global::System.ArgumentNullException(nameof(run));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRunStreamEventVariant1" /> class.
        /// </summary>
        public ProjectRunStreamEventVariant1()
        {
        }

    }
}