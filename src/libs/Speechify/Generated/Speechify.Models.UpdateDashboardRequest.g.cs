
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Partial update; omitted fields are left unchanged.
    /// </summary>
    public sealed partial class UpdateDashboardRequest
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        public global::Speechify.DashboardLayout? Layout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDashboardRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="layout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDashboardRequest(
            string? name,
            string? description,
            global::Speechify.DashboardLayout? layout)
        {
            this.Name = name;
            this.Description = description;
            this.Layout = layout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDashboardRequest" /> class.
        /// </summary>
        public UpdateDashboardRequest()
        {
        }

    }
}