
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateMetricOp), TypeInfoPropertyName = "StoreAggregateMetricOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.StoreAggregateMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiRouteMethod), TypeInfoPropertyName = "HostedApiRouteMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverType), TypeInfoPropertyName = "HostedApiResolverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverWriteMode), TypeInfoPropertyName = "HostedApiResolverWriteMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverWhereItemsOp), TypeInfoPropertyName = "HostedApiResolverWhereItemsOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverWhereItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverOrderByDirection), TypeInfoPropertyName = "HostedApiResolverOrderByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverOrderBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedAPIResolver))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.HostedApiResolverWhereItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedAPIRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListHostedAPIRoutesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.HostedAPIRoute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateHostedApiRouteRequestMethod), TypeInfoPropertyName = "CreateHostedApiRouteRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateHostedAPIRouteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MountHostedAPIRoutesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiMountToolKind), TypeInfoPropertyName = "HostedApiMountToolKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiMountOperationAction), TypeInfoPropertyName = "HostedApiMountOperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiMountOperationChangesItems), TypeInfoPropertyName = "HostedApiMountOperationChangesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedAPIMountOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.HostedApiMountOperationChangesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedAPIMountSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedAPIMount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.HostedAPIMountOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateHostedApiRouteRequestMethod), TypeInfoPropertyName = "UpdateHostedApiRouteRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateHostedAPIRouteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StoreAggregateMetricOp?), TypeInfoPropertyName = "NullableStoreAggregateMetricOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiRouteMethod?), TypeInfoPropertyName = "NullableHostedApiRouteMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverType?), TypeInfoPropertyName = "NullableHostedApiResolverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverWriteMode?), TypeInfoPropertyName = "NullableHostedApiResolverWriteMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverWhereItemsOp?), TypeInfoPropertyName = "NullableHostedApiResolverWhereItemsOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiResolverOrderByDirection?), TypeInfoPropertyName = "NullableHostedApiResolverOrderByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateHostedApiRouteRequestMethod?), TypeInfoPropertyName = "NullableCreateHostedApiRouteRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiMountToolKind?), TypeInfoPropertyName = "NullableHostedApiMountToolKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiMountOperationAction?), TypeInfoPropertyName = "NullableHostedApiMountOperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.HostedApiMountOperationChangesItems?), TypeInfoPropertyName = "NullableHostedApiMountOperationChangesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateHostedApiRouteRequestMethod?), TypeInfoPropertyName = "NullableUpdateHostedApiRouteRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.StoreAggregateMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.HostedApiResolverWhereItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.HostedAPIRoute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.HostedApiMountOperationChangesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.HostedAPIMountOperation>))]
    internal sealed partial class RoutesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RoutesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RoutesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RoutesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.HostedApiRouteMethod)

                    || typeToConvert == typeof(global::Speechify.HostedApiRouteMethod?)

                    || typeToConvert == typeof(global::Speechify.HostedApiResolverType)

                    || typeToConvert == typeof(global::Speechify.HostedApiResolverType?)

                    || typeToConvert == typeof(global::Speechify.HostedApiResolverWriteMode)

                    || typeToConvert == typeof(global::Speechify.HostedApiResolverWriteMode?)

                    || typeToConvert == typeof(global::Speechify.HostedApiResolverWhereItemsOp)

                    || typeToConvert == typeof(global::Speechify.HostedApiResolverWhereItemsOp?)

                    || typeToConvert == typeof(global::Speechify.HostedApiResolverOrderByDirection)

                    || typeToConvert == typeof(global::Speechify.HostedApiResolverOrderByDirection?)

                    || typeToConvert == typeof(global::Speechify.CreateHostedApiRouteRequestMethod)

                    || typeToConvert == typeof(global::Speechify.CreateHostedApiRouteRequestMethod?)

                    || typeToConvert == typeof(global::Speechify.HostedApiMountToolKind)

                    || typeToConvert == typeof(global::Speechify.HostedApiMountToolKind?)

                    || typeToConvert == typeof(global::Speechify.HostedApiMountOperationAction)

                    || typeToConvert == typeof(global::Speechify.HostedApiMountOperationAction?)

                    || typeToConvert == typeof(global::Speechify.HostedApiMountOperationChangesItems)

                    || typeToConvert == typeof(global::Speechify.HostedApiMountOperationChangesItems?)

                    || typeToConvert == typeof(global::Speechify.UpdateHostedApiRouteRequestMethod)

                    || typeToConvert == typeof(global::Speechify.UpdateHostedApiRouteRequestMethod?);
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

                if (typeToConvert == typeof(global::Speechify.HostedApiRouteMethod))
                {
                    return new global::Speechify.JsonConverters.HostedApiRouteMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiRouteMethod?))
                {
                    return new global::Speechify.JsonConverters.HostedApiRouteMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiResolverType))
                {
                    return new global::Speechify.JsonConverters.HostedApiResolverTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiResolverType?))
                {
                    return new global::Speechify.JsonConverters.HostedApiResolverTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiResolverWriteMode))
                {
                    return new global::Speechify.JsonConverters.HostedApiResolverWriteModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiResolverWriteMode?))
                {
                    return new global::Speechify.JsonConverters.HostedApiResolverWriteModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiResolverWhereItemsOp))
                {
                    return new global::Speechify.JsonConverters.HostedApiResolverWhereItemsOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiResolverWhereItemsOp?))
                {
                    return new global::Speechify.JsonConverters.HostedApiResolverWhereItemsOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiResolverOrderByDirection))
                {
                    return new global::Speechify.JsonConverters.HostedApiResolverOrderByDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiResolverOrderByDirection?))
                {
                    return new global::Speechify.JsonConverters.HostedApiResolverOrderByDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CreateHostedApiRouteRequestMethod))
                {
                    return new global::Speechify.JsonConverters.CreateHostedApiRouteRequestMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CreateHostedApiRouteRequestMethod?))
                {
                    return new global::Speechify.JsonConverters.CreateHostedApiRouteRequestMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiMountToolKind))
                {
                    return new global::Speechify.JsonConverters.HostedApiMountToolKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiMountToolKind?))
                {
                    return new global::Speechify.JsonConverters.HostedApiMountToolKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiMountOperationAction))
                {
                    return new global::Speechify.JsonConverters.HostedApiMountOperationActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiMountOperationAction?))
                {
                    return new global::Speechify.JsonConverters.HostedApiMountOperationActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiMountOperationChangesItems))
                {
                    return new global::Speechify.JsonConverters.HostedApiMountOperationChangesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.HostedApiMountOperationChangesItems?))
                {
                    return new global::Speechify.JsonConverters.HostedApiMountOperationChangesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.UpdateHostedApiRouteRequestMethod))
                {
                    return new global::Speechify.JsonConverters.UpdateHostedApiRouteRequestMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.UpdateHostedApiRouteRequestMethod?))
                {
                    return new global::Speechify.JsonConverters.UpdateHostedApiRouteRequestMethodNullableJsonConverter();
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
                    0 => new RoutesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}