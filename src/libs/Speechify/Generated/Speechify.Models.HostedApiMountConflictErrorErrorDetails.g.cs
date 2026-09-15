
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedApiMountConflictErrorErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public global::Speechify.HostedAPIMount? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiMountConflictErrorErrorDetails" /> class.
        /// </summary>
        /// <param name="plan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedApiMountConflictErrorErrorDetails(
            global::Speechify.HostedAPIMount? plan)
        {
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiMountConflictErrorErrorDetails" /> class.
        /// </summary>
        public HostedApiMountConflictErrorErrorDetails()
        {
        }

    }
}