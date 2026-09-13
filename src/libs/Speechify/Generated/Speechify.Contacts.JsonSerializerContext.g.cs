
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ContactIdentifierKind), TypeInfoPropertyName = "ContactIdentifierKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ContactIdentifierAssertedBy), TypeInfoPropertyName = "ContactIdentifierAssertedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ContactIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Contact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ContactIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListContactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Contact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateContactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteContactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AttachContactIdentifierRequestKind), TypeInfoPropertyName = "AttachContactIdentifierRequestKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AttachContactIdentifierRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MergeContactsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MergeContactsResponseMerged))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MergeContactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ContactResolver))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutContactResolverRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ContactIdentifierKind?), TypeInfoPropertyName = "NullableContactIdentifierKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ContactIdentifierAssertedBy?), TypeInfoPropertyName = "NullableContactIdentifierAssertedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AttachContactIdentifierRequestKind?), TypeInfoPropertyName = "NullableAttachContactIdentifierRequestKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ContactIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Contact>))]
    internal sealed partial class ContactsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContactsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ContactsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ContactsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.ContactIdentifierKind)

                    || typeToConvert == typeof(global::Speechify.ContactIdentifierKind?)

                    || typeToConvert == typeof(global::Speechify.ContactIdentifierAssertedBy)

                    || typeToConvert == typeof(global::Speechify.ContactIdentifierAssertedBy?)

                    || typeToConvert == typeof(global::Speechify.AttachContactIdentifierRequestKind)

                    || typeToConvert == typeof(global::Speechify.AttachContactIdentifierRequestKind?);
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

                if (typeToConvert == typeof(global::Speechify.ContactIdentifierKind))
                {
                    return new global::Speechify.JsonConverters.ContactIdentifierKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ContactIdentifierKind?))
                {
                    return new global::Speechify.JsonConverters.ContactIdentifierKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ContactIdentifierAssertedBy))
                {
                    return new global::Speechify.JsonConverters.ContactIdentifierAssertedByJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ContactIdentifierAssertedBy?))
                {
                    return new global::Speechify.JsonConverters.ContactIdentifierAssertedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AttachContactIdentifierRequestKind))
                {
                    return new global::Speechify.JsonConverters.AttachContactIdentifierRequestKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AttachContactIdentifierRequestKind?))
                {
                    return new global::Speechify.JsonConverters.AttachContactIdentifierRequestKindNullableJsonConverter();
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
                    0 => new ContactsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}