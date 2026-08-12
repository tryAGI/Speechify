
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Inbound SIP headers mapped onto agent variables, as configured<br/>
    /// when the trunk was created. Absent when the trunk maps none.
    /// </summary>
    public sealed partial class SIPTrunkHeadersToAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}