
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for DELETE /v1/projects/{project_id}. Omit it, or send<br/>
    /// `mode: detach`, for the default delete that keeps every resource and<br/>
    /// moves it to the Default project. Send `mode: purge` with `confirm`<br/>
    /// equal to the project's exact name to remove the project with its<br/>
    /// contents.
    /// </summary>
    public sealed partial class DeleteProjectRequest
    {
        /// <summary>
        /// `detach` removes the grouping row only; `purge` removes the<br/>
        /// project with its contents.<br/>
        /// Default Value: detach
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
        /// `detach` removes the grouping row only; `purge` removes the<br/>
        /// project with its contents.<br/>
        /// Default Value: detach
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