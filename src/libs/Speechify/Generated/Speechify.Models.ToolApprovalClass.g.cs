
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What governs a tool on the autonomous path (durable runs), where no<br/>
    /// human is on the line: `auto` runs it, `require_approval` parks the run<br/>
    /// in `requires_action` until a human decides, `disabled` refuses it. The<br/>
    /// realtime voice and text runtimes have no suspend primitive and ignore<br/>
    /// it; use the per-agent tool's `enabled` flag to switch a tool off there.
    /// </summary>
    public enum ToolApprovalClass
    {
        /// <summary>
        /// `auto` runs it, `require_approval` parks the run
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        /// `auto` runs it, `require_approval` parks the run
        /// </summary>
        RequireApproval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolApprovalClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolApprovalClass value)
        {
            return value switch
            {
                ToolApprovalClass.Auto => "auto",
                ToolApprovalClass.Disabled => "disabled",
                ToolApprovalClass.RequireApproval => "require_approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolApprovalClass? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolApprovalClass.Auto,
                "disabled" => ToolApprovalClass.Disabled,
                "require_approval" => ToolApprovalClass.RequireApproval,
                _ => null,
            };
        }
    }
}