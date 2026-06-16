
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Action when AMD returns category=machine-vm.
    /// </summary>
    public sealed partial class AmdConfigOnVoicemail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AmdConfigOnVoicemailActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AmdConfigOnVoicemailAction Action { get; set; }

        /// <summary>
        /// Spoken before terminating when action=leave_message.<br/>
        /// Supports {{variable}} substitution. Required (non-empty)<br/>
        /// when action=leave_message; rejected by the validator<br/>
        /// otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AmdConfigOnVoicemail" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="message">
        /// Spoken before terminating when action=leave_message.<br/>
        /// Supports {{variable}} substitution. Required (non-empty)<br/>
        /// when action=leave_message; rejected by the validator<br/>
        /// otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AmdConfigOnVoicemail(
            global::Speechify.AmdConfigOnVoicemailAction action,
            string? message)
        {
            this.Action = action;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmdConfigOnVoicemail" /> class.
        /// </summary>
        public AmdConfigOnVoicemail()
        {
        }

    }
}