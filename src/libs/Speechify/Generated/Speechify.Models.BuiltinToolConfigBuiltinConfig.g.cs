
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
    /// Warm mode also takes `ringing_timeout_ms`, how long the<br/>
    /// destination may ring before the transfer is given up on. Omit it<br/>
    /// to ring for 30 seconds. The accepted range is the one an outbound call<br/>
    /// already publishes, 1000-80000 ms; a whole number of milliseconds<br/>
    /// outside it is rejected here, and on the flow node, rather than<br/>
    /// quietly shortened.<br/>
    /// Transferring into a queue usually needs longer than 30 seconds,<br/>
    /// because the queue's own rollover never gets the chance to fire.<br/>
    /// `play_audio` takes `audio_asset_id`.<br/>
    /// `run_code` describes the machine the run's sandbox boots. All five<br/>
    /// keys are optional, and with none of them set the run gets the<br/>
    /// platform default: a scratch filesystem on the vendor's base image<br/>
    /// that reaches nothing. `image` is the base image reference<br/>
    /// (`registry/name[:tag][@sha256:...]`); a tag is not re-resolved, so<br/>
    /// moving to a different tag rebuilds the workspace while repushing<br/>
    /// the same tag does not, and a digest pin is what makes that<br/>
    /// distinction go away. `setup_command` runs once on a cold boot and<br/>
    /// must be idempotent, because a rebuild can happen at any phase<br/>
    /// boundary. `work_dir` is the working directory for that command and<br/>
    /// for any call that names none, and must be absolute. `env` is<br/>
    /// non-secret configuration; a key whose name looks like a credential<br/>
    /// (`token`, `secret`, `api_key`, ...) is refused, because no<br/>
    /// credential may enter a sandbox. `allowed_domains` is the exact set<br/>
    /// of hostnames the sandbox may reach, and everything else is blocked;<br/>
    /// wildcards are refused, since `*.example.com` admits every subdomain<br/>
    /// anyone can register and does not even cover the apex. Use it to let<br/>
    /// a program reach hosts you operate or depend on - a package<br/>
    /// registry, your device farm, your own API. A private image is not<br/>
    /// supported: pulling one needs a registry credential, so install<br/>
    /// private dependencies in `setup_command` from a host on your own<br/>
    /// allowlist instead.
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