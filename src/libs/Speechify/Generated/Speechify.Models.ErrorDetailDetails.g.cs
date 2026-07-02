
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Structured, endpoint-specific context beyond the flat<br/>
    /// `fields` map. Present only on the few errors that carry<br/>
    /// it (e.g. the `used_by` referrer list on a credential<br/>
    /// delete-conflict); its shape depends on the error `code`.<br/>
    /// Clients that don't recognise a `details` shape can ignore<br/>
    /// it - the `code` + `message` contract is unchanged.
    /// </summary>
    public sealed partial class ErrorDetailDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}