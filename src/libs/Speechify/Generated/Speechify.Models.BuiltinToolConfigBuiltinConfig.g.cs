
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-builtin extras, keyed by the `builtin` above.<br/>
    /// `transfer_to_number` takes `mode` (`cold`, the default, hands the<br/>
    /// caller's own line to the carrier via SIP REFER; `warm` calls the<br/>
    /// destination first, reads them a summary of the conversation while<br/>
    /// the caller holds, and bridges the two once they accept),<br/>
    /// `hold_message` (warm only; the line spoken before the caller goes<br/>
    /// on hold, `{{variable}}` tokens resolved, platform default when<br/>
    /// empty), and `allowed_numbers` (destinations the LLM may pass, in<br/>
    /// either mode; omit to allow any).<br/>
    /// `play_audio` takes `audio_asset_id`.
    /// </summary>
    public sealed partial class BuiltinToolConfigBuiltinConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}