
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The hosted API a route belongs to.
    /// </summary>
    public sealed partial class ToolAPIRouteAPI
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The API's project; null for the Default project. A route answers only while its tool is in this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolAPIRouteAPI" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// The API's project; null for the Default project. A route answers only while its tool is in this project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolAPIRouteAPI(
            string id,
            string name,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolAPIRouteAPI" /> class.
        /// </summary>
        public ToolAPIRouteAPI()
        {
        }

    }
}