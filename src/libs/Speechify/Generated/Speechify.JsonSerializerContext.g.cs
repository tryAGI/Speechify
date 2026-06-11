
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Speechify.JsonConverters.TtsGetSpeechRequestAudioFormatJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechRequestAudioFormatNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechRequestModelNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechResponseAudioFormatJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechResponseAudioFormatNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsErrorCodeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsErrorCodeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1AudioStreamPostParametersAcceptJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1AudioStreamPostParametersAcceptNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetStreamRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetStreamRequestModelNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoicesModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoicesModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreatedVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreatedVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateVoiceModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateVoiceModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreatedVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreatedVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechRequestAudioFormat), TypeInfoPropertyName = "TtsGetSpeechRequestAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechRequestModel), TypeInfoPropertyName = "TtsGetSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechResponseAudioFormat), TypeInfoPropertyName = "TtsGetSpeechResponseAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsNestedChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSpeechMarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsNestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsErrorCode), TypeInfoPropertyName = "TtsErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsV1AudioStreamPostParametersAccept), TypeInfoPropertyName = "TtsV1AudioStreamPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamRequestModel), TypeInfoPropertyName = "TtsGetStreamRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoiceGender), TypeInfoPropertyName = "TtsGetVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoicesModelName), TypeInfoPropertyName = "TtsGetVoicesModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoicesModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsGetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoiceType), TypeInfoPropertyName = "TtsGetVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsGetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender), TypeInfoPropertyName = "TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreatedVoiceGender), TypeInfoPropertyName = "TtsCreatedVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateVoiceModelName), TypeInfoPropertyName = "TtsCreateVoiceModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsCreateVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreatedVoiceType), TypeInfoPropertyName = "TtsCreatedVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreatedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsCreateVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsGetVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsNestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsCreateVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsCreateVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}