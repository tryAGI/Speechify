
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The kind of resource referencing the credential.
    /// </summary>
    public enum CredentialReferenceResourceType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Channel,
        /// <summary>
        ///
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialReferenceResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialReferenceResourceType value)
        {
            return value switch
            {
                CredentialReferenceResourceType.Agent => "agent",
                CredentialReferenceResourceType.Channel => "channel",
                CredentialReferenceResourceType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialReferenceResourceType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => CredentialReferenceResourceType.Agent,
                "channel" => CredentialReferenceResourceType.Channel,
                "tool" => CredentialReferenceResourceType.Tool,
                _ => null,
            };
        }
    }
}