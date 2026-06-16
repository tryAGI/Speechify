
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Asserts on one entry in the LLM-extracted data-collection map<br/>
    /// produced by the unified evaluator. `key` matches a<br/>
    /// data-collection field configured on the agent; the assertion<br/>
    /// runs against the value the judge wrote under that key. Same<br/>
    /// exact / regex / llm modes as `ParameterCheck` so the tool-call<br/>
    /// and data-collection assertion surfaces are uniform.
    /// </summary>
    public sealed partial class DataAssertion
    {
        /// <summary>
        /// Name of the data-collection field on the agent's evaluation config. The assertion fails when this key is missing from the extracted data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// How the assertion validates the extracted value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.DataAssertionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.DataAssertionMode Mode { get; set; }

        /// <summary>
        /// Expected value string for `exact` and `regex` modes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        public string? Expected { get; set; }

        /// <summary>
        /// Natural-language criteria for `llm` mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public string? Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAssertion" /> class.
        /// </summary>
        /// <param name="key">
        /// Name of the data-collection field on the agent's evaluation config. The assertion fails when this key is missing from the extracted data.
        /// </param>
        /// <param name="mode">
        /// How the assertion validates the extracted value.
        /// </param>
        /// <param name="expected">
        /// Expected value string for `exact` and `regex` modes.
        /// </param>
        /// <param name="criteria">
        /// Natural-language criteria for `llm` mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataAssertion(
            string key,
            global::Speechify.DataAssertionMode mode,
            string? expected,
            string? criteria)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Mode = mode;
            this.Expected = expected;
            this.Criteria = criteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAssertion" /> class.
        /// </summary>
        public DataAssertion()
        {
        }

    }
}