
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateMetricOp), TypeInfoPropertyName = "StoreAggregateMetricOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.StoreAggregateMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.QueryStoreDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.StoreDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WriteStoreDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreWhereClauseOp), TypeInfoPropertyName = "StoreWhereClauseOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreWhereClause))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreOrderByDirection), TypeInfoPropertyName = "StoreOrderByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreOrderBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreDocumentQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.StoreWhereClause>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.StoreAggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreBatchWriteOp), TypeInfoPropertyName = "StoreBatchWriteOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreBatchWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.StoreBatchWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreBatchResultOp), TypeInfoPropertyName = "StoreBatchResultOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreBatchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.StoreBatchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateMetricOp?), TypeInfoPropertyName = "NullableStoreAggregateMetricOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreWhereClauseOp?), TypeInfoPropertyName = "NullableStoreWhereClauseOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreOrderByDirection?), TypeInfoPropertyName = "NullableStoreOrderByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreBatchWriteOp?), TypeInfoPropertyName = "NullableStoreBatchWriteOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreBatchResultOp?), TypeInfoPropertyName = "NullableStoreBatchResultOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.StoreAggregateMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.StoreDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.StoreWhereClause>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.StoreAggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.StoreBatchWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.StoreBatchResult>))]
    internal sealed partial class DocumentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DocumentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DocumentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DocumentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.StoreAggregateMetricOp)

                    || typeToConvert == typeof(global::Speechify.StoreAggregateMetricOp?)

                    || typeToConvert == typeof(global::Speechify.StoreWhereClauseOp)

                    || typeToConvert == typeof(global::Speechify.StoreWhereClauseOp?)

                    || typeToConvert == typeof(global::Speechify.StoreOrderByDirection)

                    || typeToConvert == typeof(global::Speechify.StoreOrderByDirection?)

                    || typeToConvert == typeof(global::Speechify.StoreBatchWriteOp)

                    || typeToConvert == typeof(global::Speechify.StoreBatchWriteOp?)

                    || typeToConvert == typeof(global::Speechify.StoreBatchResultOp)

                    || typeToConvert == typeof(global::Speechify.StoreBatchResultOp?);
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

                if (typeToConvert == typeof(global::Speechify.StoreAggregateMetricOp))
                {
                    return new global::Speechify.JsonConverters.StoreAggregateMetricOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreAggregateMetricOp?))
                {
                    return new global::Speechify.JsonConverters.StoreAggregateMetricOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreWhereClauseOp))
                {
                    return new global::Speechify.JsonConverters.StoreWhereClauseOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreWhereClauseOp?))
                {
                    return new global::Speechify.JsonConverters.StoreWhereClauseOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreOrderByDirection))
                {
                    return new global::Speechify.JsonConverters.StoreOrderByDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreOrderByDirection?))
                {
                    return new global::Speechify.JsonConverters.StoreOrderByDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreBatchWriteOp))
                {
                    return new global::Speechify.JsonConverters.StoreBatchWriteOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreBatchWriteOp?))
                {
                    return new global::Speechify.JsonConverters.StoreBatchWriteOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreBatchResultOp))
                {
                    return new global::Speechify.JsonConverters.StoreBatchResultOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.StoreBatchResultOp?))
                {
                    return new global::Speechify.JsonConverters.StoreBatchResultOpNullableJsonConverter();
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
                    0 => new DocumentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}