
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardLayout
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widgets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.DashboardWidget> Widgets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayout" /> class.
        /// </summary>
        /// <param name="widgets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardLayout(
            global::System.Collections.Generic.IList<global::Speechify.DashboardWidget> widgets)
        {
            this.Widgets = widgets ?? throw new global::System.ArgumentNullException(nameof(widgets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayout" /> class.
        /// </summary>
        public DashboardLayout()
        {
        }

    }
}