
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Who names the person a fired run acts for. Defaults to `trigger`.<br/>
    /// `trigger` uses `run.user_identity`, so every fire on<br/>
    /// this trigger acts for the same person - or for nobody, when it is<br/>
    /// unset.<br/>
    /// `fire` takes the person from each delivery, as a<br/>
    /// `Speechify-User-Identity` header on the fire request. One trigger<br/>
    /// then serves every person your connector watches, instead of one<br/>
    /// trigger per person. `run.user_identity` must be empty when you<br/>
    /// choose it: a trigger that both pins a person and reads one per<br/>
    /// delivery would run silently as the pinned person whenever your<br/>
    /// connector forgot the header, so the combination is refused with a<br/>
    /// `400` when the trigger is saved.<br/>
    /// A fire that names a person the trigger does not accept, and a fire<br/>
    /// that names nobody on a `fire`-sourced trigger, are both refused<br/>
    /// with a `400` rather than quietly running for the wrong person.
    /// </summary>
    public enum TriggerWebhookConfigUserIdentitySource
    {
        /// <summary>
        ///
        /// </summary>
        Fire,
        /// <summary>
        /// a trigger that both pins a person and reads one per
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerWebhookConfigUserIdentitySourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerWebhookConfigUserIdentitySource value)
        {
            return value switch
            {
                TriggerWebhookConfigUserIdentitySource.Fire => "fire",
                TriggerWebhookConfigUserIdentitySource.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerWebhookConfigUserIdentitySource? ToEnum(string value)
        {
            return value switch
            {
                "fire" => TriggerWebhookConfigUserIdentitySource.Fire,
                "trigger" => TriggerWebhookConfigUserIdentitySource.Trigger,
                _ => null,
            };
        }
    }
}