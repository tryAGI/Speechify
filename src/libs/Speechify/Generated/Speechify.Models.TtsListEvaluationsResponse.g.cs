
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListEvaluationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsEvaluation> Evaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListEvaluationsResponse" /> class.
        /// </summary>
        /// <param name="evaluations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListEvaluationsResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsEvaluation> evaluations)
        {
            this.Evaluations = evaluations ?? throw new global::System.ArgumentNullException(nameof(evaluations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListEvaluationsResponse" /> class.
        /// </summary>
        public TtsListEvaluationsResponse()
        {
        }
    }
}