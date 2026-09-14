
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialKind), TypeInfoPropertyName = "CredentialKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OAuth2TokenEndpointAuthMethod), TypeInfoPropertyName = "OAuth2TokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewOauth2ClientCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewOauth2Jwt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewSharedSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewCustomHeaders))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialReferenceResourceType), TypeInfoPropertyName = "CredentialReferenceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialUsedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.CredentialReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Credential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Credential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OAuth2ClientCredentialsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OAuth2JWTConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BasicAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BearerAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CustomHeadersConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SharedSecretConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialInUseErrorDetailDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialInUseErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialInUseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialKind?), TypeInfoPropertyName = "NullableCredentialKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OAuth2TokenEndpointAuthMethod?), TypeInfoPropertyName = "NullableOAuth2TokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialReferenceResourceType?), TypeInfoPropertyName = "NullableCredentialReferenceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.CredentialReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Credential>))]
    internal sealed partial class CredentialsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CredentialsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CredentialsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CredentialsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.CredentialKind)

                    || typeToConvert == typeof(global::Speechify.CredentialKind?)

                    || typeToConvert == typeof(global::Speechify.OAuth2TokenEndpointAuthMethod)

                    || typeToConvert == typeof(global::Speechify.OAuth2TokenEndpointAuthMethod?)

                    || typeToConvert == typeof(global::Speechify.CredentialReferenceResourceType)

                    || typeToConvert == typeof(global::Speechify.CredentialReferenceResourceType?);
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

                if (typeToConvert == typeof(global::Speechify.CredentialKind))
                {
                    return new global::Speechify.JsonConverters.CredentialKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CredentialKind?))
                {
                    return new global::Speechify.JsonConverters.CredentialKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.OAuth2TokenEndpointAuthMethod))
                {
                    return new global::Speechify.JsonConverters.OAuth2TokenEndpointAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.OAuth2TokenEndpointAuthMethod?))
                {
                    return new global::Speechify.JsonConverters.OAuth2TokenEndpointAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CredentialReferenceResourceType))
                {
                    return new global::Speechify.JsonConverters.CredentialReferenceResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CredentialReferenceResourceType?))
                {
                    return new global::Speechify.JsonConverters.CredentialReferenceResourceTypeNullableJsonConverter();
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
                    0 => new CredentialsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}