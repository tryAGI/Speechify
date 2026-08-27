
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A number's carrier spam-reputation status, refreshed on a schedule<br/>
    /// from the analytics networks carriers use. Read-only; surfaced<br/>
    /// alongside relay health so a number going bad is visible before it<br/>
    /// drags down deliverability.
    /// </summary>
    public sealed partial class PhoneNumberReputation
    {
        /// <summary>
        /// Overall spam-risk classification. `unknown` means the number has<br/>
        /// been checked but the carrier networks have no score yet (a fresh<br/>
        /// number has no calling history); `low` / `medium` / `high` are the<br/>
        /// reported risk levels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("risk")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PhoneNumberReputationRiskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PhoneNumberReputationRisk Risk { get; set; }

        /// <summary>
        /// When the reputation was last read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checked_at")]
        public global::System.DateTime? CheckedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberReputation" /> class.
        /// </summary>
        /// <param name="risk">
        /// Overall spam-risk classification. `unknown` means the number has<br/>
        /// been checked but the carrier networks have no score yet (a fresh<br/>
        /// number has no calling history); `low` / `medium` / `high` are the<br/>
        /// reported risk levels.
        /// </param>
        /// <param name="checkedAt">
        /// When the reputation was last read.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberReputation(
            global::Speechify.PhoneNumberReputationRisk risk,
            global::System.DateTime? checkedAt)
        {
            this.Risk = risk;
            this.CheckedAt = checkedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberReputation" /> class.
        /// </summary>
        public PhoneNumberReputation()
        {
        }

    }
}