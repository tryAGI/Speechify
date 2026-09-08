
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Who runs a call to this built-in. `worker` runs it inside the live<br/>
    /// session, so it is only meaningful on a call. `control_plane` runs it<br/>
    /// in the platform itself, against a vendor whose key you never hold,<br/>
    /// and is what an autonomous run or a text turn can use.
    /// </summary>
    public enum SystemBuiltinInfoExecution
    {
        /// <summary>
        ///
        /// </summary>
        ControlPlane,
        /// <summary>
        ///
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemBuiltinInfoExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemBuiltinInfoExecution value)
        {
            return value switch
            {
                SystemBuiltinInfoExecution.ControlPlane => "control_plane",
                SystemBuiltinInfoExecution.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemBuiltinInfoExecution? ToEnum(string value)
        {
            return value switch
            {
                "control_plane" => SystemBuiltinInfoExecution.ControlPlane,
                "worker" => SystemBuiltinInfoExecution.Worker,
                _ => null,
            };
        }
    }
}