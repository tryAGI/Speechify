
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Up to 16 key/value pairs merged onto every run this trigger fires,<br/>
    /// beside the `trigger_id` and `trigger_fire_key` the platform stamps.<br/>
    /// Your own correlation ids belong here. The platform's keys<br/>
    /// (`trigger`, `trigger_id`, `trigger_fire_key`) are refused with a<br/>
    /// 400 when the trigger is saved, since the stamp would win.
    /// </summary>
    public sealed partial class TriggerRunSpecMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}