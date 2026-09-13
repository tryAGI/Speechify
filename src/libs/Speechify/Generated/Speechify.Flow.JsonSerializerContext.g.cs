
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentFlowGetSchemaResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishGateResultDecision), TypeInfoPropertyName = "PublishGateResultDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdictOutcome), TypeInfoPropertyName = "EvaluationCaseVerdictOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdictFault), TypeInfoPropertyName = "EvaluationCaseVerdictFault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCriterionVerdictStatus), TypeInfoPropertyName = "EvaluationCriterionVerdictStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCriterionVerdict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.EvaluationCriterionVerdict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationVerdict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.EvaluationCaseVerdict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishGateResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RollbackFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListFlowVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListFlowTemplatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphInputNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphInputEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphInputVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateFlowTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CloneFlowTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishGateResultDecision?), TypeInfoPropertyName = "NullablePublishGateResultDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdictOutcome?), TypeInfoPropertyName = "NullableEvaluationCaseVerdictOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdictFault?), TypeInfoPropertyName = "NullableEvaluationCaseVerdictFault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCriterionVerdictStatus?), TypeInfoPropertyName = "NullableEvaluationCriterionVerdictStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.EvaluationCriterionVerdict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.EvaluationCaseVerdict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputVariablesItems>))]
    internal sealed partial class FlowSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FlowSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FlowSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FlowSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.PublishGateResultDecision)

                    || typeToConvert == typeof(global::Speechify.PublishGateResultDecision?)

                    || typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictOutcome)

                    || typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictOutcome?)

                    || typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictFault)

                    || typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictFault?)

                    || typeToConvert == typeof(global::Speechify.EvaluationCriterionVerdictStatus)

                    || typeToConvert == typeof(global::Speechify.EvaluationCriterionVerdictStatus?);
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

                if (typeToConvert == typeof(global::Speechify.PublishGateResultDecision))
                {
                    return new global::Speechify.JsonConverters.PublishGateResultDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PublishGateResultDecision?))
                {
                    return new global::Speechify.JsonConverters.PublishGateResultDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictOutcome))
                {
                    return new global::Speechify.JsonConverters.EvaluationCaseVerdictOutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictOutcome?))
                {
                    return new global::Speechify.JsonConverters.EvaluationCaseVerdictOutcomeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictFault))
                {
                    return new global::Speechify.JsonConverters.EvaluationCaseVerdictFaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictFault?))
                {
                    return new global::Speechify.JsonConverters.EvaluationCaseVerdictFaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCriterionVerdictStatus))
                {
                    return new global::Speechify.JsonConverters.EvaluationCriterionVerdictStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCriterionVerdictStatus?))
                {
                    return new global::Speechify.JsonConverters.EvaluationCriterionVerdictStatusNullableJsonConverter();
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
                    0 => new FlowSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}