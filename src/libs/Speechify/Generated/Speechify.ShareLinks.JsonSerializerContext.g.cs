
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigStyle), TypeInfoPropertyName = "WidgetConfigStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTheme), TypeInfoPropertyName = "WidgetConfigTheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigAvatarType), TypeInfoPropertyName = "WidgetConfigAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLinkStatus), TypeInfoPropertyName = "ShareLinkStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListShareLinksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ShareLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkResponseStatus), TypeInfoPropertyName = "CreateShareLinkResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RevealShareLinkTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLinkPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLinkSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigStyle?), TypeInfoPropertyName = "NullableWidgetConfigStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTheme?), TypeInfoPropertyName = "NullableWidgetConfigTheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigAvatarType?), TypeInfoPropertyName = "NullableWidgetConfigAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLinkStatus?), TypeInfoPropertyName = "NullableShareLinkStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkResponseStatus?), TypeInfoPropertyName = "NullableCreateShareLinkResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ShareLink>))]
    internal sealed partial class ShareLinksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ShareLinksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ShareLinksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ShareLinksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.WidgetConfigStyle)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigStyle?)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigTheme)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigTheme?)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigAvatarType)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigAvatarType?)

                    || typeToConvert == typeof(global::Speechify.ShareLinkStatus)

                    || typeToConvert == typeof(global::Speechify.ShareLinkStatus?)

                    || typeToConvert == typeof(global::Speechify.CreateShareLinkResponseStatus)

                    || typeToConvert == typeof(global::Speechify.CreateShareLinkResponseStatus?);
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

                if (typeToConvert == typeof(global::Speechify.WidgetConfigStyle))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigStyle?))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigTheme))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigThemeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigTheme?))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigThemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigAvatarType))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigAvatarType?))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ShareLinkStatus))
                {
                    return new global::Speechify.JsonConverters.ShareLinkStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ShareLinkStatus?))
                {
                    return new global::Speechify.JsonConverters.ShareLinkStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CreateShareLinkResponseStatus))
                {
                    return new global::Speechify.JsonConverters.CreateShareLinkResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CreateShareLinkResponseStatus?))
                {
                    return new global::Speechify.JsonConverters.CreateShareLinkResponseStatusNullableJsonConverter();
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
                    0 => new ShareLinksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}