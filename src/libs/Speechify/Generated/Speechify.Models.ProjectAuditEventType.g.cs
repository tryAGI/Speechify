
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What changed. `access_widened_to_workspace` is the revoke that<br/>
    /// removed the subject's LAST grant anywhere: a member with no grants<br/>
    /// reaches the whole workspace, so that revoke widened them rather<br/>
    /// than narrowing them.
    /// </summary>
    public enum ProjectAuditEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessGranted,
        /// <summary>
        /// 
        /// </summary>
        AccessRevoked,
        /// <summary>
        /// 
        /// </summary>
        AccessWidenedToWorkspace,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Unarchived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAuditEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAuditEventType value)
        {
            return value switch
            {
                ProjectAuditEventType.AccessGranted => "access_granted",
                ProjectAuditEventType.AccessRevoked => "access_revoked",
                ProjectAuditEventType.AccessWidenedToWorkspace => "access_widened_to_workspace",
                ProjectAuditEventType.Archived => "archived",
                ProjectAuditEventType.Unarchived => "unarchived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAuditEventType? ToEnum(string value)
        {
            return value switch
            {
                "access_granted" => ProjectAuditEventType.AccessGranted,
                "access_revoked" => ProjectAuditEventType.AccessRevoked,
                "access_widened_to_workspace" => ProjectAuditEventType.AccessWidenedToWorkspace,
                "archived" => ProjectAuditEventType.Archived,
                "unarchived" => ProjectAuditEventType.Unarchived,
                _ => null,
            };
        }
    }
}