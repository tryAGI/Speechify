
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Static headers sent with every call. `Authorization` and `Speechify-Signature` are reserved.
    /// </summary>
    public sealed partial class WebhookToolConfigHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}