
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Result of one `ParameterCheck` within a tool-call test run.
    /// </summary>
    public sealed partial class ParameterCheckResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// How a `ParameterCheck` validates a tool argument.<br/>
        /// - `exact` - JSON equality.<br/>
        /// - `regex` - the argument stringified is matched against the pattern.<br/>
        /// - `llm` - an LLM judge decides whether the value semantically satisfies<br/>
        ///   the criteria (e.g. "is a plausible email address").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ParameterCheckModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ParameterCheckMode Mode { get; set; }

        /// <summary>
        /// JSON-serialised actual value at `path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActualJson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// LLM rationale (populated for `llm` mode checks).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterCheckResult" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode">
        /// How a `ParameterCheck` validates a tool argument.<br/>
        /// - `exact` - JSON equality.<br/>
        /// - `regex` - the argument stringified is matched against the pattern.<br/>
        /// - `llm` - an LLM judge decides whether the value semantically satisfies<br/>
        ///   the criteria (e.g. "is a plausible email address").
        /// </param>
        /// <param name="actualJson">
        /// JSON-serialised actual value at `path`.
        /// </param>
        /// <param name="passed"></param>
        /// <param name="rationale">
        /// LLM rationale (populated for `llm` mode checks).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParameterCheckResult(
            string path,
            global::Speechify.ParameterCheckMode mode,
            string actualJson,
            bool passed,
            string? rationale)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Mode = mode;
            this.ActualJson = actualJson ?? throw new global::System.ArgumentNullException(nameof(actualJson));
            this.Passed = passed;
            this.Rationale = rationale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterCheckResult" /> class.
        /// </summary>
        public ParameterCheckResult()
        {
        }

    }
}