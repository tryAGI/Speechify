
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One filterable / groupable axis in the analytics catalog. `type` is<br/>
    /// the value shape; `filterable` and `groupable` are the authoritative<br/>
    /// capabilities (a discrete number such as agent_version is groupable,<br/>
    /// a continuous one such as duration is not). `enum_values` is present<br/>
    /// only for closed enums whose value set is known server-side.<br/>
    /// `agent_id` is set only on per-agent evaluation / data-collection<br/>
    /// dimensions. Free-text fields are never returned as dimensions.
    /// </summary>
    public sealed partial class AnalyticsDimension
    {
        /// <summary>
        /// Stable dimension key used in filter + group-by requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Human-readable label for the picker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The dimension's value type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnalyticsDimensionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsDimensionType Type { get; set; }

        /// <summary>
        /// Where the dimension comes from, used to group the picker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnalyticsDimensionSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsDimensionSource Source { get; set; }

        /// <summary>
        /// Whether the dimension can be used as a filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Filterable { get; set; }

        /// <summary>
        /// Whether the dimension can be used as a group-by breakdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Groupable { get; set; }

        /// <summary>
        /// The closed value set, when known server-side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum_values")]
        public global::System.Collections.Generic.IList<string>? EnumValues { get; set; }

        /// <summary>
        /// The agent this per-agent dimension belongs to (prefixed id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsDimension" /> class.
        /// </summary>
        /// <param name="key">
        /// Stable dimension key used in filter + group-by requests.
        /// </param>
        /// <param name="label">
        /// Human-readable label for the picker.
        /// </param>
        /// <param name="type">
        /// The dimension's value type.
        /// </param>
        /// <param name="source">
        /// Where the dimension comes from, used to group the picker.
        /// </param>
        /// <param name="filterable">
        /// Whether the dimension can be used as a filter.
        /// </param>
        /// <param name="groupable">
        /// Whether the dimension can be used as a group-by breakdown.
        /// </param>
        /// <param name="enumValues">
        /// The closed value set, when known server-side.
        /// </param>
        /// <param name="agentId">
        /// The agent this per-agent dimension belongs to (prefixed id).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsDimension(
            string key,
            string label,
            global::Speechify.AnalyticsDimensionType type,
            global::Speechify.AnalyticsDimensionSource source,
            bool filterable,
            bool groupable,
            global::System.Collections.Generic.IList<string>? enumValues,
            string? agentId)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Type = type;
            this.Source = source;
            this.Filterable = filterable;
            this.Groupable = groupable;
            this.EnumValues = enumValues;
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsDimension" /> class.
        /// </summary>
        public AnalyticsDimension()
        {
        }

    }
}