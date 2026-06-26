
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCredentialsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.Credential> Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCredentialsResponse" /> class.
        /// </summary>
        /// <param name="credentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCredentialsResponse(
            global::System.Collections.Generic.IList<global::Speechify.Credential> credentials)
        {
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCredentialsResponse" /> class.
        /// </summary>
        public ListCredentialsResponse()
        {
        }

    }
}