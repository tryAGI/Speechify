
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The scope, or a space-delimited list of scopes the token is issued for
    /// </summary>
    public enum TtsAccessTokenScope
    {
        /// <summary>
        /// 
        /// </summary>
        Audio_all,
        /// <summary>
        /// 
        /// </summary>
        Audio_speech,
        /// <summary>
        /// 
        /// </summary>
        Audio_stream,
        /// <summary>
        /// 
        /// </summary>
        Voices_all,
        /// <summary>
        /// 
        /// </summary>
        Voices_create,
        /// <summary>
        /// 
        /// </summary>
        Voices_delete,
        /// <summary>
        /// 
        /// </summary>
        Voices_read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsAccessTokenScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAccessTokenScope value)
        {
            return value switch
            {
                TtsAccessTokenScope.Audio_all => "audio:all",
                TtsAccessTokenScope.Audio_speech => "audio:speech",
                TtsAccessTokenScope.Audio_stream => "audio:stream",
                TtsAccessTokenScope.Voices_all => "voices:all",
                TtsAccessTokenScope.Voices_create => "voices:create",
                TtsAccessTokenScope.Voices_delete => "voices:delete",
                TtsAccessTokenScope.Voices_read => "voices:read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAccessTokenScope? ToEnum(string value)
        {
            return value switch
            {
                "audio:all" => TtsAccessTokenScope.Audio_all,
                "audio:speech" => TtsAccessTokenScope.Audio_speech,
                "audio:stream" => TtsAccessTokenScope.Audio_stream,
                "voices:all" => TtsAccessTokenScope.Voices_all,
                "voices:create" => TtsAccessTokenScope.Voices_create,
                "voices:delete" => TtsAccessTokenScope.Voices_delete,
                "voices:read" => TtsAccessTokenScope.Voices_read,
                _ => null,
            };
        }
    }
}