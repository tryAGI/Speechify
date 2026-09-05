
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Variable seed for the run. A webhook fire's JSON body is merged in<br/>
    /// under the webhook's `payload_variable` key.
    /// </summary>
    public sealed partial class TriggerRunSpecVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}