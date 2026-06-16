
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Gender marker for the personal voice<br/>
    /// male GenderMale<br/>
    /// female GenderFemale<br/>
    /// notSpecified GenderNotSpecified
    /// </summary>
    public enum V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender
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
    public static class V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender value)
        {
            return value switch
            {
                V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.Female => "female",
                V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.Male => "male",
                V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.NotSpecified => "notSpecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.Female,
                "male" => V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.Male,
                "notSpecified" => V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender.NotSpecified,
                _ => null,
            };
        }
    }
}