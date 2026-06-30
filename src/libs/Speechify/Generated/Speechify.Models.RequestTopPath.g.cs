
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A called route pattern and its request count in the window.
    /// </summary>
    public sealed partial class RequestTopPath
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Route { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTopPath" /> class.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestTopPath(
            string route,
            int count)
        {
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTopPath" /> class.
        /// </summary>
        public RequestTopPath()
        {
        }

    }
}