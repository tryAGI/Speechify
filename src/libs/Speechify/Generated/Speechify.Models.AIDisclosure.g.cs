
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Opt-in AI-disclosure opening line. When `enabled` is true, `line` is<br/>
    /// spoken at the very start of the call, before the greeting - ahead of<br/>
    /// jurisdictions that require callers to be told they are speaking with an<br/>
    /// automated system. Off by default; existing agents and numbers are<br/>
    /// unaffected until they turn it on.
    /// </summary>
    public sealed partial class AIDisclosure
    {
        /// <summary>
        /// When true, `line` is spoken at the start of the call. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The disclosure spoken before the greeting (e.g. "This call is<br/>
        /// handled by an AI assistant."). Required when `enabled` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public string? Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIDisclosure" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When true, `line` is spoken at the start of the call. Defaults to false.
        /// </param>
        /// <param name="line">
        /// The disclosure spoken before the greeting (e.g. "This call is<br/>
        /// handled by an AI assistant."). Required when `enabled` is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AIDisclosure(
            bool enabled,
            string? line)
        {
            this.Enabled = enabled;
            this.Line = line;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIDisclosure" /> class.
        /// </summary>
        public AIDisclosure()
        {
        }

    }
}