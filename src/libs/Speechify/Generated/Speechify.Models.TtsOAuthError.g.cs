
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsOAuthError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsOAuthErrorErrorJsonConverter))]
        public global::Speechify.TtsOAuthErrorError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsOAuthError" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsOAuthError(
            global::Speechify.TtsOAuthErrorError? error,
            string? errorDescription)
        {
            this.Error = error;
            this.ErrorDescription = errorDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsOAuthError" /> class.
        /// </summary>
        public TtsOAuthError()
        {
        }
    }
}