
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Outcome of one `data_assertions` entry: did the value the<br/>
    /// evaluator extracted under `key` pass the configured exact /<br/>
    /// regex / llm check.
    /// </summary>
    public sealed partial class TtsDataAssertionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsDataAssertionResultModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsDataAssertionResultMode Mode { get; set; }

        /// <summary>
        /// The extracted value rendered as JSON (`null` when the key was missing from the data map).
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
        /// Empty on pass; reason for failure otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsDataAssertionResult" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="mode"></param>
        /// <param name="actualJson">
        /// The extracted value rendered as JSON (`null` when the key was missing from the data map).
        /// </param>
        /// <param name="passed"></param>
        /// <param name="rationale">
        /// Empty on pass; reason for failure otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsDataAssertionResult(
            string key,
            global::Speechify.TtsDataAssertionResultMode mode,
            string actualJson,
            bool passed,
            string? rationale)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Mode = mode;
            this.ActualJson = actualJson ?? throw new global::System.ArgumentNullException(nameof(actualJson));
            this.Passed = passed;
            this.Rationale = rationale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsDataAssertionResult" /> class.
        /// </summary>
        public TtsDataAssertionResult()
        {
        }

    }
}