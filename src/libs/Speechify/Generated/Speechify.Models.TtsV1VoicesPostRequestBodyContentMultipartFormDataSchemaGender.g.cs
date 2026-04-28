
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Gender marker for the personal voice<br/>
    /// male GenderMale<br/>
    /// female GenderFemale<br/>
    /// notSpecified GenderNotSpecified
    /// </summary>
    public enum TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
        /// <summary>
        /// 
        /// </summary>
        NotSpecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender value)
        {
            return value switch
            {
                TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.Female => "female",
                TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.Male => "male",
                TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.NotSpecified => "notSpecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.Female,
                "male" => TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.Male,
                "notSpecified" => TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.NotSpecified,
                _ => null,
            };
        }
    }
}