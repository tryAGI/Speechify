
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Terminal event carrying the standard error envelope, emitted when a<br/>
    /// failure happens after the stream has started and the status code is<br/>
    /// already committed.
    /// </summary>
    public sealed partial class SpeechStreamEventVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SpeechStreamEventVariant3TypeJsonConverter))]
        public global::Speechify.SpeechStreamEventVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ErrorDetail Error { get; set; }

        /// <summary>
        /// Server-side request identifier. Echoes the `Speechify-Request-Id`<br/>
        /// response header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamEventVariant3" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="type"></param>
        /// <param name="requestId">
        /// Server-side request identifier. Echoes the `Speechify-Request-Id`<br/>
        /// response header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechStreamEventVariant3(
            global::Speechify.ErrorDetail error,
            global::Speechify.SpeechStreamEventVariant3Type type,
            string? requestId)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamEventVariant3" /> class.
        /// </summary>
        public SpeechStreamEventVariant3()
        {
        }

    }
}