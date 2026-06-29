
#nullable enable

namespace Speechify
{
    /// <summary>
    /// JSON blob whose shape depends on `kind` — typically `url`,<br/>
    /// `max_pages`, `max_depth`. Read it for display<br/>
    /// only.
    /// </summary>
    public sealed partial class ImportJobParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}