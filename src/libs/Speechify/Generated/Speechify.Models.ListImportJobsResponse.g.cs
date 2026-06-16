
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListImportJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ImportJob> Jobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListImportJobsResponse" /> class.
        /// </summary>
        /// <param name="jobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListImportJobsResponse(
            global::System.Collections.Generic.IList<global::Speechify.ImportJob> jobs)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListImportJobsResponse" /> class.
        /// </summary>
        public ListImportJobsResponse()
        {
        }

    }
}