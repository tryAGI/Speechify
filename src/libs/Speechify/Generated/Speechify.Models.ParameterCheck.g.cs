
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Validates one argument of an expected tool call. `path` is a<br/>
    /// dotted JSON path (e.g. `customer.email`); use zero-indexed<br/>
    /// notation for arrays (`items.0.sku`). An empty path checks the<br/>
    /// whole args object.
    /// </summary>
    public sealed partial class ParameterCheck
    {
        /// <summary>
        /// Dotted JSON path to the argument being checked. Empty means the whole args object.
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
        /// Expected value string for `exact` and `regex` modes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        public string? Expected { get; set; }

        /// <summary>
        /// Natural-language criteria for `llm` mode (e.g. "is a valid email address").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public string? Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterCheck" /> class.
        /// </summary>
        /// <param name="path">
        /// Dotted JSON path to the argument being checked. Empty means the whole args object.
        /// </param>
        /// <param name="mode">
        /// How a `ParameterCheck` validates a tool argument.<br/>
        /// - `exact` - JSON equality.<br/>
        /// - `regex` - the argument stringified is matched against the pattern.<br/>
        /// - `llm` - an LLM judge decides whether the value semantically satisfies<br/>
        ///   the criteria (e.g. "is a plausible email address").
        /// </param>
        /// <param name="expected">
        /// Expected value string for `exact` and `regex` modes.
        /// </param>
        /// <param name="criteria">
        /// Natural-language criteria for `llm` mode (e.g. "is a valid email address").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParameterCheck(
            string path,
            global::Speechify.ParameterCheckMode mode,
            string? expected,
            string? criteria)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Mode = mode;
            this.Expected = expected;
            this.Criteria = criteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterCheck" /> class.
        /// </summary>
        public ParameterCheck()
        {
        }

    }
}