
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The impact class a tool declares: what kind of consequence a call has,<br/>
    /// independent of which transport executes it. It decides the approval an<br/>
    /// autonomous run applies by default.<br/>
    /// - `read`: a lookup with no side effect.<br/>
    /// - `communicate_internal`: writes inside your own estate (a CRM note, a<br/>
    ///   post to your own Slack, a row in a store).<br/>
    /// - `communicate_external`: reaches a third party (an email, an SMS).<br/>
    /// - `data_export`: moves a data set out.<br/>
    /// - `financial`: moves money or commits you to a charge.<br/>
    /// - `irreversible_other`: any other action that cannot be undone.
    /// </summary>
    public enum ToolActionClass
    {
        /// <summary>
        /// reaches a third party (an email, an SMS).
        /// </summary>
        CommunicateExternal,
        /// <summary>
        /// writes inside your own estate (a CRM note, a
        /// </summary>
        CommunicateInternal,
        /// <summary>
        /// moves a data set out.
        /// </summary>
        DataExport,
        /// <summary>
        /// moves money or commits you to a charge.
        /// </summary>
        Financial,
        /// <summary>
        /// any other action that cannot be undone.
        /// </summary>
        IrreversibleOther,
        /// <summary>
        /// a lookup with no side effect.
        /// </summary>
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolActionClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolActionClass value)
        {
            return value switch
            {
                ToolActionClass.CommunicateExternal => "communicate_external",
                ToolActionClass.CommunicateInternal => "communicate_internal",
                ToolActionClass.DataExport => "data_export",
                ToolActionClass.Financial => "financial",
                ToolActionClass.IrreversibleOther => "irreversible_other",
                ToolActionClass.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolActionClass? ToEnum(string value)
        {
            return value switch
            {
                "communicate_external" => ToolActionClass.CommunicateExternal,
                "communicate_internal" => ToolActionClass.CommunicateInternal,
                "data_export" => ToolActionClass.DataExport,
                "financial" => ToolActionClass.Financial,
                "irreversible_other" => ToolActionClass.IrreversibleOther,
                "read" => ToolActionClass.Read,
                _ => null,
            };
        }
    }
}