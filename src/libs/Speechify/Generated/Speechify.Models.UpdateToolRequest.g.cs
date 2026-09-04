
#nullable enable

namespace Speechify
{
    /// <summary>
    /// All fields optional. `kind` is immutable — create a new definition to change it.
    /// </summary>
    public sealed partial class UpdateToolRequest
    {
        /// <summary>
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.UpdateToolRequestConfigJsonConverter))]
        public global::Speechify.UpdateToolRequestConfig? Config { get; set; }

        /// <summary>
        /// A class sets it, an explicit null clears it to unclassified, omitted leaves it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_class")]
        public global::Speechify.ToolActionClass? ActionClass { get; set; }

        /// <summary>
        /// A class sets the override, an explicit null returns to derived, omitted leaves it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval")]
        public global::Speechify.ToolApprovalClass? Approval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config"></param>
        /// <param name="actionClass">
        /// A class sets it, an explicit null clears it to unclassified, omitted leaves it unchanged.
        /// </param>
        /// <param name="approval">
        /// A class sets the override, an explicit null returns to derived, omitted leaves it unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateToolRequest(
            string? projectId,
            string? name,
            string? description,
            global::Speechify.UpdateToolRequestConfig? config,
            global::Speechify.ToolActionClass? actionClass,
            global::Speechify.ToolApprovalClass? approval)
        {
            this.ProjectId = projectId;
            this.Name = name;
            this.Description = description;
            this.Config = config;
            this.ActionClass = actionClass;
            this.Approval = approval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolRequest" /> class.
        /// </summary>
        public UpdateToolRequest()
        {
        }

    }
}