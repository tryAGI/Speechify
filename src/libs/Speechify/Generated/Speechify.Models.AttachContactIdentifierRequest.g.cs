
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The customer's assertion that this handle denotes this person. It<br/>
    /// carries the handle and nothing else: `asserted_by` and `verified_at`<br/>
    /// are stamped by the server from the fact that the request<br/>
    /// authenticated, and are not accepted here.
    /// </summary>
    public sealed partial class AttachContactIdentifierRequest
    {
        /// <summary>
        /// The namespace this value lives in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AttachContactIdentifierRequestKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AttachContactIdentifierRequestKind Kind { get; set; }

        /// <summary>
        /// The handle - an application user id, an E.164 number, an email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachContactIdentifierRequest" /> class.
        /// </summary>
        /// <param name="kind">
        /// The namespace this value lives in.
        /// </param>
        /// <param name="value">
        /// The handle - an application user id, an E.164 number, an email address.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachContactIdentifierRequest(
            global::Speechify.AttachContactIdentifierRequestKind kind,
            string value)
        {
            this.Kind = kind;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachContactIdentifierRequest" /> class.
        /// </summary>
        public AttachContactIdentifierRequest()
        {
        }

    }
}