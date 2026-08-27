
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A workspace's declared intended use for its phone numbers, captured<br/>
    /// at first number purchase (or relay bind): the use case, target<br/>
    /// geographies, expected monthly volume, and whether the traffic is<br/>
    /// marketing or informational.
    /// </summary>
    public sealed partial class IntendedUse
    {
        /// <summary>
        /// What the numbers are used for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UseCase { get; set; }

        /// <summary>
        /// Regions or countries the traffic targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geographies")]
        public global::System.Collections.Generic.IList<string>? Geographies { get; set; }

        /// <summary>
        /// Rough expected calls + messages per month.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_monthly_volume")]
        public int? ExpectedMonthlyVolume { get; set; }

        /// <summary>
        /// The nature of the traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketing_or_informational")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.IntendedUseMarketingOrInformationalJsonConverter))]
        public global::Speechify.IntendedUseMarketingOrInformational? MarketingOrInformational { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntendedUse" /> class.
        /// </summary>
        /// <param name="useCase">
        /// What the numbers are used for.
        /// </param>
        /// <param name="geographies">
        /// Regions or countries the traffic targets.
        /// </param>
        /// <param name="expectedMonthlyVolume">
        /// Rough expected calls + messages per month.
        /// </param>
        /// <param name="marketingOrInformational">
        /// The nature of the traffic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntendedUse(
            string useCase,
            global::System.Collections.Generic.IList<string>? geographies,
            int? expectedMonthlyVolume,
            global::Speechify.IntendedUseMarketingOrInformational? marketingOrInformational)
        {
            this.UseCase = useCase ?? throw new global::System.ArgumentNullException(nameof(useCase));
            this.Geographies = geographies;
            this.ExpectedMonthlyVolume = expectedMonthlyVolume;
            this.MarketingOrInformational = marketingOrInformational;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntendedUse" /> class.
        /// </summary>
        public IntendedUse()
        {
        }

    }
}