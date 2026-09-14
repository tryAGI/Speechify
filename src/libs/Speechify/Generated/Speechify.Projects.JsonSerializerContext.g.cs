
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectMonthlyBudgetStatus), TypeInfoPropertyName = "ProjectMonthlyBudgetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteProjectRequestMode), TypeInfoPropertyName = "DeleteProjectRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectRestoredCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectStillRevokedCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectRestore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlockerKind), TypeInfoPropertyName = "ProjectTeardownBlockerKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlockerBlocksItems), TypeInfoPropertyName = "ProjectTeardownBlockerBlocksItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlocker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownBlockerBlocksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownBlocker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectResourceCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteReused))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttentionKind), TypeInfoPropertyName = "PromoteAttentionKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttentionReason), TypeInfoPropertyName = "PromoteAttentionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PromoteAttention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectAuditEventType), TypeInfoPropertyName = "ProjectAuditEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectAuditEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectAuditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectAuditEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GrantProjectMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectMonthlyBudgetStatus?), TypeInfoPropertyName = "NullableProjectMonthlyBudgetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteProjectRequestMode?), TypeInfoPropertyName = "NullableDeleteProjectRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlockerKind?), TypeInfoPropertyName = "NullableProjectTeardownBlockerKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlockerBlocksItems?), TypeInfoPropertyName = "NullableProjectTeardownBlockerBlocksItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttentionKind?), TypeInfoPropertyName = "NullablePromoteAttentionKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttentionReason?), TypeInfoPropertyName = "NullablePromoteAttentionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectAuditEventType?), TypeInfoPropertyName = "NullableProjectAuditEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectTeardownBlockerBlocksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectTeardownBlocker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectTeardownGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PromoteAttention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectAuditEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectMember>))]
    internal sealed partial class ProjectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.ProjectMonthlyBudgetStatus)

                    || typeToConvert == typeof(global::Speechify.ProjectMonthlyBudgetStatus?)

                    || typeToConvert == typeof(global::Speechify.DeleteProjectRequestMode)

                    || typeToConvert == typeof(global::Speechify.DeleteProjectRequestMode?)

                    || typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerKind)

                    || typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerKind?)

                    || typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerBlocksItems)

                    || typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerBlocksItems?)

                    || typeToConvert == typeof(global::Speechify.PromoteAttentionKind)

                    || typeToConvert == typeof(global::Speechify.PromoteAttentionKind?)

                    || typeToConvert == typeof(global::Speechify.PromoteAttentionReason)

                    || typeToConvert == typeof(global::Speechify.PromoteAttentionReason?)

                    || typeToConvert == typeof(global::Speechify.ProjectAuditEventType)

                    || typeToConvert == typeof(global::Speechify.ProjectAuditEventType?);
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

                if (typeToConvert == typeof(global::Speechify.ProjectMonthlyBudgetStatus))
                {
                    return new global::Speechify.JsonConverters.ProjectMonthlyBudgetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectMonthlyBudgetStatus?))
                {
                    return new global::Speechify.JsonConverters.ProjectMonthlyBudgetStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DeleteProjectRequestMode))
                {
                    return new global::Speechify.JsonConverters.DeleteProjectRequestModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DeleteProjectRequestMode?))
                {
                    return new global::Speechify.JsonConverters.DeleteProjectRequestModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerKind))
                {
                    return new global::Speechify.JsonConverters.ProjectTeardownBlockerKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerKind?))
                {
                    return new global::Speechify.JsonConverters.ProjectTeardownBlockerKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerBlocksItems))
                {
                    return new global::Speechify.JsonConverters.ProjectTeardownBlockerBlocksItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerBlocksItems?))
                {
                    return new global::Speechify.JsonConverters.ProjectTeardownBlockerBlocksItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PromoteAttentionKind))
                {
                    return new global::Speechify.JsonConverters.PromoteAttentionKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PromoteAttentionKind?))
                {
                    return new global::Speechify.JsonConverters.PromoteAttentionKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PromoteAttentionReason))
                {
                    return new global::Speechify.JsonConverters.PromoteAttentionReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PromoteAttentionReason?))
                {
                    return new global::Speechify.JsonConverters.PromoteAttentionReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectAuditEventType))
                {
                    return new global::Speechify.JsonConverters.ProjectAuditEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectAuditEventType?))
                {
                    return new global::Speechify.JsonConverters.ProjectAuditEventTypeNullableJsonConverter();
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
                    0 => new ProjectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}