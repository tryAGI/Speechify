
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=builtin`. The `builtin` value names the<br/>
    /// worker-resident capability; the catalogue served by<br/>
    /// `GET /v1/agents/tool-capabilities` is the runtime source of truth<br/>
    /// for valid names plus their human-readable labels. `builtin_config`<br/>
    /// carries per-instance extras (e.g. mode + hold_message +<br/>
    /// allowed_numbers for transfer_to_number, audio_asset_id for<br/>
    /// play_audio).
    /// </summary>
    public sealed partial class BuiltinToolConfig
    {
        /// <summary>
        /// Identifier of a built-in system tool. New builtins are added by<br/>
        /// Speechify across releases. Read the catalogue from<br/>
        /// `GET /v1/agents/tool-capabilities` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Builtin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.ToolParam>? Params { get; set; }

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
        /// Warm mode takes two more, both optional, and with neither set the<br/>
        /// person hears the brief the platform writes today.<br/>
        /// `briefing_instructions` steers how that brief is written - what to<br/>
        /// lead with, what to leave out, how long to be - and is applied<br/>
        /// UNDER the platform's own brief-writing rules rather than in place<br/>
        /// of them, so the call transcript stays quoted evidence no<br/>
        /// instruction inside it can escape (max 2000 characters).<br/>
        /// `briefing_template` replaces the generated brief with a fixed<br/>
        /// line, for a handoff that must state the same facts every time:<br/>
        /// `{{variable}}` tokens resolve as they do in `hold_message`, and<br/>
        /// `{{system__summary}}` resolves to the generated brief, so a<br/>
        /// template can pin the facts first and still hand over the rest of<br/>
        /// the call. That token sits in the reserved `system__` namespace, so<br/>
        /// it can never shadow a variable of your own. A template that never<br/>
        /// names it skips generating one (max<br/>
        /// 600 characters, short enough that the line and the "press 1 to<br/>
        /// take the call" after it fit one playout).<br/>
        /// `play_audio` takes `audio_asset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin_config")]
        public object? BuiltinConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltinToolConfig" /> class.
        /// </summary>
        /// <param name="builtin">
        /// Identifier of a built-in system tool. New builtins are added by<br/>
        /// Speechify across releases. Read the catalogue from<br/>
        /// `GET /v1/agents/tool-capabilities` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </param>
        /// <param name="params"></param>
        /// <param name="builtinConfig">
        /// Per-builtin extras, keyed by the `builtin` above.<br/>
        /// `transfer_to_number` takes `mode` (`cold`, the default, hands the<br/>
        /// caller's own line to the carrier via SIP REFER; `warm` calls the<br/>
        /// destination first, reads them a summary of the conversation while<br/>
        /// the caller holds, and bridges the two once they accept),<br/>
        /// `hold_message` (warm only; the line spoken before the caller goes<br/>
        /// on hold, `{{variable}}` tokens resolved, platform default when<br/>
        /// empty), and `allowed_numbers` (destinations the LLM may pass, in<br/>
        /// either mode; omit to allow any).<br/>
        /// Warm mode takes two more, both optional, and with neither set the<br/>
        /// person hears the brief the platform writes today.<br/>
        /// `briefing_instructions` steers how that brief is written - what to<br/>
        /// lead with, what to leave out, how long to be - and is applied<br/>
        /// UNDER the platform's own brief-writing rules rather than in place<br/>
        /// of them, so the call transcript stays quoted evidence no<br/>
        /// instruction inside it can escape (max 2000 characters).<br/>
        /// `briefing_template` replaces the generated brief with a fixed<br/>
        /// line, for a handoff that must state the same facts every time:<br/>
        /// `{{variable}}` tokens resolve as they do in `hold_message`, and<br/>
        /// `{{system__summary}}` resolves to the generated brief, so a<br/>
        /// template can pin the facts first and still hand over the rest of<br/>
        /// the call. That token sits in the reserved `system__` namespace, so<br/>
        /// it can never shadow a variable of your own. A template that never<br/>
        /// names it skips generating one (max<br/>
        /// 600 characters, short enough that the line and the "press 1 to<br/>
        /// take the call" after it fit one playout).<br/>
        /// `play_audio` takes `audio_asset_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltinToolConfig(
            string builtin,
            global::System.Collections.Generic.IList<global::Speechify.ToolParam>? @params,
            object? builtinConfig)
        {
            this.Builtin = builtin ?? throw new global::System.ArgumentNullException(nameof(builtin));
            this.Params = @params;
            this.BuiltinConfig = builtinConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltinToolConfig" /> class.
        /// </summary>
        public BuiltinToolConfig()
        {
        }

    }
}