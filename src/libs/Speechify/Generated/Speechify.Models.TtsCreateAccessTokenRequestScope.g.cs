
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The scope, or a space-delimited list of scopes the token is requested for<br/>
    /// in: body
    /// </summary>
    public enum TtsCreateAccessTokenRequestScope
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
    public static class TtsCreateAccessTokenRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsCreateAccessTokenRequestScope value)
        {
            return value switch
            {
                TtsCreateAccessTokenRequestScope.Audio_all => "audio:all",
                TtsCreateAccessTokenRequestScope.Audio_speech => "audio:speech",
                TtsCreateAccessTokenRequestScope.Audio_stream => "audio:stream",
                TtsCreateAccessTokenRequestScope.Voices_all => "voices:all",
                TtsCreateAccessTokenRequestScope.Voices_create => "voices:create",
                TtsCreateAccessTokenRequestScope.Voices_delete => "voices:delete",
                TtsCreateAccessTokenRequestScope.Voices_read => "voices:read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsCreateAccessTokenRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "audio:all" => TtsCreateAccessTokenRequestScope.Audio_all,
                "audio:speech" => TtsCreateAccessTokenRequestScope.Audio_speech,
                "audio:stream" => TtsCreateAccessTokenRequestScope.Audio_stream,
                "voices:all" => TtsCreateAccessTokenRequestScope.Voices_all,
                "voices:create" => TtsCreateAccessTokenRequestScope.Voices_create,
                "voices:delete" => TtsCreateAccessTokenRequestScope.Voices_delete,
                "voices:read" => TtsCreateAccessTokenRequestScope.Voices_read,
                _ => null,
            };
        }
    }
}