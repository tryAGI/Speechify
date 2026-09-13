
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SearchHitRanking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalCoverage), TypeInfoPropertyName = "RetrievalCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseInjection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SearchKnowledgeBasesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseSearchHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SearchKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseCoverageHealth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseCoverageGap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentSourceKind), TypeInfoPropertyName = "KnowledgeBaseDocumentSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseCoverageDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseCoverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseCoverageGap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseCoverageDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseEvalCase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseEvalCasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseEvalCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateKnowledgeBaseEvalCaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateKnowledgeBaseEvalCaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseEvaluationResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseEvaluationMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseEvaluationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.StartKnowledgeBaseEvaluationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseEvaluationHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseEvaluationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseEvaluationHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseEvaluationResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseEvaluationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentInjectionMode), TypeInfoPropertyName = "KnowledgeBaseDocumentInjectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentStatus), TypeInfoPropertyName = "KnowledgeBaseDocumentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentDetailInjectionMode), TypeInfoPropertyName = "KnowledgeBaseDocumentDetailInjectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DependentAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode), TypeInfoPropertyName = "V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateCrawlImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJobKind), TypeInfoPropertyName = "ImportJobKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateSitemapImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateTextDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateURLDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateURLBatchImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchDeleteDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchMoveDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchMoveDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseDocumentDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateRefreshConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshHistoryEntryStatus), TypeInfoPropertyName = "RefreshHistoryEntryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshHistoryEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListRefreshHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RefreshHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListImportJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ImportJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalCoverage?), TypeInfoPropertyName = "NullableRetrievalCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentSourceKind?), TypeInfoPropertyName = "NullableKnowledgeBaseDocumentSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentInjectionMode?), TypeInfoPropertyName = "NullableKnowledgeBaseDocumentInjectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentStatus?), TypeInfoPropertyName = "NullableKnowledgeBaseDocumentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentDetailInjectionMode?), TypeInfoPropertyName = "NullableKnowledgeBaseDocumentDetailInjectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode?), TypeInfoPropertyName = "NullableV1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJobKind?), TypeInfoPropertyName = "NullableImportJobKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshHistoryEntryStatus?), TypeInfoPropertyName = "NullableRefreshHistoryEntryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseCoverageGap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseCoverageDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseEvalCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseEvaluationHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseEvaluationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseDocumentDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RefreshHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ImportJob>))]
    internal sealed partial class KnowledgeBasesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeBasesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeBasesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KnowledgeBasesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.RetrievalCoverage)

                    || typeToConvert == typeof(global::Speechify.RetrievalCoverage?)

                    || typeToConvert == typeof(global::Speechify.JobStatus)

                    || typeToConvert == typeof(global::Speechify.JobStatus?)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentSourceKind)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentSourceKind?)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentInjectionMode)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentInjectionMode?)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentStatus)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentStatus?)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentDetailInjectionMode)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentDetailInjectionMode?)

                    || typeToConvert == typeof(global::Speechify.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode)

                    || typeToConvert == typeof(global::Speechify.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode?)

                    || typeToConvert == typeof(global::Speechify.ImportJobKind)

                    || typeToConvert == typeof(global::Speechify.ImportJobKind?)

                    || typeToConvert == typeof(global::Speechify.RefreshHistoryEntryStatus)

                    || typeToConvert == typeof(global::Speechify.RefreshHistoryEntryStatus?);
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

                if (typeToConvert == typeof(global::Speechify.RetrievalCoverage))
                {
                    return new global::Speechify.JsonConverters.RetrievalCoverageJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RetrievalCoverage?))
                {
                    return new global::Speechify.JsonConverters.RetrievalCoverageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.JobStatus))
                {
                    return new global::Speechify.JsonConverters.JobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.JobStatus?))
                {
                    return new global::Speechify.JsonConverters.JobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentSourceKind))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentSourceKind?))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentInjectionMode))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentInjectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentInjectionMode?))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentInjectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentStatus))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentStatus?))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentDetailInjectionMode))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentDetailInjectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentDetailInjectionMode?))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentDetailInjectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode))
                {
                    return new global::Speechify.JsonConverters.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionMode?))
                {
                    return new global::Speechify.JsonConverters.V1AgentsKnowledgeBasesKbIdDocumentsDocumentIdPatchRequestBodyContentApplicationJsonSchemaInjectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ImportJobKind))
                {
                    return new global::Speechify.JsonConverters.ImportJobKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ImportJobKind?))
                {
                    return new global::Speechify.JsonConverters.ImportJobKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RefreshHistoryEntryStatus))
                {
                    return new global::Speechify.JsonConverters.RefreshHistoryEntryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RefreshHistoryEntryStatus?))
                {
                    return new global::Speechify.JsonConverters.RefreshHistoryEntryStatusNullableJsonConverter();
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
                    0 => new KnowledgeBasesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}