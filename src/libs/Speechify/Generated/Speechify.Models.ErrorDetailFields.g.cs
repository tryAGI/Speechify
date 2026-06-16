
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-field validation errors as `path -&gt; message`. Only<br/>
    /// present on 400 responses caused by request validation<br/>
    /// (typically code=`validation_failed`). Keys are field<br/>
    /// paths in dotted/bracket notation; values are short<br/>
    /// human explanations safe to inline-surface next to the<br/>
    /// offending form field.
    /// </summary>
    public sealed partial class ErrorDetailFields
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}