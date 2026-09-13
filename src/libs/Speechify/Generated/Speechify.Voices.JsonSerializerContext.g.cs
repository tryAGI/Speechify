
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesGetParametersType), TypeInfoPropertyName = "V1VoicesGetParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesGetParametersGender), TypeInfoPropertyName = "V1VoicesGetParametersGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceGender), TypeInfoPropertyName = "GetVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoicesModelName), TypeInfoPropertyName = "GetVoicesModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoicesModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.GetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceType), TypeInfoPropertyName = "GetVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.GetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.GetVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender), TypeInfoPropertyName = "V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesGetParametersType?), TypeInfoPropertyName = "NullableV1VoicesGetParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesGetParametersGender?), TypeInfoPropertyName = "NullableV1VoicesGetParametersGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceGender?), TypeInfoPropertyName = "NullableGetVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoicesModelName?), TypeInfoPropertyName = "NullableGetVoicesModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceType?), TypeInfoPropertyName = "NullableGetVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender?), TypeInfoPropertyName = "NullableV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoice>))]
    internal sealed partial class VoicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Speechify.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Speechify.ErrorCode)

                    || typeToConvert == typeof(global::Speechify.ErrorCode?)

                    || typeToConvert == typeof(global::Speechify.V1VoicesGetParametersType)

                    || typeToConvert == typeof(global::Speechify.V1VoicesGetParametersType?)

                    || typeToConvert == typeof(global::Speechify.V1VoicesGetParametersGender)

                    || typeToConvert == typeof(global::Speechify.V1VoicesGetParametersGender?)

                    || typeToConvert == typeof(global::Speechify.GetVoiceGender)

                    || typeToConvert == typeof(global::Speechify.GetVoiceGender?)

                    || typeToConvert == typeof(global::Speechify.GetVoicesModelName)

                    || typeToConvert == typeof(global::Speechify.GetVoicesModelName?)

                    || typeToConvert == typeof(global::Speechify.GetVoiceType)

                    || typeToConvert == typeof(global::Speechify.GetVoiceType?)

                    || typeToConvert == typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender)

                    || typeToConvert == typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Speechify.ErrorCode))
                {
                    return new global::Speechify.JsonConverters.ErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ErrorCode?))
                {
                    return new global::Speechify.JsonConverters.ErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesGetParametersType))
                {
                    return new global::Speechify.JsonConverters.V1VoicesGetParametersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesGetParametersType?))
                {
                    return new global::Speechify.JsonConverters.V1VoicesGetParametersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesGetParametersGender))
                {
                    return new global::Speechify.JsonConverters.V1VoicesGetParametersGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesGetParametersGender?))
                {
                    return new global::Speechify.JsonConverters.V1VoicesGetParametersGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoiceGender))
                {
                    return new global::Speechify.JsonConverters.GetVoiceGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoiceGender?))
                {
                    return new global::Speechify.JsonConverters.GetVoiceGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoicesModelName))
                {
                    return new global::Speechify.JsonConverters.GetVoicesModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoicesModelName?))
                {
                    return new global::Speechify.JsonConverters.GetVoicesModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoiceType))
                {
                    return new global::Speechify.JsonConverters.GetVoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoiceType?))
                {
                    return new global::Speechify.JsonConverters.GetVoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender))
                {
                    return new global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender?))
                {
                    return new global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new VoicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}