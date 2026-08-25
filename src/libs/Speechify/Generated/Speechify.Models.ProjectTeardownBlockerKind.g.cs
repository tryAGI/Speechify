
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectTeardownBlockerKind
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Credential,
        /// <summary>
        /// 
        /// </summary>
        Invite,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        ProjectMember,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        WebhookEndpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectTeardownBlockerKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectTeardownBlockerKind value)
        {
            return value switch
            {
                ProjectTeardownBlockerKind.ApiKey => "api_key",
                ProjectTeardownBlockerKind.Credential => "credential",
                ProjectTeardownBlockerKind.Invite => "invite",
                ProjectTeardownBlockerKind.PhoneNumber => "phone_number",
                ProjectTeardownBlockerKind.ProjectMember => "project_member",
                ProjectTeardownBlockerKind.ServiceAccount => "service_account",
                ProjectTeardownBlockerKind.WebhookEndpoint => "webhook_endpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectTeardownBlockerKind? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => ProjectTeardownBlockerKind.ApiKey,
                "credential" => ProjectTeardownBlockerKind.Credential,
                "invite" => ProjectTeardownBlockerKind.Invite,
                "phone_number" => ProjectTeardownBlockerKind.PhoneNumber,
                "project_member" => ProjectTeardownBlockerKind.ProjectMember,
                "service_account" => ProjectTeardownBlockerKind.ServiceAccount,
                "webhook_endpoint" => ProjectTeardownBlockerKind.WebhookEndpoint,
                _ => null,
            };
        }
    }
}