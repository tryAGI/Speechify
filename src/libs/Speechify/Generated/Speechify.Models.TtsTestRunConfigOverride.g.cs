
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A run-level config override applied to every test in a Run All.<br/>
    /// Layered on top of the agent's stored config for the duration of<br/>
    /// the suite run, so the whole suite can be validated against a<br/>
    /// proposed prompt / model / toolbelt without editing any test. An<br/>
    /// absent field leaves the agent's value untouched; a run-level<br/>
    /// override wins over a deprecated per-test `system_prompt_override`<br/>
    /// / `model_override`.
    /// </summary>
    public sealed partial class TtsTestRunConfigOverride
    {
        /// <summary>
        /// Replaces the agent's system prompt for every test in the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Overrides the LLM model for every test in the run. The model<br/>
        /// id rides on the agent's configured provider — a<br/>
        /// cross-provider switch is not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Replaces the agent's attached external tools for the run with<br/>
        /// exactly this set. Each entry is a prefixed `tool_&lt;crockford&gt;`<br/>
        /// id; `builtin_` ids are rejected. An empty array runs with no<br/>
        /// tools; omit the field to keep the agent's attachments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestRunConfigOverride" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Replaces the agent's system prompt for every test in the run.
        /// </param>
        /// <param name="model">
        /// Overrides the LLM model for every test in the run. The model<br/>
        /// id rides on the agent's configured provider — a<br/>
        /// cross-provider switch is not supported.
        /// </param>
        /// <param name="toolIds">
        /// Replaces the agent's attached external tools for the run with<br/>
        /// exactly this set. Each entry is a prefixed `tool_&lt;crockford&gt;`<br/>
        /// id; `builtin_` ids are rejected. An empty array runs with no<br/>
        /// tools; omit the field to keep the agent's attachments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTestRunConfigOverride(
            string? prompt,
            string? model,
            global::System.Collections.Generic.IList<string>? toolIds)
        {
            this.Prompt = prompt;
            this.Model = model;
            this.ToolIds = toolIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestRunConfigOverride" /> class.
        /// </summary>
        public TtsTestRunConfigOverride()
        {
        }

    }
}