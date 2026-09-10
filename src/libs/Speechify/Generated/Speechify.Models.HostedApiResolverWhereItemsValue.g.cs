
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A literal; a `{{query.x}}` / `{{path.x}}` / `{{body.x}}` template<br/>
    /// bound from the request; or a `{{user.x}}` claim of the verified<br/>
    /// end-user token (only on a `user_token` API). A clause whose<br/>
    /// template is absent from the request is skipped. The field<br/>
    /// `user_identity` is the person a document belongs to, and a<br/>
    /// clause on it must bind `{{user.sub}}`, never a request template:<br/>
    /// a request parameter is whatever the caller sends, so scoping on<br/>
    /// it would let any caller read any user's rows.
    /// </summary>
    public sealed partial class HostedApiResolverWhereItemsValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}