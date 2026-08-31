
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body for `PATCH /v1/agents/phone-numbers/{phone_number_id}`. Edits<br/>
    /// the number's own attributes - `label` - and, where the Phone product is<br/>
    /// enabled, points the number at one of your external brains via<br/>
    /// `brain_id`. The<br/>
    /// number's provider and `e164` are immutable after import. The agent<br/>
    /// binding is managed separately as a relationship, via<br/>
    /// `POST`/`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`;<br/>
    /// a number's brain is a hosted agent or a brain of your own, never both.
    /// </summary>
    public sealed partial class UpdatePhoneNumberRequest
    {
        /// <summary>
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// New label. Pass an empty string to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Point this number at one of your external brains: a `brain_...`<br/>
        /// id binds it, an explicit null takes it off the number, omitted<br/>
        /// leaves the binding unchanged. Only a reference ever rides this body<br/>
        /// - the endpoint and its signing secret belong to the brain and are<br/>
        /// edited at `/v1/agents/brains/{brain_id}`, so rotating the secret<br/>
        /// there is enough and no number has to be re-saved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brain_id")]
        public string? BrainId { get; set; }

        /// <summary>
        /// Acknowledges that this bind takes the number away from a hosted<br/>
        /// agent that is still answering on it. Without it, pointing an<br/>
        /// agent-bound number at an external brain is refused with<br/>
        /// `409 relay_displaces_agent` naming the agent, so the displacement<br/>
        /// is never a surprise. Re-pointing one brain at another does not need<br/>
        /// it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_agent_binding")]
        public bool? ReplaceAgentBinding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Move the resource between workspace projects: a `proj_...` id<br/>
        /// moves it there, an explicit null moves it back to the implicit<br/>
        /// Default project, omitted leaves it unchanged.
        /// </param>
        /// <param name="label">
        /// New label. Pass an empty string to clear.
        /// </param>
        /// <param name="brainId">
        /// Point this number at one of your external brains: a `brain_...`<br/>
        /// id binds it, an explicit null takes it off the number, omitted<br/>
        /// leaves the binding unchanged. Only a reference ever rides this body<br/>
        /// - the endpoint and its signing secret belong to the brain and are<br/>
        /// edited at `/v1/agents/brains/{brain_id}`, so rotating the secret<br/>
        /// there is enough and no number has to be re-saved.
        /// </param>
        /// <param name="replaceAgentBinding">
        /// Acknowledges that this bind takes the number away from a hosted<br/>
        /// agent that is still answering on it. Without it, pointing an<br/>
        /// agent-bound number at an external brain is refused with<br/>
        /// `409 relay_displaces_agent` naming the agent, so the displacement<br/>
        /// is never a surprise. Re-pointing one brain at another does not need<br/>
        /// it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePhoneNumberRequest(
            string? projectId,
            string? label,
            string? brainId,
            bool? replaceAgentBinding)
        {
            this.ProjectId = projectId;
            this.Label = label;
            this.BrainId = brainId;
            this.ReplaceAgentBinding = replaceAgentBinding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        public UpdatePhoneNumberRequest()
        {
        }

    }
}