
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for DELETE /v1/projects/{project_id}. Omit it to delete<br/>
    /// a project that holds nothing - one that holds something is refused<br/>
    /// with `409 project_not_empty` naming what is inside. Send<br/>
    /// `mode: detach` to keep every resource and move it to the Default<br/>
    /// project, or `mode: purge` with `confirm` equal to the project's exact<br/>
    /// name to remove the project with its contents.
    /// </summary>
    public sealed partial class DeleteProjectRequest
    {
        /// <summary>
        /// `detach` removes the grouping row only and moves every resource<br/>
        /// to the Default project; `purge` removes the project with its<br/>
        /// contents. Omitted, the delete removes only an empty project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.DeleteProjectRequestModeJsonConverter))]
        public global::Speechify.DeleteProjectRequestMode? Mode { get; set; }

        /// <summary>
        /// Required for `purge`: the project's name, exactly as returned by<br/>
        /// GET. A mismatch answers 400 `validation_failed` naming this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirm")]
        public string? Confirm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProjectRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// `detach` removes the grouping row only and moves every resource<br/>
        /// to the Default project; `purge` removes the project with its<br/>
        /// contents. Omitted, the delete removes only an empty project.
        /// </param>
        /// <param name="confirm">
        /// Required for `purge`: the project's name, exactly as returned by<br/>
        /// GET. A mismatch answers 400 `validation_failed` naming this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteProjectRequest(
            global::Speechify.DeleteProjectRequestMode? mode,
            string? confirm)
        {
            this.Mode = mode;
            this.Confirm = confirm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProjectRequest" /> class.
        /// </summary>
        public DeleteProjectRequest()
        {
        }

    }
}