
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestAudioFormat), TypeInfoPropertyName = "GetSpeechRequestAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestModel), TypeInfoPropertyName = "GetSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioOutputFormat), TypeInfoPropertyName = "AudioOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechResponseAudioFormat), TypeInfoPropertyName = "GetSpeechResponseAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.NestedChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechMarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.NestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamPostParametersAccept), TypeInfoPropertyName = "V1AudioStreamPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamRequestModel), TypeInfoPropertyName = "GetStreamRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioStreamOutputFormat), TypeInfoPropertyName = "AudioStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept), TypeInfoPropertyName = "V1AudioStreamWithTimestampsPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEvent), TypeInfoPropertyName = "SpeechStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant1Type), TypeInfoPropertyName = "SpeechStreamEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant2Type), TypeInfoPropertyName = "SpeechStreamEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant3Type), TypeInfoPropertyName = "SpeechStreamEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventDiscriminatorType), TypeInfoPropertyName = "SpeechStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestAudioFormat?), TypeInfoPropertyName = "NullableGetSpeechRequestAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestModel?), TypeInfoPropertyName = "NullableGetSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioOutputFormat?), TypeInfoPropertyName = "NullableAudioOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechResponseAudioFormat?), TypeInfoPropertyName = "NullableGetSpeechResponseAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamPostParametersAccept?), TypeInfoPropertyName = "NullableV1AudioStreamPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamRequestModel?), TypeInfoPropertyName = "NullableGetStreamRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioStreamOutputFormat?), TypeInfoPropertyName = "NullableAudioStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept?), TypeInfoPropertyName = "NullableV1AudioStreamWithTimestampsPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEvent?), TypeInfoPropertyName = "NullableSpeechStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant1Type?), TypeInfoPropertyName = "NullableSpeechStreamEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant2Type?), TypeInfoPropertyName = "NullableSpeechStreamEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant3Type?), TypeInfoPropertyName = "NullableSpeechStreamEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableSpeechStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.NestedChunk>))]
    internal sealed partial class AudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Speechify.JsonConverters.SpeechStreamEventJsonConverter());
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
                    typeToConvert == typeof(global::Speechify.GetSpeechRequestAudioFormat)

                    || typeToConvert == typeof(global::Speechify.GetSpeechRequestAudioFormat?)

                    || typeToConvert == typeof(global::Speechify.GetSpeechRequestModel)

                    || typeToConvert == typeof(global::Speechify.GetSpeechRequestModel?)

                    || typeToConvert == typeof(global::Speechify.AudioOutputFormat)

                    || typeToConvert == typeof(global::Speechify.AudioOutputFormat?)

                    || typeToConvert == typeof(global::Speechify.GetSpeechResponseAudioFormat)

                    || typeToConvert == typeof(global::Speechify.GetSpeechResponseAudioFormat?)

                    || typeToConvert == typeof(global::Speechify.ErrorCode)

                    || typeToConvert == typeof(global::Speechify.ErrorCode?)

                    || typeToConvert == typeof(global::Speechify.V1AudioStreamPostParametersAccept)

                    || typeToConvert == typeof(global::Speechify.V1AudioStreamPostParametersAccept?)

                    || typeToConvert == typeof(global::Speechify.GetStreamRequestModel)

                    || typeToConvert == typeof(global::Speechify.GetStreamRequestModel?)

                    || typeToConvert == typeof(global::Speechify.AudioStreamOutputFormat)

                    || typeToConvert == typeof(global::Speechify.AudioStreamOutputFormat?)

                    || typeToConvert == typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept)

                    || typeToConvert == typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept?)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant1Type)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant1Type?)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant2Type)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant2Type?)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant3Type)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant3Type?)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Speechify.GetSpeechRequestAudioFormat))
                {
                    return new global::Speechify.JsonConverters.GetSpeechRequestAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechRequestAudioFormat?))
                {
                    return new global::Speechify.JsonConverters.GetSpeechRequestAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechRequestModel))
                {
                    return new global::Speechify.JsonConverters.GetSpeechRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechRequestModel?))
                {
                    return new global::Speechify.JsonConverters.GetSpeechRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AudioOutputFormat))
                {
                    return new global::Speechify.JsonConverters.AudioOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AudioOutputFormat?))
                {
                    return new global::Speechify.JsonConverters.AudioOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechResponseAudioFormat))
                {
                    return new global::Speechify.JsonConverters.GetSpeechResponseAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechResponseAudioFormat?))
                {
                    return new global::Speechify.JsonConverters.GetSpeechResponseAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ErrorCode))
                {
                    return new global::Speechify.JsonConverters.ErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ErrorCode?))
                {
                    return new global::Speechify.JsonConverters.ErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AudioStreamPostParametersAccept))
                {
                    return new global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AudioStreamPostParametersAccept?))
                {
                    return new global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetStreamRequestModel))
                {
                    return new global::Speechify.JsonConverters.GetStreamRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetStreamRequestModel?))
                {
                    return new global::Speechify.JsonConverters.GetStreamRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AudioStreamOutputFormat))
                {
                    return new global::Speechify.JsonConverters.AudioStreamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AudioStreamOutputFormat?))
                {
                    return new global::Speechify.JsonConverters.AudioStreamOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept))
                {
                    return new global::Speechify.JsonConverters.V1AudioStreamWithTimestampsPostParametersAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept?))
                {
                    return new global::Speechify.JsonConverters.V1AudioStreamWithTimestampsPostParametersAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant1Type))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant1Type?))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant2Type))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant2Type?))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant3Type))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant3Type?))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventDiscriminatorType))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventDiscriminatorType?))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventDiscriminatorTypeNullableJsonConverter();
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
                    0 => new AudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}