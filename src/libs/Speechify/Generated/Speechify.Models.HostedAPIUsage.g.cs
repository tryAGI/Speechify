
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedAPIUsage
    {
        /// <summary>
        /// The UTC day the counters cover, `YYYY-MM-DD`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// Reads served from storage today across the API's routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Reads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_read_cap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DailyReadCap { get; set; }

        /// <summary>
        /// Runs started today through the API's run routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Runs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_run_cap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DailyRunCap { get; set; }

        /// <summary>
        /// Documents landed today through the API's write routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Writes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_write_cap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DailyWriteCap { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.HostedApiUsageRoutesItems> Routes { get; set; }

        /// <summary>
        /// False where nothing counts (no Redis); the numbers are then zero, not quiet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counters_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CountersAvailable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIUsage" /> class.
        /// </summary>
        /// <param name="day">
        /// The UTC day the counters cover, `YYYY-MM-DD`.
        /// </param>
        /// <param name="reads">
        /// Reads served from storage today across the API's routes.
        /// </param>
        /// <param name="dailyReadCap"></param>
        /// <param name="runs">
        /// Runs started today through the API's run routes.
        /// </param>
        /// <param name="dailyRunCap"></param>
        /// <param name="writes">
        /// Documents landed today through the API's write routes.
        /// </param>
        /// <param name="dailyWriteCap"></param>
        /// <param name="routes"></param>
        /// <param name="countersAvailable">
        /// False where nothing counts (no Redis); the numbers are then zero, not quiet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIUsage(
            string day,
            long reads,
            int dailyReadCap,
            long runs,
            int dailyRunCap,
            long writes,
            int dailyWriteCap,
            global::System.Collections.Generic.IList<global::Speechify.HostedApiUsageRoutesItems> routes,
            bool countersAvailable)
        {
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.Reads = reads;
            this.DailyReadCap = dailyReadCap;
            this.Runs = runs;
            this.DailyRunCap = dailyRunCap;
            this.Writes = writes;
            this.DailyWriteCap = dailyWriteCap;
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
            this.CountersAvailable = countersAvailable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIUsage" /> class.
        /// </summary>
        public HostedAPIUsage()
        {
        }

    }
}