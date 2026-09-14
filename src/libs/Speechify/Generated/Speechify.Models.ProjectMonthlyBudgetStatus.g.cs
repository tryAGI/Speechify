
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Where `monthly_spend` stands against `monthly_budget`, present<br/>
    /// only when both are: `warning` from 80% of the budget, `reached`<br/>
    /// once the spend has reached it and new billable work attributed to<br/>
    /// the project is refused with `402 project_spend_limit_exceeded`,<br/>
    /// `ok` below 80%. These are the thresholds the<br/>
    /// `project.spend_budget.warning` and `project.spend_budget.reached`<br/>
    /// webhook events fire at, so polling this field and subscribing to<br/>
    /// the events give the same answer.
    /// </summary>
    public enum ProjectMonthlyBudgetStatus
    {
        /// <summary>
        ///
        /// </summary>
        Ok,
        /// <summary>
        /// `warning` from 80% of the budget, `reached`
        /// </summary>
        Reached,
        /// <summary>
        /// `warning` from 80% of the budget, `reached`
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectMonthlyBudgetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMonthlyBudgetStatus value)
        {
            return value switch
            {
                ProjectMonthlyBudgetStatus.Ok => "ok",
                ProjectMonthlyBudgetStatus.Reached => "reached",
                ProjectMonthlyBudgetStatus.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMonthlyBudgetStatus? ToEnum(string value)
        {
            return value switch
            {
                "ok" => ProjectMonthlyBudgetStatus.Ok,
                "reached" => ProjectMonthlyBudgetStatus.Reached,
                "warning" => ProjectMonthlyBudgetStatus.Warning,
                _ => null,
            };
        }
    }
}